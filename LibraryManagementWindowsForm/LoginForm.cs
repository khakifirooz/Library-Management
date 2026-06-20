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

        }

        private async void btn1_Click(object sender, EventArgs e)
        {

            //  بررسی لاگین از طریق سرویس
            var result = await _memberService.Login(txt_user.Text.Trim(), txt_pass.Text.Trim());

            if (result != null)
            {
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
    }
}
