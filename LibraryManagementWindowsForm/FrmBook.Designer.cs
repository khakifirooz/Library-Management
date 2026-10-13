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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            rootLayout = new TableLayoutPanel();
            headerLayout = new TableLayoutPanel();
            userProfile1 = new UserProfile();
            headingLayout = new TableLayoutPanel();
            headingLabel = new Label();
            subtitleLabel = new Label();
            footerLabel = new Label();
            bodyLayout = new TableLayoutPanel();
            booksCard = new TableLayoutPanel();
            booksCardTitle = new Label();
            listLayout = new TableLayoutPanel();
            searchLayout = new TableLayoutPanel();
            searchField = new TableLayoutPanel();
            searchFieldLabel = new Label();
            txt_search = new TextBox();
            btn_refresh = new Button();
            dataGrid_books = new DataGridView();
            _status = new Label();
            editorCard = new TableLayoutPanel();
            editorCardTitle = new Label();
            _editorHost = new Panel();
            _editor = new TableLayoutPanel();
            _mode = new Label();
            txt_nameField = new TableLayoutPanel();
            txt_nameFieldLabel = new Label();
            txt_name = new TextBox();
            txt_authorField = new TableLayoutPanel();
            txt_authorFieldLabel = new Label();
            txt_author = new TextBox();
            txt_languageField = new TableLayoutPanel();
            txt_languageFieldLabel = new Label();
            txt_language = new TextBox();
            photoCaption = new Label();
            picture_book = new PictureBox();
            photoActions = new FlowLayoutPanel();
            btn_choose_photo = new Button();
            _actions = new FlowLayoutPanel();
            btn_save = new Button();
            btn_edite = new Button();
            btn_delete = new Button();
            btn_new = new Button();
            viewportPanel = new Panel();
            _errors = new ErrorProvider(components);
            rootLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            headingLayout.SuspendLayout();
            bodyLayout.SuspendLayout();
            booksCard.SuspendLayout();
            listLayout.SuspendLayout();
            searchLayout.SuspendLayout();
            searchField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_books).BeginInit();
            editorCard.SuspendLayout();
            _editorHost.SuspendLayout();
            _editor.SuspendLayout();
            txt_nameField.SuspendLayout();
            txt_authorField.SuspendLayout();
            txt_languageField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_book).BeginInit();
            photoActions.SuspendLayout();
            _actions.SuspendLayout();
            viewportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_errors).BeginInit();
            SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.BackColor = Color.FromArgb(242, 245, 249);
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rootLayout.Controls.Add(headerLayout, 0, 0);
            rootLayout.Controls.Add(footerLabel, 0, 2);
            rootLayout.Controls.Add(bodyLayout, 0, 1);
            rootLayout.Dock = DockStyle.Fill;
            rootLayout.Location = new Point(0, 0);
            rootLayout.Margin = new Padding(0);
            rootLayout.MinimumSize = new Size(0, 620);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new Padding(16);
            rootLayout.RightToLeft = RightToLeft.No;
            rootLayout.RowCount = 3;
            rootLayout.RowStyles.Add(new RowStyle());
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            rootLayout.Size = new Size(1120, 740);
            rootLayout.TabIndex = 0;
            // 
            // headerLayout
            // 
            headerLayout.AutoSize = true;
            headerLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            headerLayout.BackColor = Color.White;
            headerLayout.ColumnCount = 2;
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            headerLayout.Controls.Add(userProfile1, 0, 0);
            headerLayout.Controls.Add(headingLayout, 1, 0);
            headerLayout.Dock = DockStyle.Fill;
            headerLayout.Location = new Point(16, 16);
            headerLayout.Margin = new Padding(0, 0, 0, 12);
            headerLayout.Name = "headerLayout";
            headerLayout.Padding = new Padding(12);
            headerLayout.RightToLeft = RightToLeft.No;
            headerLayout.RowCount = 1;
            headerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            headerLayout.Size = new Size(1088, 92);
            headerLayout.TabIndex = 1;
            // 
            // userProfile1
            // 
            userProfile1.BackColor = Color.White;
            userProfile1.Dock = DockStyle.Fill;
            userProfile1.Font = new Font("Tahoma", 10F);
            userProfile1.ForeColor = Color.FromArgb(25, 42, 66);
            userProfile1.Location = new Point(16, 16);
            userProfile1.Margin = new Padding(4, 4, 4, 4);
            userProfile1.MinimumSize = new Size(160, 32);
            userProfile1.Name = "userProfile1";
            userProfile1.RightToLeft = RightToLeft.Yes;
            userProfile1.Size = new Size(212, 60);
            userProfile1.TabIndex = 5;
            // 
            // headingLayout
            // 
            headingLayout.BackColor = Color.White;
            headingLayout.ColumnCount = 1;
            headingLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            headingLayout.Controls.Add(headingLabel, 0, 0);
            headingLayout.Controls.Add(subtitleLabel, 0, 1);
            headingLayout.Dock = DockStyle.Fill;
            headingLayout.Location = new Point(232, 12);
            headingLayout.Margin = new Padding(0);
            headingLayout.Name = "headingLayout";
            headingLayout.RightToLeft = RightToLeft.No;
            headingLayout.RowCount = 2;
            headingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            headingLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            headingLayout.Size = new Size(844, 68);
            headingLayout.TabIndex = 2;
            // 
            // headingLabel
            // 
            headingLabel.AutoEllipsis = true;
            headingLabel.Dock = DockStyle.Fill;
            headingLabel.Font = new Font("Tahoma", 17F, FontStyle.Bold);
            headingLabel.ForeColor = Color.FromArgb(25, 42, 66);
            headingLabel.Location = new Point(0, 0);
            headingLabel.Margin = new Padding(0);
            headingLabel.Name = "headingLabel";
            headingLabel.Padding = new Padding(4, 0, 4, 0);
            headingLabel.RightToLeft = RightToLeft.Yes;
            headingLabel.Size = new Size(844, 32);
            headingLabel.TabIndex = 3;
            headingLabel.Text = "مدیریت کتاب‌ها";
            headingLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoEllipsis = true;
            subtitleLabel.Dock = DockStyle.Fill;
            subtitleLabel.Font = new Font("Tahoma", 9F);
            subtitleLabel.ForeColor = Color.FromArgb(94, 110, 132);
            subtitleLabel.Location = new Point(0, 32);
            subtitleLabel.Margin = new Padding(0);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Padding = new Padding(4, 0, 4, 0);
            subtitleLabel.RightToLeft = RightToLeft.Yes;
            subtitleLabel.Size = new Size(844, 36);
            subtitleLabel.TabIndex = 4;
            subtitleLabel.Text = "ثبت، جست‌وجو و ویرایش مشخصات و تصویر کتاب";
            subtitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // footerLabel
            // 
            footerLabel.AutoEllipsis = true;
            footerLabel.Dock = DockStyle.Fill;
            footerLabel.Font = new Font("Tahoma", 9F);
            footerLabel.ForeColor = Color.FromArgb(94, 110, 132);
            footerLabel.Location = new Point(16, 700);
            footerLabel.Margin = new Padding(0);
            footerLabel.Name = "footerLabel";
            footerLabel.Padding = new Padding(4, 0, 4, 0);
            footerLabel.RightToLeft = RightToLeft.Yes;
            footerLabel.Size = new Size(1088, 24);
            footerLabel.TabIndex = 6;
            footerLabel.Text = "مدیریت کتابخانه  •  ثبت و پیگیری اطلاعات";
            footerLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bodyLayout
            // 
            bodyLayout.BackColor = Color.FromArgb(242, 245, 249);
            bodyLayout.ColumnCount = 2;
            bodyLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bodyLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 340F));
            bodyLayout.Controls.Add(booksCard, 0, 0);
            bodyLayout.Controls.Add(editorCard, 1, 0);
            bodyLayout.Dock = DockStyle.Fill;
            bodyLayout.Location = new Point(16, 120);
            bodyLayout.Margin = new Padding(0);
            bodyLayout.Name = "bodyLayout";
            bodyLayout.RightToLeft = RightToLeft.No;
            bodyLayout.RowCount = 1;
            bodyLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bodyLayout.Size = new Size(1088, 580);
            bodyLayout.TabIndex = 41;
            // 
            // booksCard
            // 
            booksCard.BackColor = Color.White;
            booksCard.ColumnCount = 1;
            booksCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            booksCard.Controls.Add(booksCardTitle, 0, 0);
            booksCard.Controls.Add(listLayout, 0, 1);
            booksCard.Dock = DockStyle.Fill;
            booksCard.Location = new Point(6, 6);
            booksCard.Margin = new Padding(6);
            booksCard.Name = "booksCard";
            booksCard.Padding = new Padding(12);
            booksCard.RightToLeft = RightToLeft.No;
            booksCard.RowCount = 2;
            booksCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            booksCard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            booksCard.Size = new Size(736, 568);
            booksCard.TabIndex = 16;
            // 
            // booksCardTitle
            // 
            booksCardTitle.AutoEllipsis = true;
            booksCardTitle.Dock = DockStyle.Fill;
            booksCardTitle.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            booksCardTitle.ForeColor = Color.FromArgb(25, 42, 66);
            booksCardTitle.Location = new Point(12, 12);
            booksCardTitle.Margin = new Padding(0);
            booksCardTitle.Name = "booksCardTitle";
            booksCardTitle.Padding = new Padding(4, 0, 4, 0);
            booksCardTitle.RightToLeft = RightToLeft.Yes;
            booksCardTitle.Size = new Size(712, 32);
            booksCardTitle.TabIndex = 17;
            booksCardTitle.Text = "فهرست کتاب‌ها";
            booksCardTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // listLayout
            // 
            listLayout.BackColor = Color.White;
            listLayout.ColumnCount = 1;
            listLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            listLayout.Controls.Add(searchLayout, 0, 0);
            listLayout.Controls.Add(dataGrid_books, 0, 1);
            listLayout.Controls.Add(_status, 0, 2);
            listLayout.Dock = DockStyle.Fill;
            listLayout.Location = new Point(12, 44);
            listLayout.Margin = new Padding(0);
            listLayout.Name = "listLayout";
            listLayout.RightToLeft = RightToLeft.No;
            listLayout.RowCount = 3;
            listLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            listLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            listLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            listLayout.Size = new Size(712, 512);
            listLayout.TabIndex = 15;
            // 
            // searchLayout
            // 
            searchLayout.BackColor = Color.White;
            searchLayout.ColumnCount = 2;
            searchLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            searchLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            searchLayout.Controls.Add(searchField, 0, 0);
            searchLayout.Controls.Add(btn_refresh, 1, 0);
            searchLayout.Dock = DockStyle.Fill;
            searchLayout.Location = new Point(0, 0);
            searchLayout.Margin = new Padding(0);
            searchLayout.Name = "searchLayout";
            searchLayout.RightToLeft = RightToLeft.No;
            searchLayout.RowCount = 1;
            searchLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            searchLayout.Size = new Size(712, 74);
            searchLayout.TabIndex = 10;
            // 
            // searchField
            // 
            searchField.BackColor = Color.White;
            searchField.ColumnCount = 1;
            searchField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            searchField.Controls.Add(searchFieldLabel, 0, 0);
            searchField.Controls.Add(txt_search, 0, 1);
            searchField.Dock = DockStyle.Top;
            searchField.Location = new Point(4, 0);
            searchField.Margin = new Padding(4, 0, 4, 8);
            searchField.Name = "searchField";
            searchField.RightToLeft = RightToLeft.No;
            searchField.RowCount = 2;
            searchField.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            searchField.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            searchField.Size = new Size(560, 64);
            searchField.TabIndex = 11;
            // 
            // searchFieldLabel
            // 
            searchFieldLabel.AutoEllipsis = true;
            searchFieldLabel.Dock = DockStyle.Fill;
            searchFieldLabel.Font = new Font("Tahoma", 9F);
            searchFieldLabel.ForeColor = Color.FromArgb(94, 110, 132);
            searchFieldLabel.Location = new Point(0, 0);
            searchFieldLabel.Margin = new Padding(0);
            searchFieldLabel.Name = "searchFieldLabel";
            searchFieldLabel.Padding = new Padding(4, 0, 4, 0);
            searchFieldLabel.RightToLeft = RightToLeft.Yes;
            searchFieldLabel.Size = new Size(560, 24);
            searchFieldLabel.TabIndex = 12;
            searchFieldLabel.Text = "جست‌وجوی کتاب";
            searchFieldLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.White;
            txt_search.BorderStyle = BorderStyle.FixedSingle;
            txt_search.Dock = DockStyle.Fill;
            txt_search.ForeColor = Color.FromArgb(25, 42, 66);
            txt_search.Location = new Point(0, 27);
            txt_search.Margin = new Padding(0, 3, 18, 3);
            txt_search.MaxLength = 50;
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "عنوان کتاب یا نام نویسنده…";
            txt_search.RightToLeft = RightToLeft.Yes;
            txt_search.Size = new Size(542, 28);
            txt_search.TabIndex = 8;
            txt_search.TextAlign = HorizontalAlignment.Right;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // btn_refresh
            // 
            btn_refresh.Anchor = AnchorStyles.Right;
            btn_refresh.BackColor = Color.White;
            btn_refresh.Cursor = Cursors.Hand;
            btn_refresh.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            btn_refresh.FlatStyle = FlatStyle.Flat;
            btn_refresh.ForeColor = Color.FromArgb(25, 42, 66);
            btn_refresh.Location = new Point(580, 17);
            btn_refresh.Margin = new Padding(4);
            btn_refresh.MinimumSize = new Size(112, 38);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.RightToLeft = RightToLeft.Yes;
            btn_refresh.Size = new Size(128, 40);
            btn_refresh.TabIndex = 9;
            btn_refresh.Text = "تازه‌سازی";
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += RefreshBooks_Click;
            // 
            // dataGrid_books
            // 
            dataGrid_books.AllowUserToAddRows = false;
            dataGrid_books.AllowUserToDeleteRows = false;
            dataGrid_books.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 251, 253);
            dataGrid_books.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_books.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_books.BackgroundColor = Color.White;
            dataGrid_books.BorderStyle = BorderStyle.None;
            dataGrid_books.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid_books.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 245, 249);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(25, 42, 66);
            dataGridViewCellStyle2.Padding = new Padding(6);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGrid_books.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGrid_books.ColumnHeadersHeight = 42;
            dataGrid_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(25, 42, 66);
            dataGridViewCellStyle3.NullValue = "—";
            dataGridViewCellStyle3.Padding = new Padding(6);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 242, 238);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(25, 42, 66);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGrid_books.DefaultCellStyle = dataGridViewCellStyle3;
            dataGrid_books.Dock = DockStyle.Fill;
            dataGrid_books.EnableHeadersVisualStyles = false;
            dataGrid_books.GridColor = Color.FromArgb(222, 230, 239);
            dataGrid_books.Location = new Point(0, 74);
            dataGrid_books.Margin = new Padding(0);
            dataGrid_books.MultiSelect = false;
            dataGrid_books.Name = "dataGrid_books";
            dataGrid_books.ReadOnly = true;
            dataGrid_books.RightToLeft = RightToLeft.Yes;
            dataGrid_books.RowHeadersVisible = false;
            dataGrid_books.RowHeadersWidth = 51;
            dataGrid_books.RowTemplate.Height = 36;
            dataGrid_books.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_books.Size = new Size(712, 408);
            dataGrid_books.TabIndex = 13;
            dataGrid_books.Tag = "books";
            dataGrid_books.CellClick += dataGrid_books_CellClick;
            // 
            // _status
            // 
            _status.AutoEllipsis = true;
            _status.Dock = DockStyle.Fill;
            _status.Font = new Font("Tahoma", 9F);
            _status.ForeColor = Color.FromArgb(94, 110, 132);
            _status.Location = new Point(0, 482);
            _status.Margin = new Padding(0);
            _status.Name = "_status";
            _status.Padding = new Padding(4, 0, 4, 0);
            _status.RightToLeft = RightToLeft.Yes;
            _status.Size = new Size(712, 30);
            _status.TabIndex = 14;
            _status.Text = "برای شروع، کتاب تازه ثبت کنید یا یک ردیف را انتخاب کنید.";
            _status.TextAlign = ContentAlignment.MiddleRight;
            // 
            // editorCard
            // 
            editorCard.BackColor = Color.White;
            editorCard.ColumnCount = 1;
            editorCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            editorCard.Controls.Add(editorCardTitle, 0, 0);
            editorCard.Controls.Add(_editorHost, 0, 1);
            editorCard.Dock = DockStyle.Fill;
            editorCard.Location = new Point(754, 6);
            editorCard.Margin = new Padding(6);
            editorCard.Name = "editorCard";
            editorCard.Padding = new Padding(12);
            editorCard.RightToLeft = RightToLeft.No;
            editorCard.RowCount = 2;
            editorCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            editorCard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            editorCard.Size = new Size(328, 568);
            editorCard.TabIndex = 39;
            // 
            // editorCardTitle
            // 
            editorCardTitle.AutoEllipsis = true;
            editorCardTitle.Dock = DockStyle.Fill;
            editorCardTitle.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            editorCardTitle.ForeColor = Color.FromArgb(25, 42, 66);
            editorCardTitle.Location = new Point(12, 12);
            editorCardTitle.Margin = new Padding(0);
            editorCardTitle.Name = "editorCardTitle";
            editorCardTitle.Padding = new Padding(4, 0, 4, 0);
            editorCardTitle.RightToLeft = RightToLeft.Yes;
            editorCardTitle.Size = new Size(304, 32);
            editorCardTitle.TabIndex = 40;
            editorCardTitle.Text = "مشخصات کتاب";
            editorCardTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // _editorHost
            // 
            _editorHost.AutoScroll = true;
            _editorHost.BackColor = Color.White;
            _editorHost.Controls.Add(_editor);
            _editorHost.Dock = DockStyle.Fill;
            _editorHost.Location = new Point(12, 44);
            _editorHost.Margin = new Padding(0);
            _editorHost.Name = "_editorHost";
            _editorHost.Padding = new Padding(0, 0, 4, 0);
            _editorHost.RightToLeft = RightToLeft.No;
            _editorHost.Size = new Size(304, 512);
            _editorHost.TabIndex = 38;
            // 
            // _editor
            // 
            _editor.AutoSize = true;
            _editor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _editor.BackColor = Color.White;
            _editor.ColumnCount = 1;
            _editor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _editor.Controls.Add(_mode, 0, 0);
            _editor.Controls.Add(txt_nameField, 0, 1);
            _editor.Controls.Add(txt_authorField, 0, 2);
            _editor.Controls.Add(txt_languageField, 0, 3);
            _editor.Controls.Add(photoCaption, 0, 4);
            _editor.Controls.Add(picture_book, 0, 5);
            _editor.Controls.Add(photoActions, 0, 6);
            _editor.Controls.Add(_actions, 0, 7);
            _editor.Dock = DockStyle.Top;
            _editor.Location = new Point(0, 0);
            _editor.Margin = new Padding(0);
            _editor.MaximumSize = new Size(300, 0);
            _editor.Name = "_editor";
            _editor.Padding = new Padding(4);
            _editor.RightToLeft = RightToLeft.No;
            _editor.RowCount = 8;
            _editor.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            _editor.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            _editor.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            _editor.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            _editor.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            _editor.RowStyles.Add(new RowStyle(SizeType.Absolute, 148F));
            _editor.RowStyles.Add(new RowStyle());
            _editor.RowStyles.Add(new RowStyle());
            _editor.Size = new Size(279, 686);
            _editor.TabIndex = 37;
            // 
            // _mode
            // 
            _mode.AutoEllipsis = true;
            _mode.Dock = DockStyle.Fill;
            _mode.Font = new Font("Tahoma", 9F);
            _mode.ForeColor = Color.FromArgb(94, 110, 132);
            _mode.Location = new Point(4, 4);
            _mode.Margin = new Padding(0);
            _mode.Name = "_mode";
            _mode.Padding = new Padding(4, 0, 4, 0);
            _mode.RightToLeft = RightToLeft.Yes;
            _mode.Size = new Size(271, 30);
            _mode.TabIndex = 18;
            _mode.Text = "کتاب جدید";
            _mode.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_nameField
            // 
            txt_nameField.BackColor = Color.White;
            txt_nameField.ColumnCount = 1;
            txt_nameField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            txt_nameField.Controls.Add(txt_nameFieldLabel, 0, 0);
            txt_nameField.Controls.Add(txt_name, 0, 1);
            txt_nameField.Dock = DockStyle.Top;
            txt_nameField.Location = new Point(8, 34);
            txt_nameField.Margin = new Padding(4, 0, 4, 8);
            txt_nameField.Name = "txt_nameField";
            txt_nameField.RightToLeft = RightToLeft.No;
            txt_nameField.RowCount = 2;
            txt_nameField.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            txt_nameField.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            txt_nameField.Size = new Size(263, 64);
            txt_nameField.TabIndex = 20;
            // 
            // txt_nameFieldLabel
            // 
            txt_nameFieldLabel.AutoEllipsis = true;
            txt_nameFieldLabel.Dock = DockStyle.Fill;
            txt_nameFieldLabel.Font = new Font("Tahoma", 9F);
            txt_nameFieldLabel.ForeColor = Color.FromArgb(94, 110, 132);
            txt_nameFieldLabel.Location = new Point(0, 0);
            txt_nameFieldLabel.Margin = new Padding(0);
            txt_nameFieldLabel.Name = "txt_nameFieldLabel";
            txt_nameFieldLabel.Padding = new Padding(4, 0, 4, 0);
            txt_nameFieldLabel.RightToLeft = RightToLeft.Yes;
            txt_nameFieldLabel.Size = new Size(263, 24);
            txt_nameFieldLabel.TabIndex = 21;
            txt_nameFieldLabel.Text = "عنوان کتاب *";
            txt_nameFieldLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.White;
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Dock = DockStyle.Fill;
            txt_name.ForeColor = Color.FromArgb(25, 42, 66);
            txt_name.Location = new Point(0, 27);
            txt_name.Margin = new Padding(0, 3, 18, 3);
            txt_name.MaxLength = 50;
            txt_name.Name = "txt_name";
            txt_name.RightToLeft = RightToLeft.Yes;
            txt_name.Size = new Size(245, 28);
            txt_name.TabIndex = 19;
            txt_name.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_authorField
            // 
            txt_authorField.BackColor = Color.White;
            txt_authorField.ColumnCount = 1;
            txt_authorField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            txt_authorField.Controls.Add(txt_authorFieldLabel, 0, 0);
            txt_authorField.Controls.Add(txt_author, 0, 1);
            txt_authorField.Dock = DockStyle.Top;
            txt_authorField.Location = new Point(8, 106);
            txt_authorField.Margin = new Padding(4, 0, 4, 8);
            txt_authorField.Name = "txt_authorField";
            txt_authorField.RightToLeft = RightToLeft.No;
            txt_authorField.RowCount = 2;
            txt_authorField.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            txt_authorField.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            txt_authorField.Size = new Size(263, 64);
            txt_authorField.TabIndex = 23;
            // 
            // txt_authorFieldLabel
            // 
            txt_authorFieldLabel.AutoEllipsis = true;
            txt_authorFieldLabel.Dock = DockStyle.Fill;
            txt_authorFieldLabel.Font = new Font("Tahoma", 9F);
            txt_authorFieldLabel.ForeColor = Color.FromArgb(94, 110, 132);
            txt_authorFieldLabel.Location = new Point(0, 0);
            txt_authorFieldLabel.Margin = new Padding(0);
            txt_authorFieldLabel.Name = "txt_authorFieldLabel";
            txt_authorFieldLabel.Padding = new Padding(4, 0, 4, 0);
            txt_authorFieldLabel.RightToLeft = RightToLeft.Yes;
            txt_authorFieldLabel.Size = new Size(263, 24);
            txt_authorFieldLabel.TabIndex = 24;
            txt_authorFieldLabel.Text = "نویسنده *";
            txt_authorFieldLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_author
            // 
            txt_author.BackColor = Color.White;
            txt_author.BorderStyle = BorderStyle.FixedSingle;
            txt_author.Dock = DockStyle.Fill;
            txt_author.ForeColor = Color.FromArgb(25, 42, 66);
            txt_author.Location = new Point(0, 27);
            txt_author.Margin = new Padding(0, 3, 18, 3);
            txt_author.MaxLength = 50;
            txt_author.Name = "txt_author";
            txt_author.RightToLeft = RightToLeft.Yes;
            txt_author.Size = new Size(245, 28);
            txt_author.TabIndex = 22;
            txt_author.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_languageField
            // 
            txt_languageField.BackColor = Color.White;
            txt_languageField.ColumnCount = 1;
            txt_languageField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            txt_languageField.Controls.Add(txt_languageFieldLabel, 0, 0);
            txt_languageField.Controls.Add(txt_language, 0, 1);
            txt_languageField.Dock = DockStyle.Top;
            txt_languageField.Location = new Point(8, 178);
            txt_languageField.Margin = new Padding(4, 0, 4, 8);
            txt_languageField.Name = "txt_languageField";
            txt_languageField.RightToLeft = RightToLeft.No;
            txt_languageField.RowCount = 2;
            txt_languageField.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            txt_languageField.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            txt_languageField.Size = new Size(263, 64);
            txt_languageField.TabIndex = 26;
            // 
            // txt_languageFieldLabel
            // 
            txt_languageFieldLabel.AutoEllipsis = true;
            txt_languageFieldLabel.Dock = DockStyle.Fill;
            txt_languageFieldLabel.Font = new Font("Tahoma", 9F);
            txt_languageFieldLabel.ForeColor = Color.FromArgb(94, 110, 132);
            txt_languageFieldLabel.Location = new Point(0, 0);
            txt_languageFieldLabel.Margin = new Padding(0);
            txt_languageFieldLabel.Name = "txt_languageFieldLabel";
            txt_languageFieldLabel.Padding = new Padding(4, 0, 4, 0);
            txt_languageFieldLabel.RightToLeft = RightToLeft.Yes;
            txt_languageFieldLabel.Size = new Size(263, 24);
            txt_languageFieldLabel.TabIndex = 27;
            txt_languageFieldLabel.Text = "زبان *";
            txt_languageFieldLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_language
            // 
            txt_language.BackColor = Color.White;
            txt_language.BorderStyle = BorderStyle.FixedSingle;
            txt_language.Dock = DockStyle.Fill;
            txt_language.ForeColor = Color.FromArgb(25, 42, 66);
            txt_language.Location = new Point(0, 27);
            txt_language.Margin = new Padding(0, 3, 18, 3);
            txt_language.MaxLength = 50;
            txt_language.Name = "txt_language";
            txt_language.RightToLeft = RightToLeft.Yes;
            txt_language.Size = new Size(245, 28);
            txt_language.TabIndex = 25;
            txt_language.TextAlign = HorizontalAlignment.Right;
            // 
            // photoCaption
            // 
            photoCaption.AutoEllipsis = true;
            photoCaption.Dock = DockStyle.Fill;
            photoCaption.Font = new Font("Tahoma", 9F);
            photoCaption.ForeColor = Color.FromArgb(94, 110, 132);
            photoCaption.Location = new Point(4, 250);
            photoCaption.Margin = new Padding(0);
            photoCaption.Name = "photoCaption";
            photoCaption.Padding = new Padding(4, 0, 4, 0);
            photoCaption.RightToLeft = RightToLeft.Yes;
            photoCaption.Size = new Size(271, 28);
            photoCaption.TabIndex = 28;
            photoCaption.Text = "تصویر کتاب؛ اختیاری";
            photoCaption.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picture_book
            // 
            picture_book.BackColor = Color.FromArgb(242, 245, 249);
            picture_book.BorderStyle = BorderStyle.FixedSingle;
            picture_book.Cursor = Cursors.Hand;
            picture_book.Dock = DockStyle.Fill;
            picture_book.Location = new Point(8, 282);
            picture_book.Margin = new Padding(4);
            picture_book.Name = "picture_book";
            picture_book.RightToLeft = RightToLeft.Yes;
            picture_book.Size = new Size(263, 140);
            picture_book.SizeMode = PictureBoxSizeMode.Zoom;
            picture_book.TabIndex = 29;
            picture_book.TabStop = false;
            picture_book.Click += picture_book_Click;
            // 
            // photoActions
            // 
            photoActions.AutoSize = true;
            photoActions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            photoActions.Controls.Add(btn_choose_photo);
            photoActions.Dock = DockStyle.Top;
            photoActions.FlowDirection = FlowDirection.RightToLeft;
            photoActions.Location = new Point(4, 426);
            photoActions.Margin = new Padding(0);
            photoActions.MaximumSize = new Size(288, 0);
            photoActions.Name = "photoActions";
            photoActions.Padding = new Padding(0, 4, 0, 4);
            photoActions.RightToLeft = RightToLeft.No;
            photoActions.Size = new Size(271, 56);
            photoActions.TabIndex = 31;
            // 
            // btn_choose_photo
            // 
            btn_choose_photo.BackColor = Color.White;
            btn_choose_photo.Cursor = Cursors.Hand;
            btn_choose_photo.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            btn_choose_photo.FlatStyle = FlatStyle.Flat;
            btn_choose_photo.ForeColor = Color.FromArgb(25, 42, 66);
            btn_choose_photo.Location = new Point(139, 8);
            btn_choose_photo.Margin = new Padding(4);
            btn_choose_photo.MinimumSize = new Size(112, 38);
            btn_choose_photo.Name = "btn_choose_photo";
            btn_choose_photo.RightToLeft = RightToLeft.Yes;
            btn_choose_photo.Size = new Size(128, 40);
            btn_choose_photo.TabIndex = 30;
            btn_choose_photo.Text = "انتخاب تصویر";
            btn_choose_photo.UseVisualStyleBackColor = false;
            btn_choose_photo.Click += picture_book_Click;
            // 
            // _actions
            // 
            _actions.AutoSize = true;
            _actions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _actions.Controls.Add(btn_save);
            _actions.Controls.Add(btn_edite);
            _actions.Controls.Add(btn_delete);
            _actions.Controls.Add(btn_new);
            _actions.Dock = DockStyle.Top;
            _actions.FlowDirection = FlowDirection.RightToLeft;
            _actions.Location = new Point(4, 482);
            _actions.Margin = new Padding(0);
            _actions.MaximumSize = new Size(288, 0);
            _actions.Name = "_actions";
            _actions.Padding = new Padding(0, 4, 0, 4);
            _actions.RightToLeft = RightToLeft.No;
            _actions.Size = new Size(271, 200);
            _actions.TabIndex = 36;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(12, 120, 113);
            btn_save.Cursor = Cursors.Hand;
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(139, 8);
            btn_save.Margin = new Padding(4);
            btn_save.MinimumSize = new Size(112, 38);
            btn_save.Name = "btn_save";
            btn_save.RightToLeft = RightToLeft.Yes;
            btn_save.Size = new Size(128, 40);
            btn_save.TabIndex = 32;
            btn_save.Text = "ثبت کتاب";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += button1_Click;
            // 
            // btn_edite
            // 
            btn_edite.BackColor = Color.FromArgb(12, 120, 113);
            btn_edite.Cursor = Cursors.Hand;
            btn_edite.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            btn_edite.FlatAppearance.BorderSize = 0;
            btn_edite.FlatStyle = FlatStyle.Flat;
            btn_edite.ForeColor = Color.White;
            btn_edite.Location = new Point(139, 56);
            btn_edite.Margin = new Padding(4);
            btn_edite.MinimumSize = new Size(112, 38);
            btn_edite.Name = "btn_edite";
            btn_edite.RightToLeft = RightToLeft.Yes;
            btn_edite.Size = new Size(128, 40);
            btn_edite.TabIndex = 33;
            btn_edite.Text = "ذخیرهٔ تغییرات";
            btn_edite.UseVisualStyleBackColor = false;
            btn_edite.Click += btn_edite_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(169, 49, 60);
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(139, 104);
            btn_delete.Margin = new Padding(4);
            btn_delete.MinimumSize = new Size(112, 38);
            btn_delete.Name = "btn_delete";
            btn_delete.RightToLeft = RightToLeft.Yes;
            btn_delete.Size = new Size(128, 40);
            btn_delete.TabIndex = 34;
            btn_delete.Text = "حذف کتاب";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_new
            // 
            btn_new.BackColor = Color.White;
            btn_new.Cursor = Cursors.Hand;
            btn_new.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            btn_new.FlatStyle = FlatStyle.Flat;
            btn_new.ForeColor = Color.FromArgb(25, 42, 66);
            btn_new.Location = new Point(139, 152);
            btn_new.Margin = new Padding(4);
            btn_new.MinimumSize = new Size(112, 38);
            btn_new.Name = "btn_new";
            btn_new.RightToLeft = RightToLeft.Yes;
            btn_new.Size = new Size(128, 40);
            btn_new.TabIndex = 35;
            btn_new.Text = "کتاب جدید";
            btn_new.UseVisualStyleBackColor = false;
            btn_new.Click += NewBook_Click;
            // 
            // viewportPanel
            // 
            viewportPanel.AutoScroll = true;
            viewportPanel.AutoScrollMinSize = new Size(0, 620);
            viewportPanel.BackColor = Color.FromArgb(242, 245, 249);
            viewportPanel.Controls.Add(rootLayout);
            viewportPanel.Dock = DockStyle.Fill;
            viewportPanel.Location = new Point(0, 0);
            viewportPanel.Margin = new Padding(0);
            viewportPanel.Name = "viewportPanel";
            viewportPanel.RightToLeft = RightToLeft.No;
            viewportPanel.Size = new Size(1120, 740);
            viewportPanel.TabIndex = 7;
            // 
            // _errors
            // 
            _errors.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            _errors.ContainerControl = this;
            // 
            // FrmBook
            // 
            AcceptButton = btn_save;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 245, 249);
            ClientSize = new Size(1120, 740);
            Controls.Add(viewportPanel);
            Font = new Font("Tahoma", 10F);
            ForeColor = Color.FromArgb(25, 42, 66);
            MinimumSize = new Size(860, 560);
            Name = "FrmBook";
            RightToLeft = RightToLeft.Yes;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "مدیریت کتاب‌ها";
            Load += FrmBook_Load;
            rootLayout.ResumeLayout(false);
            rootLayout.PerformLayout();
            headerLayout.ResumeLayout(false);
            headingLayout.ResumeLayout(false);
            bodyLayout.ResumeLayout(false);
            booksCard.ResumeLayout(false);
            listLayout.ResumeLayout(false);
            searchLayout.ResumeLayout(false);
            searchField.ResumeLayout(false);
            searchField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_books).EndInit();
            editorCard.ResumeLayout(false);
            _editorHost.ResumeLayout(false);
            _editorHost.PerformLayout();
            _editor.ResumeLayout(false);
            _editor.PerformLayout();
            txt_nameField.ResumeLayout(false);
            txt_nameField.PerformLayout();
            txt_authorField.ResumeLayout(false);
            txt_authorField.PerformLayout();
            txt_languageField.ResumeLayout(false);
            txt_languageField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_book).EndInit();
            photoActions.ResumeLayout(false);
            _actions.ResumeLayout(false);
            viewportPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_errors).EndInit();
            ResumeLayout(false);
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
