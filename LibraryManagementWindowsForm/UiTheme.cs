namespace LibraryManagementWindowsForm;

internal static class UiTheme
{
    public static readonly Color Background = Color.FromArgb(242, 245, 249);
    public static readonly Color Ink = Color.FromArgb(25, 42, 66);
    public static readonly Color Muted = Color.FromArgb(94, 110, 132);
    public static readonly Color Accent = Color.FromArgb(12, 120, 113);
    public static readonly Color Border = Color.FromArgb(222, 230, 239);

    public static void Apply(Form form)
    {
        form.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
        form.BackColor = Background;
        form.ForeColor = Ink;
        form.BackgroundImage = null;
        // Tables have explicit directions. Do not mirror the entire window a second time.
        form.RightToLeft = RightToLeft.Yes;
        form.RightToLeftLayout = false;
        form.StartPosition = FormStartPosition.CenterParent;
        ApplyControl(form, form.Font);
    }

    private static void ApplyControl(Control control, Font font)
    {
        control.Font = font;
        switch (control)
        {
            case Button button:
                if (button.Name == "PersianCalendarOpen")
                {
                    button.Width = 30;
                    button.BackColor = Accent; button.ForeColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat; button.FlatAppearance.BorderSize = 0;
                }
                else Button(button);
                break;
            case TextBox text:
                text.Multiline = false;
                var dateInput = text.Name == "PersianDateInput";
                var latin = dateInput || text.Name is "txt_user" or "txt_pass" or "txtUserName" or "txtPassword"
                    or "txt_national_code" or "txt_mobile" or "txt_search_id" or "txt_id" or "txt_search_national_code";
                text.RightToLeft = latin ? RightToLeft.No : RightToLeft.Yes;
                text.TextAlign = dateInput ? HorizontalAlignment.Center
                    : latin ? HorizontalAlignment.Left : HorizontalAlignment.Right;
                text.BackColor = text.ReadOnly ? Background : Color.White;
                text.ForeColor = Ink;
                text.BorderStyle = BorderStyle.FixedSingle;
                break;
            case ComboBox combo:
                combo.RightToLeft = RightToLeft.Yes;
                combo.FlatStyle = FlatStyle.Flat;
                combo.BackColor = Color.White;
                combo.ForeColor = Ink;
                break;
            case CheckBox check:
                check.AutoSize = true;
                check.RightToLeft = RightToLeft.Yes;
                break;
            case PictureBox picture:
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.BackColor = Background;
                picture.BorderStyle = BorderStyle.FixedSingle;
                break;
        }
        foreach (Control child in control.Controls) ApplyControl(child, font);
    }

    public static void Button(Button button, bool primary = true, bool danger = false)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = primary ? 0 : 1;
        button.FlatAppearance.BorderColor = Border;
        button.UseVisualStyleBackColor = false;
        button.BackColor = danger ? Color.FromArgb(169, 49, 60) : primary ? Accent : Color.White;
        button.ForeColor = primary || danger ? Color.White : Ink;
        button.FlatAppearance.MouseOverBackColor = danger ? Color.FromArgb(144, 35, 47)
            : primary ? Color.FromArgb(8, 99, 94) : Background;
        button.Cursor = Cursors.Hand;
        button.RightToLeft = RightToLeft.Yes;
        button.AutoSize = false;
        button.Size = new Size(132, 40);
        button.Margin = new Padding(4);
    }

    public static Label Status() => new()
    {
        AutoSize = false, Dock = DockStyle.Fill, Height = 28,
        TextAlign = ContentAlignment.MiddleRight, ForeColor = Muted,
        RightToLeft = RightToLeft.Yes
    };

    public static Button NewButton(string text, EventHandler click, bool primary = false)
    {
        var button = new Button { Text = text };
        Button(button, primary);
        button.Click += click;
        return button;
    }
}
