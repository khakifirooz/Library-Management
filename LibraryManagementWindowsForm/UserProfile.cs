using System.ComponentModel;

namespace LibraryManagementWindowsForm;

public partial class UserProfile : UserControl
{
    private string _username = "";
    public UserProfile()
    {
        InitializeComponent();
        Controls.Remove(label1); label1.Dispose();
        lblTitle.AutoSize = false; lblTitle.Dock = DockStyle.Fill;
        lblTitle.BackColor = Color.Transparent;
        lblTitle.TextAlign = ContentAlignment.MiddleRight;
        RightToLeft = RightToLeft.Yes;
        BackColor = Color.White;
        MinimumSize = new Size(160, 32);
        AccessibleName = "کاربر واردشده";
    }

    [Browsable(true), DefaultValue("")]
    public string UserName
    {
        get => _username;
        set { _username = value ?? ""; ShowOnline(_username); }
    }

    public void ShowOnline(string username)
    {
        _username = username ?? "";
        lblTitle.Text = string.IsNullOrWhiteSpace(_username) ? "" : $"{_username}  •  آنلاین";
        lblTitle.ForeColor = UiTheme.Accent;
    }

    private void UserProfile_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(GlobalUser.Username)) ShowOnline(GlobalUser.Username);
    }
}
