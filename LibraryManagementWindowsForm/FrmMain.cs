using Microsoft.Extensions.DependencyInjection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementWindowsForm
{
    public partial class FrmMain : Form
    {
        private string _loggedInUser;

        /// private string loggedInUser;   // 
        public FrmMain(/*string username*/)
        {
            InitializeComponent();
           // loggedInUser = username;      // گرفتن یوز
        }

        public void SetUserData(string username)
        {
            _loggedInUser = username;
            // تغییر نام از userProfile1 به userProfile2
            if (userProfile2 != null)
            {
                userProfile2.UserName = username;
                userProfile2.ShowOnline(username);
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            userProfile2.ShowOnline(_loggedInUser);
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

        private void userProfile2_Load(object sender, EventArgs e)
        {

        }
    }
}
