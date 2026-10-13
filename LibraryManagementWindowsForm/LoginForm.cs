using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm;

public partial class LoginForm : Form
{
    private readonly IMemberService _memberService = null!;
    public LoginForm() { InitializeComponent(); }

    public LoginForm(IMemberService memberService) : this()
    {
        _memberService = memberService;
    }
    private void LoginForm_Load(object sender, EventArgs e) { }
    private async void btn1_Click(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    {
        // Whitespace is part of a password. Only normalize the username.
        var result = await _memberService.Login(txt_user.Text.Trim(), txt_pass.Text);
        if (result is null)
        {
            MessageBox.Show("نام کاربری یا رمز عبور اشتباه است یا حساب فعال نیست.", "خطا",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        GlobalUser.Username = result.Name; GlobalUser.Role = result.Role;
        Hide();
        Program.ShowDialog<FrmMain>(form => form.SetUserData(result));
        Close();
    });
    private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        txt_pass.UseSystemPasswordChar = !chkShowPassword.Checked;
        txt_pass.PasswordChar = '\0';
        chkShowPassword.Text = chkShowPassword.Checked ? "مخفی کردن رمز" : "نمایش رمز";
    }



    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        UiDesigner.FitToScreen(this);
    }
}
