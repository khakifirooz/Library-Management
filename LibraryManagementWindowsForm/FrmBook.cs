using System.Threading.Tasks;
using Contracts.Book;
using LibraryManagementContracts.Book;

namespace LibraryManagementWindowsForm
{
    public partial class FrmBook : Form
    {
        private readonly IBookService _bookService;

        public FrmBook(IBookService bookService)
        {
            InitializeComponent();
            _bookService = bookService;
        }

        private void picture_book_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            picture_book.Load(openFileDialog.FileName);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            picture_book.Image.Save(stream, picture_book.Image.RawFormat);
            var image = stream.GetBuffer();
            BookDTO book = new BookDTO();
            book.Title = txt_name.Text;
            book.Author = txt_author.Text;
            book.Language = txt_language.Text;
            book.Image = image;
            var result = await _bookService.CreateAsync(book);
            if (result.Success)
            {
                txt_name.Text = "";
                txt_author.Text = "";
                txt_language.Text = "";
                picture_book.Image = null;
                MessageBox.Show(result.Message);
            }
            else
                MessageBox.Show(result.Message);

            FrmBook_Load(null, null);
        }

        private async void FrmBook_Load(object sender, EventArgs e)
        {
            dataGrid_books.DataSource = await _bookService.GetAllAsync();
            SetColumns();
        }

        public void SetColumns()
        {
            dataGrid_books.Columns[0].HeaderText = "شناسه";
            dataGrid_books.Columns[1].HeaderText = "عنوان کتاب";
            dataGrid_books.Columns[2].HeaderText = "نویسنده کتاب";
            dataGrid_books.Columns[3].HeaderText = "زبان کتاب";
            dataGrid_books.Columns[4].Visible = false;
        }

        private void dataGrid_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id.Text = dataGrid_books.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGrid_books.CurrentRow.Cells[1].Value.ToString();
            txt_author.Text = dataGrid_books.CurrentRow.Cells[2].Value.ToString();
            txt_language.Text = dataGrid_books.CurrentRow.Cells[3].Value.ToString();
            MemoryStream memoryStream = new MemoryStream((byte[])dataGrid_books.CurrentRow.Cells[4].Value);
            picture_book.Image = Image.FromStream(memoryStream);
        }

        private async void btn_edite_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            picture_book.Image.Save(stream, picture_book.Image.RawFormat);
            var image = stream.GetBuffer();
            BookDTO book = new BookDTO();
            book.Id = Convert.ToInt32(lbl_id.Text);
            book.Title = txt_name.Text;
            book.Author = txt_author.Text;
            book.Language = txt_language.Text;
            book.Image = image;
            var result = await _bookService.UpdateAsync(book);
            if (result.Success)
            {
                txt_name.Text = "";
                txt_author.Text = "";
                txt_language.Text = "";
                picture_book.Image = null;
                MessageBox.Show(result.Message);
            }
            else
                MessageBox.Show(result.Message);

            FrmBook_Load(null, null);
        }

        private async void txt_search_TextChanged(object sender, EventArgs e)
        {
            var result = await _bookService.GetByTitleAsync(txt_search.Text);
            dataGrid_books.DataSource = result;
            SetColumns();
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            var result = await _bookService.DeleteAsync(Convert.ToInt32(lbl_id.Text));
            if (result.Success)
            {
                txt_name.Text = "";
                txt_author.Text = "";
                txt_language.Text = "";
                picture_book.Image = null;
                MessageBox.Show(result.Message);
            }
            else
                MessageBox.Show(result.Message);

            FrmBook_Load(null, null);
        }
    }
}
