using System.Threading.Tasks;
using LibraryManagementContracts.Member;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementWindowsForm
{
    public partial class LoginForm : Form
    {
        private readonly IMemberService _memberService;  // اضافه کردن برای استفاده از متد لاگین
        public LoginForm(IMemberService memberService)
        {
            InitializeComponent();
            _memberService = memberService;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = '*';
        }

        private async void btn1_Click(object sender, EventArgs e)
        {

            //  بررسی لاگین از طریق سرویس
            var result = await _memberService.Login(txt_user.Text.Trim(), txt_pass.Text.Trim());

            if (result != null)
            {

                GlobalUser.Username = result.Name;   // اگر نام فیلد Name است
                GlobalUser.Role = result.Role;

                //  گرفتن نمونه فرم اصلی از طریق ServiceProvider
                var mainForm = Program.ServiceProvider.GetRequiredService<FrmMain>();

                //  انتقال نام کاربر به فرم اصلی از طریق متدی که قبلاً ساختیم
                // ترکیب نام و نام خانوادگی برای نمایش کامل
                mainForm.SetUserData(result);

                // مدیریت بستن برنامه و نمایش فرم
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (chkShowPassword.Checked)
            {
                txt_pass.PasswordChar = '\0';
                chkShowPassword.Text = "مخفی کردن رمز";
            }
            else
            {
                txt_pass.PasswordChar = '*';
                chkShowPassword.Text = "نمایش رمز";
            }

            //if (chkShowPassword.Checked)
            //{
            //    txt_pass.PasswordChar = '\0'; // نمایش رمز
            //}
            //else
            //{
            //    txt_pass.PasswordChar = '*'; // مخفی شدن رمز
            //}
        }
    }
}
