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
    }
}
