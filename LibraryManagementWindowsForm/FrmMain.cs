using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm;

public partial class FrmMain : Form
{
    private string _role = "";
    private Control _adminTile = null!;
    public FrmMain() { InitializeComponent(); BuildUi(); }
    public void SetUserData(MemberViewModel user)
    {
        GlobalUser.Username = user.Name; _role = user.Role ?? "";
        userProfile2.UserName = user.Name; userProfile2.ShowOnline(user.Name);
    }
    private void FrmMain_Load(object sender, EventArgs e)
    { userProfile2.ShowOnline(GlobalUser.Username); _adminTile.Visible = _role == "SuperAdmin"; btnAdminManagement.Visible = _role == "SuperAdmin"; }
    private void btnBook_Click(object sender, EventArgs e) => Program.ShowDialog<FrmBook>();
    private void button1_Click(object sender, EventArgs e) => Program.ShowDialog<FrmManageMembers>();
    private void button2_Click(object sender, EventArgs e) => Program.ShowDialog<FrmLoan>();
    private void btnAdminManagement_Click(object sender, EventArgs e)
    { if (_role == "SuperAdmin") Program.ShowDialog<FrmAdminManagement>(); }
    private void userProfile2_Load(object sender, EventArgs e) { }

    private void BuildUi()
    {
        var tiles = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoScroll = true, WrapContents = true,
            FlowDirection = FlowDirection.RightToLeft, RightToLeft = RightToLeft.No };
        Control Tile(string title, string description, Button button)
        {
            button.Text = "باز کردن";
            var text = new Label { Text = description, Height = 66, Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleRight, RightToLeft = RightToLeft.Yes, ForeColor = UiTheme.Muted };
            var card = UiLayout.Card(title, UiLayout.Stack(text, UiLayout.Actions(button)));
            card.Dock = DockStyle.None; card.Size = new Size(280, 220); card.Margin = new Padding(10);
            tiles.Controls.Add(card); return card;
        }
        Tile("کتاب‌ها", "ثبت کتاب، جست‌وجوی عنوان و نویسنده و ویرایش مشخصات.", btnBook);
        Tile("اعضا", "ثبت عضو، بررسی وضعیت عضویت و اصلاح اطلاعات.", button1);
        Tile("امانت‌ها", "ثبت امانت و برگشت کتاب با تاریخ شمسی و حفظ تاریخچه.", button2);
        _adminTile = Tile("مدیران", "مدیریت حساب‌ها و وضعیت دسترسی مدیران.", btnAdminManagement);
        UiLayout.Install(this, "مدیریت کتابخانه", "بخش موردنظر را برای شروع کار انتخاب کنید", tiles, userProfile2,
            1080, 660, 760, 560);
    }

}
