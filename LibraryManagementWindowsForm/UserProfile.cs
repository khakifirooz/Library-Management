using System.ComponentModel;

namespace LibraryManagementWindowsForm
{
    public partial class UserProfile : UserControl
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        // اضافه کردن این پراپرتی برای حل خطای عدم شناسایی UserName
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string UserName
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }
        public void ShowOnline(string username)
        {
            //  زمانی که هنوز یوزری وارد نشده (جلوگیری از نمایش نام خالی)
            if (string.IsNullOrEmpty(username)) return;

            lblTitle.Text = $"{username} is online";
            lblTitle.ForeColor = Color.Green;
            lblTitle.Font = new Font("Tahoma", 8, FontStyle.Bold);
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(GlobalUser.Username))
            {
                ShowOnline(GlobalUser.Username);
            }
        }
    }
}
