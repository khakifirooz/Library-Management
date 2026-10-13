using LibraryManagementContracts.Loan;

namespace LibraryManagementWindowsForm;

internal static class UiGrids
{
    // Preserve columns and styles created and edited in Visual Studio Designer.
    public static void AttachFormatting(DataGridView grid, string kind)
    {
        grid.Tag = kind;
        grid.CellFormatting -= FormatCell;
        grid.CellFormatting += FormatCell;
    }

    public static void Books(DataGridView grid) => Configure(grid, "books",
        ("Id", "شناسه", 70), ("Title", "عنوان کتاب", 220),
        ("Author", "نویسنده", 180), ("Language", "زبان", 95));

    public static void Members(DataGridView grid) => Configure(grid, "members",
        ("Id", "شناسه", 65), ("Name", "نام", 110), ("Family", "نام خانوادگی", 150),
        ("NationalCode", "کد ملی", 125), ("Mobile", "موبایل", 135),
        ("IsSpecial", "نوع عضویت", 110), ("Status", "وضعیت", 95));

    public static void Admins(DataGridView grid) => Configure(grid, "admins",
        ("UserName", "نام کاربری", 210), ("Role", "نقش", 150), ("IsActive", "وضعیت", 110));

    public static void Loans(DataGridView grid) => Configure(grid, "loans",
        ("Id", "شناسه", 65), ("BookName", "کتاب", 190), ("LoanDate", "تاریخ امانت", 120),
        ("ReturnDate", "موعد تحویل", 120), ("ReturnedAt", "برگشت واقعی", 125),
        ("Status", "وضعیت", 105), ("DaysOverdue", "روز دیرکرد", 90));

    private static void Configure(DataGridView grid, string kind,
        params (string Property, string Header, int Width)[] columns)
    {
        grid.DataSource = null;
        grid.AutoGenerateColumns = false;
        grid.Columns.Clear();
        grid.Tag = kind;
        grid.ReadOnly = true;
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.AllowUserToOrderColumns = false;
        grid.AllowUserToResizeRows = false;
        grid.MultiSelect = false;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.RowHeadersVisible = false;
        grid.RightToLeft = RightToLeft.Yes;
        grid.BorderStyle = BorderStyle.None;
        grid.BackgroundColor = Color.White;
        grid.GridColor = UiTheme.Border;
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        grid.EnableHeadersVisualStyles = false;
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        grid.ColumnHeadersHeight = 44;
        grid.RowTemplate.Height = 42;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = UiTheme.Background, ForeColor = UiTheme.Ink,
            Alignment = DataGridViewContentAlignment.MiddleRight,
            Padding = new Padding(6), WrapMode = DataGridViewTriState.False
        };
        grid.DefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.White, ForeColor = UiTheme.Ink,
            SelectionBackColor = Color.FromArgb(219, 242, 238), SelectionForeColor = UiTheme.Ink,
            Alignment = DataGridViewContentAlignment.MiddleRight, Padding = new Padding(6),
            NullValue = "—", WrapMode = DataGridViewTriState.False
        };
        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 251, 253);
        foreach (var (property, header, width) in columns)
            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = property, DataPropertyName = property, HeaderText = header,
                MinimumWidth = width, FillWeight = width, SortMode = DataGridViewColumnSortMode.NotSortable
            });
        // Remove our own previous subscription only, if Configure is called again.
        grid.CellFormatting -= FormatCell;
        grid.CellFormatting += FormatCell;
    }

    private static void FormatCell(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (sender is not DataGridView grid || e.RowIndex < 0 || e.ColumnIndex < 0) return;
        var property = grid.Columns[e.ColumnIndex].DataPropertyName;
        if (property is "LoanDate" or "ReturnDate" or "ReturnedAt")
        {
            e.Value = e.Value is DateTime date ? UiText.Date(date) : "—";
            e.FormattingApplied = true;
        }
        else if (property == "Role")
        {
            e.Value = UiText.Role(e.Value as string);
            e.FormattingApplied = true;
        }
        else if (property == "Status" && grid.Tag as string == "loans"
            && grid.Rows[e.RowIndex].DataBoundItem is LoanViewModel loan)
        {
            e.Value = loan.Status ? "برگشت داده شده" : loan.ReturnDate.Date < DateTime.Today ? "دیرکرد" : "در امانت";
            e.CellStyle.ForeColor = loan.Status ? UiTheme.Accent : loan.ReturnDate.Date < DateTime.Today
                ? Color.FromArgb(160, 65, 35) : UiTheme.Ink;
            e.FormattingApplied = true;
        }
        else if (e.Value is bool flag)
        {
            e.Value = property == "IsSpecial" ? flag ? "ویژه" : "عادی" : flag ? "فعال" : "غیرفعال";
            e.FormattingApplied = true;
        }
        else if (e.Value is int number)
        {
            e.Value = UiText.Digits(number);
            e.FormattingApplied = true;
        }
    }
}
