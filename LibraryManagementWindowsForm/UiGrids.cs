using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using LibraryManagementContracts.Loan;

namespace LibraryManagementWindowsForm;

internal static class UiGrids
{
    private sealed class State
    {
        public string Kind = "";
        public Action<string>? Report;
        public bool ErrorReported;
        public bool Configuring;
        public bool Logged;
    }
    private static readonly ConditionalWeakTable<DataGridView, State> States = new();
    private static (string Property, string Caption, int Width)[] Schema(string kind) => kind switch
    {
        "books" => [("Id", "شناسه", 65), ("Title", "عنوان کتاب", 220), ("Author", "نویسنده", 170), ("Language", "زبان", 90)],
        "members" => [("Id", "شناسه", 60), ("Name", "نام", 110), ("Family", "نام خانوادگی", 145), ("NationalCode", "کد ملی", 125), ("Mobile", "موبایل", 130), ("IsSpecial", "عضویت", 90), ("Status", "وضعیت", 90)],
        "admins" => [("UserName", "نام کاربری", 210), ("Role", "نقش", 150), ("IsActive", "وضعیت", 110)],
        "loans" => [("Id", "شناسه", 60), ("BookName", "کتاب", 180), ("LoanDate", "تاریخ امانت", 110), ("ReturnDate", "موعد تحویل", 110), ("ReturnedAt", "برگشت واقعی", 110), ("Status", "وضعیت", 110), ("DaysOverdue", "روز دیرکرد", 85)],
        _ => throw new ArgumentException("نوع جدول شناخته‌شده نیست.", nameof(kind))
    };

    public static void AttachFormatting(DataGridView grid, string kind, Action<string>? report = null)
    {
        var state = States.GetValue(grid, _ => new State());
        state.Kind = kind; state.Report = report; state.ErrorReported = false;
        grid.ReadOnly = true; grid.AllowUserToAddRows = false; grid.AllowUserToDeleteRows = false;
        grid.Tag = kind;
        grid.DataError -= OnDataError; grid.DataError += OnDataError;
        grid.DataBindingComplete -= OnBindingComplete; grid.DataBindingComplete += OnBindingComplete;
        grid.DataSourceChanged -= OnSourceChanged; grid.DataSourceChanged += OnSourceChanged;
        ConfigureColumns(grid, state);
        grid.CellFormatting -= FormatCell; grid.CellFormatting += FormatCell;
        if (!state.Logged)
        {
            state.Logged = true;
            Debug.WriteLine($"[UI-Grids-v3] {grid.Name}: {typeof(UiGrids).Assembly.Location}");
        }
    }

    // Keep original DTOs for selection in the non-loan forms.
    public static void Bind(DataGridView grid, object rows, string kind, Action<string>? report = null)
    {
        AttachFormatting(grid, kind, report);
        grid.DataSource = rows;
    }

    // All public display properties are strings. The original loan stays separate.
    private sealed class LoanDisplayRow
    {
        internal LoanViewModel Source { get; }
        public string Id { get; }
        public string BookName { get; }
        public string LoanDate { get; }
        public string ReturnDate { get; }
        public string ReturnedAt { get; }
        public string Status { get; }
        public string DaysOverdue { get; }

        internal LoanDisplayRow(LoanViewModel loan)
        {
            Source = loan;
            Id = UiText.Digits(loan.Id);
            BookName = string.IsNullOrWhiteSpace(loan.BookName) ? "—" : loan.BookName;
            LoanDate = UiText.Date(loan.LoanDate);
            ReturnDate = UiText.Date(loan.ReturnDate);
            ReturnedAt = UiText.Date(loan.ReturnedAt);
            Status = loan.Status ? "برگشت داده شده"
                : loan.ReturnDate.Date < DateTime.Today ? "دیرکرد" : "در امانت";
            DaysOverdue = UiText.Digits(loan.DaysOverdue);
        }
    }

    public static void BindLoans(DataGridView grid, IEnumerable<LoanViewModel> loans, Action<string>? report = null)
        => Bind(grid, loans.Select(loan => new LoanDisplayRow(loan)).ToList(), "loans", report);

    public static LoanViewModel? GetLoan(DataGridViewRow? row) => row?.DataBoundItem switch
    {
        LoanDisplayRow display => display.Source,
        LoanViewModel loan => loan,
        _ => null
    };

    private static void ConfigureColumns(DataGridView grid, State state)
    {
        if (state.Configuring || grid.IsDisposed) return;
        state.Configuring = true;
        try { grid.AutoGenerateColumns = false; RepairColumns(grid, state.Kind); }
        finally { state.Configuring = false; }
    }

    private static void OnSourceChanged(object? sender, EventArgs e)
    {
        if (sender is DataGridView grid && States.TryGetValue(grid, out var state))
            ConfigureColumns(grid, state);
    }

    private static void RepairColumns(DataGridView grid, string kind)
    {
        var schema = Schema(kind);
        var allowed = schema.Select(x => x.Property).ToHashSet(StringComparer.Ordinal);
        foreach (var column in grid.Columns.Cast<DataGridViewColumn>().ToArray())
            if (!allowed.Contains(column.DataPropertyName)) grid.Columns.Remove(column);
        foreach (var spec in schema)
        {
            var matches = grid.Columns.Cast<DataGridViewColumn>().Where(x => x.DataPropertyName == spec.Property).ToList();
            foreach (var duplicate in matches.Skip(1)) grid.Columns.Remove(duplicate);
            var column = matches.FirstOrDefault();
            if (column is null)
            {
                column = new DataGridViewTextBoxColumn
                {
                    Name = spec.Property, DataPropertyName = spec.Property, HeaderText = spec.Caption,
                    FillWeight = spec.Width, MinimumWidth = Math.Min(spec.Width, 90)
                };
                grid.Columns.Add(column);
            }
            else if (column is not DataGridViewTextBoxColumn)
            {
                var index = column.Index; var displayIndex = column.DisplayIndex;
                var replacement = new DataGridViewTextBoxColumn
                {
                    Name = column.Name, DataPropertyName = spec.Property, HeaderText = column.HeaderText,
                    FillWeight = column.FillWeight, MinimumWidth = column.MinimumWidth, Width = column.Width,
                    AutoSizeMode = column.AutoSizeMode, Visible = column.Visible,
                    DefaultCellStyle = column.DefaultCellStyle.Clone()
                };
                grid.Columns.Remove(column); grid.Columns.Insert(index, replacement);
                replacement.DisplayIndex = Math.Min(displayIndex, grid.Columns.Count - 1);
                column.Dispose(); column = replacement;
            }
            column.ValueType = typeof(string); column.ReadOnly = true;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            if (string.IsNullOrWhiteSpace(column.HeaderText) || !column.HeaderText.Any(c => c is >= '\u0600' and <= '\u06ff'))
                column.HeaderText = spec.Caption;
        }
    }

    private static void FormatCell(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (sender is not DataGridView grid || e.RowIndex < 0 || e.RowIndex >= grid.Rows.Count
            || e.ColumnIndex < 0 || e.ColumnIndex >= grid.Columns.Count) return;
        // Checkbox cells expect bool/CheckState, not a translated string.
        if (grid.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValueType != typeof(string)) return;
        var property = grid.Columns[e.ColumnIndex].DataPropertyName;
        var kind = States.TryGetValue(grid, out var state) ? state.Kind : grid.Tag as string;
        if (grid.Rows[e.RowIndex].DataBoundItem is LoanDisplayRow display)
        {
            // The source already contains Persian strings; never convert them as dates/bools again.
            if (property == "Status")
                e.CellStyle.ForeColor = display.Source.Status ? UiTheme.Accent
                    : display.Source.ReturnDate.Date < DateTime.Today ? Color.FromArgb(160, 65, 35) : UiTheme.Ink;
            e.FormattingApplied = true;
            return;
        }
        if (property is "LoanDate" or "ReturnDate" or "ReturnedAt")
            e.Value = e.Value is DateTime date ? UiText.Date(date) : "—";
        else if (property == "Role") e.Value = UiText.Role(e.Value as string);
        else if (property == "Status" && kind == "loans" && grid.Rows[e.RowIndex].DataBoundItem is LoanViewModel loan)
        {
            var overdue = !loan.Status && loan.ReturnDate.Date < DateTime.Today;
            e.Value = loan.Status ? "برگشت داده شده" : overdue ? "دیرکرد" : "در امانت";
            e.CellStyle.ForeColor = loan.Status ? UiTheme.Accent : overdue ? Color.FromArgb(160, 65, 35) : UiTheme.Ink;
        }
        else if (e.Value is bool flag)
            e.Value = property == "IsSpecial" ? flag ? "ویژه" : "عادی" : flag ? "فعال" : "غیرفعال";
        else if (e.Value is int number) e.Value = UiText.Digits(number);
        else e.Value = e.Value is null or DBNull ? "—" : Convert.ToString(e.Value, CultureInfo.InvariantCulture) ?? "";
        e.FormattingApplied = true;
    }

    private static void OnBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
    {
        if (sender is not DataGridView grid || !States.TryGetValue(grid, out var state) || state.Configuring) return;
        state.ErrorReported = false;
        ConfigureColumns(grid, state);
    }

    private static void OnDataError(object? sender, DataGridViewDataErrorEventArgs e)
    {
        e.ThrowException = false; e.Cancel = false;
        if (sender is not DataGridView grid) return;
        Debug.WriteLine($"[Grid:{grid.Name}] row={e.RowIndex}; column={e.ColumnIndex}; context={e.Context}; {e.Exception}");
        if (e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < grid.Columns.Count)
            grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "این مقدار قابل نمایش نیست؛ جزئیات در Output ثبت شد.";
        if (States.TryGetValue(grid, out var state) && !state.ErrorReported)
        {
            state.ErrorReported = true;
            state.Report?.Invoke("یک مقدار جدول قابل نمایش نیست؛ جزئیات در Output ثبت شد.");
        }
    }

    public static void Books(DataGridView grid) => AttachFormatting(grid, "books");
    public static void Members(DataGridView grid) => AttachFormatting(grid, "members");
    public static void Loans(DataGridView grid) => AttachFormatting(grid, "loans");
    public static void Admins(DataGridView grid) => AttachFormatting(grid, "admins");
}
