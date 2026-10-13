using System.ComponentModel;

namespace LibraryManagementWindowsForm;

internal static class UiDesigner
{
    public static bool IsDesignMode(Control control) =>
        LicenseManager.UsageMode == LicenseUsageMode.Designtime || control.Site?.DesignMode == true;

    public static void FitToScreen(Form form)
    {
        if (IsDesignMode(form) || form.WindowState != FormWindowState.Normal) return;
        var area = Screen.FromControl(form).WorkingArea;
        var maxWidth = Math.Max(1, area.Width - 24);
        var maxHeight = Math.Max(1, area.Height - 24);
        form.MinimumSize = new Size(Math.Min(form.MinimumSize.Width, maxWidth),
            Math.Min(form.MinimumSize.Height, maxHeight));
        if (form.Width > maxWidth || form.Height > maxHeight)
            form.Size = new Size(Math.Min(form.Width, maxWidth), Math.Min(form.Height, maxHeight));
        form.Location = new Point(Math.Clamp(form.Left, area.Left, area.Right - form.Width),
            Math.Clamp(form.Top, area.Top, area.Bottom - form.Height));
    }
}
