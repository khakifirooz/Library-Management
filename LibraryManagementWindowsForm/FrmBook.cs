using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contracts.Book;
using LibraryManagementContracts.Book;

namespace LibraryManagementWindowsForm;

public partial class FrmBook : Form
{
    private readonly IBookService _bookService = null!;
    private List<BookDTO> _books = new();
    private int _selectedId;
    private bool _ready, _binding, _populating, _showValidation;
    private string _originalTitle = "", _originalAuthor = "", _originalLanguage = "";
    private Image? _originalImage;

    public FrmBook()
    {
        InitializeComponent();
    }

    public FrmBook(IBookService bookService) : this()
    {
        _bookService = bookService;
        UiGrids.AttachFormatting(dataGrid_books, "books");
        dataGrid_books.SelectionChanged += (_, _) => SelectBook();
        foreach (var field in new[] { txt_name, txt_author, txt_language })
            field.TextChanged += (_, _) => { if (_ready && !_populating && _showValidation) ValidateFields(); };
        FormClosing += (_, e) => { if (_ready && !ConfirmDiscard()) e.Cancel = true; };
        _ready = true;
        ResetEditor();
    }










    private bool HasChanges() => txt_name.Text != _originalTitle || txt_author.Text != _originalAuthor
        || txt_language.Text != _originalLanguage || !ReferenceEquals(picture_book.Image, _originalImage);
    private bool ConfirmDiscard() => !HasChanges() || MessageBox.Show(this,
        "اطلاعات ویرایش‌شده ذخیره نشده است. تغییرها کنار گذاشته شوند؟", "تغییرهای ذخیره‌نشده",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
    private void RememberOriginal()
    { _originalTitle = txt_name.Text; _originalAuthor = txt_author.Text; _originalLanguage = txt_language.Text; _originalImage = picture_book.Image; }
    private void ResetEditor()
    {
        _binding = true; _populating = true;
        try
        {
            _selectedId = 0; dataGrid_books.ClearSelection(); dataGrid_books.CurrentCell = null;
            txt_name.Clear(); txt_author.Clear(); txt_language.Clear(); ImageHelper.SetImage(picture_book, null);
            _errors.Clear(); _showValidation = false; _mode.Text = "کتاب جدید"; RememberOriginal(); UpdateMode();
        }
        finally { _binding = false; _populating = false; }
    }
    private void UpdateMode()
    {
        btn_save.Visible = _selectedId == 0; btn_save.Enabled = _selectedId == 0;
        btn_edite.Visible = _selectedId > 0; btn_edite.Enabled = _selectedId > 0; btn_delete.Enabled = _selectedId > 0;
        AcceptButton = _selectedId == 0 ? btn_save : btn_edite;
    }
    private void RestoreSelection()
    {
        _binding = true;
        try
        {
            dataGrid_books.ClearSelection();
            foreach (DataGridViewRow row in dataGrid_books.Rows)
                if (row.DataBoundItem is BookDTO book && book.Id == _selectedId)
                { row.Selected = true; dataGrid_books.CurrentCell = row.Cells["Title"]; break; }
        }
        finally { _binding = false; }
    }
    private void SelectBook()
    {
        if (!_ready || _binding || dataGrid_books.SelectedRows.Count == 0) return;
        if (dataGrid_books.SelectedRows[0].DataBoundItem is not BookDTO book || book.Id == _selectedId) return;
        if (!ConfirmDiscard()) { RestoreSelection(); return; }
        _populating = true;
        try
        {
            _selectedId = book.Id; txt_name.Text = book.Title; txt_author.Text = book.Author; txt_language.Text = book.Language;
            ImageHelper.SetImage(picture_book, book.Image); _errors.Clear(); _showValidation = false;
            _mode.Text = $"ویرایش کتاب • شناسهٔ {UiText.Digits(book.Id)}"; RememberOriginal(); UpdateMode();
        }
        finally { _populating = false; }
    }
    private async Task LoadBooksAsync()
    {
        _status.Text = "در حال بارگذاری کتاب‌ها…";
        try { var books = await _bookService.GetAllAsync(); _books = books; ApplySearch(); }
        catch { _status.Text = "بارگذاری ناموفق بود؛ دوباره تازه‌سازی کنید."; throw; }
    }
    private void ApplySearch()
    {
        if (!_ready) return;
        var key = UiText.SearchKey(txt_search.Text);
        var rows = _books.Where(x => UiText.SearchKey(x.Title).Contains(key, StringComparison.OrdinalIgnoreCase)
            || UiText.SearchKey(x.Author).Contains(key, StringComparison.OrdinalIgnoreCase)).ToList();
        _binding = true;
        try { dataGrid_books.DataSource = rows; dataGrid_books.ClearSelection(); dataGrid_books.CurrentCell = null; }
        finally { _binding = false; }
        RestoreSelection();
        _status.Text = rows.Count == 0 ? "کتابی در این فهرست نیست."
            : $"{UiText.Digits(rows.Count)} کتاب از {UiText.Digits(_books.Count)} کتاب";
    }
    private string FieldError(TextBox field, string caption)
    {
        var value = field.Text.Trim();
        if (!value.Any(c => !char.IsWhiteSpace(c)
            && char.GetUnicodeCategory(c) is not UnicodeCategory.Format and not UnicodeCategory.Control))
            return $"{caption} را وارد کنید.";
        return value.Length > 50 ? $"{caption} نباید بیشتر از ۵۰ کاراکتر باشد." : "";
    }
    private bool ValidateFields()
    {
        _errors.SetError(txt_name, FieldError(txt_name, "عنوان کتاب"));
        _errors.SetError(txt_author, FieldError(txt_author, "نویسنده"));
        _errors.SetError(txt_language, FieldError(txt_language, "زبان"));
        return new[] { txt_name, txt_author, txt_language }.All(x => _errors.GetError(x).Length == 0);
    }
    private bool TryRead(out BookDTO command)
    {
        command = null!; _showValidation = true;
        if (!ValidateFields())
        {
            var first = new[] { txt_name, txt_author, txt_language }.First(x => _errors.GetError(x).Length > 0);
            MessageBox.Show(this, _errors.GetError(first), "اطلاعات کتاب", MessageBoxButtons.OK, MessageBoxIcon.Information);
            first.Focus(); return false;
        }
        try
        {
            command = new BookDTO { Id = _selectedId, Title = txt_name.Text.Trim(), Author = txt_author.Text.Trim(),
                Language = txt_language.Text.Trim(), Image = ImageHelper.ToBytes(picture_book) };
            return true;
        }
        catch (Exception error)
        {
            System.Diagnostics.Debug.WriteLine(error);
            MessageBox.Show(this, "تصویر کتاب قابل ذخیره نیست؛ آن را دوباره انتخاب کنید.", "تصویر کتاب");
            return false;
        }
    }
    private async void FrmBook_Load(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    { if (_bookService is null || UiDesigner.IsDesignMode(this)) return; userProfile1.ShowOnline(GlobalUser.Username); await LoadBooksAsync(); }, "بارگذاری کتاب‌ها");
    private async void button1_Click(object sender, EventArgs e)
    {
        if (_selectedId != 0 || !TryRead(out var command)) return;
        await UiActions.RunAsync(this, async () =>
        {
            var result = await _bookService.CreateAsync(command); MessageBox.Show(result.Message);
            if (result.Success) { ResetEditor(); txt_search.Clear(); await LoadBooksAsync(); }
        }, "ثبت کتاب");
    }
    private async void btn_edite_Click(object sender, EventArgs e)
    {
        if (_selectedId <= 0 || !TryRead(out var command)) return;
        await UiActions.RunAsync(this, async () =>
        {
            var result = await _bookService.UpdateAsync(command); MessageBox.Show(result.Message);
            if (result.Success) { ResetEditor(); await LoadBooksAsync(); }
        }, "ویرایش کتاب");
    }
    private async void btn_delete_Click(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    {
        if (_selectedId <= 0) return;
        if (MessageBox.Show(this, "کتاب انتخاب‌شده از فهرست حذف شود؟", "حذف کتاب",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        var result = await _bookService.DeleteAsync(_selectedId); MessageBox.Show(result.Message);
        if (result.Success) { ResetEditor(); await LoadBooksAsync(); }
    }, "حذف کتاب");
    private void picture_book_Click(object? sender, EventArgs e)
    { try { ImageHelper.Select(picture_book); } catch (Exception) { MessageBox.Show("فایل تصویر معتبر نیست."); } }
    private void txt_search_TextChanged(object sender, EventArgs e) => ApplySearch();
    private void dataGrid_books_CellClick(object sender, DataGridViewCellEventArgs e)
    { if (e.RowIndex >= 0) SelectBook(); }
    public void SetColumns() { }
    private void groupBox2_Enter(object sender, EventArgs e) { }
    private void dataGrid_books_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    private void NewBook_Click(object sender, EventArgs e)
    { if (ConfirmDiscard()) { ResetEditor(); txt_name.Focus(); } }
    private async void RefreshBooks_Click(object sender, EventArgs e)
    {
        if (!ConfirmDiscard()) return;
        ResetEditor();
        await UiActions.RunAsync(this, LoadBooksAsync, "بارگذاری کتاب‌ها");
    }
    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        UiDesigner.FitToScreen(this);
    }
}
