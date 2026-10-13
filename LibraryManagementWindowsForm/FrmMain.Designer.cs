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
            components = new System.ComponentModel.Container();
            rootLayout = new System.Windows.Forms.TableLayoutPanel();
            headerLayout = new System.Windows.Forms.TableLayoutPanel();
            headingLayout = new System.Windows.Forms.TableLayoutPanel();
            headingLabel = new System.Windows.Forms.Label();
            subtitleLabel = new System.Windows.Forms.Label();
            userProfile2 = new LibraryManagementWindowsForm.UserProfile();
            footerLabel = new System.Windows.Forms.Label();
            viewportPanel = new System.Windows.Forms.Panel();
            tilesPanel = new System.Windows.Forms.FlowLayoutPanel();
            booksTile = new System.Windows.Forms.TableLayoutPanel();
            booksAccent = new System.Windows.Forms.Panel();
            booksTitle = new System.Windows.Forms.Label();
            booksDescription = new System.Windows.Forms.Label();
            btnBook = new System.Windows.Forms.Button();
            membersTile = new System.Windows.Forms.TableLayoutPanel();
            membersAccent = new System.Windows.Forms.Panel();
            membersTitle = new System.Windows.Forms.Label();
            membersDescription = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            loansTile = new System.Windows.Forms.TableLayoutPanel();
            loansAccent = new System.Windows.Forms.Panel();
            loansTitle = new System.Windows.Forms.Label();
            loansDescription = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            _adminTile = new System.Windows.Forms.TableLayoutPanel();
            adminsAccent = new System.Windows.Forms.Panel();
            adminsTitle = new System.Windows.Forms.Label();
            adminsDescription = new System.Windows.Forms.Label();
            btnAdminManagement = new System.Windows.Forms.Button();
            rootLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            headingLayout.SuspendLayout();
            viewportPanel.SuspendLayout();
            tilesPanel.SuspendLayout();
            booksTile.SuspendLayout();
            booksAccent.SuspendLayout();
            membersTile.SuspendLayout();
            membersAccent.SuspendLayout();
            loansTile.SuspendLayout();
            loansAccent.SuspendLayout();
            _adminTile.SuspendLayout();
            adminsAccent.SuspendLayout();
            SuspendLayout();
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
            rootLayout.MinimumSize = new System.Drawing.Size(0, 420);
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
            headingLabel.Text = "مدیریت کتابخانه";
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
            subtitleLabel.Text = "بخش موردنظر را برای شروع انتخاب کنید";
            subtitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            subtitleLabel.AutoSize = false;
            subtitleLabel.AutoEllipsis = true;
            subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            subtitleLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            subtitleLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            subtitleLabel.TabIndex = 4;
            //
            // userProfile2
            //
            userProfile2.Name = "userProfile2";
            userProfile2.Margin = new System.Windows.Forms.Padding(4);
            userProfile2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            userProfile2.Dock = System.Windows.Forms.DockStyle.Fill;
            userProfile2.MinimumSize = new System.Drawing.Size(160, 32);
            userProfile2.TabIndex = 5;
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
            viewportPanel.AutoScrollMinSize = new System.Drawing.Size(0, 420);
            viewportPanel.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            viewportPanel.TabIndex = 7;
            //
            // tilesPanel
            //
            tilesPanel.Name = "tilesPanel";
            tilesPanel.Margin = new System.Windows.Forms.Padding(0);
            tilesPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            tilesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tilesPanel.AutoScroll = true;
            tilesPanel.WrapContents = true;
            tilesPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            tilesPanel.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            tilesPanel.Padding = new System.Windows.Forms.Padding(4);
            tilesPanel.TabIndex = 8;
            //
            // booksTile
            //
            booksTile.Name = "booksTile";
            booksTile.Margin = new System.Windows.Forms.Padding(6);
            booksTile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            booksTile.Dock = System.Windows.Forms.DockStyle.None;
            booksTile.ColumnCount = 1;
            booksTile.RowCount = 4;
            booksTile.Padding = new System.Windows.Forms.Padding(12);
            booksTile.BackColor = System.Drawing.Color.White;
            booksTile.Size = new System.Drawing.Size(250, 214);
            booksTile.TabIndex = 9;
            booksTile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            booksTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            booksTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            booksTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            booksTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            //
            // booksAccent
            //
            booksAccent.Name = "booksAccent";
            booksAccent.Margin = new System.Windows.Forms.Padding(0);
            booksAccent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            booksAccent.Dock = System.Windows.Forms.DockStyle.Fill;
            booksAccent.BackColor = System.Drawing.Color.FromArgb(12, 120, 113);
            booksAccent.TabIndex = 10;
            //
            // booksTitle
            //
            booksTitle.Name = "booksTitle";
            booksTitle.Margin = new System.Windows.Forms.Padding(0);
            booksTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            booksTitle.Text = "کتاب‌ها";
            booksTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            booksTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            booksTitle.AutoSize = false;
            booksTitle.AutoEllipsis = true;
            booksTitle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            booksTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            booksTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            booksTitle.TabIndex = 11;
            //
            // booksDescription
            //
            booksDescription.Name = "booksDescription";
            booksDescription.Margin = new System.Windows.Forms.Padding(0);
            booksDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            booksDescription.Text = "ثبت کتاب، جست‌وجو و ویرایش مشخصات و تصویر.";
            booksDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            booksDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            booksDescription.AutoSize = false;
            booksDescription.AutoEllipsis = true;
            booksDescription.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            booksDescription.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            booksDescription.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            booksDescription.TabIndex = 12;
            //
            // btnBook
            //
            btnBook.Name = "btnBook";
            btnBook.Margin = new System.Windows.Forms.Padding(4);
            btnBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btnBook.Text = "باز کردن";
            btnBook.Size = new System.Drawing.Size(128, 40);
            btnBook.MinimumSize = new System.Drawing.Size(112, 38);
            btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBook.BackColor = System.Drawing.Color.FromArgb(12, 120, 113);
            btnBook.ForeColor = System.Drawing.Color.White;
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBook.AutoSize = false;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btnBook.Dock = System.Windows.Forms.DockStyle.Fill;
            btnBook.TabIndex = 13;
            //
            // membersTile
            //
            membersTile.Name = "membersTile";
            membersTile.Margin = new System.Windows.Forms.Padding(6);
            membersTile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            membersTile.Dock = System.Windows.Forms.DockStyle.None;
            membersTile.ColumnCount = 1;
            membersTile.RowCount = 4;
            membersTile.Padding = new System.Windows.Forms.Padding(12);
            membersTile.BackColor = System.Drawing.Color.White;
            membersTile.Size = new System.Drawing.Size(250, 214);
            membersTile.TabIndex = 14;
            membersTile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            membersTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            membersTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            membersTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            membersTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            //
            // membersAccent
            //
            membersAccent.Name = "membersAccent";
            membersAccent.Margin = new System.Windows.Forms.Padding(0);
            membersAccent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            membersAccent.Dock = System.Windows.Forms.DockStyle.Fill;
            membersAccent.BackColor = System.Drawing.Color.FromArgb(12, 120, 113);
            membersAccent.TabIndex = 15;
            //
            // membersTitle
            //
            membersTitle.Name = "membersTitle";
            membersTitle.Margin = new System.Windows.Forms.Padding(0);
            membersTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            membersTitle.Text = "اعضا";
            membersTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            membersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            membersTitle.AutoSize = false;
            membersTitle.AutoEllipsis = true;
            membersTitle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            membersTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            membersTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            membersTitle.TabIndex = 16;
            //
            // membersDescription
            //
            membersDescription.Name = "membersDescription";
            membersDescription.Margin = new System.Windows.Forms.Padding(0);
            membersDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            membersDescription.Text = "ثبت عضو، جست‌وجو و مدیریت وضعیت عضویت.";
            membersDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            membersDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            membersDescription.AutoSize = false;
            membersDescription.AutoEllipsis = true;
            membersDescription.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            membersDescription.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            membersDescription.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            membersDescription.TabIndex = 17;
            //
            // button1
            //
            button1.Name = "button1";
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            button1.Text = "باز کردن";
            button1.Size = new System.Drawing.Size(128, 40);
            button1.MinimumSize = new System.Drawing.Size(112, 38);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.BackColor = System.Drawing.Color.FromArgb(12, 120, 113);
            button1.ForeColor = System.Drawing.Color.White;
            button1.UseVisualStyleBackColor = false;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.AutoSize = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            button1.Dock = System.Windows.Forms.DockStyle.Fill;
            button1.TabIndex = 18;
            //
            // loansTile
            //
            loansTile.Name = "loansTile";
            loansTile.Margin = new System.Windows.Forms.Padding(6);
            loansTile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            loansTile.Dock = System.Windows.Forms.DockStyle.None;
            loansTile.ColumnCount = 1;
            loansTile.RowCount = 4;
            loansTile.Padding = new System.Windows.Forms.Padding(12);
            loansTile.BackColor = System.Drawing.Color.White;
            loansTile.Size = new System.Drawing.Size(250, 214);
            loansTile.TabIndex = 19;
            loansTile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            loansTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            loansTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            loansTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            loansTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            //
            // loansAccent
            //
            loansAccent.Name = "loansAccent";
            loansAccent.Margin = new System.Windows.Forms.Padding(0);
            loansAccent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            loansAccent.Dock = System.Windows.Forms.DockStyle.Fill;
            loansAccent.BackColor = System.Drawing.Color.FromArgb(12, 120, 113);
            loansAccent.TabIndex = 20;
            //
            // loansTitle
            //
            loansTitle.Name = "loansTitle";
            loansTitle.Margin = new System.Windows.Forms.Padding(0);
            loansTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            loansTitle.Text = "امانت‌ها";
            loansTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            loansTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            loansTitle.AutoSize = false;
            loansTitle.AutoEllipsis = true;
            loansTitle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            loansTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            loansTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            loansTitle.TabIndex = 21;
            //
            // loansDescription
            //
            loansDescription.Name = "loansDescription";
            loansDescription.Margin = new System.Windows.Forms.Padding(0);
            loansDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            loansDescription.Text = "امانت و برگشت کتاب با تاریخ شمسی و حفظ سابقه.";
            loansDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            loansDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            loansDescription.AutoSize = false;
            loansDescription.AutoEllipsis = true;
            loansDescription.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            loansDescription.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            loansDescription.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            loansDescription.TabIndex = 22;
            //
            // button2
            //
            button2.Name = "button2";
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            button2.Text = "باز کردن";
            button2.Size = new System.Drawing.Size(128, 40);
            button2.MinimumSize = new System.Drawing.Size(112, 38);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.BackColor = System.Drawing.Color.FromArgb(12, 120, 113);
            button2.ForeColor = System.Drawing.Color.White;
            button2.UseVisualStyleBackColor = false;
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.AutoSize = false;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            button2.Dock = System.Windows.Forms.DockStyle.Fill;
            button2.TabIndex = 23;
            //
            // _adminTile
            //
            _adminTile.Name = "_adminTile";
            _adminTile.Margin = new System.Windows.Forms.Padding(6);
            _adminTile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _adminTile.Dock = System.Windows.Forms.DockStyle.None;
            _adminTile.ColumnCount = 1;
            _adminTile.RowCount = 4;
            _adminTile.Padding = new System.Windows.Forms.Padding(12);
            _adminTile.BackColor = System.Drawing.Color.White;
            _adminTile.Size = new System.Drawing.Size(250, 214);
            _adminTile.TabIndex = 24;
            _adminTile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            _adminTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            _adminTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            _adminTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            _adminTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            //
            // adminsAccent
            //
            adminsAccent.Name = "adminsAccent";
            adminsAccent.Margin = new System.Windows.Forms.Padding(0);
            adminsAccent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            adminsAccent.Dock = System.Windows.Forms.DockStyle.Fill;
            adminsAccent.BackColor = System.Drawing.Color.FromArgb(12, 120, 113);
            adminsAccent.TabIndex = 25;
            //
            // adminsTitle
            //
            adminsTitle.Name = "adminsTitle";
            adminsTitle.Margin = new System.Windows.Forms.Padding(0);
            adminsTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            adminsTitle.Text = "مدیران";
            adminsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            adminsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            adminsTitle.AutoSize = false;
            adminsTitle.AutoEllipsis = true;
            adminsTitle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            adminsTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            adminsTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adminsTitle.TabIndex = 26;
            //
            // adminsDescription
            //
            adminsDescription.Name = "adminsDescription";
            adminsDescription.Margin = new System.Windows.Forms.Padding(0);
            adminsDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            adminsDescription.Text = "حساب‌های مدیریت و وضعیت دسترسی مدیران.";
            adminsDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            adminsDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            adminsDescription.AutoSize = false;
            adminsDescription.AutoEllipsis = true;
            adminsDescription.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            adminsDescription.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            adminsDescription.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adminsDescription.TabIndex = 27;
            //
            // btnAdminManagement
            //
            btnAdminManagement.Name = "btnAdminManagement";
            btnAdminManagement.Margin = new System.Windows.Forms.Padding(4);
            btnAdminManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btnAdminManagement.Text = "باز کردن";
            btnAdminManagement.Size = new System.Drawing.Size(128, 40);
            btnAdminManagement.MinimumSize = new System.Drawing.Size(112, 38);
            btnAdminManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdminManagement.BackColor = System.Drawing.Color.FromArgb(12, 120, 113);
            btnAdminManagement.ForeColor = System.Drawing.Color.White;
            btnAdminManagement.UseVisualStyleBackColor = false;
            btnAdminManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdminManagement.AutoSize = false;
            btnAdminManagement.FlatAppearance.BorderSize = 0;
            btnAdminManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btnAdminManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            btnAdminManagement.TabIndex = 28;
            headingLayout.Controls.Add(headingLabel, 0, 0);
            headingLayout.Controls.Add(subtitleLabel, 0, 1);
            headerLayout.Controls.Add(userProfile2, 0, 0);
            headerLayout.Controls.Add(headingLayout, 1, 0);
            rootLayout.Controls.Add(headerLayout, 0, 0);
            rootLayout.Controls.Add(footerLabel, 0, 2);
            viewportPanel.Controls.Add(rootLayout);
            Controls.Add(viewportPanel);
            booksTile.Controls.Add(booksAccent, 0, 0);
            booksTile.Controls.Add(booksTitle, 0, 1);
            booksTile.Controls.Add(booksDescription, 0, 2);
            booksTile.Controls.Add(btnBook, 0, 3);
            tilesPanel.Controls.Add(booksTile);
            membersTile.Controls.Add(membersAccent, 0, 0);
            membersTile.Controls.Add(membersTitle, 0, 1);
            membersTile.Controls.Add(membersDescription, 0, 2);
            membersTile.Controls.Add(button1, 0, 3);
            tilesPanel.Controls.Add(membersTile);
            loansTile.Controls.Add(loansAccent, 0, 0);
            loansTile.Controls.Add(loansTitle, 0, 1);
            loansTile.Controls.Add(loansDescription, 0, 2);
            loansTile.Controls.Add(button2, 0, 3);
            tilesPanel.Controls.Add(loansTile);
            _adminTile.Controls.Add(adminsAccent, 0, 0);
            _adminTile.Controls.Add(adminsTitle, 0, 1);
            _adminTile.Controls.Add(adminsDescription, 0, 2);
            _adminTile.Controls.Add(btnAdminManagement, 0, 3);
            tilesPanel.Controls.Add(_adminTile);
            rootLayout.Controls.Add(tilesPanel, 0, 1);
            btnBook.Click += btnBook_Click;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            btnAdminManagement.Click += btnAdminManagement_Click;
            Load += FrmMain_Load;
            //
            // FrmMain
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Name = "FrmMain";
            ClientSize = new System.Drawing.Size(1130, 620);
            MinimumSize = new System.Drawing.Size(740, 480);
            Text = "مدیریت کتابخانه";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            RightToLeftLayout = false;
            ShowIcon = false;
            adminsAccent.ResumeLayout(false);
            adminsAccent.PerformLayout();
            _adminTile.ResumeLayout(false);
            _adminTile.PerformLayout();
            loansAccent.ResumeLayout(false);
            loansAccent.PerformLayout();
            loansTile.ResumeLayout(false);
            loansTile.PerformLayout();
            membersAccent.ResumeLayout(false);
            membersAccent.PerformLayout();
            membersTile.ResumeLayout(false);
            membersTile.PerformLayout();
            booksAccent.ResumeLayout(false);
            booksAccent.PerformLayout();
            booksTile.ResumeLayout(false);
            booksTile.PerformLayout();
            tilesPanel.ResumeLayout(false);
            tilesPanel.PerformLayout();
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
