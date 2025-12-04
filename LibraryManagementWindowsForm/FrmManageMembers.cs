using System.Threading.Tasks;
using LibraryManagementContracts.Member;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementWindowsForm
{
    public partial class FrmManageMembers : Form
    {
        private readonly IMemberService _memberService;

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
    }
}
