using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contracts.Book;
using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm
{
    public partial class FrmLoan : Form
    {
        private readonly IMemberService _memberService;
        private readonly IBookService _bookService;

        public FrmLoan(IMemberService memberService, IBookService bookService)
        {
            _memberService = memberService;
            _bookService = bookService;
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
            dataGridView_loans.DataBindings.Clear();
            dataGridView_loans.DataSource = result.Loans;
            dataGridView_loans.Columns[0].HeaderText = "شناسه";
            dataGridView_loans.Columns[1].Visible = false;
            dataGridView_loans.Columns[2].Visible = false;
            dataGridView_loans.Columns[3].Visible = false;
            dataGridView_loans.Columns[4].HeaderText = "نام کتاب";
            dataGridView_loans.Columns[5].HeaderText = "تاریخ امانت";
            dataGridView_loans.Columns[6].HeaderText = "تاریخ تحویل";
            dataGridView_loans.Columns[7].HeaderText = "وضعیت";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView_loans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void FrmLoan_Load(object sender, EventArgs e)
        {
            comboBox_books.DataSource = await _bookService.GetExistForComboAsync();
            comboBox_books.DisplayMember = "Title";
            comboBox_books.ValueMember = "Id";
        }
    }
}
