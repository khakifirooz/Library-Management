#nullable disable
namespace LibraryManagementWindowsForm
{
    partial class FrmLoan
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
            memberCard = new TableLayoutPanel();
            memberCardTitle = new Label();
            memberDetailsLayout = new TableLayoutPanel();
            pictureBox_member = new PictureBox();
            loanMemberIdField = new TableLayoutPanel();
            loanMemberIdFieldLabel = new Label();
            txt_search_id = new TextBox();
            loanMemberNameField = new TableLayoutPanel();
            loanMemberNameFieldLabel = new Label();
            txt_family = new TextBox();
            memberFlags = new FlowLayoutPanel();
            checkBox_status = new CheckBox();
            checkBox_isSpecial = new CheckBox();
            btn_reneview = new Button();
            historyCard = new TableLayoutPanel();
            historyCardTitle = new Label();
            historyLayout = new TableLayoutPanel();
            dataGridView_loans = new DataGridView();
            _loanStatus = new Label();
            loanActionsLayout = new TableLayoutPanel();
            issueCard = new TableLayoutPanel();
            issueCardTitle = new Label();
            issueLayout = new TableLayoutPanel();
            issueFieldsLayout = new TableLayoutPanel();
            comboBox_booksField = new TableLayoutPanel();
            comboBox_booksFieldLabel = new Label();
            comboBox_books = new ComboBox();
            dateTimePicker_loanField = new TableLayoutPanel();
            dateTimePicker_loanFieldLabel = new Label();
            dateTimePicker_loan = new PersianDatePicker();
            dateTimePicker_returnField = new TableLayoutPanel();
            dateTimePicker_returnFieldLabel = new Label();
            dateTimePicker_return = new PersianDatePicker();
            _bookStatus = new Label();
            issueActions = new FlowLayoutPanel();
            btn_save = new Button();
            btn_refresh_books = new Button();
            returnCard = new TableLayoutPanel();
            returnCardTitle = new Label();
            returnLayout = new TableLayoutPanel();
            returnFieldsLayout = new TableLayoutPanel();
            comboBox_Book_returnField = new TableLayoutPanel();
            comboBox_Book_returnFieldLabel = new Label();
            comboBox_Book_return = new ComboBox();
            dateTimePicker_ExpiredTimeField = new TableLayoutPanel();
            dateTimePicker_ExpiredTimeFieldLabel = new Label();
            dateTimePicker_ExpiredTime = new PersianDatePicker();
            dateTimePicker_returnBackField = new TableLayoutPanel();
            dateTimePicker_returnBackFieldLabel = new Label();
            dateTimePicker_returnBack = new PersianDatePicker();
            returnHint = new Label();
            returnActions = new FlowLayoutPanel();
            btn_return_save = new Button();
            viewportPanel = new Panel();
            rootLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            headingLayout.SuspendLayout();
            bodyLayout.SuspendLayout();
            memberCard.SuspendLayout();
            memberDetailsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_member).BeginInit();
            loanMemberIdField.SuspendLayout();
            loanMemberNameField.SuspendLayout();
            memberFlags.SuspendLayout();
            historyCard.SuspendLayout();
            historyLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_loans).BeginInit();
            loanActionsLayout.SuspendLayout();
            issueCard.SuspendLayout();
            issueLayout.SuspendLayout();
            issueFieldsLayout.SuspendLayout();
            comboBox_booksField.SuspendLayout();
            dateTimePicker_loanField.SuspendLayout();
            dateTimePicker_returnField.SuspendLayout();
            issueActions.SuspendLayout();
            returnCard.SuspendLayout();
            returnLayout.SuspendLayout();
            returnFieldsLayout.SuspendLayout();
            comboBox_Book_returnField.SuspendLayout();
            dateTimePicker_ExpiredTimeField.SuspendLayout();
            dateTimePicker_returnBackField.SuspendLayout();
            returnActions.SuspendLayout();
            viewportPanel.SuspendLayout();
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
            rootLayout.MinimumSize = new Size(0, 700);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new Padding(16);
            rootLayout.RightToLeft = RightToLeft.No;
            rootLayout.RowCount = 3;
            rootLayout.RowStyles.Add(new RowStyle());
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            rootLayout.Size = new Size(1292, 780);
            rootLayout.TabIndex = 0;
            rootLayout.Paint += rootLayout_Paint;
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
            headerLayout.Size = new Size(1260, 92);
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
            headingLayout.Size = new Size(1016, 68);
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
            headingLabel.Size = new Size(1016, 32);
            headingLabel.TabIndex = 3;
            headingLabel.Text = "امانت و برگشت کتاب";
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
            subtitleLabel.Size = new Size(1016, 36);
            subtitleLabel.TabIndex = 4;
            subtitleLabel.Text = "تاریخ شمسی، ثبت برگشت واقعی و حفظ تاریخچهٔ امانت";
            subtitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // footerLabel
            // 
            footerLabel.AutoEllipsis = true;
            footerLabel.Dock = DockStyle.Fill;
            footerLabel.Font = new Font("Tahoma", 9F);
            footerLabel.ForeColor = Color.FromArgb(94, 110, 132);
            footerLabel.Location = new Point(16, 740);
            footerLabel.Margin = new Padding(0);
            footerLabel.Name = "footerLabel";
            footerLabel.Padding = new Padding(4, 0, 4, 0);
            footerLabel.RightToLeft = RightToLeft.Yes;
            footerLabel.Size = new Size(1260, 24);
            footerLabel.TabIndex = 6;
            footerLabel.Text = "مدیریت کتابخانه  •  ثبت و پیگیری اطلاعات";
            footerLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bodyLayout
            // 
            bodyLayout.BackColor = Color.FromArgb(242, 245, 249);
            bodyLayout.ColumnCount = 1;
            bodyLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bodyLayout.Controls.Add(memberCard, 0, 0);
            bodyLayout.Controls.Add(historyCard, 0, 1);
            bodyLayout.Controls.Add(loanActionsLayout, 0, 2);
            bodyLayout.Dock = DockStyle.Fill;
            bodyLayout.Location = new Point(16, 120);
            bodyLayout.Margin = new Padding(0);
            bodyLayout.Name = "bodyLayout";
            bodyLayout.RightToLeft = RightToLeft.No;
            bodyLayout.RowCount = 3;
            bodyLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 193F));
            bodyLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bodyLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 223F));
            bodyLayout.Size = new Size(1260, 620);
            bodyLayout.TabIndex = 61;
            // 
            // memberCard
            // 
            memberCard.BackColor = Color.White;
            memberCard.ColumnCount = 1;
            memberCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            memberCard.Controls.Add(memberCardTitle, 0, 0);
            memberCard.Controls.Add(memberDetailsLayout, 0, 1);
            memberCard.Dock = DockStyle.Fill;
            memberCard.Location = new Point(6, 6);
            memberCard.Margin = new Padding(6);
            memberCard.Name = "memberCard";
            memberCard.Padding = new Padding(12);
            memberCard.RightToLeft = RightToLeft.No;
            memberCard.RowCount = 2;
            memberCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            memberCard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            memberCard.Size = new Size(1248, 181);
            memberCard.TabIndex = 20;
            // 
            // memberCardTitle
            // 
            memberCardTitle.AutoEllipsis = true;
            memberCardTitle.Dock = DockStyle.Fill;
            memberCardTitle.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            memberCardTitle.ForeColor = Color.FromArgb(25, 42, 66);
            memberCardTitle.Location = new Point(12, 12);
            memberCardTitle.Margin = new Padding(0);
            memberCardTitle.Name = "memberCardTitle";
            memberCardTitle.Padding = new Padding(4, 0, 4, 0);
            memberCardTitle.RightToLeft = RightToLeft.Yes;
            memberCardTitle.Size = new Size(1224, 32);
            memberCardTitle.TabIndex = 21;
            memberCardTitle.Text = "بازیابی عضو";
            memberCardTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // memberDetailsLayout
            // 
            memberDetailsLayout.BackColor = Color.White;
            memberDetailsLayout.ColumnCount = 4;
            memberDetailsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            memberDetailsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            memberDetailsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            memberDetailsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            memberDetailsLayout.Controls.Add(pictureBox_member, 0, 0);
            memberDetailsLayout.Controls.Add(loanMemberIdField, 1, 0);
            memberDetailsLayout.Controls.Add(loanMemberNameField, 2, 0);
            memberDetailsLayout.Controls.Add(memberFlags, 1, 1);
            memberDetailsLayout.Controls.Add(btn_reneview, 3, 0);
            memberDetailsLayout.Dock = DockStyle.Fill;
            memberDetailsLayout.Location = new Point(12, 44);
            memberDetailsLayout.Margin = new Padding(0);
            memberDetailsLayout.Name = "memberDetailsLayout";
            memberDetailsLayout.RightToLeft = RightToLeft.No;
            memberDetailsLayout.RowCount = 2;
            memberDetailsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            memberDetailsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            memberDetailsLayout.Size = new Size(1224, 125);
            memberDetailsLayout.TabIndex = 14;
            // 
            // pictureBox_member
            // 
            pictureBox_member.BackColor = Color.FromArgb(242, 245, 249);
            pictureBox_member.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_member.Cursor = Cursors.Hand;
            pictureBox_member.Dock = DockStyle.Fill;
            pictureBox_member.Location = new Point(4, 4);
            pictureBox_member.Margin = new Padding(4);
            pictureBox_member.Name = "pictureBox_member";
            pictureBox_member.RightToLeft = RightToLeft.Yes;
            memberDetailsLayout.SetRowSpan(pictureBox_member, 2);
            pictureBox_member.Size = new Size(96, 117);
            pictureBox_member.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_member.TabIndex = 8;
            pictureBox_member.TabStop = false;
            // 
            // loanMemberIdField
            // 
            loanMemberIdField.BackColor = Color.White;
            loanMemberIdField.ColumnCount = 1;
            loanMemberIdField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            loanMemberIdField.Controls.Add(loanMemberIdFieldLabel, 0, 0);
            loanMemberIdField.Controls.Add(txt_search_id, 0, 1);
            loanMemberIdField.Dock = DockStyle.Top;
            loanMemberIdField.Location = new Point(108, 0);
            loanMemberIdField.Margin = new Padding(4, 0, 4, 8);
            loanMemberIdField.Name = "loanMemberIdField";
            loanMemberIdField.RightToLeft = RightToLeft.No;
            loanMemberIdField.RowCount = 2;
            loanMemberIdField.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            loanMemberIdField.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            loanMemberIdField.Size = new Size(182, 58);
            loanMemberIdField.TabIndex = 15;
            // 
            // loanMemberIdFieldLabel
            // 
            loanMemberIdFieldLabel.AutoEllipsis = true;
            loanMemberIdFieldLabel.Dock = DockStyle.Fill;
            loanMemberIdFieldLabel.Font = new Font("Tahoma", 9F);
            loanMemberIdFieldLabel.ForeColor = Color.FromArgb(94, 110, 132);
            loanMemberIdFieldLabel.Location = new Point(0, 0);
            loanMemberIdFieldLabel.Margin = new Padding(0);
            loanMemberIdFieldLabel.Name = "loanMemberIdFieldLabel";
            loanMemberIdFieldLabel.Padding = new Padding(4, 0, 4, 0);
            loanMemberIdFieldLabel.RightToLeft = RightToLeft.Yes;
            loanMemberIdFieldLabel.Size = new Size(182, 24);
            loanMemberIdFieldLabel.TabIndex = 16;
            loanMemberIdFieldLabel.Text = "شماره عضویت";
            loanMemberIdFieldLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_search_id
            // 
            txt_search_id.BackColor = Color.White;
            txt_search_id.BorderStyle = BorderStyle.FixedSingle;
            txt_search_id.Dock = DockStyle.Fill;
            txt_search_id.ForeColor = Color.FromArgb(25, 42, 66);
            txt_search_id.Location = new Point(0, 27);
            txt_search_id.Margin = new Padding(0, 3, 18, 3);
            txt_search_id.MaxLength = 10;
            txt_search_id.Name = "txt_search_id";
            txt_search_id.PlaceholderText = "شماره عضویت";
            txt_search_id.RightToLeft = RightToLeft.No;
            txt_search_id.Size = new Size(164, 28);
            txt_search_id.TabIndex = 9;
            // 
            // loanMemberNameField
            // 
            loanMemberNameField.BackColor = Color.White;
            loanMemberNameField.ColumnCount = 1;
            loanMemberNameField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            loanMemberNameField.Controls.Add(loanMemberNameFieldLabel, 0, 0);
            loanMemberNameField.Controls.Add(txt_family, 0, 1);
            loanMemberNameField.Dock = DockStyle.Top;
            loanMemberNameField.Location = new Point(298, 0);
            loanMemberNameField.Margin = new Padding(4, 0, 4, 8);
            loanMemberNameField.Name = "loanMemberNameField";
            loanMemberNameField.RightToLeft = RightToLeft.No;
            loanMemberNameField.RowCount = 2;
            loanMemberNameField.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            loanMemberNameField.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            loanMemberNameField.Size = new Size(778, 58);
            loanMemberNameField.TabIndex = 17;
            // 
            // loanMemberNameFieldLabel
            // 
            loanMemberNameFieldLabel.AutoEllipsis = true;
            loanMemberNameFieldLabel.Dock = DockStyle.Fill;
            loanMemberNameFieldLabel.Font = new Font("Tahoma", 9F);
            loanMemberNameFieldLabel.ForeColor = Color.FromArgb(94, 110, 132);
            loanMemberNameFieldLabel.Location = new Point(0, 0);
            loanMemberNameFieldLabel.Margin = new Padding(0);
            loanMemberNameFieldLabel.Name = "loanMemberNameFieldLabel";
            loanMemberNameFieldLabel.Padding = new Padding(4, 0, 4, 0);
            loanMemberNameFieldLabel.RightToLeft = RightToLeft.Yes;
            loanMemberNameFieldLabel.Size = new Size(778, 24);
            loanMemberNameFieldLabel.TabIndex = 18;
            loanMemberNameFieldLabel.Text = "نام و نام خانوادگی";
            loanMemberNameFieldLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_family
            // 
            txt_family.BackColor = Color.FromArgb(242, 245, 249);
            txt_family.BorderStyle = BorderStyle.FixedSingle;
            txt_family.Dock = DockStyle.Fill;
            txt_family.ForeColor = Color.FromArgb(25, 42, 66);
            txt_family.Location = new Point(0, 27);
            txt_family.Margin = new Padding(0, 3, 18, 3);
            txt_family.MaxLength = 60;
            txt_family.Name = "txt_family";
            txt_family.ReadOnly = true;
            txt_family.RightToLeft = RightToLeft.Yes;
            txt_family.Size = new Size(760, 28);
            txt_family.TabIndex = 10;
            txt_family.TextAlign = HorizontalAlignment.Right;
            // 
            // memberFlags
            // 
            memberFlags.AutoSize = true;
            memberFlags.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            memberDetailsLayout.SetColumnSpan(memberFlags, 3);
            memberFlags.Controls.Add(checkBox_status);
            memberFlags.Controls.Add(checkBox_isSpecial);
            memberFlags.Dock = DockStyle.Top;
            memberFlags.FlowDirection = FlowDirection.RightToLeft;
            memberFlags.Location = new Point(104, 66);
            memberFlags.Margin = new Padding(0);
            memberFlags.Name = "memberFlags";
            memberFlags.Padding = new Padding(0, 4, 0, 4);
            memberFlags.RightToLeft = RightToLeft.No;
            memberFlags.Size = new Size(1120, 45);
            memberFlags.TabIndex = 19;
            // 
            // checkBox_status
            // 
            checkBox_status.AutoSize = true;
            checkBox_status.Enabled = false;
            checkBox_status.Location = new Point(1017, 10);
            checkBox_status.Margin = new Padding(4, 6, 4, 6);
            checkBox_status.Name = "checkBox_status";
            checkBox_status.RightToLeft = RightToLeft.Yes;
            checkBox_status.Size = new Size(99, 25);
            checkBox_status.TabIndex = 12;
            checkBox_status.Text = "عضو فعال";
            // 
            // checkBox_isSpecial
            // 
            checkBox_isSpecial.AutoSize = true;
            checkBox_isSpecial.Enabled = false;
            checkBox_isSpecial.Location = new Point(893, 10);
            checkBox_isSpecial.Margin = new Padding(4, 6, 4, 6);
            checkBox_isSpecial.Name = "checkBox_isSpecial";
            checkBox_isSpecial.RightToLeft = RightToLeft.Yes;
            checkBox_isSpecial.Size = new Size(116, 25);
            checkBox_isSpecial.TabIndex = 13;
            checkBox_isSpecial.Text = "عضویت ویژه";
            // 
            // btn_reneview
            // 
            btn_reneview.Anchor = AnchorStyles.Right;
            btn_reneview.BackColor = Color.FromArgb(12, 120, 113);
            btn_reneview.Cursor = Cursors.Hand;
            btn_reneview.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            btn_reneview.FlatAppearance.BorderSize = 0;
            btn_reneview.FlatStyle = FlatStyle.Flat;
            btn_reneview.ForeColor = Color.White;
            btn_reneview.Location = new Point(1092, 13);
            btn_reneview.Margin = new Padding(4);
            btn_reneview.MinimumSize = new Size(112, 38);
            btn_reneview.Name = "btn_reneview";
            btn_reneview.RightToLeft = RightToLeft.Yes;
            btn_reneview.Size = new Size(128, 40);
            btn_reneview.TabIndex = 11;
            btn_reneview.Text = "بازیابی عضو";
            btn_reneview.UseVisualStyleBackColor = false;
            btn_reneview.Click += btn_reneview_Click;
            // 
            // historyCard
            // 
            historyCard.BackColor = Color.White;
            historyCard.ColumnCount = 1;
            historyCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            historyCard.Controls.Add(historyCardTitle, 0, 0);
            historyCard.Controls.Add(historyLayout, 0, 1);
            historyCard.Dock = DockStyle.Fill;
            historyCard.Location = new Point(6, 199);
            historyCard.Margin = new Padding(6);
            historyCard.Name = "historyCard";
            historyCard.Padding = new Padding(12);
            historyCard.RightToLeft = RightToLeft.No;
            historyCard.RowCount = 2;
            historyCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            historyCard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            historyCard.Size = new Size(1248, 192);
            historyCard.TabIndex = 25;
            // 
            // historyCardTitle
            // 
            historyCardTitle.AutoEllipsis = true;
            historyCardTitle.Dock = DockStyle.Fill;
            historyCardTitle.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            historyCardTitle.ForeColor = Color.FromArgb(25, 42, 66);
            historyCardTitle.Location = new Point(12, 12);
            historyCardTitle.Margin = new Padding(0);
            historyCardTitle.Name = "historyCardTitle";
            historyCardTitle.Padding = new Padding(4, 0, 4, 0);
            historyCardTitle.RightToLeft = RightToLeft.Yes;
            historyCardTitle.Size = new Size(1224, 32);
            historyCardTitle.TabIndex = 26;
            historyCardTitle.Text = "تاریخچهٔ امانت‌ها";
            historyCardTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // historyLayout
            // 
            historyLayout.BackColor = Color.White;
            historyLayout.ColumnCount = 1;
            historyLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            historyLayout.Controls.Add(dataGridView_loans, 0, 0);
            historyLayout.Controls.Add(_loanStatus, 0, 1);
            historyLayout.Dock = DockStyle.Fill;
            historyLayout.Location = new Point(12, 44);
            historyLayout.Margin = new Padding(0);
            historyLayout.Name = "historyLayout";
            historyLayout.RightToLeft = RightToLeft.No;
            historyLayout.RowCount = 2;
            historyLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            historyLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            historyLayout.Size = new Size(1224, 136);
            historyLayout.TabIndex = 24;
            // 
            // dataGridView_loans
            // 
            dataGridView_loans.AllowUserToAddRows = false;
            dataGridView_loans.AllowUserToDeleteRows = false;
            dataGridView_loans.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 251, 253);
            dataGridView_loans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_loans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_loans.BackgroundColor = Color.White;
            dataGridView_loans.BorderStyle = BorderStyle.None;
            dataGridView_loans.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_loans.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 245, 249);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(25, 42, 66);
            dataGridViewCellStyle2.Padding = new Padding(6);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_loans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_loans.ColumnHeadersHeight = 42;
            dataGridView_loans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(25, 42, 66);
            dataGridViewCellStyle3.NullValue = "—";
            dataGridViewCellStyle3.Padding = new Padding(6);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 242, 238);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(25, 42, 66);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_loans.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_loans.Dock = DockStyle.Fill;
            dataGridView_loans.EnableHeadersVisualStyles = false;
            dataGridView_loans.GridColor = Color.FromArgb(222, 230, 239);
            dataGridView_loans.Location = new Point(0, 0);
            dataGridView_loans.Margin = new Padding(0);
            dataGridView_loans.MultiSelect = false;
            dataGridView_loans.Name = "dataGridView_loans";
            dataGridView_loans.ReadOnly = true;
            dataGridView_loans.RightToLeft = RightToLeft.Yes;
            dataGridView_loans.RowHeadersVisible = false;
            dataGridView_loans.RowHeadersWidth = 51;
            dataGridView_loans.RowTemplate.Height = 36;
            dataGridView_loans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_loans.Size = new Size(1224, 106);
            dataGridView_loans.TabIndex = 22;
            dataGridView_loans.Tag = "loans";
            dataGridView_loans.CellClick += dataGridView_loans_CellClick;
            // 
            // _loanStatus
            // 
            _loanStatus.AutoEllipsis = true;
            _loanStatus.Dock = DockStyle.Fill;
            _loanStatus.Font = new Font("Tahoma", 9F);
            _loanStatus.ForeColor = Color.FromArgb(94, 110, 132);
            _loanStatus.Location = new Point(0, 106);
            _loanStatus.Margin = new Padding(0);
            _loanStatus.Name = "_loanStatus";
            _loanStatus.Padding = new Padding(4, 0, 4, 0);
            _loanStatus.RightToLeft = RightToLeft.Yes;
            _loanStatus.Size = new Size(1224, 30);
            _loanStatus.TabIndex = 23;
            _loanStatus.Text = "عضو را بازیابی کنید تا سابقهٔ امانت نمایش داده شود.";
            _loanStatus.TextAlign = ContentAlignment.MiddleRight;
            _loanStatus.Click += _loanStatus_Click;
            // 
            // loanActionsLayout
            // 
            loanActionsLayout.BackColor = Color.FromArgb(242, 245, 249);
            loanActionsLayout.ColumnCount = 2;
            loanActionsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            loanActionsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            loanActionsLayout.Controls.Add(issueCard, 0, 0);
            loanActionsLayout.Controls.Add(returnCard, 1, 0);
            loanActionsLayout.Dock = DockStyle.Fill;
            loanActionsLayout.Location = new Point(0, 397);
            loanActionsLayout.Margin = new Padding(0);
            loanActionsLayout.Name = "loanActionsLayout";
            loanActionsLayout.RightToLeft = RightToLeft.No;
            loanActionsLayout.RowCount = 1;
            loanActionsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            loanActionsLayout.Size = new Size(1260, 223);
            loanActionsLayout.TabIndex = 60;
            // 
            // issueCard
            // 
            issueCard.BackColor = Color.White;
            issueCard.ColumnCount = 1;
            issueCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            issueCard.Controls.Add(issueCardTitle, 0, 0);
            issueCard.Controls.Add(issueLayout, 0, 1);
            issueCard.Dock = DockStyle.Fill;
            issueCard.Location = new Point(6, 6);
            issueCard.Margin = new Padding(6);
            issueCard.Name = "issueCard";
            issueCard.Padding = new Padding(12);
            issueCard.RightToLeft = RightToLeft.No;
            issueCard.RowCount = 2;
            issueCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            issueCard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            issueCard.Size = new Size(618, 211);
            issueCard.TabIndex = 42;
            // 
            // issueCardTitle
            // 
            issueCardTitle.AutoEllipsis = true;
            issueCardTitle.Dock = DockStyle.Fill;
            issueCardTitle.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            issueCardTitle.ForeColor = Color.FromArgb(25, 42, 66);
            issueCardTitle.Location = new Point(12, 12);
            issueCardTitle.Margin = new Padding(0);
            issueCardTitle.Name = "issueCardTitle";
            issueCardTitle.Padding = new Padding(4, 0, 4, 0);
            issueCardTitle.RightToLeft = RightToLeft.Yes;
            issueCardTitle.Size = new Size(594, 32);
            issueCardTitle.TabIndex = 43;
            issueCardTitle.Text = "امانت جدید";
            issueCardTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // issueLayout
            // 
            issueLayout.AutoSize = true;
            issueLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            issueLayout.BackColor = Color.White;
            issueLayout.ColumnCount = 1;
            issueLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            issueLayout.Controls.Add(issueFieldsLayout, 0, 0);
            issueLayout.Controls.Add(_bookStatus, 0, 1);
            issueLayout.Controls.Add(issueActions, 0, 2);
            issueLayout.Dock = DockStyle.Top;
            issueLayout.Location = new Point(12, 44);
            issueLayout.Margin = new Padding(0);
            issueLayout.Name = "issueLayout";
            issueLayout.Padding = new Padding(4);
            issueLayout.RightToLeft = RightToLeft.No;
            issueLayout.RowCount = 3;
            issueLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            issueLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            issueLayout.RowStyles.Add(new RowStyle());
            issueLayout.Size = new Size(594, 155);
            issueLayout.TabIndex = 41;
            // 
            // issueFieldsLayout
            // 
            issueFieldsLayout.BackColor = Color.White;
            issueFieldsLayout.ColumnCount = 3;
            issueFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            issueFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            issueFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            issueFieldsLayout.Controls.Add(comboBox_booksField, 0, 0);
            issueFieldsLayout.Controls.Add(dateTimePicker_loanField, 1, 0);
            issueFieldsLayout.Controls.Add(dateTimePicker_returnField, 2, 0);
            issueFieldsLayout.Dock = DockStyle.Fill;
            issueFieldsLayout.Location = new Point(4, 4);
            issueFieldsLayout.Margin = new Padding(0);
            issueFieldsLayout.Name = "issueFieldsLayout";
            issueFieldsLayout.RightToLeft = RightToLeft.No;
            issueFieldsLayout.RowCount = 1;
            issueFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            issueFieldsLayout.Size = new Size(586, 76);
            issueFieldsLayout.TabIndex = 30;
            // 
            // comboBox_booksField
            // 
            comboBox_booksField.BackColor = Color.White;
            comboBox_booksField.ColumnCount = 1;
            comboBox_booksField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            comboBox_booksField.Controls.Add(comboBox_booksFieldLabel, 0, 0);
            comboBox_booksField.Controls.Add(comboBox_books, 0, 1);
            comboBox_booksField.Dock = DockStyle.Top;
            comboBox_booksField.Location = new Point(4, 0);
            comboBox_booksField.Margin = new Padding(4, 0, 4, 8);
            comboBox_booksField.Name = "comboBox_booksField";
            comboBox_booksField.RightToLeft = RightToLeft.No;
            comboBox_booksField.RowCount = 2;
            comboBox_booksField.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            comboBox_booksField.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            comboBox_booksField.Size = new Size(187, 64);
            comboBox_booksField.TabIndex = 31;
            // 
            // comboBox_booksFieldLabel
            // 
            comboBox_booksFieldLabel.AutoEllipsis = true;
            comboBox_booksFieldLabel.Dock = DockStyle.Fill;
            comboBox_booksFieldLabel.Font = new Font("Tahoma", 9F);
            comboBox_booksFieldLabel.ForeColor = Color.FromArgb(94, 110, 132);
            comboBox_booksFieldLabel.Location = new Point(0, 0);
            comboBox_booksFieldLabel.Margin = new Padding(0);
            comboBox_booksFieldLabel.Name = "comboBox_booksFieldLabel";
            comboBox_booksFieldLabel.Padding = new Padding(4, 0, 4, 0);
            comboBox_booksFieldLabel.RightToLeft = RightToLeft.Yes;
            comboBox_booksFieldLabel.Size = new Size(187, 24);
            comboBox_booksFieldLabel.TabIndex = 32;
            comboBox_booksFieldLabel.Text = "کتاب قابل امانت";
            comboBox_booksFieldLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBox_books
            // 
            comboBox_books.Dock = DockStyle.Fill;
            comboBox_books.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_books.FlatStyle = FlatStyle.Flat;
            comboBox_books.FormattingEnabled = true;
            comboBox_books.Location = new Point(0, 27);
            comboBox_books.Margin = new Padding(0, 3, 0, 3);
            comboBox_books.Name = "comboBox_books";
            comboBox_books.RightToLeft = RightToLeft.Yes;
            comboBox_books.Size = new Size(187, 29);
            comboBox_books.TabIndex = 27;
            // 
            // dateTimePicker_loanField
            // 
            dateTimePicker_loanField.BackColor = Color.White;
            dateTimePicker_loanField.ColumnCount = 1;
            dateTimePicker_loanField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            dateTimePicker_loanField.Controls.Add(dateTimePicker_loanFieldLabel, 0, 0);
            dateTimePicker_loanField.Controls.Add(dateTimePicker_loan, 0, 1);
            dateTimePicker_loanField.Dock = DockStyle.Top;
            dateTimePicker_loanField.Location = new Point(199, 0);
            dateTimePicker_loanField.Margin = new Padding(4, 0, 4, 8);
            dateTimePicker_loanField.Name = "dateTimePicker_loanField";
            dateTimePicker_loanField.RightToLeft = RightToLeft.No;
            dateTimePicker_loanField.RowCount = 2;
            dateTimePicker_loanField.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            dateTimePicker_loanField.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            dateTimePicker_loanField.Size = new Size(187, 64);
            dateTimePicker_loanField.TabIndex = 33;
            // 
            // dateTimePicker_loanFieldLabel
            // 
            dateTimePicker_loanFieldLabel.AutoEllipsis = true;
            dateTimePicker_loanFieldLabel.Dock = DockStyle.Fill;
            dateTimePicker_loanFieldLabel.Font = new Font("Tahoma", 9F);
            dateTimePicker_loanFieldLabel.ForeColor = Color.FromArgb(94, 110, 132);
            dateTimePicker_loanFieldLabel.Location = new Point(0, 0);
            dateTimePicker_loanFieldLabel.Margin = new Padding(0);
            dateTimePicker_loanFieldLabel.Name = "dateTimePicker_loanFieldLabel";
            dateTimePicker_loanFieldLabel.Padding = new Padding(4, 0, 4, 0);
            dateTimePicker_loanFieldLabel.RightToLeft = RightToLeft.Yes;
            dateTimePicker_loanFieldLabel.Size = new Size(187, 24);
            dateTimePicker_loanFieldLabel.TabIndex = 34;
            dateTimePicker_loanFieldLabel.Text = "تاریخ امانت";
            dateTimePicker_loanFieldLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker_loan
            // 
            dateTimePicker_loan.BackColor = Color.White;
            dateTimePicker_loan.Dock = DockStyle.Fill;
            dateTimePicker_loan.Font = new Font("Tahoma", 10F);
            dateTimePicker_loan.ForeColor = Color.FromArgb(25, 42, 66);
            dateTimePicker_loan.Location = new Point(0, 26);
            dateTimePicker_loan.Margin = new Padding(0, 2, 0, 2);
            dateTimePicker_loan.MinimumSize = new Size(140, 32);
            dateTimePicker_loan.Name = "dateTimePicker_loan";
            dateTimePicker_loan.RightToLeft = RightToLeft.Yes;
            dateTimePicker_loan.Size = new Size(187, 36);
            dateTimePicker_loan.TabIndex = 28;
            // 
            // dateTimePicker_returnField
            // 
            dateTimePicker_returnField.BackColor = Color.White;
            dateTimePicker_returnField.ColumnCount = 1;
            dateTimePicker_returnField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            dateTimePicker_returnField.Controls.Add(dateTimePicker_returnFieldLabel, 0, 0);
            dateTimePicker_returnField.Controls.Add(dateTimePicker_return, 0, 1);
            dateTimePicker_returnField.Dock = DockStyle.Top;
            dateTimePicker_returnField.Location = new Point(394, 0);
            dateTimePicker_returnField.Margin = new Padding(4, 0, 4, 8);
            dateTimePicker_returnField.Name = "dateTimePicker_returnField";
            dateTimePicker_returnField.RightToLeft = RightToLeft.No;
            dateTimePicker_returnField.RowCount = 2;
            dateTimePicker_returnField.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            dateTimePicker_returnField.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            dateTimePicker_returnField.Size = new Size(188, 64);
            dateTimePicker_returnField.TabIndex = 35;
            // 
            // dateTimePicker_returnFieldLabel
            // 
            dateTimePicker_returnFieldLabel.AutoEllipsis = true;
            dateTimePicker_returnFieldLabel.Dock = DockStyle.Fill;
            dateTimePicker_returnFieldLabel.Font = new Font("Tahoma", 9F);
            dateTimePicker_returnFieldLabel.ForeColor = Color.FromArgb(94, 110, 132);
            dateTimePicker_returnFieldLabel.Location = new Point(0, 0);
            dateTimePicker_returnFieldLabel.Margin = new Padding(0);
            dateTimePicker_returnFieldLabel.Name = "dateTimePicker_returnFieldLabel";
            dateTimePicker_returnFieldLabel.Padding = new Padding(4, 0, 4, 0);
            dateTimePicker_returnFieldLabel.RightToLeft = RightToLeft.Yes;
            dateTimePicker_returnFieldLabel.Size = new Size(188, 24);
            dateTimePicker_returnFieldLabel.TabIndex = 36;
            dateTimePicker_returnFieldLabel.Text = "موعد تحویل";
            dateTimePicker_returnFieldLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker_return
            // 
            dateTimePicker_return.BackColor = Color.White;
            dateTimePicker_return.Dock = DockStyle.Fill;
            dateTimePicker_return.Font = new Font("Tahoma", 10F);
            dateTimePicker_return.ForeColor = Color.FromArgb(25, 42, 66);
            dateTimePicker_return.Location = new Point(0, 26);
            dateTimePicker_return.Margin = new Padding(0, 2, 0, 2);
            dateTimePicker_return.MinimumSize = new Size(140, 32);
            dateTimePicker_return.Name = "dateTimePicker_return";
            dateTimePicker_return.RightToLeft = RightToLeft.Yes;
            dateTimePicker_return.Size = new Size(188, 36);
            dateTimePicker_return.TabIndex = 29;
            // 
            // _bookStatus
            // 
            _bookStatus.AutoEllipsis = true;
            _bookStatus.Dock = DockStyle.Fill;
            _bookStatus.Font = new Font("Tahoma", 9F);
            _bookStatus.ForeColor = Color.FromArgb(94, 110, 132);
            _bookStatus.Location = new Point(4, 80);
            _bookStatus.Margin = new Padding(0);
            _bookStatus.Name = "_bookStatus";
            _bookStatus.Padding = new Padding(4, 0, 4, 0);
            _bookStatus.RightToLeft = RightToLeft.Yes;
            _bookStatus.Size = new Size(586, 28);
            _bookStatus.TabIndex = 39;
            _bookStatus.Text = "کتاب‌های قابل امانت پس از بارگذاری نمایش داده می‌شوند.";
            _bookStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // issueActions
            // 
            issueActions.AutoSize = true;
            issueActions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            issueActions.Controls.Add(btn_save);
            issueActions.Controls.Add(btn_refresh_books);
            issueActions.Dock = DockStyle.Top;
            issueActions.FlowDirection = FlowDirection.RightToLeft;
            issueActions.Location = new Point(4, 108);
            issueActions.Margin = new Padding(0);
            issueActions.MaximumSize = new Size(410, 0);
            issueActions.Name = "issueActions";
            issueActions.Padding = new Padding(0, 4, 0, 4);
            issueActions.RightToLeft = RightToLeft.No;
            issueActions.Size = new Size(410, 56);
            issueActions.TabIndex = 40;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(12, 120, 113);
            btn_save.Cursor = Cursors.Hand;
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(278, 8);
            btn_save.Margin = new Padding(4);
            btn_save.MinimumSize = new Size(112, 38);
            btn_save.Name = "btn_save";
            btn_save.RightToLeft = RightToLeft.Yes;
            btn_save.Size = new Size(128, 40);
            btn_save.TabIndex = 37;
            btn_save.Text = "ثبت امانت";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_refresh_books
            // 
            btn_refresh_books.BackColor = Color.White;
            btn_refresh_books.Cursor = Cursors.Hand;
            btn_refresh_books.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            btn_refresh_books.FlatStyle = FlatStyle.Flat;
            btn_refresh_books.ForeColor = Color.FromArgb(25, 42, 66);
            btn_refresh_books.Location = new Point(142, 8);
            btn_refresh_books.Margin = new Padding(4);
            btn_refresh_books.MinimumSize = new Size(112, 38);
            btn_refresh_books.Name = "btn_refresh_books";
            btn_refresh_books.RightToLeft = RightToLeft.Yes;
            btn_refresh_books.Size = new Size(128, 40);
            btn_refresh_books.TabIndex = 38;
            btn_refresh_books.Text = "تازه‌سازی کتاب‌ها";
            btn_refresh_books.UseVisualStyleBackColor = false;
            btn_refresh_books.Click += RefreshBooks_Click;
            // 
            // returnCard
            // 
            returnCard.BackColor = Color.White;
            returnCard.ColumnCount = 1;
            returnCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            returnCard.Controls.Add(returnCardTitle, 0, 0);
            returnCard.Controls.Add(returnLayout, 0, 1);
            returnCard.Dock = DockStyle.Fill;
            returnCard.Location = new Point(636, 6);
            returnCard.Margin = new Padding(6);
            returnCard.Name = "returnCard";
            returnCard.Padding = new Padding(12);
            returnCard.RightToLeft = RightToLeft.No;
            returnCard.RowCount = 2;
            returnCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            returnCard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            returnCard.Size = new Size(618, 211);
            returnCard.TabIndex = 58;
            // 
            // returnCardTitle
            // 
            returnCardTitle.AutoEllipsis = true;
            returnCardTitle.Dock = DockStyle.Fill;
            returnCardTitle.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            returnCardTitle.ForeColor = Color.FromArgb(25, 42, 66);
            returnCardTitle.Location = new Point(12, 12);
            returnCardTitle.Margin = new Padding(0);
            returnCardTitle.Name = "returnCardTitle";
            returnCardTitle.Padding = new Padding(4, 0, 4, 0);
            returnCardTitle.RightToLeft = RightToLeft.Yes;
            returnCardTitle.Size = new Size(594, 32);
            returnCardTitle.TabIndex = 59;
            returnCardTitle.Text = "برگشت کتاب";
            returnCardTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // returnLayout
            // 
            returnLayout.AutoSize = true;
            returnLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            returnLayout.BackColor = Color.White;
            returnLayout.ColumnCount = 1;
            returnLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            returnLayout.Controls.Add(returnFieldsLayout, 0, 0);
            returnLayout.Controls.Add(returnHint, 0, 1);
            returnLayout.Controls.Add(returnActions, 0, 2);
            returnLayout.Dock = DockStyle.Top;
            returnLayout.Location = new Point(12, 44);
            returnLayout.Margin = new Padding(0);
            returnLayout.Name = "returnLayout";
            returnLayout.Padding = new Padding(4);
            returnLayout.RightToLeft = RightToLeft.No;
            returnLayout.RowCount = 3;
            returnLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            returnLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            returnLayout.RowStyles.Add(new RowStyle());
            returnLayout.Size = new Size(594, 155);
            returnLayout.TabIndex = 57;
            // 
            // returnFieldsLayout
            // 
            returnFieldsLayout.BackColor = Color.White;
            returnFieldsLayout.ColumnCount = 3;
            returnFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            returnFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            returnFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            returnFieldsLayout.Controls.Add(comboBox_Book_returnField, 0, 0);
            returnFieldsLayout.Controls.Add(dateTimePicker_ExpiredTimeField, 1, 0);
            returnFieldsLayout.Controls.Add(dateTimePicker_returnBackField, 2, 0);
            returnFieldsLayout.Dock = DockStyle.Fill;
            returnFieldsLayout.Location = new Point(4, 4);
            returnFieldsLayout.Margin = new Padding(0);
            returnFieldsLayout.Name = "returnFieldsLayout";
            returnFieldsLayout.RightToLeft = RightToLeft.No;
            returnFieldsLayout.RowCount = 1;
            returnFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            returnFieldsLayout.Size = new Size(586, 76);
            returnFieldsLayout.TabIndex = 47;
            // 
            // comboBox_Book_returnField
            // 
            comboBox_Book_returnField.BackColor = Color.White;
            comboBox_Book_returnField.ColumnCount = 1;
            comboBox_Book_returnField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            comboBox_Book_returnField.Controls.Add(comboBox_Book_returnFieldLabel, 0, 0);
            comboBox_Book_returnField.Controls.Add(comboBox_Book_return, 0, 1);
            comboBox_Book_returnField.Dock = DockStyle.Top;
            comboBox_Book_returnField.Location = new Point(4, 0);
            comboBox_Book_returnField.Margin = new Padding(4, 0, 4, 8);
            comboBox_Book_returnField.Name = "comboBox_Book_returnField";
            comboBox_Book_returnField.RightToLeft = RightToLeft.No;
            comboBox_Book_returnField.RowCount = 2;
            comboBox_Book_returnField.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            comboBox_Book_returnField.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            comboBox_Book_returnField.Size = new Size(187, 64);
            comboBox_Book_returnField.TabIndex = 48;
            // 
            // comboBox_Book_returnFieldLabel
            // 
            comboBox_Book_returnFieldLabel.AutoEllipsis = true;
            comboBox_Book_returnFieldLabel.Dock = DockStyle.Fill;
            comboBox_Book_returnFieldLabel.Font = new Font("Tahoma", 9F);
            comboBox_Book_returnFieldLabel.ForeColor = Color.FromArgb(94, 110, 132);
            comboBox_Book_returnFieldLabel.Location = new Point(0, 0);
            comboBox_Book_returnFieldLabel.Margin = new Padding(0);
            comboBox_Book_returnFieldLabel.Name = "comboBox_Book_returnFieldLabel";
            comboBox_Book_returnFieldLabel.Padding = new Padding(4, 0, 4, 0);
            comboBox_Book_returnFieldLabel.RightToLeft = RightToLeft.Yes;
            comboBox_Book_returnFieldLabel.Size = new Size(187, 24);
            comboBox_Book_returnFieldLabel.TabIndex = 49;
            comboBox_Book_returnFieldLabel.Text = "کتاب انتخاب‌شده";
            comboBox_Book_returnFieldLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBox_Book_return
            // 
            comboBox_Book_return.Dock = DockStyle.Fill;
            comboBox_Book_return.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Book_return.Enabled = false;
            comboBox_Book_return.FlatStyle = FlatStyle.Flat;
            comboBox_Book_return.FormattingEnabled = true;
            comboBox_Book_return.Location = new Point(0, 27);
            comboBox_Book_return.Margin = new Padding(0, 3, 0, 3);
            comboBox_Book_return.Name = "comboBox_Book_return";
            comboBox_Book_return.RightToLeft = RightToLeft.Yes;
            comboBox_Book_return.Size = new Size(187, 29);
            comboBox_Book_return.TabIndex = 44;
            // 
            // dateTimePicker_ExpiredTimeField
            // 
            dateTimePicker_ExpiredTimeField.BackColor = Color.White;
            dateTimePicker_ExpiredTimeField.ColumnCount = 1;
            dateTimePicker_ExpiredTimeField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            dateTimePicker_ExpiredTimeField.Controls.Add(dateTimePicker_ExpiredTimeFieldLabel, 0, 0);
            dateTimePicker_ExpiredTimeField.Controls.Add(dateTimePicker_ExpiredTime, 0, 1);
            dateTimePicker_ExpiredTimeField.Dock = DockStyle.Top;
            dateTimePicker_ExpiredTimeField.Location = new Point(199, 0);
            dateTimePicker_ExpiredTimeField.Margin = new Padding(4, 0, 4, 8);
            dateTimePicker_ExpiredTimeField.Name = "dateTimePicker_ExpiredTimeField";
            dateTimePicker_ExpiredTimeField.RightToLeft = RightToLeft.No;
            dateTimePicker_ExpiredTimeField.RowCount = 2;
            dateTimePicker_ExpiredTimeField.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            dateTimePicker_ExpiredTimeField.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            dateTimePicker_ExpiredTimeField.Size = new Size(187, 64);
            dateTimePicker_ExpiredTimeField.TabIndex = 50;
            // 
            // dateTimePicker_ExpiredTimeFieldLabel
            // 
            dateTimePicker_ExpiredTimeFieldLabel.AutoEllipsis = true;
            dateTimePicker_ExpiredTimeFieldLabel.Dock = DockStyle.Fill;
            dateTimePicker_ExpiredTimeFieldLabel.Font = new Font("Tahoma", 9F);
            dateTimePicker_ExpiredTimeFieldLabel.ForeColor = Color.FromArgb(94, 110, 132);
            dateTimePicker_ExpiredTimeFieldLabel.Location = new Point(0, 0);
            dateTimePicker_ExpiredTimeFieldLabel.Margin = new Padding(0);
            dateTimePicker_ExpiredTimeFieldLabel.Name = "dateTimePicker_ExpiredTimeFieldLabel";
            dateTimePicker_ExpiredTimeFieldLabel.Padding = new Padding(4, 0, 4, 0);
            dateTimePicker_ExpiredTimeFieldLabel.RightToLeft = RightToLeft.Yes;
            dateTimePicker_ExpiredTimeFieldLabel.Size = new Size(187, 24);
            dateTimePicker_ExpiredTimeFieldLabel.TabIndex = 51;
            dateTimePicker_ExpiredTimeFieldLabel.Text = "موعد تحویل";
            dateTimePicker_ExpiredTimeFieldLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker_ExpiredTime
            // 
            dateTimePicker_ExpiredTime.BackColor = Color.White;
            dateTimePicker_ExpiredTime.Dock = DockStyle.Fill;
            dateTimePicker_ExpiredTime.Font = new Font("Tahoma", 10F);
            dateTimePicker_ExpiredTime.ForeColor = Color.FromArgb(25, 42, 66);
            dateTimePicker_ExpiredTime.Location = new Point(0, 26);
            dateTimePicker_ExpiredTime.Margin = new Padding(0, 2, 0, 2);
            dateTimePicker_ExpiredTime.MinimumSize = new Size(140, 32);
            dateTimePicker_ExpiredTime.Name = "dateTimePicker_ExpiredTime";
            dateTimePicker_ExpiredTime.ReadOnly = true;
            dateTimePicker_ExpiredTime.RightToLeft = RightToLeft.Yes;
            dateTimePicker_ExpiredTime.Size = new Size(187, 36);
            dateTimePicker_ExpiredTime.TabIndex = 45;
            // 
            // dateTimePicker_returnBackField
            // 
            dateTimePicker_returnBackField.BackColor = Color.White;
            dateTimePicker_returnBackField.ColumnCount = 1;
            dateTimePicker_returnBackField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            dateTimePicker_returnBackField.Controls.Add(dateTimePicker_returnBackFieldLabel, 0, 0);
            dateTimePicker_returnBackField.Controls.Add(dateTimePicker_returnBack, 0, 1);
            dateTimePicker_returnBackField.Dock = DockStyle.Top;
            dateTimePicker_returnBackField.Location = new Point(394, 0);
            dateTimePicker_returnBackField.Margin = new Padding(4, 0, 4, 8);
            dateTimePicker_returnBackField.Name = "dateTimePicker_returnBackField";
            dateTimePicker_returnBackField.RightToLeft = RightToLeft.No;
            dateTimePicker_returnBackField.RowCount = 2;
            dateTimePicker_returnBackField.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            dateTimePicker_returnBackField.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            dateTimePicker_returnBackField.Size = new Size(188, 64);
            dateTimePicker_returnBackField.TabIndex = 52;
            // 
            // dateTimePicker_returnBackFieldLabel
            // 
            dateTimePicker_returnBackFieldLabel.AutoEllipsis = true;
            dateTimePicker_returnBackFieldLabel.Dock = DockStyle.Fill;
            dateTimePicker_returnBackFieldLabel.Font = new Font("Tahoma", 9F);
            dateTimePicker_returnBackFieldLabel.ForeColor = Color.FromArgb(94, 110, 132);
            dateTimePicker_returnBackFieldLabel.Location = new Point(0, 0);
            dateTimePicker_returnBackFieldLabel.Margin = new Padding(0);
            dateTimePicker_returnBackFieldLabel.Name = "dateTimePicker_returnBackFieldLabel";
            dateTimePicker_returnBackFieldLabel.Padding = new Padding(4, 0, 4, 0);
            dateTimePicker_returnBackFieldLabel.RightToLeft = RightToLeft.Yes;
            dateTimePicker_returnBackFieldLabel.Size = new Size(188, 24);
            dateTimePicker_returnBackFieldLabel.TabIndex = 53;
            dateTimePicker_returnBackFieldLabel.Text = "برگشت واقعی";
            dateTimePicker_returnBackFieldLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker_returnBack
            // 
            dateTimePicker_returnBack.BackColor = Color.White;
            dateTimePicker_returnBack.Dock = DockStyle.Fill;
            dateTimePicker_returnBack.Font = new Font("Tahoma", 10F);
            dateTimePicker_returnBack.ForeColor = Color.FromArgb(25, 42, 66);
            dateTimePicker_returnBack.Location = new Point(0, 26);
            dateTimePicker_returnBack.Margin = new Padding(0, 2, 0, 2);
            dateTimePicker_returnBack.MinimumSize = new Size(140, 32);
            dateTimePicker_returnBack.Name = "dateTimePicker_returnBack";
            dateTimePicker_returnBack.RightToLeft = RightToLeft.Yes;
            dateTimePicker_returnBack.Size = new Size(188, 36);
            dateTimePicker_returnBack.TabIndex = 46;
            // 
            // returnHint
            // 
            returnHint.AutoEllipsis = true;
            returnHint.Dock = DockStyle.Fill;
            returnHint.Font = new Font("Tahoma", 9F);
            returnHint.ForeColor = Color.FromArgb(94, 110, 132);
            returnHint.Location = new Point(4, 80);
            returnHint.Margin = new Padding(0);
            returnHint.Name = "returnHint";
            returnHint.Padding = new Padding(4, 0, 4, 0);
            returnHint.RightToLeft = RightToLeft.Yes;
            returnHint.Size = new Size(586, 28);
            returnHint.TabIndex = 55;
            returnHint.Text = "ابتدا یک امانت فعال را از جدول انتخاب کنید.";
            returnHint.TextAlign = ContentAlignment.MiddleRight;
            // 
            // returnActions
            // 
            returnActions.AutoSize = true;
            returnActions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            returnActions.Controls.Add(btn_return_save);
            returnActions.Dock = DockStyle.Top;
            returnActions.FlowDirection = FlowDirection.RightToLeft;
            returnActions.Location = new Point(4, 108);
            returnActions.Margin = new Padding(0);
            returnActions.Name = "returnActions";
            returnActions.Padding = new Padding(0, 4, 0, 4);
            returnActions.RightToLeft = RightToLeft.No;
            returnActions.Size = new Size(586, 56);
            returnActions.TabIndex = 56;
            // 
            // btn_return_save
            // 
            btn_return_save.BackColor = Color.FromArgb(12, 120, 113);
            btn_return_save.Cursor = Cursors.Hand;
            btn_return_save.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            btn_return_save.FlatAppearance.BorderSize = 0;
            btn_return_save.FlatStyle = FlatStyle.Flat;
            btn_return_save.ForeColor = Color.White;
            btn_return_save.Location = new Point(454, 8);
            btn_return_save.Margin = new Padding(4);
            btn_return_save.MinimumSize = new Size(112, 38);
            btn_return_save.Name = "btn_return_save";
            btn_return_save.RightToLeft = RightToLeft.Yes;
            btn_return_save.Size = new Size(128, 40);
            btn_return_save.TabIndex = 54;
            btn_return_save.Text = "ثبت برگشت";
            btn_return_save.UseVisualStyleBackColor = false;
            btn_return_save.Click += button1_Click;
            // 
            // viewportPanel
            // 
            viewportPanel.AutoScroll = true;
            viewportPanel.AutoScrollMinSize = new Size(0, 700);
            viewportPanel.BackColor = Color.FromArgb(242, 245, 249);
            viewportPanel.Controls.Add(rootLayout);
            viewportPanel.Dock = DockStyle.Fill;
            viewportPanel.Location = new Point(0, 0);
            viewportPanel.Margin = new Padding(0);
            viewportPanel.Name = "viewportPanel";
            viewportPanel.RightToLeft = RightToLeft.No;
            viewportPanel.Size = new Size(1292, 780);
            viewportPanel.TabIndex = 7;
            // 
            // FrmLoan
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 245, 249);
            ClientSize = new Size(1292, 780);
            Controls.Add(viewportPanel);
            Font = new Font("Tahoma", 10F);
            ForeColor = Color.FromArgb(25, 42, 66);
            MinimumSize = new Size(1040, 620);
            Name = "FrmLoan";
            RightToLeft = RightToLeft.Yes;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "امانت و برگشت کتاب";
            Load += FrmLoan_Load;
            rootLayout.ResumeLayout(false);
            rootLayout.PerformLayout();
            headerLayout.ResumeLayout(false);
            headingLayout.ResumeLayout(false);
            bodyLayout.ResumeLayout(false);
            memberCard.ResumeLayout(false);
            memberDetailsLayout.ResumeLayout(false);
            memberDetailsLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_member).EndInit();
            loanMemberIdField.ResumeLayout(false);
            loanMemberIdField.PerformLayout();
            loanMemberNameField.ResumeLayout(false);
            loanMemberNameField.PerformLayout();
            memberFlags.ResumeLayout(false);
            memberFlags.PerformLayout();
            historyCard.ResumeLayout(false);
            historyLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_loans).EndInit();
            loanActionsLayout.ResumeLayout(false);
            issueCard.ResumeLayout(false);
            issueCard.PerformLayout();
            issueLayout.ResumeLayout(false);
            issueLayout.PerformLayout();
            issueFieldsLayout.ResumeLayout(false);
            comboBox_booksField.ResumeLayout(false);
            dateTimePicker_loanField.ResumeLayout(false);
            dateTimePicker_returnField.ResumeLayout(false);
            issueActions.ResumeLayout(false);
            returnCard.ResumeLayout(false);
            returnCard.PerformLayout();
            returnLayout.ResumeLayout(false);
            returnLayout.PerformLayout();
            returnFieldsLayout.ResumeLayout(false);
            comboBox_Book_returnField.ResumeLayout(false);
            dateTimePicker_ExpiredTimeField.ResumeLayout(false);
            dateTimePicker_returnBackField.ResumeLayout(false);
            returnActions.ResumeLayout(false);
            viewportPanel.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox_member;
        private System.Windows.Forms.TextBox txt_search_id;
        private System.Windows.Forms.TextBox txt_family;
        private System.Windows.Forms.Button btn_reneview;
        private System.Windows.Forms.CheckBox checkBox_status;
        private System.Windows.Forms.CheckBox checkBox_isSpecial;
        private System.Windows.Forms.TableLayoutPanel memberDetailsLayout;
        private System.Windows.Forms.TableLayoutPanel loanMemberIdField;
        private System.Windows.Forms.Label loanMemberIdFieldLabel;
        private System.Windows.Forms.TableLayoutPanel loanMemberNameField;
        private System.Windows.Forms.Label loanMemberNameFieldLabel;
        private System.Windows.Forms.FlowLayoutPanel memberFlags;
        private System.Windows.Forms.TableLayoutPanel memberCard;
        private System.Windows.Forms.Label memberCardTitle;
        private System.Windows.Forms.DataGridView dataGridView_loans;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_loans_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_loans_BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_loans_LoanDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_loans_ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_loans_ReturnedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_loans_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_loans_DaysOverdue;
        private System.Windows.Forms.Label _loanStatus;
        private System.Windows.Forms.TableLayoutPanel historyLayout;
        private System.Windows.Forms.TableLayoutPanel historyCard;
        private System.Windows.Forms.Label historyCardTitle;
        private System.Windows.Forms.ComboBox comboBox_books;
        private LibraryManagementWindowsForm.PersianDatePicker dateTimePicker_loan;
        private LibraryManagementWindowsForm.PersianDatePicker dateTimePicker_return;
        private System.Windows.Forms.TableLayoutPanel issueFieldsLayout;
        private System.Windows.Forms.TableLayoutPanel comboBox_booksField;
        private System.Windows.Forms.Label comboBox_booksFieldLabel;
        private System.Windows.Forms.TableLayoutPanel dateTimePicker_loanField;
        private System.Windows.Forms.Label dateTimePicker_loanFieldLabel;
        private System.Windows.Forms.TableLayoutPanel dateTimePicker_returnField;
        private System.Windows.Forms.Label dateTimePicker_returnFieldLabel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_refresh_books;
        private System.Windows.Forms.Label _bookStatus;
        private System.Windows.Forms.FlowLayoutPanel issueActions;
        private System.Windows.Forms.TableLayoutPanel issueLayout;
        private System.Windows.Forms.TableLayoutPanel issueCard;
        private System.Windows.Forms.Label issueCardTitle;
        private System.Windows.Forms.ComboBox comboBox_Book_return;
        private LibraryManagementWindowsForm.PersianDatePicker dateTimePicker_ExpiredTime;
        private LibraryManagementWindowsForm.PersianDatePicker dateTimePicker_returnBack;
        private System.Windows.Forms.TableLayoutPanel returnFieldsLayout;
        private System.Windows.Forms.TableLayoutPanel comboBox_Book_returnField;
        private System.Windows.Forms.Label comboBox_Book_returnFieldLabel;
        private System.Windows.Forms.TableLayoutPanel dateTimePicker_ExpiredTimeField;
        private System.Windows.Forms.Label dateTimePicker_ExpiredTimeFieldLabel;
        private System.Windows.Forms.TableLayoutPanel dateTimePicker_returnBackField;
        private System.Windows.Forms.Label dateTimePicker_returnBackFieldLabel;
        private System.Windows.Forms.Button btn_return_save;
        private System.Windows.Forms.Label returnHint;
        private System.Windows.Forms.FlowLayoutPanel returnActions;
        private System.Windows.Forms.TableLayoutPanel returnLayout;
        private System.Windows.Forms.TableLayoutPanel returnCard;
        private System.Windows.Forms.Label returnCardTitle;
        private System.Windows.Forms.TableLayoutPanel loanActionsLayout;
        private System.Windows.Forms.TableLayoutPanel bodyLayout;
    }
}
