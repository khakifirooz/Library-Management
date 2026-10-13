using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm;

public partial class FrmMain : Form
{
    private string _role = "";
    public FrmMain() { InitializeComponent(); }
    public void SetUserData(MemberViewModel user)
    {
        GlobalUser.Username = user.Name; _role = user.Role ?? "";
        userProfile2.UserName = user.Name; userProfile2.ShowOnline(user.Name);
    }
    private void FrmMain_Load(object sender, EventArgs e)
    { if (UiDesigner.IsDesignMode(this)) return; userProfile2.ShowOnline(GlobalUser.Username); _adminTile.Visible = _role == "SuperAdmin"; btnAdminManagement.Visible = _role == "SuperAdmin"; }
    private void btnBook_Click(object sender, EventArgs e) => Program.ShowDialog<FrmBook>();
    private void button1_Click(object sender, EventArgs e) => Program.ShowDialog<FrmManageMembers>();
    private void button2_Click(object sender, EventArgs e) => Program.ShowDialog<FrmLoan>();
    private void btnAdminManagement_Click(object sender, EventArgs e)
    { if (_role == "SuperAdmin") Program.ShowDialog<FrmAdminManagement>(); }
    private void userProfile2_Load(object sender, EventArgs e) { }



    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        UiDesigner.FitToScreen(this);
    }
}
