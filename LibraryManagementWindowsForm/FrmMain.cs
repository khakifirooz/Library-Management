using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementWindowsForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            var FrmBook = Program.ServiceProvider.GetRequiredService<FrmBook>();
            FrmBook.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmManageMember = Program.ServiceProvider.GetRequiredService<FrmManageMembers>();
            frmManageMember.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmLoan = Program.ServiceProvider.GetRequiredService<FrmLoan>();
            frmLoan.ShowDialog();
        }
    }
}
