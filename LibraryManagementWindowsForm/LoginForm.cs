using System.Threading.Tasks;
using LibraryManagementContracts.Member;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementWindowsForm
{
    public partial class LoginForm : Form
    {

        private readonly IMemberService _memberService;
        public LoginForm(IMemberService memberService)
        {
            InitializeComponent();
            _memberService = memberService;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private async Task button1_Click(object sender, EventArgs e)
        {

           // var result = await _memberService.(txt_user.Text);

            if (txt_user.Text == "123" && txt_pass.Text == "123")
            {
                // اسم کاربر رو به FrmMain فرستادن
                FrmMain mainForm = new FrmMain(txt_user.Text); // اینجا
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("رمز یا نام کاربری اشتباه");
            }




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
