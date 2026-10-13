using System.ComponentModel;

namespace LibraryManagementWindowsForm;

public partial class UserProfile : UserControl
{
    private string _username = "";
    public UserProfile() { InitializeComponent(); }

    [Browsable(true), DefaultValue("")]
    public string UserName
    {
        get => _username;
        set { _username = value ?? ""; if (!UiDesigner.IsDesignMode(this)) ShowOnline(_username); }
    }

    public void ShowOnline(string username)
    {
        _username = username ?? "";
        lblTitle.Text = string.IsNullOrWhiteSpace(_username) ? "" : $"{_username}  •  آنلاین";
        statusDot.Visible = !string.IsNullOrWhiteSpace(_username);
    }

    private void UserProfile_Load(object sender, EventArgs e)
    { if (!UiDesigner.IsDesignMode(this)) ShowOnline(GlobalUser.Username); }
}
