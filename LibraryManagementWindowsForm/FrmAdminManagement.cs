using LibraryManagementContracts.Admin;
using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm;

public partial class FrmAdminManagement : Form
{
    private readonly IMemberService _memberService = null!;
    private int _selectedAdminId;
    private List<AdminViewModel> _admins = [];
    public FrmAdminManagement() { InitializeComponent(); }

    public FrmAdminManagement(IMemberService memberService) : this()
    {
        _memberService = memberService;
        UiGrids.AttachFormatting(dgvAdmins, "admins");
        btnUpdate.Enabled = false; btnDisable.Enabled = false; btnEnable.Enabled = false;
        dgvAdmins.SelectionChanged += (_, _) =>
        {
            if (dgvAdmins.SelectedRows.Count == 0 ||
                dgvAdmins.SelectedRows[0].DataBoundItem is not AdminViewModel admin) return;
            _selectedAdminId = admin.Id; txtUserName.Text = admin.UserName; txtPassword.Clear();
            btnUpdate.Enabled = true; btnDisable.Enabled = admin.IsActive; btnEnable.Enabled = !admin.IsActive;
        };
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
    { if (_memberService is null || UiDesigner.IsDesignMode(this)) return; await LoadData(); userProfile1.ShowOnline(GlobalUser.Username); });
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



    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        UiDesigner.FitToScreen(this);
    }
}
