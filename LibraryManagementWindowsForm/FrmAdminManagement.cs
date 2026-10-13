using LibraryManagementContracts.Admin;
using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm;

public partial class FrmAdminManagement : Form
{
    private readonly IMemberService _memberService;
    private int _selectedAdminId;
    private List<AdminViewModel> _admins = [];
    private readonly Label _status = UiTheme.Status();
    public FrmAdminManagement(IMemberService memberService)
    {
        InitializeComponent(); BuildUi(); _memberService = memberService;
        dgvAdmins.ReadOnly = true; dgvAdmins.AllowUserToAddRows = false;
        dgvAdmins.MultiSelect = false; dgvAdmins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        txtPassword.PasswordChar = '*'; txtPassword.PlaceholderText = "خالی = حفظ رمز فعلی";
    }
    private async Task LoadData()
    {
        _admins = await _memberService.GetAllAdminsAsync();
        _selectedAdminId = 0; txtUserName.Clear(); txtPassword.Clear(); Filter();
    }
    private void Filter()
    {
        var rows = _admins.Where(x => x.UserName.Contains(txt_search.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();
        dgvAdmins.DataSource = rows;
        dgvAdmins.ClearSelection(); dgvAdmins.CurrentCell = null;
        _selectedAdminId = 0; txtUserName.Clear(); txtPassword.Clear();
        btnUpdate.Enabled = false; btnDisable.Enabled = false; btnEnable.Enabled = false;
        _status.Text = rows.Count == 0 ? "مدیری با این نام پیدا نشد." : $"{UiText.Digits(rows.Count)} حساب مدیر";
    }
    private async void FrmAdminManagement_Load(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    { await LoadData(); userProfile1.ShowOnline(GlobalUser.Username); });
    private void dgvAdmins_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgvAdmins.Rows[e.RowIndex].DataBoundItem is not AdminViewModel admin) return;
        _selectedAdminId = admin.Id; txtUserName.Text = admin.UserName; txtPassword.Clear();
        btnUpdate.Enabled = true; btnDisable.Enabled = admin.IsActive; btnEnable.Enabled = !admin.IsActive;
    }
    private async void btnEdit_Click(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    {
        if (_selectedAdminId <= 0) { MessageBox.Show("ابتدا یک مدیر انتخاب کنید."); return; }
        var result = await _memberService.UpdateAdminAsync(new UpdateAdminModel
        { Id = _selectedAdminId, UserName = txtUserName.Text, Password = txtPassword.Text });
        MessageBox.Show(result.Message); if (result.Success) await LoadData();
    });
    private async void btnDisable_Click(object sender, EventArgs e) => await ChangeState(false);
    private async void button5_Click(object sender, EventArgs e) => await ChangeState(true);
    private Task ChangeState(bool active) => UiActions.RunAsync(this, async () =>
    {
        if (_selectedAdminId <= 0) { MessageBox.Show("ابتدا یک مدیر انتخاب کنید."); return; }
        var result = active ? await _memberService.EnableAdminAsync(_selectedAdminId)
            : await _memberService.DisableAdminAsync(_selectedAdminId);
        MessageBox.Show(result.Message); if (result.Success) await LoadData();
    });
    private async void btnRefresh_Click(object sender, EventArgs e) => await UiActions.RunAsync(this, LoadData);
    private async void btnCreateAdmin_Click(object sender, EventArgs e)
    { if (Program.ShowDialog<FrmCreateAdmin>() == DialogResult.OK) await UiActions.RunAsync(this, LoadData); }
    private void textBox1_TextChanged(object sender, EventArgs e) => Filter();
    public void SetColumns() { }
    private void userProfile1_Load(object sender, EventArgs e) { }
    private void label2_Click(object sender, EventArgs e) { }

    private void BuildUi()
    {
        txtUserName.MaxLength = 50; txtPassword.MaxLength = 128;
        var search = UiLayout.Across(UiLayout.Field("جست‌وجوی نام کاربری", txt_search), UiLayout.Actions(btnRefresh, btnCreateAdmin));
        var list = UiLayout.Card("حساب‌های مدیر", UiLayout.GridArea(dgvAdmins, _status, search));
        var editor = UiLayout.Card("ویرایش حساب انتخاب‌شده", UiLayout.ScrollFields(
            UiLayout.Field("نام کاربری", txtUserName), UiLayout.Field("رمز جدید؛ خالی یعنی حفظ رمز", txtPassword),
            UiLayout.Actions(btnUpdate, btnEnable, btnDisable)));
        UiLayout.Install(this, "مدیریت مدیران", "نمایش نقش و وضعیت حساب، بدون نمایش رمز عبور", UiLayout.Split(list, editor), userProfile1);
        btnCreateAdmin.Text = "مدیر جدید"; btnRefresh.Text = "تازه‌سازی";
        btnUpdate.Text = "ذخیرهٔ تغییرات"; btnEnable.Text = "فعال‌سازی"; btnDisable.Text = "غیرفعال‌سازی";
        UiTheme.Button(btnRefresh, false); UiTheme.Button(btnEnable, false); UiTheme.Button(btnDisable, true, true);
        UiGrids.Admins(dgvAdmins);
        btnUpdate.Enabled = false; btnDisable.Enabled = false; btnEnable.Enabled = false;
        dgvAdmins.SelectionChanged += (_, _) =>
        {
            if (dgvAdmins.SelectedRows.Count == 0) return;
            if (dgvAdmins.SelectedRows[0].DataBoundItem is not AdminViewModel admin) return;
            _selectedAdminId = admin.Id; txtUserName.Text = admin.UserName; txtPassword.Clear();
            btnUpdate.Enabled = true; btnDisable.Enabled = admin.IsActive; btnEnable.Enabled = !admin.IsActive;
        };
    }

}
