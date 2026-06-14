using Microsoft.Extensions.DependencyInjection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementWindowsForm
{
    public partial class FrmMain : Form
    {
        private string loggedInUser;   // 
        public FrmMain(string username)
        {
            InitializeComponent();
            loggedInUser = username;      // گرفتن یوز
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UserProfile uc = new UserProfile();

            uc.ShowOnline(loggedInUser); 

            uc.Dock = DockStyle.Top;
            Controls.Add(uc);
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
