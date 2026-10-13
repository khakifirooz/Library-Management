using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagementWindowsForm;

internal static class ImageHelper
{
    public static byte[] ToBytes(Image? image)
    {
        if (image is null) return Array.Empty<byte>();

        using var stream = new MemoryStream();
        image.Save(stream, ImageFormat.Png);
        return stream.ToArray();
    }

    public static void SetImage(PictureBox box, byte[]? bytes)
    {
        Image? next = null;
        if (bytes is { Length: > 0 })
        {
            try
            {
                using var stream = new MemoryStream(bytes);
                using var source = Image.FromStream(stream, false, true);
                next = new Bitmap(source);
            }
            catch (Exception error) when (error is ArgumentException or OutOfMemoryException)
            {
                Trace.TraceWarning("Image could not be decoded: {0}", error.GetType().Name);
            }
        }

        var previous = box.Image;
        box.Image = next;
        previous?.Dispose();
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
