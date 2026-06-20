using LibraryManagementContracts.Admin;
using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm
{
    public partial class FrmCreateAdmin : Form
    {
        private readonly IMemberService _memberService;

        //private string _originalUserName;
        //private string _originalPassword;
        //private bool _isDataChanged = false;

        public FrmCreateAdmin(IMemberService memberService)
        {
            InitializeComponent();
            _memberService = memberService;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("نام کاربری نباید خالی باشد.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("رمز عبور نباید خالی باشد.");
                return;
            }

            if (txtPassword.Text.Trim().Length < 3)
            {
                MessageBox.Show("رمز عبور باید حداقل ۳ کاراکتر باشد.");
                return;
            }

            // تایید قبل از ذخیره
            var confirm = MessageBox.Show(
                "آیا از ثبت این ادمین مطمئن هستید؟",
                "تأیید ثبت",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            var result =
              await _memberService.CreateAdminAsync(
              new CreateAdminModel
              {
                  UserName = txtUserName.Text,
                  Password = txtPassword.Text
              });

            //MessageBox.Show(result.Message);

            if (result.Success)
            {
                MessageBox.Show("ادمین با موفقیت ثبت شد");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("نام کاربری تکراری است");
            }
        }

        private void FrmCreateAdmin_Load(object sender, EventArgs e)
        {
            if (GlobalUser.Username != null)
            {
                userProfile1.ShowOnline(GlobalUser.Username);
            }
        }
    }
}
