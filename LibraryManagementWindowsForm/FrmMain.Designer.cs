#nullable disable
namespace LibraryManagementWindowsForm
{
    partial class FrmMain
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
            rootLayout = new TableLayoutPanel();
            headerLayout = new TableLayoutPanel();
            userProfile2 = new UserProfile();
            headingLayout = new TableLayoutPanel();
            headingLabel = new Label();
            subtitleLabel = new Label();
            footerLabel = new Label();
            tilesPanel = new FlowLayoutPanel();
            booksTile = new TableLayoutPanel();
            booksAccent = new Panel();
            booksTitle = new Label();
            booksDescription = new Label();
            btnBook = new Button();
            membersTile = new TableLayoutPanel();
            membersAccent = new Panel();
            membersTitle = new Label();
            membersDescription = new Label();
            button1 = new Button();
            loansTile = new TableLayoutPanel();
            loansAccent = new Panel();
            loansTitle = new Label();
            loansDescription = new Label();
            button2 = new Button();
            _adminTile = new TableLayoutPanel();
            adminsAccent = new Panel();
            adminsTitle = new Label();
            adminsDescription = new Label();
            btnAdminManagement = new Button();
            viewportPanel = new Panel();
            rootLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            headingLayout.SuspendLayout();
            tilesPanel.SuspendLayout();
            booksTile.SuspendLayout();
            membersTile.SuspendLayout();
            loansTile.SuspendLayout();
            _adminTile.SuspendLayout();
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
            rootLayout.Controls.Add(tilesPanel, 0, 1);
            rootLayout.Dock = DockStyle.Fill;
            rootLayout.Location = new Point(0, 0);
            rootLayout.Margin = new Padding(0);
            rootLayout.MinimumSize = new Size(0, 420);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new Padding(16);
            rootLayout.RightToLeft = RightToLeft.No;
            rootLayout.RowCount = 3;
            rootLayout.RowStyles.Add(new RowStyle());
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            rootLayout.Size = new Size(1130, 620);
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
            headerLayout.Controls.Add(userProfile2, 0, 0);
            headerLayout.Controls.Add(headingLayout, 1, 0);
            headerLayout.Dock = DockStyle.Fill;
            headerLayout.Location = new Point(16, 16);
            headerLayout.Margin = new Padding(0, 0, 0, 12);
            headerLayout.Name = "headerLayout";
            headerLayout.Padding = new Padding(12);
            headerLayout.RightToLeft = RightToLeft.No;
            headerLayout.RowCount = 1;
            headerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            headerLayout.Size = new Size(1098, 92);
            headerLayout.TabIndex = 1;
            // 
            // userProfile2
            // 
            userProfile2.AccessibleName = "کاربر واردشده";
            userProfile2.BackColor = Color.White;
            userProfile2.Dock = DockStyle.Fill;
            userProfile2.Font = new Font("Tahoma", 10F);
            userProfile2.ForeColor = Color.FromArgb(25, 42, 66);
            userProfile2.Location = new Point(16, 16);
            userProfile2.Margin = new Padding(4, 4, 4, 4);
            userProfile2.MinimumSize = new Size(160, 32);
            userProfile2.Name = "userProfile2";
            userProfile2.RightToLeft = RightToLeft.Yes;
            userProfile2.Size = new Size(212, 60);
            userProfile2.TabIndex = 5;
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
            headingLayout.Size = new Size(854, 68);
            headingLayout.TabIndex = 2;
            // 
            // headingLabel
            // 
            headingLabel.AutoEllipsis = true;
            headingLabel.Dock = DockStyle.Fill;
            headingLabel.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headingLabel.ForeColor = Color.FromArgb(25, 42, 66);
            headingLabel.Location = new Point(0, 0);
            headingLabel.Margin = new Padding(0);
            headingLabel.Name = "headingLabel";
            headingLabel.Padding = new Padding(4, 0, 4, 0);
            headingLabel.RightToLeft = RightToLeft.Yes;
            headingLabel.Size = new Size(854, 32);
            headingLabel.TabIndex = 3;
            headingLabel.Text = "مدیریت کتابخانه";
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
            subtitleLabel.Size = new Size(854, 36);
            subtitleLabel.TabIndex = 4;
            subtitleLabel.Text = "بخش موردنظر را برای شروع انتخاب کنید";
            subtitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // footerLabel
            // 
            footerLabel.AutoEllipsis = true;
            footerLabel.Dock = DockStyle.Fill;
            footerLabel.Font = new Font("Tahoma", 9F);
            footerLabel.ForeColor = Color.FromArgb(94, 110, 132);
            footerLabel.Location = new Point(16, 580);
            footerLabel.Margin = new Padding(0);
            footerLabel.Name = "footerLabel";
            footerLabel.Padding = new Padding(4, 0, 4, 0);
            footerLabel.RightToLeft = RightToLeft.Yes;
            footerLabel.Size = new Size(1098, 24);
            footerLabel.TabIndex = 6;
            footerLabel.Text = "مدیریت کتابخانه  •  ثبت و پیگیری اطلاعات";
            footerLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tilesPanel
            // 
            tilesPanel.AutoScroll = true;
            tilesPanel.BackColor = Color.FromArgb(242, 245, 249);
            tilesPanel.Controls.Add(booksTile);
            tilesPanel.Controls.Add(membersTile);
            tilesPanel.Controls.Add(loansTile);
            tilesPanel.Controls.Add(_adminTile);
            tilesPanel.Dock = DockStyle.Fill;
            tilesPanel.FlowDirection = FlowDirection.RightToLeft;
            tilesPanel.Location = new Point(16, 120);
            tilesPanel.Margin = new Padding(0);
            tilesPanel.Name = "tilesPanel";
            tilesPanel.Padding = new Padding(4);
            tilesPanel.RightToLeft = RightToLeft.No;
            tilesPanel.Size = new Size(1098, 460);
            tilesPanel.TabIndex = 8;
            // 
            // booksTile
            // 
            booksTile.BackColor = Color.White;
            booksTile.ColumnCount = 1;
            booksTile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            booksTile.Controls.Add(booksAccent, 0, 0);
            booksTile.Controls.Add(booksTitle, 0, 1);
            booksTile.Controls.Add(booksDescription, 0, 2);
            booksTile.Controls.Add(btnBook, 0, 3);
            booksTile.Location = new Point(834, 10);
            booksTile.Margin = new Padding(6);
            booksTile.Name = "booksTile";
            booksTile.Padding = new Padding(12);
            booksTile.RightToLeft = RightToLeft.No;
            booksTile.RowCount = 4;
            booksTile.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            booksTile.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            booksTile.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            booksTile.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            booksTile.Size = new Size(250, 214);
            booksTile.TabIndex = 9;
            // 
            // booksAccent
            // 
            booksAccent.BackColor = Color.FromArgb(12, 120, 113);
            booksAccent.Dock = DockStyle.Fill;
            booksAccent.Location = new Point(12, 12);
            booksAccent.Margin = new Padding(0);
            booksAccent.Name = "booksAccent";
            booksAccent.RightToLeft = RightToLeft.Yes;
            booksAccent.Size = new Size(226, 6);
            booksAccent.TabIndex = 10;
            // 
            // booksTitle
            // 
            booksTitle.AutoEllipsis = true;
            booksTitle.Dock = DockStyle.Fill;
            booksTitle.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            booksTitle.ForeColor = Color.FromArgb(25, 42, 66);
            booksTitle.Location = new Point(12, 18);
            booksTitle.Margin = new Padding(0);
            booksTitle.Name = "booksTitle";
            booksTitle.Padding = new Padding(4, 0, 4, 0);
            booksTitle.RightToLeft = RightToLeft.Yes;
            booksTitle.Size = new Size(226, 42);
            booksTitle.TabIndex = 11;
            booksTitle.Text = "کتاب‌ها";
            booksTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // booksDescription
            // 
            booksDescription.AutoEllipsis = true;
            booksDescription.Dock = DockStyle.Fill;
            booksDescription.Font = new Font("Tahoma", 10F);
            booksDescription.ForeColor = Color.FromArgb(94, 110, 132);
            booksDescription.Location = new Point(12, 60);
            booksDescription.Margin = new Padding(0);
            booksDescription.Name = "booksDescription";
            booksDescription.Padding = new Padding(4, 0, 4, 0);
            booksDescription.RightToLeft = RightToLeft.Yes;
            booksDescription.Size = new Size(226, 92);
            booksDescription.TabIndex = 12;
            booksDescription.Text = "ثبت کتاب، جست‌وجو و ویرایش مشخصات و تصویر.";
            booksDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(12, 120, 113);
            btnBook.Cursor = Cursors.Hand;
            btnBook.Dock = DockStyle.Fill;
            btnBook.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(16, 156);
            btnBook.Margin = new Padding(4);
            btnBook.MinimumSize = new Size(112, 38);
            btnBook.Name = "btnBook";
            btnBook.RightToLeft = RightToLeft.Yes;
            btnBook.Size = new Size(218, 42);
            btnBook.TabIndex = 13;
            btnBook.Text = "باز کردن";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // membersTile
            // 
            membersTile.BackColor = Color.White;
            membersTile.ColumnCount = 1;
            membersTile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            membersTile.Controls.Add(membersAccent, 0, 0);
            membersTile.Controls.Add(membersTitle, 0, 1);
            membersTile.Controls.Add(membersDescription, 0, 2);
            membersTile.Controls.Add(button1, 0, 3);
            membersTile.Location = new Point(572, 10);
            membersTile.Margin = new Padding(6);
            membersTile.Name = "membersTile";
            membersTile.Padding = new Padding(12);
            membersTile.RightToLeft = RightToLeft.No;
            membersTile.RowCount = 4;
            membersTile.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            membersTile.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            membersTile.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            membersTile.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            membersTile.Size = new Size(250, 214);
            membersTile.TabIndex = 14;
            // 
            // membersAccent
            // 
            membersAccent.BackColor = Color.FromArgb(12, 120, 113);
            membersAccent.Dock = DockStyle.Fill;
            membersAccent.Location = new Point(12, 12);
            membersAccent.Margin = new Padding(0);
            membersAccent.Name = "membersAccent";
            membersAccent.RightToLeft = RightToLeft.Yes;
            membersAccent.Size = new Size(226, 6);
            membersAccent.TabIndex = 15;
            // 
            // membersTitle
            // 
            membersTitle.AutoEllipsis = true;
            membersTitle.Dock = DockStyle.Fill;
            membersTitle.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            membersTitle.ForeColor = Color.FromArgb(25, 42, 66);
            membersTitle.Location = new Point(12, 18);
            membersTitle.Margin = new Padding(0);
            membersTitle.Name = "membersTitle";
            membersTitle.Padding = new Padding(4, 0, 4, 0);
            membersTitle.RightToLeft = RightToLeft.Yes;
            membersTitle.Size = new Size(226, 42);
            membersTitle.TabIndex = 16;
            membersTitle.Text = "اعضا";
            membersTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // membersDescription
            // 
            membersDescription.AutoEllipsis = true;
            membersDescription.Dock = DockStyle.Fill;
            membersDescription.Font = new Font("Tahoma", 10F);
            membersDescription.ForeColor = Color.FromArgb(94, 110, 132);
            membersDescription.Location = new Point(12, 60);
            membersDescription.Margin = new Padding(0);
            membersDescription.Name = "membersDescription";
            membersDescription.Padding = new Padding(4, 0, 4, 0);
            membersDescription.RightToLeft = RightToLeft.Yes;
            membersDescription.Size = new Size(226, 92);
            membersDescription.TabIndex = 17;
            membersDescription.Text = "ثبت عضو، جست‌وجو و مدیریت وضعیت عضویت.";
            membersDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(12, 120, 113);
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(16, 156);
            button1.Margin = new Padding(4);
            button1.MinimumSize = new Size(112, 38);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(218, 42);
            button1.TabIndex = 18;
            button1.Text = "باز کردن";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // loansTile
            // 
            loansTile.BackColor = Color.White;
            loansTile.ColumnCount = 1;
            loansTile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            loansTile.Controls.Add(loansAccent, 0, 0);
            loansTile.Controls.Add(loansTitle, 0, 1);
            loansTile.Controls.Add(loansDescription, 0, 2);
            loansTile.Controls.Add(button2, 0, 3);
            loansTile.Location = new Point(310, 10);
            loansTile.Margin = new Padding(6);
            loansTile.Name = "loansTile";
            loansTile.Padding = new Padding(12);
            loansTile.RightToLeft = RightToLeft.No;
            loansTile.RowCount = 4;
            loansTile.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            loansTile.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            loansTile.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            loansTile.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            loansTile.Size = new Size(250, 214);
            loansTile.TabIndex = 19;
            // 
            // loansAccent
            // 
            loansAccent.BackColor = Color.FromArgb(12, 120, 113);
            loansAccent.Dock = DockStyle.Fill;
            loansAccent.Location = new Point(12, 12);
            loansAccent.Margin = new Padding(0);
            loansAccent.Name = "loansAccent";
            loansAccent.RightToLeft = RightToLeft.Yes;
            loansAccent.Size = new Size(226, 6);
            loansAccent.TabIndex = 20;
            // 
            // loansTitle
            // 
            loansTitle.AutoEllipsis = true;
            loansTitle.Dock = DockStyle.Fill;
            loansTitle.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            loansTitle.ForeColor = Color.FromArgb(25, 42, 66);
            loansTitle.Location = new Point(12, 18);
            loansTitle.Margin = new Padding(0);
            loansTitle.Name = "loansTitle";
            loansTitle.Padding = new Padding(4, 0, 4, 0);
            loansTitle.RightToLeft = RightToLeft.Yes;
            loansTitle.Size = new Size(226, 42);
            loansTitle.TabIndex = 21;
            loansTitle.Text = "امانت‌ها";
            loansTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // loansDescription
            // 
            loansDescription.AutoEllipsis = true;
            loansDescription.Dock = DockStyle.Fill;
            loansDescription.Font = new Font("Tahoma", 10F);
            loansDescription.ForeColor = Color.FromArgb(94, 110, 132);
            loansDescription.Location = new Point(12, 60);
            loansDescription.Margin = new Padding(0);
            loansDescription.Name = "loansDescription";
            loansDescription.Padding = new Padding(4, 0, 4, 0);
            loansDescription.RightToLeft = RightToLeft.Yes;
            loansDescription.Size = new Size(226, 92);
            loansDescription.TabIndex = 22;
            loansDescription.Text = "امانت و برگشت کتاب با تاریخ شمسی و حفظ سابقه.";
            loansDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(12, 120, 113);
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(16, 156);
            button2.Margin = new Padding(4);
            button2.MinimumSize = new Size(112, 38);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(218, 42);
            button2.TabIndex = 23;
            button2.Text = "باز کردن";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // _adminTile
            // 
            _adminTile.BackColor = Color.White;
            _adminTile.ColumnCount = 1;
            _adminTile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _adminTile.Controls.Add(adminsAccent, 0, 0);
            _adminTile.Controls.Add(adminsTitle, 0, 1);
            _adminTile.Controls.Add(adminsDescription, 0, 2);
            _adminTile.Controls.Add(btnAdminManagement, 0, 3);
            _adminTile.Location = new Point(48, 10);
            _adminTile.Margin = new Padding(6);
            _adminTile.Name = "_adminTile";
            _adminTile.Padding = new Padding(12);
            _adminTile.RightToLeft = RightToLeft.No;
            _adminTile.RowCount = 4;
            _adminTile.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            _adminTile.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            _adminTile.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _adminTile.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            _adminTile.Size = new Size(250, 214);
            _adminTile.TabIndex = 24;
            // 
            // adminsAccent
            // 
            adminsAccent.BackColor = Color.FromArgb(12, 120, 113);
            adminsAccent.Dock = DockStyle.Fill;
            adminsAccent.Location = new Point(12, 12);
            adminsAccent.Margin = new Padding(0);
            adminsAccent.Name = "adminsAccent";
            adminsAccent.RightToLeft = RightToLeft.Yes;
            adminsAccent.Size = new Size(226, 6);
            adminsAccent.TabIndex = 25;
            // 
            // adminsTitle
            // 
            adminsTitle.AutoEllipsis = true;
            adminsTitle.Dock = DockStyle.Fill;
            adminsTitle.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            adminsTitle.ForeColor = Color.FromArgb(25, 42, 66);
            adminsTitle.Location = new Point(12, 18);
            adminsTitle.Margin = new Padding(0);
            adminsTitle.Name = "adminsTitle";
            adminsTitle.Padding = new Padding(4, 0, 4, 0);
            adminsTitle.RightToLeft = RightToLeft.Yes;
            adminsTitle.Size = new Size(226, 42);
            adminsTitle.TabIndex = 26;
            adminsTitle.Text = "مدیران";
            adminsTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // adminsDescription
            // 
            adminsDescription.AutoEllipsis = true;
            adminsDescription.Dock = DockStyle.Fill;
            adminsDescription.Font = new Font("Tahoma", 10F);
            adminsDescription.ForeColor = Color.FromArgb(94, 110, 132);
            adminsDescription.Location = new Point(12, 60);
            adminsDescription.Margin = new Padding(0);
            adminsDescription.Name = "adminsDescription";
            adminsDescription.Padding = new Padding(4, 0, 4, 0);
            adminsDescription.RightToLeft = RightToLeft.Yes;
            adminsDescription.Size = new Size(226, 92);
            adminsDescription.TabIndex = 27;
            adminsDescription.Text = "حساب‌های مدیریت و وضعیت دسترسی مدیران.";
            adminsDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAdminManagement
            // 
            btnAdminManagement.BackColor = Color.FromArgb(12, 120, 113);
            btnAdminManagement.Cursor = Cursors.Hand;
            btnAdminManagement.Dock = DockStyle.Fill;
            btnAdminManagement.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            btnAdminManagement.FlatAppearance.BorderSize = 0;
            btnAdminManagement.FlatStyle = FlatStyle.Flat;
            btnAdminManagement.ForeColor = Color.White;
            btnAdminManagement.Location = new Point(16, 156);
            btnAdminManagement.Margin = new Padding(4);
            btnAdminManagement.MinimumSize = new Size(112, 38);
            btnAdminManagement.Name = "btnAdminManagement";
            btnAdminManagement.RightToLeft = RightToLeft.Yes;
            btnAdminManagement.Size = new Size(218, 42);
            btnAdminManagement.TabIndex = 28;
            btnAdminManagement.Text = "باز کردن";
            btnAdminManagement.UseVisualStyleBackColor = false;
            btnAdminManagement.Click += btnAdminManagement_Click;
            // 
            // viewportPanel
            // 
            viewportPanel.AutoScroll = true;
            viewportPanel.AutoScrollMinSize = new Size(0, 420);
            viewportPanel.BackColor = Color.FromArgb(242, 245, 249);
            viewportPanel.Controls.Add(rootLayout);
            viewportPanel.Dock = DockStyle.Fill;
            viewportPanel.Location = new Point(0, 0);
            viewportPanel.Margin = new Padding(0);
            viewportPanel.Name = "viewportPanel";
            viewportPanel.RightToLeft = RightToLeft.No;
            viewportPanel.Size = new Size(1130, 620);
            viewportPanel.TabIndex = 7;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 245, 249);
            ClientSize = new Size(1130, 620);
            Controls.Add(viewportPanel);
            Font = new Font("Tahoma", 10F);
            ForeColor = Color.FromArgb(25, 42, 66);
            MinimumSize = new Size(740, 480);
            Name = "FrmMain";
            RightToLeft = RightToLeft.Yes;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "مدیریت کتابخانه";
            Load += FrmMain_Load;
            rootLayout.ResumeLayout(false);
            rootLayout.PerformLayout();
            headerLayout.ResumeLayout(false);
            headingLayout.ResumeLayout(false);
            tilesPanel.ResumeLayout(false);
            booksTile.ResumeLayout(false);
            membersTile.ResumeLayout(false);
            loansTile.ResumeLayout(false);
            _adminTile.ResumeLayout(false);
            viewportPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.TableLayoutPanel headingLayout;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private LibraryManagementWindowsForm.UserProfile userProfile2;
        private System.Windows.Forms.Label footerLabel;
        private System.Windows.Forms.Panel viewportPanel;
        private System.Windows.Forms.FlowLayoutPanel tilesPanel;
        private System.Windows.Forms.TableLayoutPanel booksTile;
        private System.Windows.Forms.Panel booksAccent;
        private System.Windows.Forms.Label booksTitle;
        private System.Windows.Forms.Label booksDescription;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TableLayoutPanel membersTile;
        private System.Windows.Forms.Panel membersAccent;
        private System.Windows.Forms.Label membersTitle;
        private System.Windows.Forms.Label membersDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel loansTile;
        private System.Windows.Forms.Panel loansAccent;
        private System.Windows.Forms.Label loansTitle;
        private System.Windows.Forms.Label loansDescription;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel _adminTile;
        private System.Windows.Forms.Panel adminsAccent;
        private System.Windows.Forms.Label adminsTitle;
        private System.Windows.Forms.Label adminsDescription;
        private System.Windows.Forms.Button btnAdminManagement;
    }
}
