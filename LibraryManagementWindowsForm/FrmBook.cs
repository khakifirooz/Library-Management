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
    private readonly IBookService _bookService;
    private readonly ErrorProvider _errors = new() { BlinkStyle = ErrorBlinkStyle.NeverBlink };
    private readonly Label _status = new() { AutoSize = true, ForeColor = Color.FromArgb(94, 110, 132) };
    private readonly Label _mode = new() { AutoSize = true, Text = "کتاب جدید" };
    private readonly Panel _editorHost = new() { Dock = DockStyle.Fill, AutoScroll = true };
    private readonly TableLayoutPanel _editor = new() { AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, Dock = DockStyle.Top, ColumnCount = 1 };
    private readonly FlowLayoutPanel _actions = new() { AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, WrapContents = true, FlowDirection = FlowDirection.RightToLeft, Dock = DockStyle.Top };
    private List<BookDTO> _books = new();
    private int _selectedId;
    private bool _ready, _binding, _populating, _showValidation;
    private string _originalTitle = "", _originalAuthor = "", _originalLanguage = "";
    private Image? _originalImage;

    public FrmBook(IBookService bookService)
    {
        _bookService = bookService;
        InitializeComponent();
        components ??= new Container(); components.Add(_errors); _errors.ContainerControl = this;
        BuildBookLayout();
        UiGrids.Books(dataGrid_books);
        dataGrid_books.Font = Font;
        dataGrid_books.ColumnHeadersHeight = Math.Max(40, (int)Math.Ceiling(Font.GetHeight()) + 20);
        dataGrid_books.RowTemplate.Height = Math.Max(38, (int)Math.Ceiling(Font.GetHeight()) + 16);
        dataGrid_books.SelectionChanged += (_, _) => SelectBook();
        foreach (var field in new[] { txt_name, txt_author, txt_language })
            field.TextChanged += (_, _) => { if (_ready && !_populating && _showValidation) ValidateFields(); };
        _editorHost.ClientSizeChanged += (_, _) => FitEditor();
        FormClosing += (_, e) => { if (_ready && !ConfirmDiscard()) e.Cancel = true; };
        Shown += (_, _) => FitWindow();
        _ready = true; ResetEditor();
    }

    private void BuildBookLayout()
    {
        SuspendLayout();
        Font = new Font("Tahoma", 10F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScaleDimensions = CurrentAutoScaleDimensions;
        BackColor = Color.FromArgb(242, 245, 249); ForeColor = Color.FromArgb(25, 42, 66);
        BackgroundImage = null; RightToLeft = RightToLeft.Yes; RightToLeftLayout = false;
        Text = "مدیریت کتاب‌ها"; StartPosition = FormStartPosition.CenterParent;
        _mode.TextAlign = ContentAlignment.MiddleRight; _mode.RightToLeft = RightToLeft.Yes;
        _mode.Margin = new Padding(4, 8, 22, 12); _mode.ForeColor = Color.FromArgb(94, 110, 132);
        _status.TextAlign = ContentAlignment.MiddleRight;

        foreach (var field in new[] { txt_name, txt_author, txt_language, txt_search })
        {
            field.Font = Font; field.Multiline = false; field.BackColor = Color.White;
            field.BorderStyle = BorderStyle.FixedSingle; field.RightToLeft = RightToLeft.Yes;
            field.TextAlign = HorizontalAlignment.Right; field.MaxLength = 50;
            field.Margin = new Padding(4, 4, 22, 12); field.Dock = DockStyle.Top;
        }
        txt_search.PlaceholderText = "جست‌وجوی عنوان یا نویسنده…";
        foreach (var button in new[] { btn_save, btn_edite, btn_delete }) StyleButton(button);
        btn_save.Text = "ثبت کتاب"; btn_edite.Text = "ذخیرهٔ تغییرات"; btn_delete.Text = "حذف کتاب";
        btn_delete.BackColor = Color.FromArgb(169, 49, 60);
        var fresh = NewButton("کتاب جدید", (_, _) => { if (ConfirmDiscard()) { ResetEditor(); txt_name.Focus(); } }, false);
        var refresh = NewButton("تازه‌سازی", async (_, _) =>
        {
            if (!ConfirmDiscard()) return;
            ResetEditor(); await UiActions.RunAsync(this, LoadBooksAsync, "بارگذاری کتاب‌ها");
        }, false);
        var photo = NewButton("انتخاب تصویر", picture_book_Click, false);
        _actions.Controls.AddRange(new Control[] { btn_save, btn_edite, btn_delete, fresh });
        _actions.RightToLeft = RightToLeft.No;
        _editor.RightToLeft = RightToLeft.No; _editor.Padding = new Padding(12); _editor.BackColor = Color.White;
        _editor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        AddEditor(_mode); AddEditor(Caption("عنوان کتاب *")); AddEditor(txt_name);
        AddEditor(Caption("نویسنده *")); AddEditor(txt_author); AddEditor(Caption("زبان *")); AddEditor(txt_language);
        AddEditor(Caption("تصویر کتاب؛ اختیاری"));
        picture_book.Dock = DockStyle.Top; picture_book.Height = 140; picture_book.Margin = new Padding(4, 4, 22, 8);
        picture_book.SizeMode = PictureBoxSizeMode.Zoom; picture_book.BackColor = BackColor;
        picture_book.BorderStyle = BorderStyle.FixedSingle; picture_book.Cursor = Cursors.Hand;
        AddEditor(picture_book); AddEditor(photo); AddEditor(_actions);
        _editorHost.BackColor = Color.White; _editorHost.RightToLeft = RightToLeft.No; _editorHost.Controls.Add(_editor);

        var search = new TableLayoutPanel { Dock = DockStyle.Top, AutoSize = true, ColumnCount = 2, RowCount = 2,
            RightToLeft = RightToLeft.No, Padding = new Padding(8) };
        search.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); search.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        search.RowStyles.Add(new RowStyle(SizeType.AutoSize)); search.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        search.Controls.Add(Caption("جست‌وجوی کتاب"), 0, 0); search.SetColumnSpan(search.Controls[0], 2);
        txt_search.Dock = DockStyle.Fill; search.Controls.Add(txt_search, 0, 1); search.Controls.Add(refresh, 1, 1);
        var list = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 3,
            BackColor = Color.White, Padding = new Padding(8), RightToLeft = RightToLeft.No };
        list.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        list.RowStyles.Add(new RowStyle(SizeType.AutoSize)); list.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        list.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        list.Controls.Add(search, 0, 0); dataGrid_books.Dock = DockStyle.Fill; list.Controls.Add(dataGrid_books, 0, 1);
        _status.Dock = DockStyle.Top; _status.Padding = new Padding(6, 12, 6, 6); _status.RightToLeft = RightToLeft.Yes;
        list.Controls.Add(_status, 0, 2);
        var panes = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 1,
            Padding = new Padding(12), RightToLeft = RightToLeft.No };
        panes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); panes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 330));
        panes.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        list.Margin = new Padding(0, 0, 12, 0); panes.Controls.Add(list, 0, 0); panes.Controls.Add(_editorHost, 1, 0);
        var heading = new TableLayoutPanel { Dock = DockStyle.Top, AutoSize = true, ColumnCount = 2,
            Padding = new Padding(20, 16, 20, 12), BackColor = Color.White, RightToLeft = RightToLeft.No };
        heading.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230)); heading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        userProfile1.Dock = DockStyle.Fill; heading.Controls.Add(userProfile1, 0, 0);
        var title = Caption("مدیریت کتاب‌ها"); title.Font = new Font(Font.FontFamily, 15F, FontStyle.Bold);
        heading.Controls.Add(title, 1, 0);
        var root = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 2, RightToLeft = RightToLeft.No };
        root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        root.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); root.Controls.Add(heading, 0, 0); root.Controls.Add(panes, 0, 1);
        var old = Controls.Cast<Control>().ToArray(); Controls.Clear(); Controls.Add(root);
        foreach (var control in old) control.Dispose();
        ResumeLayout(true);
    }

    private Label Caption(string text) => new() { Text = text, AutoSize = true, Dock = DockStyle.Top,
        Font = Font, TextAlign = ContentAlignment.MiddleRight, RightToLeft = RightToLeft.Yes,
        Margin = new Padding(4, 6, 22, 6) };
    private void AddEditor(Control control)
    {
        var row = _editor.RowCount++; _editor.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        control.Dock = DockStyle.Top; _editor.Controls.Add(control, 0, row);
    }
    private void StyleButton(Button button, bool primary = true)
    {
        button.Font = Font; button.AutoSize = true; button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        button.MinimumSize = new Size(116, 38); button.Padding = new Padding(12, 6, 12, 6); button.Margin = new Padding(4);
        button.FlatStyle = FlatStyle.Flat; button.FlatAppearance.BorderSize = primary ? 0 : 1;
        button.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239); button.UseVisualStyleBackColor = false;
        button.BackColor = primary ? Color.FromArgb(12, 120, 113) : Color.White;
        button.ForeColor = primary ? Color.White : ForeColor; button.Cursor = Cursors.Hand;
    }
    private Button NewButton(string title, EventHandler click, bool primary = true)
    { var button = new Button { Text = title }; StyleButton(button, primary); button.Click += click; return button; }
    private void FitWindow()
    {
        var area = Screen.FromControl(this).WorkingArea;
        MinimumSize = new Size(Math.Min(840, area.Width - 32), Math.Min(540, area.Height - 32));
        Size = new Size(Math.Min(1120, area.Width - 48), Math.Min(790, area.Height - 48));
        FitEditor();
    }
    private void FitEditor()
    {
        var width = Math.Max(160, _editorHost.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 4);
        if (_editor.Width == width && _editor.MaximumSize.Width == width) return;
        _editor.MinimumSize = new Size(width, 0); _editor.MaximumSize = new Size(width, 0); _editor.Width = width;
        _actions.MaximumSize = new Size(Math.Max(100, width - 24), 0); _editor.PerformLayout();
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
                Language = txt_language.Text.Trim(), Image = ImageHelper.ToBytes(picture_book.Image) };
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
    { userProfile1.ShowOnline(GlobalUser.Username); await LoadBooksAsync(); }, "بارگذاری کتاب‌ها");
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
}
