using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace LibraryManagementWindowsForm;

internal static class ImageHelper
{
    // Keep database bytes separate from the image shown on screen.
    private sealed class PhotoState
    {
        public byte[] StoredBytes = Array.Empty<byte>();
        public Image? LoadedImage;
    }

    private static readonly ConditionalWeakTable<PictureBox, PhotoState> States = new();

    public static byte[] ToBytes(Image? image)
    {
        if (image is null) return Array.Empty<byte>();
        using var stream = new MemoryStream();
        image.Save(stream, ImageFormat.Png);
        return stream.ToArray();
    }

    public static byte[] ToBytes(PictureBox box)
    {
        var state = States.GetOrCreateValue(box);
        // Unchanged, missing or undecodable previews must not erase stored bytes.
        if (ReferenceEquals(box.Image, state.LoadedImage))
            return state.StoredBytes.ToArray();
        return ToBytes(box.Image);
    }

    public static bool SetImage(PictureBox box, byte[]? bytes)
    {
        var state = States.GetOrCreateValue(box);
        state.StoredBytes = bytes?.ToArray() ?? Array.Empty<byte>();
        Image? next = null;
        var decoded = true;

        if (state.StoredBytes.Length > 0)
        {
            try
            {
                using var stream = new MemoryStream(state.StoredBytes);
                using var source = Image.FromStream(stream, false, true);
                next = new Bitmap(source);
            }
            catch (Exception error) when (error is ArgumentException or OutOfMemoryException
                or System.Runtime.InteropServices.ExternalException)
            {
                decoded = false;
                Trace.TraceWarning("Photo decode failed: control={0}, bytes={1}, error={2}",
                    box.Name, state.StoredBytes.Length, error.GetType().Name);
            }
        }

        var previous = box.Image;
        box.Image = next;
        state.LoadedImage = next;
        previous?.Dispose();

        Debug.WriteLine($"[Photo] control={box.Name}; bytes={state.StoredBytes.Length}; " +
            $"result={(state.StoredBytes.Length == 0 ? "no-image" : decoded ? "decoded" : "decode-failed")}");

        if (!decoded)
            MessageBox.Show(box.FindForm(),
                "تصویر ذخیره‌شده باز نشد. برای جایگزینی، فایل اصلی عکس را دوباره انتخاب کنید. " +
                "ویرایش متن، بایت‌های عکس قبلی را حفظ می‌کند.",
                "بازیابی تصویر", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        return decoded;
    }

    public static void Select(PictureBox box)
    {
        using var dialog = new OpenFileDialog
        {
            Title = "انتخاب تصویر",
            Filter = "تصاویر|*.png;*.jpg;*.jpeg;*.bmp",
            CheckFileExists = true,
            Multiselect = false
        };
        if (dialog.ShowDialog() != DialogResult.OK) return;
        if (new FileInfo(dialog.FileName).Length > 5 * 1024 * 1024)
        {
            MessageBox.Show("حداکثر حجم عکس ۵ مگابایت است.");
            return;
        }
        using var source = Image.FromFile(dialog.FileName);
        var next = new Bitmap(source);
        var previous = box.Image;
        box.Image = next;
        previous?.Dispose();
    }
}
