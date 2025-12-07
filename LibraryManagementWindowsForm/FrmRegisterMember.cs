using System.Threading.Tasks;
using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm
{
    public partial class FrmRegisterMember : Form
    {
        private readonly IMemberService _memberService;

        public FrmRegisterMember(IMemberService memberService)
        {
            InitializeComponent();
            _memberService = memberService;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegisterMember_Load(object sender, EventArgs e)
        {

        }

        private void picture_member_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            picture_member.Load(openFileDialog.FileName);
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) ||
                  string.IsNullOrWhiteSpace(txt_family.Text) ||
                  string.IsNullOrWhiteSpace(txt_mobile.Text) ||
                  string.IsNullOrWhiteSpace(txt_national_code.Text) ||
                  picture_member.Image == null)
            {
                MessageBox.Show("حتما همه مقادیر را پر کنید");
                return;
            }
            if (txt_national_code.Text.Length != 10)
            {
                MessageBox.Show("کد ملی باید 10 رقم باشد");
                txt_national_code.Focus();
                return;
            }
            if (txt_mobile.Text.Length != 11)
            {
                MessageBox.Show("شماره موبایل باید 11 رقم باشد");
                txt_mobile.Focus();
                return;
            }
            MemoryStream stream = new MemoryStream();
            picture_member.Image.Save(stream, picture_member.Image.RawFormat);
            var image = stream.GetBuffer();

            var model = new MemberCreateModel()
            {
                Name = txt_name.Text,
                Family = txt_family.Text,
                NationalCode = txt_national_code.Text,
                Mobile = txt_mobile.Text,
                IsSpecial = checkBox_isSpecial.Checked,
                Image = image,
            };
            var result = await _memberService.CreateAsync(model);
            if (result.Success)
            {
                txt_name.Text = "";
                txt_family.Text = "";
                txt_mobile.Text = "";
                txt_national_code.Text = "";
                checkBox_isSpecial.Checked = false;
                picture_member.Image = null;
                MessageBox.Show(result.Message);
            }
            else
                MessageBox.Show(result.Message);
        }

        private void txt_national_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // block letters & symbols
                MessageBox.Show("حروف قابل استقاده در کد ملی نمیباشند");
            }
        }

        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // block letters & symbols
                MessageBox.Show("حروف قابل استقاده در شماره همراه نمیباشند");
            }
        }
    }
}
