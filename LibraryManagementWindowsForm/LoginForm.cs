using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm;

public partial class LoginForm : Form
{
    private readonly IMemberService _memberService;
    public LoginForm(IMemberService memberService)
    { InitializeComponent(); BuildUi(); _memberService = memberService; }
    private void LoginForm_Load(object sender, EventArgs e) { txt_pass.PasswordChar = '*'; }
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

    private void BuildUi()
    {
        txt_user.MaxLength = 50; txt_pass.MaxLength = 128;
        txt_user.RightToLeft = RightToLeft.No; txt_pass.RightToLeft = RightToLeft.No;
        txt_user.PlaceholderText = "نام کاربری"; txt_pass.UseSystemPasswordChar = true;
        var fields = UiLayout.Card("ورود به حساب", UiLayout.ScrollFields(UiLayout.Field("نام کاربری", txt_user),
            UiLayout.Field("رمز عبور", txt_pass), chkShowPassword, UiLayout.Actions(btn1)));
        UiLayout.Install(this, "مدیریت کتابخانه", "برای دسترسی به کتاب‌ها، اعضا و امانت‌ها وارد شوید", fields,
            null, 620, 520, 540, 460);
        btn1.Text = "ورود"; AcceptButton = btn1; StartPosition = FormStartPosition.CenterScreen;
    }

}
