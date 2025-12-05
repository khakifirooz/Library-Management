using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm
{
    public partial class FrmLoan : Form
    {
        private readonly IMemberService _memberService;

        public FrmLoan(IMemberService memberService)
        {
            _memberService = memberService;
            InitializeComponent();
        }

        private async void btn_reneview_Click(object sender, EventArgs e)
        {
            var memberId = txt_search_id.Text == "" ? 0 : Convert.ToInt32(txt_search_id.Text);
            var result = await _memberService.GetMemberWithLoanByIdAsync(memberId);
            txt_family.Text = result.Name + " " + result.Family;
            checkBox_isSpecial.Checked = result.IsSpecial;
            checkBox_status.Checked = result.Status;
            MemoryStream stream = new MemoryStream(result.Image);
            pictureBox_member.Image = Image.FromStream(stream);
        }
    }
}
