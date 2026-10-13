using System.ComponentModel;
using System.Globalization;
using FrameworkApplication;

namespace LibraryManagementWindowsForm;

// Persian input and month calendar; Value remains a Gregorian DateTime for EF.
public sealed class PersianDatePicker : UserControl
{
    private readonly TextBox _input = new() { Name = "PersianDateInput", Dock = DockStyle.Fill, TextAlign = HorizontalAlignment.Center,
        RightToLeft = RightToLeft.No, MaxLength = 10 };
    private readonly Button _open = new() { Name = "PersianCalendarOpen", Dock = DockStyle.Right, Width = 30, Text = "▾", TabStop = false };
    private readonly PersianCalendar _calendar = new();
    private ToolStripDropDown? _popup;
    private DateTime _visibleMonth;
    public event EventHandler? ValueChanged;

    public PersianDatePicker()
    {
        MinimumSize = new Size(140, 32);
        Height = 36;
        _open.AccessibleName = "باز کردن تقویم شمسی";
        _open.FlatStyle = FlatStyle.Flat;
        _open.FlatAppearance.BorderSize = 0;
        _open.BackColor = UiTheme.Accent; _open.ForeColor = Color.White;
        Controls.Add(_input); Controls.Add(_open);
        _input.TextChanged += (_, _) => ValueChanged?.Invoke(this, EventArgs.Empty);
        _input.Validated += (_, _) => { if (TryGetValue(out var date)) Value = date; };
        _open.Click += (_, _) => ShowCalendar();
        Value = DateTime.Today;
        AccessibleName = "تاریخ شمسی با قالب سال/ماه/روز";
    }

    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public DateTime Value
    {
        get => PersianDateHelper.Parse(_input.Text);
        set => _input.Text = UiText.Date(value.Date);
    }

    [DefaultValue(false)]
    public bool ReadOnly
    {
        get => _input.ReadOnly;
        set { _input.ReadOnly = value; _open.Enabled = !value; _input.BackColor = value ? UiTheme.Background : Color.White; }
    }
    public void Clear() => _input.Clear();
    public bool TryGetValue(out DateTime date) => PersianDateHelper.TryParse(_input.Text, out date);

    private void ShowCalendar()
    {
        if (ReadOnly) return;
        var date = TryGetValue(out var parsed) ? parsed : DateTime.Today;
        _visibleMonth = _calendar.ToDateTime(_calendar.GetYear(date), _calendar.GetMonth(date), 1, 0, 0, 0, 0);
        _popup?.Dispose();
        _popup = new ToolStripDropDown { Padding = Padding.Empty };
        RenderMonth();
        _popup.Show(this, new Point(0, Height));
    }

    private void RenderMonth()
    {
        if (_popup is null) return;
        while (_popup.Items.Count > 0) { var old = _popup.Items[0]; _popup.Items.Remove(old); old.Dispose(); }
        var panel = new TableLayoutPanel { Width = 336, Height = 324, Font = Font, ColumnCount = 7, RowCount = 9,
            RightToLeft = RightToLeft.No, BackColor = Color.White, Margin = Padding.Empty };
        for (var i = 0; i < 7; i++) panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));
        for (var i = 0; i < 9; i++) panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 9));
        var year = _calendar.GetYear(_visibleMonth); var month = _calendar.GetMonth(_visibleMonth);
        string[] months = ["فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند"];
        var previous = MakeButton("‹", () => ChangeMonth(-1));
        var next = MakeButton("›", () => ChangeMonth(1));
        panel.Controls.Add(previous, 0, 0); panel.Controls.Add(next, 6, 0);
        var title = new Label { Text = $"{months[month - 1]} {UiText.Digits(year)}", Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter, RightToLeft = RightToLeft.Yes };
        panel.Controls.Add(title, 1, 0); panel.SetColumnSpan(title, 5);
        string[] days = ["ش", "ی", "د", "س", "چ", "پ", "ج"];
        // Saturday first at the right edge.
        for (var i = 0; i < 7; i++) panel.Controls.Add(new Label { Text = days[i], Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter }, 6 - i, 1);
        var offset = ((int)_visibleMonth.DayOfWeek + 1) % 7;
        var length = _calendar.GetDaysInMonth(year, month);
        if (year == _calendar.GetYear(_calendar.MaxSupportedDateTime) && month == _calendar.GetMonth(_calendar.MaxSupportedDateTime))
            length = _calendar.GetDayOfMonth(_calendar.MaxSupportedDateTime);
        for (var day = 1; day <= length; day++)
        {
            var chosen = _calendar.ToDateTime(year, month, day, 0, 0, 0, 0);
            var slot = offset + day - 1;
            var button = MakeButton(UiText.Digits(day), () =>
                { Value = chosen; _popup?.Close(); });
            if (TryGetValue(out var selected) && selected == chosen) button.BackColor = Color.FromArgb(219, 242, 238);
            panel.Controls.Add(button, 6 - slot % 7, 2 + slot / 7);
        }
        var today = MakeButton("امروز", () => { Value = DateTime.Today; _popup?.Close(); });
        panel.Controls.Add(today, 0, 8); panel.SetColumnSpan(today, 7);
        var host = new ToolStripControlHost(panel) { Margin = Padding.Empty, Padding = Padding.Empty, AutoSize = false,
            Size = panel.Size };
        _popup.Items.Add(host);
    }

    private void ChangeMonth(int step)
    {
        try { _visibleMonth = _calendar.AddMonths(_visibleMonth, step); RenderMonth(); }
        catch (ArgumentOutOfRangeException) { }
    }
    private static Button MakeButton(string text, Action click)
    {
        var button = new Button { Text = text, Dock = DockStyle.Fill, Margin = new Padding(1),
            FlatStyle = FlatStyle.Flat, BackColor = Color.White };
        button.Click += (_, _) => click();
        return button;
    }
    protected override void Dispose(bool disposing)
    {
        if (disposing) _popup?.Dispose();
        base.Dispose(disposing);
    }
}
