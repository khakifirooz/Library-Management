using System.Threading.Tasks;
using LibraryManagementContracts.Member;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementWindowsForm
{
    public partial class LoginForm : Form
    {

        //private readonly IMemberService _memberService;
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

            // ۱. بررسی لاگین از طریق سرویس
            var result = await _memberService.Login(txt_user.Text.Trim(), txt_pass.Text.Trim());

            if (result != null)
            {
                // ۲. گرفتن نمونه فرم اصلی از طریق ServiceProvider (اصولی‌ترین روش در معماری تو)
                var mainForm = Program.ServiceProvider.GetRequiredService<FrmMain>();

                // ۳. انتقال نام کاربر به فرم اصلی از طریق متدی که قبلاً ساختیم
                // ترکیب نام و نام خانوادگی برای نمایش کامل
                mainForm.SetUserData($"{result.Name} {result.Family}");

                // ۴. مدیریت بستن برنامه و نمایش فرم
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطا", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // var result = await _memberService.(txt_user.Text);

            //if (txt_user.Text == "123" && txt_pass.Text == "123")
            //{
            //    // اسم کاربر رو به FrmMain فرستادن
            //    FrmMain mainForm = new FrmMain(txt_user.Text); // اینجا
            //    mainForm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("رمز یا نام کاربری اشتباه");
            //}




            //var result = await _memberService.GetByIdAsync(Convert.ToInt32(txt_user.Text));

            //if (result)
            //{

            //}




            //var model = new MemberCreateModel()
            //{
            //    Name = txt_user.Text,
            //    Family = txt_pass.Text,
            //};

            //if (Name == )
            //{

            //}

        }
    }
}
