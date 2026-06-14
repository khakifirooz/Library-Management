using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementWindowsForm
{
    public partial class UserProfile : UserControl
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        //private void UserProfile_Load(object sender, EventArgs e)
        //{
        //    lblTitle.Text = "ادمین آنلاین";  //  اینجا باید بعدا یوزر نیم مقابل که وارد میشه ادیتش کنیم 
        //    lblTitle.ForeColor = Color.Green;
        //    lblTitle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        //}

        public void showonline(string username)
        {
            lblTitle.Text = $" کاربر {username} انلاینه";  // یوزر نیم  
            lblTitle.ForeColor = Color.Green;
            lblTitle.Font = new Font("tahoma", 10, FontStyle.Bold);
        }

        public void ShowOnline(string username)
        {
            lblTitle.Text = $" کاربر {username} آنلاین";
            lblTitle.ForeColor = Color.Green;
            lblTitle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
