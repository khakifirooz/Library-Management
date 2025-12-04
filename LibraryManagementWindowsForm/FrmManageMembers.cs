using System.Threading.Tasks;
using LibraryManagementContracts.Member;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementWindowsForm
{
    public partial class FrmManageMembers : Form
    {
        private readonly IMemberService _memberService;
        public static int MemberId = 0;

        public FrmManageMembers(IMemberService memberService)
        {
            InitializeComponent();
            _memberService = memberService;
        }

        private async void FrmManageMembers_Load(object sender, EventArgs e)
        {
            dataGrid_members.DataSource = await _memberService.GetAllAsync();
            SetColumns();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmRegisterMember = Program.ServiceProvider.GetRequiredService<FrmRegisterMember>();
            frmRegisterMember.ShowDialog();
        }

        private void SetColumns()
        {
            dataGrid_members.Columns[0].HeaderText = "شناسه";
            dataGrid_members.Columns[1].HeaderText = "نام";
            dataGrid_members.Columns[2].HeaderText = "فامیلی";
            dataGrid_members.Columns[3].HeaderText = "کد ملی";
            dataGrid_members.Columns[4].HeaderText = "موبایل";
            dataGrid_members.Columns[5].HeaderText = "عضو ویژه";
            dataGrid_members.Columns[6].HeaderText = "وضعیت";
            dataGrid_members.Columns[7].Visible = false;
        }

        private async void btn_search_Click(object sender, EventArgs e)
        {
            var id = txt_search_id.Text == "" ? 0 : Convert.ToInt32(txt_search_id.Text);
            var nationalCode = txt_search_national_code.Text;
            dataGrid_members.DataBindings.Clear();
            dataGrid_members.DataSource = await _memberService.SearchAsync(id, nationalCode);
            SetColumns();
        }

        private void dataGrid_members_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_update.Enabled = true;
            MemberId = Convert.ToInt32(dataGrid_members.CurrentRow.Cells[0].Value);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var frmUpdateMember = Program.ServiceProvider.GetRequiredService<FrmUpdateMember>();
            frmUpdateMember.ShowDialog();
        }
    }
}
