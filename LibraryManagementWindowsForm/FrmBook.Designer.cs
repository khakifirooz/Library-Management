#nullable disable
namespace LibraryManagementWindowsForm
{
    partial class FrmBook
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGrid_booksColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGrid_booksDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGrid_booksAlternatingRowsDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            rootLayout = new System.Windows.Forms.TableLayoutPanel();
            headerLayout = new System.Windows.Forms.TableLayoutPanel();
            headingLayout = new System.Windows.Forms.TableLayoutPanel();
            headingLabel = new System.Windows.Forms.Label();
            subtitleLabel = new System.Windows.Forms.Label();
            userProfile1 = new LibraryManagementWindowsForm.UserProfile();
            footerLabel = new System.Windows.Forms.Label();
            viewportPanel = new System.Windows.Forms.Panel();
            _errors = new System.Windows.Forms.ErrorProvider(components);
            txt_search = new System.Windows.Forms.TextBox();
            btn_refresh = new System.Windows.Forms.Button();
            searchLayout = new System.Windows.Forms.TableLayoutPanel();
            searchField = new System.Windows.Forms.TableLayoutPanel();
            searchFieldLabel = new System.Windows.Forms.Label();
            dataGrid_books = new System.Windows.Forms.DataGridView();
            dataGrid_books_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGrid_books_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGrid_books_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGrid_books_Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            _status = new System.Windows.Forms.Label();
            listLayout = new System.Windows.Forms.TableLayoutPanel();
            booksCard = new System.Windows.Forms.TableLayoutPanel();
            booksCardTitle = new System.Windows.Forms.Label();
            _mode = new System.Windows.Forms.Label();
            txt_name = new System.Windows.Forms.TextBox();
            txt_nameField = new System.Windows.Forms.TableLayoutPanel();
            txt_nameFieldLabel = new System.Windows.Forms.Label();
            txt_author = new System.Windows.Forms.TextBox();
            txt_authorField = new System.Windows.Forms.TableLayoutPanel();
            txt_authorFieldLabel = new System.Windows.Forms.Label();
            txt_language = new System.Windows.Forms.TextBox();
            txt_languageField = new System.Windows.Forms.TableLayoutPanel();
            txt_languageFieldLabel = new System.Windows.Forms.Label();
            photoCaption = new System.Windows.Forms.Label();
            picture_book = new System.Windows.Forms.PictureBox();
            btn_choose_photo = new System.Windows.Forms.Button();
            photoActions = new System.Windows.Forms.FlowLayoutPanel();
            btn_save = new System.Windows.Forms.Button();
            btn_edite = new System.Windows.Forms.Button();
            btn_delete = new System.Windows.Forms.Button();
            btn_new = new System.Windows.Forms.Button();
            _actions = new System.Windows.Forms.FlowLayoutPanel();
            _editor = new System.Windows.Forms.TableLayoutPanel();
            _editorHost = new System.Windows.Forms.Panel();
            editorCard = new System.Windows.Forms.TableLayoutPanel();
            editorCardTitle = new System.Windows.Forms.Label();
            bodyLayout = new System.Windows.Forms.TableLayoutPanel();
            rootLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            headingLayout.SuspendLayout();
            viewportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_errors).BeginInit();
            searchLayout.SuspendLayout();
            searchField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_books).BeginInit();
            listLayout.SuspendLayout();
            booksCard.SuspendLayout();
            txt_nameField.SuspendLayout();
            txt_authorField.SuspendLayout();
            txt_languageField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_book).BeginInit();
            photoActions.SuspendLayout();
            _actions.SuspendLayout();
            _editor.SuspendLayout();
            _editorHost.SuspendLayout();
            editorCard.SuspendLayout();
            bodyLayout.SuspendLayout();
            SuspendLayout();
            dataGrid_booksColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            dataGrid_booksColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            dataGrid_booksColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGrid_booksColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGrid_booksColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(6);
            dataGrid_booksColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGrid_booksDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGrid_booksDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            dataGrid_booksDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 242, 238);
            dataGrid_booksDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            dataGrid_booksDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGrid_booksDefaultCellStyle.Padding = new System.Windows.Forms.Padding(6);
            dataGrid_booksDefaultCellStyle.NullValue = "—";
            dataGrid_booksDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGrid_booksAlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(249, 251, 253);
            //
            // rootLayout
            //
            rootLayout.Name = "rootLayout";
            rootLayout.Margin = new System.Windows.Forms.Padding(0);
            rootLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            rootLayout.ColumnCount = 1;
            rootLayout.RowCount = 3;
            rootLayout.Padding = new System.Windows.Forms.Padding(16);
            rootLayout.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            rootLayout.MinimumSize = new System.Drawing.Size(0, 620);
            rootLayout.TabIndex = 0;
            rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize, 0F));
            rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            //
            // headerLayout
            //
            headerLayout.Name = "headerLayout";
            headerLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            headerLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            headerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            headerLayout.ColumnCount = 2;
            headerLayout.RowCount = 1;
            headerLayout.Padding = new System.Windows.Forms.Padding(12);
            headerLayout.BackColor = System.Drawing.Color.White;
            headerLayout.AutoSize = true;
            headerLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            headerLayout.TabIndex = 1;
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            //
            // headingLayout
            //
            headingLayout.Name = "headingLayout";
            headingLayout.Margin = new System.Windows.Forms.Padding(0);
            headingLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            headingLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            headingLayout.ColumnCount = 1;
            headingLayout.RowCount = 2;
            headingLayout.Padding = new System.Windows.Forms.Padding(0);
            headingLayout.BackColor = System.Drawing.Color.White;
            headingLayout.TabIndex = 2;
            headingLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            headingLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            headingLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            //
            // headingLabel
            //
            headingLabel.Name = "headingLabel";
            headingLabel.Margin = new System.Windows.Forms.Padding(0);
            headingLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            headingLabel.Text = "مدیریت کتاب‌ها";
            headingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            headingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            headingLabel.AutoSize = false;
            headingLabel.AutoEllipsis = true;
            headingLabel.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            headingLabel.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            headingLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            headingLabel.TabIndex = 3;
            //
            // subtitleLabel
            //
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Margin = new System.Windows.Forms.Padding(0);
            subtitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            subtitleLabel.Text = "ثبت، جست‌وجو و ویرایش مشخصات و تصویر کتاب";
            subtitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            subtitleLabel.AutoSize = false;
            subtitleLabel.AutoEllipsis = true;
            subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            subtitleLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            subtitleLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            subtitleLabel.TabIndex = 4;
            //
            // userProfile1
            //
            userProfile1.Name = "userProfile1";
            userProfile1.Margin = new System.Windows.Forms.Padding(4);
            userProfile1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            userProfile1.Dock = System.Windows.Forms.DockStyle.Fill;
            userProfile1.MinimumSize = new System.Drawing.Size(160, 32);
            userProfile1.TabIndex = 5;
            //
            // footerLabel
            //
            footerLabel.Name = "footerLabel";
            footerLabel.Margin = new System.Windows.Forms.Padding(0);
            footerLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            footerLabel.Text = "مدیریت کتابخانه  •  ثبت و پیگیری اطلاعات";
            footerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            footerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            footerLabel.AutoSize = false;
            footerLabel.AutoEllipsis = true;
            footerLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            footerLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            footerLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            footerLabel.TabIndex = 6;
            //
            // viewportPanel
            //
            viewportPanel.Name = "viewportPanel";
            viewportPanel.Margin = new System.Windows.Forms.Padding(0);
            viewportPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            viewportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            viewportPanel.AutoScroll = true;
            viewportPanel.AutoScrollMinSize = new System.Drawing.Size(0, 620);
            viewportPanel.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            viewportPanel.TabIndex = 7;
            //
            // _errors
            //
            _errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            _errors.ContainerControl = this;
            //
            // txt_search
            //
            txt_search.Name = "txt_search";
            txt_search.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txt_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txt_search.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_search.MaxLength = 50;
            txt_search.PlaceholderText = "عنوان کتاب یا نام نویسنده…";
            txt_search.ReadOnly = false;
            txt_search.Multiline = false;
            txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_search.BackColor = System.Drawing.Color.White;
            txt_search.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txt_search.TabIndex = 0;
            txt_search.TabIndex = 8;
            //
            // btn_refresh
            //
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Margin = new System.Windows.Forms.Padding(4);
            btn_refresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btn_refresh.Text = "تازه‌سازی";
            btn_refresh.Size = new System.Drawing.Size(128, 40);
            btn_refresh.MinimumSize = new System.Drawing.Size(112, 38);
            btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_refresh.BackColor = System.Drawing.Color.White;
            btn_refresh.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_refresh.AutoSize = false;
            btn_refresh.FlatAppearance.BorderSize = 1;
            btn_refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btn_refresh.TabIndex = 9;
            //
            // searchLayout
            //
            searchLayout.Name = "searchLayout";
            searchLayout.Margin = new System.Windows.Forms.Padding(0);
            searchLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            searchLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            searchLayout.ColumnCount = 2;
            searchLayout.RowCount = 1;
            searchLayout.Padding = new System.Windows.Forms.Padding(0);
            searchLayout.BackColor = System.Drawing.Color.White;
            searchLayout.TabIndex = 10;
            searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            searchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            //
            // searchField
            //
            searchField.Name = "searchField";
            searchField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            searchField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            searchField.Dock = System.Windows.Forms.DockStyle.Top;
            searchField.ColumnCount = 1;
            searchField.RowCount = 2;
            searchField.Padding = new System.Windows.Forms.Padding(0);
            searchField.BackColor = System.Drawing.Color.White;
            searchField.Size = new System.Drawing.Size(280, 64);
            searchField.TabIndex = 11;
            searchField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            searchField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            searchField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // searchFieldLabel
            //
            searchFieldLabel.Name = "searchFieldLabel";
            searchFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            searchFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            searchFieldLabel.Text = "جست‌وجوی کتاب";
            searchFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            searchFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            searchFieldLabel.AutoSize = false;
            searchFieldLabel.AutoEllipsis = true;
            searchFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            searchFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            searchFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            searchFieldLabel.TabIndex = 12;
            //
            // dataGrid_books
            //
            dataGrid_books.Name = "dataGrid_books";
            dataGrid_books.Margin = new System.Windows.Forms.Padding(0);
            dataGrid_books.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGrid_books.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGrid_books.AutoGenerateColumns = false;
            dataGrid_books.ReadOnly = true;
            dataGrid_books.AllowUserToAddRows = false;
            dataGrid_books.AllowUserToDeleteRows = false;
            dataGrid_books.AllowUserToResizeRows = false;
            dataGrid_books.MultiSelect = false;
            dataGrid_books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGrid_books.RowHeadersVisible = false;
            dataGrid_books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_books.ColumnHeadersHeight = 42;
            dataGrid_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid_books.BackgroundColor = System.Drawing.Color.White;
            dataGrid_books.GridColor = System.Drawing.Color.FromArgb(222, 230, 239);
            dataGrid_books.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGrid_books.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid_books.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGrid_books.EnableHeadersVisualStyles = false;
            dataGrid_books.RowTemplate.Height = 36;
            dataGrid_books.Tag = "books";
            dataGrid_books.ColumnHeadersDefaultCellStyle = dataGrid_booksColumnHeadersDefaultCellStyle;
            dataGrid_books.DefaultCellStyle = dataGrid_booksDefaultCellStyle;
            dataGrid_books.AlternatingRowsDefaultCellStyle = dataGrid_booksAlternatingRowsDefaultCellStyle;
            dataGrid_books.TabIndex = 13;
            //
            // dataGrid_books_Id
            //
            dataGrid_books_Id.Name = "Id";
            dataGrid_books_Id.DataPropertyName = "Id";
            dataGrid_books_Id.HeaderText = "شناسه";
            dataGrid_books_Id.MinimumWidth = 65;
            dataGrid_books_Id.FillWeight = 65F;
            dataGrid_books_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // dataGrid_books_Title
            //
            dataGrid_books_Title.Name = "Title";
            dataGrid_books_Title.DataPropertyName = "Title";
            dataGrid_books_Title.HeaderText = "عنوان کتاب";
            dataGrid_books_Title.MinimumWidth = 100;
            dataGrid_books_Title.FillWeight = 220F;
            dataGrid_books_Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // dataGrid_books_Author
            //
            dataGrid_books_Author.Name = "Author";
            dataGrid_books_Author.DataPropertyName = "Author";
            dataGrid_books_Author.HeaderText = "نویسنده";
            dataGrid_books_Author.MinimumWidth = 100;
            dataGrid_books_Author.FillWeight = 170F;
            dataGrid_books_Author.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // dataGrid_books_Language
            //
            dataGrid_books_Language.Name = "Language";
            dataGrid_books_Language.DataPropertyName = "Language";
            dataGrid_books_Language.HeaderText = "زبان";
            dataGrid_books_Language.MinimumWidth = 90;
            dataGrid_books_Language.FillWeight = 90F;
            dataGrid_books_Language.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // _status
            //
            _status.Name = "_status";
            _status.Margin = new System.Windows.Forms.Padding(0);
            _status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            _status.Text = "برای شروع، کتاب تازه ثبت کنید یا یک ردیف را انتخاب کنید.";
            _status.Dock = System.Windows.Forms.DockStyle.Fill;
            _status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            _status.AutoSize = false;
            _status.AutoEllipsis = true;
            _status.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            _status.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _status.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _status.TabIndex = 14;
            //
            // listLayout
            //
            listLayout.Name = "listLayout";
            listLayout.Margin = new System.Windows.Forms.Padding(0);
            listLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            listLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            listLayout.ColumnCount = 1;
            listLayout.RowCount = 3;
            listLayout.Padding = new System.Windows.Forms.Padding(0);
            listLayout.BackColor = System.Drawing.Color.White;
            listLayout.TabIndex = 15;
            listLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            listLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            listLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            listLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            //
            // booksCard
            //
            booksCard.Name = "booksCard";
            booksCard.Margin = new System.Windows.Forms.Padding(6);
            booksCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            booksCard.Dock = System.Windows.Forms.DockStyle.Fill;
            booksCard.ColumnCount = 1;
            booksCard.RowCount = 2;
            booksCard.Padding = new System.Windows.Forms.Padding(12);
            booksCard.BackColor = System.Drawing.Color.White;
            booksCard.TabIndex = 16;
            booksCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            booksCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            booksCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // booksCardTitle
            //
            booksCardTitle.Name = "booksCardTitle";
            booksCardTitle.Margin = new System.Windows.Forms.Padding(0);
            booksCardTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            booksCardTitle.Text = "فهرست کتاب‌ها";
            booksCardTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            booksCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            booksCardTitle.AutoSize = false;
            booksCardTitle.AutoEllipsis = true;
            booksCardTitle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            booksCardTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            booksCardTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            booksCardTitle.TabIndex = 17;
            //
            // _mode
            //
            _mode.Name = "_mode";
            _mode.Margin = new System.Windows.Forms.Padding(0);
            _mode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            _mode.Text = "کتاب جدید";
            _mode.Dock = System.Windows.Forms.DockStyle.Fill;
            _mode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            _mode.AutoSize = false;
            _mode.AutoEllipsis = true;
            _mode.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            _mode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _mode.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _mode.TabIndex = 18;
            //
            // txt_name
            //
            txt_name.Name = "txt_name";
            txt_name.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txt_name.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_name.MaxLength = 50;
            txt_name.PlaceholderText = "";
            txt_name.ReadOnly = false;
            txt_name.Multiline = false;
            txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_name.BackColor = System.Drawing.Color.White;
            txt_name.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txt_name.TabIndex = 0;
            txt_name.TabIndex = 19;
            //
            // txt_nameField
            //
            txt_nameField.Name = "txt_nameField";
            txt_nameField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            txt_nameField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txt_nameField.Dock = System.Windows.Forms.DockStyle.Top;
            txt_nameField.ColumnCount = 1;
            txt_nameField.RowCount = 2;
            txt_nameField.Padding = new System.Windows.Forms.Padding(0);
            txt_nameField.BackColor = System.Drawing.Color.White;
            txt_nameField.Size = new System.Drawing.Size(280, 64);
            txt_nameField.TabIndex = 20;
            txt_nameField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            txt_nameField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            txt_nameField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // txt_nameFieldLabel
            //
            txt_nameFieldLabel.Name = "txt_nameFieldLabel";
            txt_nameFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            txt_nameFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txt_nameFieldLabel.Text = "عنوان کتاب *";
            txt_nameFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_nameFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            txt_nameFieldLabel.AutoSize = false;
            txt_nameFieldLabel.AutoEllipsis = true;
            txt_nameFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            txt_nameFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_nameFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txt_nameFieldLabel.TabIndex = 21;
            //
            // txt_author
            //
            txt_author.Name = "txt_author";
            txt_author.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txt_author.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txt_author.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_author.MaxLength = 50;
            txt_author.PlaceholderText = "";
            txt_author.ReadOnly = false;
            txt_author.Multiline = false;
            txt_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_author.BackColor = System.Drawing.Color.White;
            txt_author.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txt_author.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txt_author.TabIndex = 0;
            txt_author.TabIndex = 22;
            //
            // txt_authorField
            //
            txt_authorField.Name = "txt_authorField";
            txt_authorField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            txt_authorField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txt_authorField.Dock = System.Windows.Forms.DockStyle.Top;
            txt_authorField.ColumnCount = 1;
            txt_authorField.RowCount = 2;
            txt_authorField.Padding = new System.Windows.Forms.Padding(0);
            txt_authorField.BackColor = System.Drawing.Color.White;
            txt_authorField.Size = new System.Drawing.Size(280, 64);
            txt_authorField.TabIndex = 23;
            txt_authorField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            txt_authorField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            txt_authorField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // txt_authorFieldLabel
            //
            txt_authorFieldLabel.Name = "txt_authorFieldLabel";
            txt_authorFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            txt_authorFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txt_authorFieldLabel.Text = "نویسنده *";
            txt_authorFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_authorFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            txt_authorFieldLabel.AutoSize = false;
            txt_authorFieldLabel.AutoEllipsis = true;
            txt_authorFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            txt_authorFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_authorFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txt_authorFieldLabel.TabIndex = 24;
            //
            // txt_language
            //
            txt_language.Name = "txt_language";
            txt_language.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txt_language.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txt_language.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_language.MaxLength = 50;
            txt_language.PlaceholderText = "";
            txt_language.ReadOnly = false;
            txt_language.Multiline = false;
            txt_language.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_language.BackColor = System.Drawing.Color.White;
            txt_language.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txt_language.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txt_language.TabIndex = 0;
            txt_language.TabIndex = 25;
            //
            // txt_languageField
            //
            txt_languageField.Name = "txt_languageField";
            txt_languageField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            txt_languageField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txt_languageField.Dock = System.Windows.Forms.DockStyle.Top;
            txt_languageField.ColumnCount = 1;
            txt_languageField.RowCount = 2;
            txt_languageField.Padding = new System.Windows.Forms.Padding(0);
            txt_languageField.BackColor = System.Drawing.Color.White;
            txt_languageField.Size = new System.Drawing.Size(280, 64);
            txt_languageField.TabIndex = 26;
            txt_languageField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            txt_languageField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            txt_languageField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // txt_languageFieldLabel
            //
            txt_languageFieldLabel.Name = "txt_languageFieldLabel";
            txt_languageFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            txt_languageFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txt_languageFieldLabel.Text = "زبان *";
            txt_languageFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_languageFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            txt_languageFieldLabel.AutoSize = false;
            txt_languageFieldLabel.AutoEllipsis = true;
            txt_languageFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            txt_languageFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_languageFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txt_languageFieldLabel.TabIndex = 27;
            //
            // photoCaption
            //
            photoCaption.Name = "photoCaption";
            photoCaption.Margin = new System.Windows.Forms.Padding(0);
            photoCaption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            photoCaption.Text = "تصویر کتاب؛ اختیاری";
            photoCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            photoCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            photoCaption.AutoSize = false;
            photoCaption.AutoEllipsis = true;
            photoCaption.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            photoCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            photoCaption.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            photoCaption.TabIndex = 28;
            //
            // picture_book
            //
            picture_book.Name = "picture_book";
            picture_book.Margin = new System.Windows.Forms.Padding(4);
            picture_book.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            picture_book.Dock = System.Windows.Forms.DockStyle.Fill;
            picture_book.Size = new System.Drawing.Size(220, 140);
            picture_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picture_book.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            picture_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picture_book.Cursor = System.Windows.Forms.Cursors.Hand;
            picture_book.TabStop = false;
            picture_book.TabIndex = 29;
            //
            // btn_choose_photo
            //
            btn_choose_photo.Name = "btn_choose_photo";
            btn_choose_photo.Margin = new System.Windows.Forms.Padding(4);
            btn_choose_photo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btn_choose_photo.Text = "انتخاب تصویر";
            btn_choose_photo.Size = new System.Drawing.Size(128, 40);
            btn_choose_photo.MinimumSize = new System.Drawing.Size(112, 38);
            btn_choose_photo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_choose_photo.BackColor = System.Drawing.Color.White;
            btn_choose_photo.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            btn_choose_photo.UseVisualStyleBackColor = false;
            btn_choose_photo.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_choose_photo.AutoSize = false;
            btn_choose_photo.FlatAppearance.BorderSize = 1;
            btn_choose_photo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btn_choose_photo.TabIndex = 30;
            //
            // photoActions
            //
            photoActions.Name = "photoActions";
            photoActions.Margin = new System.Windows.Forms.Padding(0);
            photoActions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            photoActions.Dock = System.Windows.Forms.DockStyle.Top;
            photoActions.AutoSize = true;
            photoActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            photoActions.WrapContents = true;
            photoActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            photoActions.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            photoActions.MaximumSize = new System.Drawing.Size(288, 0);
            photoActions.TabIndex = 31;
            //
            // btn_save
            //
            btn_save.Name = "btn_save";
            btn_save.Margin = new System.Windows.Forms.Padding(4);
            btn_save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btn_save.Text = "ثبت کتاب";
            btn_save.Size = new System.Drawing.Size(128, 40);
            btn_save.MinimumSize = new System.Drawing.Size(112, 38);
            btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_save.BackColor = System.Drawing.Color.FromArgb(12, 120, 113);
            btn_save.ForeColor = System.Drawing.Color.White;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_save.AutoSize = false;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btn_save.TabIndex = 32;
            //
            // btn_edite
            //
            btn_edite.Name = "btn_edite";
            btn_edite.Margin = new System.Windows.Forms.Padding(4);
            btn_edite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btn_edite.Text = "ذخیرهٔ تغییرات";
            btn_edite.Size = new System.Drawing.Size(128, 40);
            btn_edite.MinimumSize = new System.Drawing.Size(112, 38);
            btn_edite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_edite.BackColor = System.Drawing.Color.FromArgb(12, 120, 113);
            btn_edite.ForeColor = System.Drawing.Color.White;
            btn_edite.UseVisualStyleBackColor = false;
            btn_edite.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_edite.AutoSize = false;
            btn_edite.FlatAppearance.BorderSize = 0;
            btn_edite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btn_edite.TabIndex = 33;
            //
            // btn_delete
            //
            btn_delete.Name = "btn_delete";
            btn_delete.Margin = new System.Windows.Forms.Padding(4);
            btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btn_delete.Text = "حذف کتاب";
            btn_delete.Size = new System.Drawing.Size(128, 40);
            btn_delete.MinimumSize = new System.Drawing.Size(112, 38);
            btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_delete.BackColor = System.Drawing.Color.FromArgb(169, 49, 60);
            btn_delete.ForeColor = System.Drawing.Color.White;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_delete.AutoSize = false;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btn_delete.TabIndex = 34;
            //
            // btn_new
            //
            btn_new.Name = "btn_new";
            btn_new.Margin = new System.Windows.Forms.Padding(4);
            btn_new.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btn_new.Text = "کتاب جدید";
            btn_new.Size = new System.Drawing.Size(128, 40);
            btn_new.MinimumSize = new System.Drawing.Size(112, 38);
            btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_new.BackColor = System.Drawing.Color.White;
            btn_new.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            btn_new.UseVisualStyleBackColor = false;
            btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_new.AutoSize = false;
            btn_new.FlatAppearance.BorderSize = 1;
            btn_new.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btn_new.TabIndex = 35;
            //
            // _actions
            //
            _actions.Name = "_actions";
            _actions.Margin = new System.Windows.Forms.Padding(0);
            _actions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _actions.Dock = System.Windows.Forms.DockStyle.Top;
            _actions.AutoSize = true;
            _actions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            _actions.WrapContents = true;
            _actions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            _actions.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            _actions.MaximumSize = new System.Drawing.Size(288, 0);
            _actions.TabIndex = 36;
            //
            // _editor
            //
            _editor.Name = "_editor";
            _editor.Margin = new System.Windows.Forms.Padding(0);
            _editor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _editor.Dock = System.Windows.Forms.DockStyle.Top;
            _editor.ColumnCount = 1;
            _editor.RowCount = 8;
            _editor.Padding = new System.Windows.Forms.Padding(4);
            _editor.BackColor = System.Drawing.Color.White;
            _editor.AutoSize = true;
            _editor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            _editor.MaximumSize = new System.Drawing.Size(300, 0);
            _editor.TabIndex = 37;
            _editor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            _editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            _editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            _editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            _editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            _editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            _editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            _editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize, 0F));
            _editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize, 0F));
            //
            // _editorHost
            //
            _editorHost.Name = "_editorHost";
            _editorHost.Margin = new System.Windows.Forms.Padding(0);
            _editorHost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _editorHost.Dock = System.Windows.Forms.DockStyle.Fill;
            _editorHost.AutoScroll = true;
            _editorHost.BackColor = System.Drawing.Color.White;
            _editorHost.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            _editorHost.TabIndex = 38;
            //
            // editorCard
            //
            editorCard.Name = "editorCard";
            editorCard.Margin = new System.Windows.Forms.Padding(6);
            editorCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            editorCard.Dock = System.Windows.Forms.DockStyle.Fill;
            editorCard.ColumnCount = 1;
            editorCard.RowCount = 2;
            editorCard.Padding = new System.Windows.Forms.Padding(12);
            editorCard.BackColor = System.Drawing.Color.White;
            editorCard.TabIndex = 39;
            editorCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            editorCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            editorCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // editorCardTitle
            //
            editorCardTitle.Name = "editorCardTitle";
            editorCardTitle.Margin = new System.Windows.Forms.Padding(0);
            editorCardTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            editorCardTitle.Text = "مشخصات کتاب";
            editorCardTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            editorCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            editorCardTitle.AutoSize = false;
            editorCardTitle.AutoEllipsis = true;
            editorCardTitle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            editorCardTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            editorCardTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            editorCardTitle.TabIndex = 40;
            //
            // bodyLayout
            //
            bodyLayout.Name = "bodyLayout";
            bodyLayout.Margin = new System.Windows.Forms.Padding(0);
            bodyLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            bodyLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            bodyLayout.ColumnCount = 2;
            bodyLayout.RowCount = 1;
            bodyLayout.Padding = new System.Windows.Forms.Padding(0);
            bodyLayout.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            bodyLayout.TabIndex = 41;
            bodyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            bodyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            bodyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            headingLayout.Controls.Add(headingLabel, 0, 0);
            headingLayout.Controls.Add(subtitleLabel, 0, 1);
            headerLayout.Controls.Add(userProfile1, 0, 0);
            headerLayout.Controls.Add(headingLayout, 1, 0);
            rootLayout.Controls.Add(headerLayout, 0, 0);
            rootLayout.Controls.Add(footerLabel, 0, 2);
            viewportPanel.Controls.Add(rootLayout);
            Controls.Add(viewportPanel);
            searchField.Controls.Add(searchFieldLabel, 0, 0);
            searchField.Controls.Add(txt_search, 0, 1);
            searchLayout.Controls.Add(searchField, 0, 0);
            searchLayout.Controls.Add(btn_refresh, 1, 0);
            listLayout.Controls.Add(searchLayout, 0, 0);
            listLayout.Controls.Add(dataGrid_books, 0, 1);
            listLayout.Controls.Add(_status, 0, 2);
            booksCard.Controls.Add(booksCardTitle, 0, 0);
            booksCard.Controls.Add(listLayout, 0, 1);
            txt_nameField.Controls.Add(txt_nameFieldLabel, 0, 0);
            txt_nameField.Controls.Add(txt_name, 0, 1);
            txt_authorField.Controls.Add(txt_authorFieldLabel, 0, 0);
            txt_authorField.Controls.Add(txt_author, 0, 1);
            txt_languageField.Controls.Add(txt_languageFieldLabel, 0, 0);
            txt_languageField.Controls.Add(txt_language, 0, 1);
            photoActions.Controls.Add(btn_choose_photo);
            _actions.Controls.Add(btn_save);
            _actions.Controls.Add(btn_edite);
            _actions.Controls.Add(btn_delete);
            _actions.Controls.Add(btn_new);
            _editor.Controls.Add(_mode, 0, 0);
            _editor.Controls.Add(txt_nameField, 0, 1);
            _editor.Controls.Add(txt_authorField, 0, 2);
            _editor.Controls.Add(txt_languageField, 0, 3);
            _editor.Controls.Add(photoCaption, 0, 4);
            _editor.Controls.Add(picture_book, 0, 5);
            _editor.Controls.Add(photoActions, 0, 6);
            _editor.Controls.Add(_actions, 0, 7);
            _editorHost.Controls.Add(_editor);
            editorCard.Controls.Add(editorCardTitle, 0, 0);
            editorCard.Controls.Add(_editorHost, 0, 1);
            bodyLayout.Controls.Add(booksCard, 0, 0);
            bodyLayout.Controls.Add(editorCard, 1, 0);
            rootLayout.Controls.Add(bodyLayout, 0, 1);
            dataGrid_books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGrid_books_Id, dataGrid_books_Title, dataGrid_books_Author, dataGrid_books_Language });
            btn_refresh.Click += RefreshBooks_Click;
            picture_book.Click += picture_book_Click;
            btn_choose_photo.Click += picture_book_Click;
            btn_save.Click += button1_Click;
            btn_edite.Click += btn_edite_Click;
            btn_delete.Click += btn_delete_Click;
            btn_new.Click += NewBook_Click;
            txt_search.TextChanged += txt_search_TextChanged;
            dataGrid_books.CellClick += dataGrid_books_CellClick;
            Load += FrmBook_Load;
            //
            // FrmBook
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Name = "FrmBook";
            ClientSize = new System.Drawing.Size(1120, 740);
            MinimumSize = new System.Drawing.Size(860, 560);
            Text = "مدیریت کتاب‌ها";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            RightToLeftLayout = false;
            ShowIcon = false;
            AcceptButton = btn_save;
            bodyLayout.ResumeLayout(false);
            bodyLayout.PerformLayout();
            editorCard.ResumeLayout(false);
            editorCard.PerformLayout();
            _editorHost.ResumeLayout(false);
            _editorHost.PerformLayout();
            _editor.ResumeLayout(false);
            _editor.PerformLayout();
            _actions.ResumeLayout(false);
            _actions.PerformLayout();
            photoActions.ResumeLayout(false);
            photoActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_book).EndInit();
            txt_languageField.ResumeLayout(false);
            txt_languageField.PerformLayout();
            txt_authorField.ResumeLayout(false);
            txt_authorField.PerformLayout();
            txt_nameField.ResumeLayout(false);
            txt_nameField.PerformLayout();
            booksCard.ResumeLayout(false);
            booksCard.PerformLayout();
            listLayout.ResumeLayout(false);
            listLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_books).EndInit();
            searchField.ResumeLayout(false);
            searchField.PerformLayout();
            searchLayout.ResumeLayout(false);
            searchLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_errors).EndInit();
            viewportPanel.ResumeLayout(false);
            viewportPanel.PerformLayout();
            headingLayout.ResumeLayout(false);
            headingLayout.PerformLayout();
            headerLayout.ResumeLayout(false);
            headerLayout.PerformLayout();
            rootLayout.ResumeLayout(false);
            rootLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.TableLayoutPanel headingLayout;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private LibraryManagementWindowsForm.UserProfile userProfile1;
        private System.Windows.Forms.Label footerLabel;
        private System.Windows.Forms.Panel viewportPanel;
        private System.Windows.Forms.ErrorProvider _errors;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TableLayoutPanel searchLayout;
        private System.Windows.Forms.TableLayoutPanel searchField;
        private System.Windows.Forms.Label searchFieldLabel;
        private System.Windows.Forms.DataGridView dataGrid_books;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_books_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_books_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_books_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_books_Language;
        private System.Windows.Forms.Label _status;
        private System.Windows.Forms.TableLayoutPanel listLayout;
        private System.Windows.Forms.TableLayoutPanel booksCard;
        private System.Windows.Forms.Label booksCardTitle;
        private System.Windows.Forms.Label _mode;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TableLayoutPanel txt_nameField;
        private System.Windows.Forms.Label txt_nameFieldLabel;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TableLayoutPanel txt_authorField;
        private System.Windows.Forms.Label txt_authorFieldLabel;
        private System.Windows.Forms.TextBox txt_language;
        private System.Windows.Forms.TableLayoutPanel txt_languageField;
        private System.Windows.Forms.Label txt_languageFieldLabel;
        private System.Windows.Forms.Label photoCaption;
        private System.Windows.Forms.PictureBox picture_book;
        private System.Windows.Forms.Button btn_choose_photo;
        private System.Windows.Forms.FlowLayoutPanel photoActions;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edite;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.FlowLayoutPanel _actions;
        private System.Windows.Forms.TableLayoutPanel _editor;
        private System.Windows.Forms.Panel _editorHost;
        private System.Windows.Forms.TableLayoutPanel editorCard;
        private System.Windows.Forms.Label editorCardTitle;
        private System.Windows.Forms.TableLayoutPanel bodyLayout;
    }
}
