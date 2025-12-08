using Contracts.Book;
using LibraryManagementContracts.Loan;
using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm
{
    public partial class FrmLoan : Form
    {
        private readonly IMemberService _memberService;
        private readonly IBookService _bookService;
        private readonly ILoanService _loanService;

        //  private readonly LoanRepository repository;

        public FrmLoan(IMemberService memberService, IBookService bookService, ILoanService loanService)
        {
            _memberService = memberService;
            _bookService = bookService;
            _loanService = loanService;
            //  this.repository = repository;
            InitializeComponent();
        }

        private async void btn_reneview_Click(object sender, EventArgs e)
        {
            var memberId = txt_search_id.Text == "" ? 0 : Convert.ToInt32(txt_search_id.Text);
            if (memberId == 0)
            {
                MessageBox.Show("وارد کردن شماره عضویت اجباری است");
                return;
            }
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
            btn_save.Enabled = true;
            btn_return_save.Enabled = true;
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

            comboBox_Book_return.DataSource = await _bookService.GetAllAsync();
            comboBox_Book_return.DisplayMember = "Title";
            comboBox_Book_return.ValueMember = "Id";

            dataGridView_loans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_loans.MultiSelect = false;
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            var loan = new LoanCreateModel()
            {
                MemberId = txt_search_id.Text == "" ? 0 : Convert.ToInt32(txt_search_id.Text),
                BookId = Convert.ToInt32(comboBox_books.SelectedValue),
                ReturnDate = dateTimePicker_return.Value,
            };

            var result = await _memberService.AddLoanAsync(loan);
            MessageBox.Show(result.Message);

            comboBox_books.DataSource = null;
            comboBox_books.DataSource = await _bookService.GetExistForComboAsync();
            comboBox_books.DisplayMember = "Title";
            comboBox_books.ValueMember = "Id";
            btn_reneview_Click(null, null);
        }

        private void comboBox_books_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int loanId = Convert.ToInt32(dataGridView_loans.CurrentRow.Cells[0].Value);

            var result = await _loanService.ReturnLoanAsync(loanId);

            MessageBox.Show(result.Message);

            if (result.Success)
            {
                dataGridView_loans.DataSource = await _memberService.GetMemberWithLoanByIdAsync(loanId);
            }
            else
            {
                MessageBox.Show(result.Message);
            }

           // dataGridView_loans.DataBindings.Clear();
        }

        private void dataGridView_loans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_Book_return.Text = dataGridView_loans.CurrentRow.Cells[4].Value.ToString();
        }

        private void comboBox_Book_return_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
