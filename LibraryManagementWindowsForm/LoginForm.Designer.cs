#nullable disable
namespace LibraryManagementWindowsForm
{
    partial class LoginForm
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
            footerLabel = new System.Windows.Forms.Label();
            viewportPanel = new System.Windows.Forms.Panel();
            txt_user = new System.Windows.Forms.TextBox();
            txt_pass = new System.Windows.Forms.TextBox();
            chkShowPassword = new System.Windows.Forms.CheckBox();
            btn1 = new System.Windows.Forms.Button();
            loginUserField = new System.Windows.Forms.TableLayoutPanel();
            loginUserFieldLabel = new System.Windows.Forms.Label();
            loginPassField = new System.Windows.Forms.TableLayoutPanel();
            loginPassFieldLabel = new System.Windows.Forms.Label();
            loginActions = new System.Windows.Forms.FlowLayoutPanel();
            loginFieldsLayout = new System.Windows.Forms.TableLayoutPanel();
            loginScroll = new System.Windows.Forms.Panel();
            loginCard = new System.Windows.Forms.TableLayoutPanel();
            loginCardTitle = new System.Windows.Forms.Label();
            welcomeLayout = new System.Windows.Forms.TableLayoutPanel();
            welcomeTitle = new System.Windows.Forms.Label();
            welcomeText = new System.Windows.Forms.Label();
            welcomeBooks = new System.Windows.Forms.Label();
            welcomeMembers = new System.Windows.Forms.Label();
            welcomeLoans = new System.Windows.Forms.Label();
            bodyLayout = new System.Windows.Forms.TableLayoutPanel();
            rootLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            headingLayout.SuspendLayout();
            viewportPanel.SuspendLayout();
            loginUserField.SuspendLayout();
            loginPassField.SuspendLayout();
            loginActions.SuspendLayout();
            loginFieldsLayout.SuspendLayout();
            loginScroll.SuspendLayout();
            loginCard.SuspendLayout();
            welcomeLayout.SuspendLayout();
            bodyLayout.SuspendLayout();
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
            rootLayout.MinimumSize = new System.Drawing.Size(0, 440);
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
            headerLayout.ColumnCount = 1;
            headerLayout.RowCount = 1;
            headerLayout.Padding = new System.Windows.Forms.Padding(12);
            headerLayout.BackColor = System.Drawing.Color.White;
            headerLayout.AutoSize = true;
            headerLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            headerLayout.TabIndex = 1;
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
            headingLabel.Text = "ورود به مدیریت کتابخانه";
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
            subtitleLabel.Text = "برای دسترسی به اطلاعات وارد حساب خود شوید";
            subtitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            subtitleLabel.AutoSize = false;
            subtitleLabel.AutoEllipsis = true;
            subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            subtitleLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            subtitleLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            subtitleLabel.TabIndex = 4;
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
            footerLabel.TabIndex = 5;
            //
            // viewportPanel
            //
            viewportPanel.Name = "viewportPanel";
            viewportPanel.Margin = new System.Windows.Forms.Padding(0);
            viewportPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            viewportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            viewportPanel.AutoScroll = true;
            viewportPanel.AutoScrollMinSize = new System.Drawing.Size(0, 440);
            viewportPanel.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            viewportPanel.TabIndex = 6;
            //
            // txt_user
            //
            txt_user.Name = "txt_user";
            txt_user.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txt_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txt_user.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_user.MaxLength = 50;
            txt_user.PlaceholderText = "نام کاربری";
            txt_user.ReadOnly = false;
            txt_user.Multiline = false;
            txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_user.BackColor = System.Drawing.Color.White;
            txt_user.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_user.TabIndex = 0;
            txt_user.TabIndex = 7;
            //
            // txt_pass
            //
            txt_pass.Name = "txt_pass";
            txt_pass.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txt_pass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txt_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_pass.MaxLength = 100;
            txt_pass.PlaceholderText = "رمز عبور";
            txt_pass.ReadOnly = false;
            txt_pass.Multiline = false;
            txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_pass.BackColor = System.Drawing.Color.White;
            txt_pass.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_pass.TabIndex = 0;
            txt_pass.UseSystemPasswordChar = true;
            txt_pass.TabIndex = 8;
            //
            // chkShowPassword
            //
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            chkShowPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkShowPassword.Text = "نمایش رمز";
            chkShowPassword.AutoSize = true;
            chkShowPassword.Enabled = true;
            chkShowPassword.TabIndex = 9;
            //
            // btn1
            //
            btn1.Name = "btn1";
            btn1.Margin = new System.Windows.Forms.Padding(4);
            btn1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btn1.Text = "ورود";
            btn1.Size = new System.Drawing.Size(128, 40);
            btn1.MinimumSize = new System.Drawing.Size(112, 38);
            btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn1.BackColor = System.Drawing.Color.FromArgb(12, 120, 113);
            btn1.ForeColor = System.Drawing.Color.White;
            btn1.UseVisualStyleBackColor = false;
            btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            btn1.AutoSize = false;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btn1.TabIndex = 10;
            //
            // loginUserField
            //
            loginUserField.Name = "loginUserField";
            loginUserField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            loginUserField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            loginUserField.Dock = System.Windows.Forms.DockStyle.Top;
            loginUserField.ColumnCount = 1;
            loginUserField.RowCount = 2;
            loginUserField.Padding = new System.Windows.Forms.Padding(0);
            loginUserField.BackColor = System.Drawing.Color.White;
            loginUserField.Size = new System.Drawing.Size(280, 64);
            loginUserField.TabIndex = 11;
            loginUserField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            loginUserField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            loginUserField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // loginUserFieldLabel
            //
            loginUserFieldLabel.Name = "loginUserFieldLabel";
            loginUserFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            loginUserFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            loginUserFieldLabel.Text = "نام کاربری";
            loginUserFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            loginUserFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            loginUserFieldLabel.AutoSize = false;
            loginUserFieldLabel.AutoEllipsis = true;
            loginUserFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            loginUserFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            loginUserFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            loginUserFieldLabel.TabIndex = 12;
            //
            // loginPassField
            //
            loginPassField.Name = "loginPassField";
            loginPassField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            loginPassField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            loginPassField.Dock = System.Windows.Forms.DockStyle.Top;
            loginPassField.ColumnCount = 1;
            loginPassField.RowCount = 2;
            loginPassField.Padding = new System.Windows.Forms.Padding(0);
            loginPassField.BackColor = System.Drawing.Color.White;
            loginPassField.Size = new System.Drawing.Size(280, 64);
            loginPassField.TabIndex = 13;
            loginPassField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            loginPassField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            loginPassField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // loginPassFieldLabel
            //
            loginPassFieldLabel.Name = "loginPassFieldLabel";
            loginPassFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            loginPassFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            loginPassFieldLabel.Text = "رمز عبور";
            loginPassFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            loginPassFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            loginPassFieldLabel.AutoSize = false;
            loginPassFieldLabel.AutoEllipsis = true;
            loginPassFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            loginPassFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            loginPassFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            loginPassFieldLabel.TabIndex = 14;
            //
            // loginActions
            //
            loginActions.Name = "loginActions";
            loginActions.Margin = new System.Windows.Forms.Padding(0);
            loginActions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            loginActions.Dock = System.Windows.Forms.DockStyle.Top;
            loginActions.AutoSize = true;
            loginActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            loginActions.WrapContents = true;
            loginActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            loginActions.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            loginActions.TabIndex = 15;
            //
            // loginFieldsLayout
            //
            loginFieldsLayout.Name = "loginFieldsLayout";
            loginFieldsLayout.Margin = new System.Windows.Forms.Padding(0);
            loginFieldsLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            loginFieldsLayout.Dock = System.Windows.Forms.DockStyle.Top;
            loginFieldsLayout.ColumnCount = 1;
            loginFieldsLayout.RowCount = 4;
            loginFieldsLayout.Padding = new System.Windows.Forms.Padding(4);
            loginFieldsLayout.BackColor = System.Drawing.Color.White;
            loginFieldsLayout.AutoSize = true;
            loginFieldsLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            loginFieldsLayout.TabIndex = 16;
            loginFieldsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            loginFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            loginFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            loginFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            loginFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize, 0F));
            //
            // loginScroll
            //
            loginScroll.Name = "loginScroll";
            loginScroll.Margin = new System.Windows.Forms.Padding(0);
            loginScroll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            loginScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            loginScroll.AutoScroll = true;
            loginScroll.BackColor = System.Drawing.Color.White;
            loginScroll.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            loginScroll.TabIndex = 17;
            //
            // loginCard
            //
            loginCard.Name = "loginCard";
            loginCard.Margin = new System.Windows.Forms.Padding(6);
            loginCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            loginCard.Dock = System.Windows.Forms.DockStyle.Fill;
            loginCard.ColumnCount = 1;
            loginCard.RowCount = 2;
            loginCard.Padding = new System.Windows.Forms.Padding(12);
            loginCard.BackColor = System.Drawing.Color.White;
            loginCard.TabIndex = 18;
            loginCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            loginCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            loginCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // loginCardTitle
            //
            loginCardTitle.Name = "loginCardTitle";
            loginCardTitle.Margin = new System.Windows.Forms.Padding(0);
            loginCardTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            loginCardTitle.Text = "ورود به حساب";
            loginCardTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            loginCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            loginCardTitle.AutoSize = false;
            loginCardTitle.AutoEllipsis = true;
            loginCardTitle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            loginCardTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            loginCardTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            loginCardTitle.TabIndex = 19;
            //
            // welcomeLayout
            //
            welcomeLayout.Name = "welcomeLayout";
            welcomeLayout.Margin = new System.Windows.Forms.Padding(0);
            welcomeLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            welcomeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            welcomeLayout.ColumnCount = 1;
            welcomeLayout.RowCount = 5;
            welcomeLayout.Padding = new System.Windows.Forms.Padding(20);
            welcomeLayout.BackColor = System.Drawing.Color.FromArgb(25, 42, 66);
            welcomeLayout.TabIndex = 20;
            welcomeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            welcomeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            welcomeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            welcomeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            welcomeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            welcomeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            //
            // welcomeTitle
            //
            welcomeTitle.Name = "welcomeTitle";
            welcomeTitle.Margin = new System.Windows.Forms.Padding(0);
            welcomeTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            welcomeTitle.Text = "کتابخانهٔ شما";
            welcomeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            welcomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            welcomeTitle.AutoSize = false;
            welcomeTitle.AutoEllipsis = true;
            welcomeTitle.ForeColor = System.Drawing.Color.White;
            welcomeTitle.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            welcomeTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            welcomeTitle.TabIndex = 21;
            //
            // welcomeText
            //
            welcomeText.Name = "welcomeText";
            welcomeText.Margin = new System.Windows.Forms.Padding(0);
            welcomeText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            welcomeText.Text = "ثبت کتاب‌ها، مدیریت اعضا و پیگیری امانت و برگشت در یک محیط یکپارچه.";
            welcomeText.Dock = System.Windows.Forms.DockStyle.Fill;
            welcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            welcomeText.AutoSize = false;
            welcomeText.AutoEllipsis = true;
            welcomeText.ForeColor = System.Drawing.Color.White;
            welcomeText.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            welcomeText.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            welcomeText.TabIndex = 22;
            //
            // welcomeBooks
            //
            welcomeBooks.Name = "welcomeBooks";
            welcomeBooks.Margin = new System.Windows.Forms.Padding(0);
            welcomeBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            welcomeBooks.Text = "کتاب‌ها و تصاویر";
            welcomeBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            welcomeBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            welcomeBooks.AutoSize = false;
            welcomeBooks.AutoEllipsis = true;
            welcomeBooks.ForeColor = System.Drawing.Color.White;
            welcomeBooks.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            welcomeBooks.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            welcomeBooks.TabIndex = 23;
            //
            // welcomeMembers
            //
            welcomeMembers.Name = "welcomeMembers";
            welcomeMembers.Margin = new System.Windows.Forms.Padding(0);
            welcomeMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            welcomeMembers.Text = "عضویت عادی و ویژه";
            welcomeMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            welcomeMembers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            welcomeMembers.AutoSize = false;
            welcomeMembers.AutoEllipsis = true;
            welcomeMembers.ForeColor = System.Drawing.Color.White;
            welcomeMembers.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            welcomeMembers.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            welcomeMembers.TabIndex = 24;
            //
            // welcomeLoans
            //
            welcomeLoans.Name = "welcomeLoans";
            welcomeLoans.Margin = new System.Windows.Forms.Padding(0);
            welcomeLoans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            welcomeLoans.Text = "تاریخ شمسی و سابقهٔ امانت";
            welcomeLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            welcomeLoans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            welcomeLoans.AutoSize = false;
            welcomeLoans.AutoEllipsis = true;
            welcomeLoans.ForeColor = System.Drawing.Color.White;
            welcomeLoans.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            welcomeLoans.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            welcomeLoans.TabIndex = 25;
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
            bodyLayout.TabIndex = 26;
            bodyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            bodyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            bodyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            headingLayout.Controls.Add(headingLabel, 0, 0);
            headingLayout.Controls.Add(subtitleLabel, 0, 1);
            headerLayout.Controls.Add(headingLayout, 0, 0);
            rootLayout.Controls.Add(headerLayout, 0, 0);
            rootLayout.Controls.Add(footerLabel, 0, 2);
            viewportPanel.Controls.Add(rootLayout);
            Controls.Add(viewportPanel);
            loginUserField.Controls.Add(loginUserFieldLabel, 0, 0);
            loginUserField.Controls.Add(txt_user, 0, 1);
            loginPassField.Controls.Add(loginPassFieldLabel, 0, 0);
            loginPassField.Controls.Add(txt_pass, 0, 1);
            loginActions.Controls.Add(btn1);
            loginFieldsLayout.Controls.Add(loginUserField, 0, 0);
            loginFieldsLayout.Controls.Add(loginPassField, 0, 1);
            loginFieldsLayout.Controls.Add(chkShowPassword, 0, 2);
            loginFieldsLayout.Controls.Add(loginActions, 0, 3);
            loginScroll.Controls.Add(loginFieldsLayout);
            loginCard.Controls.Add(loginCardTitle, 0, 0);
            loginCard.Controls.Add(loginScroll, 0, 1);
            welcomeLayout.Controls.Add(welcomeBooks, 0, 2);
            welcomeLayout.Controls.Add(welcomeMembers, 0, 3);
            welcomeLayout.Controls.Add(welcomeLoans, 0, 4);
            welcomeLayout.Controls.Add(welcomeTitle, 0, 0);
            welcomeLayout.Controls.Add(welcomeText, 0, 1);
            bodyLayout.Controls.Add(loginCard, 0, 0);
            bodyLayout.Controls.Add(welcomeLayout, 1, 0);
            rootLayout.Controls.Add(bodyLayout, 0, 1);
            btn1.Click += btn1_Click;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            Load += LoginForm_Load;
            //
            // LoginForm
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Name = "LoginForm";
            ClientSize = new System.Drawing.Size(900, 550);
            MinimumSize = new System.Drawing.Size(740, 460);
            Text = "ورود به مدیریت کتابخانه";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            RightToLeftLayout = false;
            ShowIcon = false;
            AcceptButton = btn1;
            MaximizeBox = false;
            bodyLayout.ResumeLayout(false);
            bodyLayout.PerformLayout();
            welcomeLayout.ResumeLayout(false);
            welcomeLayout.PerformLayout();
            loginCard.ResumeLayout(false);
            loginCard.PerformLayout();
            loginScroll.ResumeLayout(false);
            loginScroll.PerformLayout();
            loginFieldsLayout.ResumeLayout(false);
            loginFieldsLayout.PerformLayout();
            loginActions.ResumeLayout(false);
            loginActions.PerformLayout();
            loginPassField.ResumeLayout(false);
            loginPassField.PerformLayout();
            loginUserField.ResumeLayout(false);
            loginUserField.PerformLayout();
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
        private System.Windows.Forms.Label footerLabel;
        private System.Windows.Forms.Panel viewportPanel;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TableLayoutPanel loginUserField;
        private System.Windows.Forms.Label loginUserFieldLabel;
        private System.Windows.Forms.TableLayoutPanel loginPassField;
        private System.Windows.Forms.Label loginPassFieldLabel;
        private System.Windows.Forms.FlowLayoutPanel loginActions;
        private System.Windows.Forms.TableLayoutPanel loginFieldsLayout;
        private System.Windows.Forms.Panel loginScroll;
        private System.Windows.Forms.TableLayoutPanel loginCard;
        private System.Windows.Forms.Label loginCardTitle;
        private System.Windows.Forms.TableLayoutPanel welcomeLayout;
        private System.Windows.Forms.Label welcomeTitle;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Label welcomeBooks;
        private System.Windows.Forms.Label welcomeMembers;
        private System.Windows.Forms.Label welcomeLoans;
        private System.Windows.Forms.TableLayoutPanel bodyLayout;
    }
}
