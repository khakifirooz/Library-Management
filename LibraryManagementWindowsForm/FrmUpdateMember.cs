using System.Threading.Tasks;
using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm
{
    public partial class FrmUpdateMember : Form
    {
        private readonly IMemberService _memberService;

        public FrmUpdateMember(IMemberService memberService)
        {
            _memberService = memberService;
            InitializeComponent();

        }

        private async void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            var id = FrmManageMembers.MemberId;
            var member = await _memberService.GetByIdAsync(id);
            txt_id.Text = member.Id.ToString();
            txt_name.Text = member.Name;
            txt_family.Text = member.Family;
            txt_national_code.Text = member.NationalCode;
            txt_mobile.Text = member.Mobile;
            checkBox_isSpecial.Checked = member.IsSpecial;
            checkBox_status.Checked = member.Status;
            MemoryStream memoryStream = new MemoryStream(member.Image);
            picture_member.Image = Image.FromStream(memoryStream);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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
            MemoryStream stream = new MemoryStream();
            picture_member.Image.Save(stream, picture_member.Image.RawFormat);
            var image = stream.GetBuffer();

            var member = await _memberService.GetByIdAsync(Convert.ToInt32(txt_id.Text));
            var model = new MemberUpdateModel()
            {
                Id = member.Id,
                Name = txt_name.Text,
                Family = txt_family.Text,
                NationalCode = txt_national_code.Text,
                Mobile = txt_mobile.Text,
                IsSpecial = checkBox_isSpecial.Checked,
                Status = checkBox_status.Checked,
                Image = image,
            };

            var result = await _memberService.UpdateAsync(model);
            if (result.Success)
            {
                txt_name.Text = "";
                txt_family.Text = "";
                txt_mobile.Text = "";
                txt_national_code.Text = "";
                checkBox_isSpecial.Checked = false;
                checkBox_status.Checked = false;
                picture_member.Image = null;
                MessageBox.Show(result.Message);
            }
            else
                MessageBox.Show(result.Message);
        }
    }
}
