using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementWindowsForm
{
    public partial class FrmManageMembers : Form
    {
        public FrmManageMembers()
        {
            InitializeComponent();
        }

        private void FrmManageMembers_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmRegisterMember = Program.ServiceProvider.GetRequiredService<FrmRegisterMember>();
            frmRegisterMember.ShowDialog();
        }
    }
}
