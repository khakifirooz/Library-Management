using LibraryManagementContracts.Admin;
using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm;

public partial class FrmCreateAdmin : Form
{
    private readonly IMemberService _memberService = null!;
    public FrmCreateAdmin() { InitializeComponent(); }

    public FrmCreateAdmin(IMemberService memberService) : this()
    {
        _memberService = memberService;
    }
    private async void btnSave_Click(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    {
        var result = await _memberService.CreateAdminAsync(new CreateAdminModel
        { UserName = txtUserName.Text, Password = txtPassword.Text });
        MessageBox.Show(result.Message);
        if (result.Success) { DialogResult = DialogResult.OK; Close(); }
    });
    private void FrmCreateAdmin_Load(object sender, EventArgs e) { if (!UiDesigner.IsDesignMode(this)) userProfile1.ShowOnline(GlobalUser.Username); }
    private void textBox1_TextChanged(object sender, EventArgs e) { }
    private void label1_Click(object sender, EventArgs e) { }



    private void Cancel_Click(object sender, EventArgs e) => Close();
    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        UiDesigner.FitToScreen(this);
    }
}
