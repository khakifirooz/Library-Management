using Contracts.Book;
using FrameworkApplication;
using LibraryManagementContracts.Loan;
using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm;

public partial class FrmLoan : Form
{
    private readonly IMemberService _memberService;
    private readonly IBookService _bookService;
    private readonly ILoanService _loanService;
    private MemberViewModel? _member;
    private LoanViewModel? _selectedLoan;
    private readonly Label _loanStatus = UiTheme.Status();
    private readonly Label _bookStatus = UiTheme.Status();
    private bool _bindingLoans;

    public FrmLoan(IMemberService memberService, IBookService bookService, ILoanService loanService)
    {
        _memberService = memberService; _bookService = bookService; _loanService = loanService;
        InitializeComponent();
        dataGridView_loans.ReadOnly = true;
        dataGridView_loans.AllowUserToAddRows = false;
        dataGridView_loans.AllowUserToDeleteRows = false;
        dataGridView_loans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView_loans.MultiSelect = false;
        dataGridView_loans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView_loans.SelectionChanged += (_, _) => ShowSelectedLoan();
        comboBox_books.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox_Book_return.Enabled = false;
        dateTimePicker_ExpiredTime.ReadOnly = true;
        dateTimePicker_loan.Value = DateTime.Today;
        dateTimePicker_return.Value = DateTime.Today.AddDays(14);
        dateTimePicker_returnBack.Value = DateTime.Today;
        txt_search_id.TextChanged += (_, _) => ClearMember();
        BuildUi();
        ClearMember();
    }

    private void ClearMember()
    {
        _member = null; _selectedLoan = null;
        txt_family.Clear(); checkBox_isSpecial.Checked = false; checkBox_status.Checked = false;
        ImageHelper.SetImage(pictureBox_member, null);
        _bindingLoans = true;
        try { dataGridView_loans.DataSource = null; comboBox_Book_return.DataSource = null; }
        finally { _bindingLoans = false; }
        _loanStatus.Text = "شماره عضویت را وارد کنید و بازیابی عضو را بزنید.";
        dateTimePicker_ExpiredTime.Clear();
        dateTimePicker_returnBack.ReadOnly = false;
        dateTimePicker_returnBack.Value = DateTime.Today;
        btn_save.Enabled = false; btn_return_save.Enabled = false;
    }

    private async Task LoadMemberAsync()
    {
        ClearMember();
        if (!int.TryParse(PersianDateHelper.NormalizeDigits(txt_search_id.Text).Trim(), out var id) || id <= 0)
        { MessageBox.Show("شماره عضویت معتبر وارد کنید."); return; }
        var model = await _memberService.GetMemberWithLoanByIdAsync(id);
        if (model is null) { MessageBox.Show("عضو پیدا نشد."); return; }
        _member = model;
        txt_family.Text = $"{model.Name} {model.Family}";
        checkBox_isSpecial.Checked = model.IsSpecial; checkBox_status.Checked = model.Status;
        ImageHelper.SetImage(pictureBox_member, model.Image);
        _bindingLoans = true;
        try
        {
            comboBox_Book_return.DataSource = null;
            comboBox_Book_return.DisplayMember = nameof(LoanViewModel.BookName);
            comboBox_Book_return.ValueMember = nameof(LoanViewModel.Id);
            comboBox_Book_return.DataSource = model.Loans;
            dataGridView_loans.DataSource = model.Loans;
            dataGridView_loans.ClearSelection(); dataGridView_loans.CurrentCell = null;
        }
        finally { _bindingLoans = false; }
        _selectedLoan = null; btn_return_save.Enabled = false;
        _loanStatus.Text = model.Loans.Count == 0 ? "این عضو سابقهٔ امانت ندارد."
            : $"{UiText.Digits(model.Loans.Count)} سابقه؛ {UiText.Digits(model.Loans.Count(x => !x.Status))} امانت فعال";
        await LoadBooksAsync();
    }

    private async Task LoadBooksAsync()
    {
        btn_save.Enabled = false; _bookStatus.Text = "در حال بارگذاری کتاب‌های آزاد…";
        try
        {
            var books = await _bookService.GetExistForComboAsync();
            comboBox_books.DataSource = null;
            comboBox_books.DisplayMember = "Title"; comboBox_books.ValueMember = "Id";
            comboBox_books.DataSource = books;
            _bookStatus.Text = books.Count == 0 ? "کتاب آزاد برای امانت وجود ندارد."
                : $"{UiText.Digits(books.Count)} کتاب قابل امانت";
            btn_save.Enabled = _member is { Status: true } && books.Count > 0;
        }
        catch
        {
            comboBox_books.DataSource = null;
            _bookStatus.Text = "بارگذاری ناموفق بود؛ تازه‌سازی را بزنید.";
            throw;
        }
    }

    private void ConfigureGrid() { }

    private void ShowSelectedLoan()
    {
        if (_bindingLoans) return;
        var next = dataGridView_loans.SelectedRows.Count > 0
            ? dataGridView_loans.SelectedRows[0].DataBoundItem as LoanViewModel : null;
        if (next?.Id == _selectedLoan?.Id) return;
        _selectedLoan = next;
        btn_return_save.Enabled = next is { Status: false };
        if (next is not { } loan) { dateTimePicker_ExpiredTime.Clear(); return; }
        comboBox_Book_return.SelectedValue = loan.Id;
        dateTimePicker_ExpiredTime.Value = loan.ReturnDate;
        dateTimePicker_returnBack.ReadOnly = loan.Status;
        if (loan.Status && loan.ReturnedAt is null) dateTimePicker_returnBack.Clear();
        else dateTimePicker_returnBack.Value = loan.ReturnedAt ?? DateTime.Today;
    }

    private async void FrmLoan_Load(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    {
        await LoadBooksAsync();
        if (!string.IsNullOrEmpty(GlobalUser.Username)) userProfile1.ShowOnline(GlobalUser.Username);
    });
    private async void btn_reneview_Click(object sender, EventArgs e) => await UiActions.RunAsync(this, LoadMemberAsync);
    private async void btn_save_Click(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    {
        if (_member is null || !int.TryParse(PersianDateHelper.NormalizeDigits(txt_search_id.Text).Trim(), out var id)
            || id != _member.Id || comboBox_books.SelectedValue is not int bookId)
        { MessageBox.Show("ابتدا عضو و کتاب را انتخاب کنید."); return; }
        if (!dateTimePicker_loan.TryGetValue(out var loanDate) || !dateTimePicker_return.TryGetValue(out var dueDate))
        { MessageBox.Show("تاریخ‌های شمسی معتبر با قالب ۱۴۰۵/۰۷/۱۹ وارد کنید."); return; }
        var result = await _memberService.AddLoanAsync(new LoanCreateModel
        { MemberId = id, BookId = bookId, LoanDate = loanDate, ReturnDate = dueDate });
        MessageBox.Show(result.Message);
        if (result.Success) await LoadMemberAsync();
    });
    private async void button1_Click(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    {
        if (_selectedLoan is not { Status: false } loan)
        { MessageBox.Show("یک امانت فعال از جدول انتخاب کنید."); return; }
        if (!dateTimePicker_returnBack.TryGetValue(out var actualReturn))
        { MessageBox.Show("تاریخ واقعی برگشت را صحیح وارد کنید."); return; }
        var result = await _loanService.ReturnLoanAsync(loan.Id, actualReturn);
        MessageBox.Show(result.Message);
        if (result.Success) await LoadMemberAsync();
    });
    private void dataGridView_loans_CellClick(object sender, DataGridViewCellEventArgs e)
    { if (e.RowIndex >= 0) ShowSelectedLoan(); }
    private void groupBox1_Enter(object sender, EventArgs e) { }
    private void groupBox2_Enter(object sender, EventArgs e) { }
    private void dataGridView_loans_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    private void comboBox_books_SelectedIndexChanged(object sender, EventArgs e) { }
    private void comboBox_Book_return_SelectedIndexChanged(object sender, EventArgs e) { }
    private void dateTimePicker_ExpiredTime_ValueChanged(object sender, EventArgs e) { }
    private void userProfile1_Load(object sender, EventArgs e) { }

    private void BuildUi()
    {
        txt_family.ReadOnly = true; txt_search_id.MaxLength = 10;
        checkBox_status.Enabled = false; checkBox_isSpecial.Enabled = false;
        checkBox_status.Text = "عضو فعال"; checkBox_isSpecial.Text = "عضویت ویژه";
        comboBox_Book_return.DropDownStyle = ComboBoxStyle.DropDownList;
        var refresh = UiTheme.NewButton("تازه‌سازی کتاب‌ها", async (_, _) =>
            await UiActions.RunAsync(this, LoadBooksAsync, "بارگذاری کتاب‌های آزاد"));
        var memberSearch = UiLayout.Across(UiLayout.Field("شماره عضویت", txt_search_id),
            UiLayout.Field("نام عضو", txt_family), UiLayout.Actions(btn_reneview, checkBox_status, checkBox_isSpecial));
        var memberPanel = new TableLayoutPanel { ColumnCount = 2, RowCount = 1, Dock = DockStyle.Fill,
            RightToLeft = RightToLeft.No };
        memberPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95));
        memberPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        pictureBox_member.Dock = DockStyle.Fill;
        memberPanel.Controls.Add(pictureBox_member, 0, 0); memberPanel.Controls.Add(memberSearch, 1, 0);
        var issueFields = UiLayout.Across(UiLayout.Field("کتاب قابل امانت", comboBox_books),
            UiLayout.Field("تاریخ امانت", dateTimePicker_loan), UiLayout.Field("موعد تحویل", dateTimePicker_return));
        issueFields.Height = 76;
        var returnFields = UiLayout.Across(UiLayout.Field("کتاب انتخاب‌شده", comboBox_Book_return),
            UiLayout.Field("موعد تحویل", dateTimePicker_ExpiredTime), UiLayout.Field("برگشت واقعی", dateTimePicker_returnBack));
        returnFields.Height = 76;
        var issue = UiLayout.Card("ثبت امانت جدید", UiLayout.Stack(issueFields, _bookStatus, UiLayout.Actions(btn_save, refresh)));
        var returned = UiLayout.Card("برگشت کتاب", UiLayout.Stack(returnFields, UiLayout.Actions(btn_return_save)));
        var body = new TableLayoutPanel { ColumnCount = 1, RowCount = 3, Dock = DockStyle.Fill,
            RightToLeft = RightToLeft.No };
        body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        body.RowStyles.Add(new RowStyle(SizeType.Absolute, 138));
        body.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        body.RowStyles.Add(new RowStyle(SizeType.Absolute, 250));
        body.Controls.Add(UiLayout.Card("بازیابی عضو", memberPanel), 0, 0);
        body.Controls.Add(UiLayout.Card("تاریخچهٔ امانت‌ها", UiLayout.GridArea(dataGridView_loans, _loanStatus)), 0, 1);
        body.Controls.Add(UiLayout.Across(issue, returned), 0, 2);
        UiLayout.Install(this, "امانت و برگشت کتاب", "تاریخچهٔ کامل، تاریخ شمسی و کتاب‌های قابل امانت",
            body, userProfile1, 1280, 850, 1120, 760);
        UiTheme.Button(refresh, false); UiGrids.Loans(dataGridView_loans);
    }

}
