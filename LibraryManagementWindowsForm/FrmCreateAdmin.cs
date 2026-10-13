using LibraryManagementContracts.Admin;
using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm;

public partial class FrmCreateAdmin : Form
{
    private readonly IMemberService _memberService;
    public FrmCreateAdmin(IMemberService memberService)
    { InitializeComponent(); BuildUi(); _memberService = memberService; txtPassword.PasswordChar = '*'; }
    private async void btnSave_Click(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    {
        var result = await _memberService.CreateAdminAsync(new CreateAdminModel
        { UserName = txtUserName.Text, Password = txtPassword.Text });
        MessageBox.Show(result.Message);
        if (result.Success) { DialogResult = DialogResult.OK; Close(); }
    });
    private void FrmCreateAdmin_Load(object sender, EventArgs e) => userProfile1.ShowOnline(GlobalUser.Username);
    private void textBox1_TextChanged(object sender, EventArgs e) { }
    private void label1_Click(object sender, EventArgs e) { }

    private void BuildUi()
    {
        txtUserName.MaxLength = 50; txtPassword.MaxLength = 128;
        var cancel = UiTheme.NewButton("بازگشت", (_, _) => Close());
        var fields = UiLayout.Card("حساب جدید", UiLayout.ScrollFields(UiLayout.Field("نام کاربری", txtUserName),
            UiLayout.Field("رمز عبور", txtPassword), UiLayout.Actions(btnSave, cancel)));
        UiLayout.Install(this, "ثبت مدیر جدید", "ایجاد حساب مدیریت کتابخانه", fields, userProfile1,
            650, 500, 580, 450);
        btnSave.Text = "ثبت مدیر"; UiTheme.Button(cancel, false); AcceptButton = btnSave; CancelButton = cancel;
    }

}
