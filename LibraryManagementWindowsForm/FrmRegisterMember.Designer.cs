#nullable disable
namespace LibraryManagementWindowsForm
{
    partial class FrmRegisterMember
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
            userProfile1 = new LibraryManagementWindowsForm.UserProfile();
            footerLabel = new System.Windows.Forms.Label();
            viewportPanel = new System.Windows.Forms.Panel();
            txt_name = new System.Windows.Forms.TextBox();
            txt_nameField = new System.Windows.Forms.TableLayoutPanel();
            txt_nameFieldLabel = new System.Windows.Forms.Label();
            txt_family = new System.Windows.Forms.TextBox();
            txt_familyField = new System.Windows.Forms.TableLayoutPanel();
            txt_familyFieldLabel = new System.Windows.Forms.Label();
            txt_national_code = new System.Windows.Forms.TextBox();
            txt_national_codeField = new System.Windows.Forms.TableLayoutPanel();
            txt_national_codeFieldLabel = new System.Windows.Forms.Label();
            txt_mobile = new System.Windows.Forms.TextBox();
            txt_mobileField = new System.Windows.Forms.TableLayoutPanel();
            txt_mobileFieldLabel = new System.Windows.Forms.Label();
            checkBox_isSpecial = new System.Windows.Forms.CheckBox();
            btn_save = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            memberActions = new System.Windows.Forms.FlowLayoutPanel();
            memberFieldsLayout = new System.Windows.Forms.TableLayoutPanel();
            memberFieldsScroll = new System.Windows.Forms.Panel();
            memberFieldsCard = new System.Windows.Forms.TableLayoutPanel();
            memberFieldsCardTitle = new System.Windows.Forms.Label();
            picture_member = new System.Windows.Forms.PictureBox();
            btn_choose_photo = new System.Windows.Forms.Button();
            photoHint = new System.Windows.Forms.Label();
            memberPhotoActions = new System.Windows.Forms.FlowLayoutPanel();
            memberPhotoLayout = new System.Windows.Forms.TableLayoutPanel();
            memberPhotoCard = new System.Windows.Forms.TableLayoutPanel();
            memberPhotoCardTitle = new System.Windows.Forms.Label();
            bodyLayout = new System.Windows.Forms.TableLayoutPanel();
            rootLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            headingLayout.SuspendLayout();
            viewportPanel.SuspendLayout();
            txt_nameField.SuspendLayout();
            txt_familyField.SuspendLayout();
            txt_national_codeField.SuspendLayout();
            txt_mobileField.SuspendLayout();
            memberActions.SuspendLayout();
            memberFieldsLayout.SuspendLayout();
            memberFieldsScroll.SuspendLayout();
            memberFieldsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_member).BeginInit();
            memberPhotoActions.SuspendLayout();
            memberPhotoLayout.SuspendLayout();
            memberPhotoCard.SuspendLayout();
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
            rootLayout.MinimumSize = new System.Drawing.Size(0, 520);
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
            headingLabel.Text = "ثبت عضو جدید";
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
            subtitleLabel.Text = "مشخصات هویتی، وضعیت عضویت و تصویر عضو";
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
            viewportPanel.AutoScrollMinSize = new System.Drawing.Size(0, 520);
            viewportPanel.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            viewportPanel.TabIndex = 7;
            //
            // txt_name
            //
            txt_name.Name = "txt_name";
            txt_name.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txt_name.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_name.MaxLength = 20;
            txt_name.PlaceholderText = "";
            txt_name.ReadOnly = false;
            txt_name.Multiline = false;
            txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_name.BackColor = System.Drawing.Color.White;
            txt_name.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txt_name.TabIndex = 0;
            txt_name.TabIndex = 8;
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
            txt_nameField.TabIndex = 9;
            txt_nameField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            txt_nameField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            txt_nameField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // txt_nameFieldLabel
            //
            txt_nameFieldLabel.Name = "txt_nameFieldLabel";
            txt_nameFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            txt_nameFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txt_nameFieldLabel.Text = "نام *";
            txt_nameFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_nameFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            txt_nameFieldLabel.AutoSize = false;
            txt_nameFieldLabel.AutoEllipsis = true;
            txt_nameFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            txt_nameFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_nameFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txt_nameFieldLabel.TabIndex = 10;
            //
            // txt_family
            //
            txt_family.Name = "txt_family";
            txt_family.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txt_family.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txt_family.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_family.MaxLength = 30;
            txt_family.PlaceholderText = "";
            txt_family.ReadOnly = false;
            txt_family.Multiline = false;
            txt_family.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_family.BackColor = System.Drawing.Color.White;
            txt_family.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txt_family.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txt_family.TabIndex = 0;
            txt_family.TabIndex = 11;
            //
            // txt_familyField
            //
            txt_familyField.Name = "txt_familyField";
            txt_familyField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            txt_familyField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txt_familyField.Dock = System.Windows.Forms.DockStyle.Top;
            txt_familyField.ColumnCount = 1;
            txt_familyField.RowCount = 2;
            txt_familyField.Padding = new System.Windows.Forms.Padding(0);
            txt_familyField.BackColor = System.Drawing.Color.White;
            txt_familyField.Size = new System.Drawing.Size(280, 64);
            txt_familyField.TabIndex = 12;
            txt_familyField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            txt_familyField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            txt_familyField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // txt_familyFieldLabel
            //
            txt_familyFieldLabel.Name = "txt_familyFieldLabel";
            txt_familyFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            txt_familyFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txt_familyFieldLabel.Text = "نام خانوادگی *";
            txt_familyFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_familyFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            txt_familyFieldLabel.AutoSize = false;
            txt_familyFieldLabel.AutoEllipsis = true;
            txt_familyFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            txt_familyFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_familyFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txt_familyFieldLabel.TabIndex = 13;
            //
            // txt_national_code
            //
            txt_national_code.Name = "txt_national_code";
            txt_national_code.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txt_national_code.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txt_national_code.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_national_code.MaxLength = 10;
            txt_national_code.PlaceholderText = "";
            txt_national_code.ReadOnly = false;
            txt_national_code.Multiline = false;
            txt_national_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_national_code.BackColor = System.Drawing.Color.White;
            txt_national_code.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txt_national_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_national_code.TabIndex = 0;
            txt_national_code.TabIndex = 14;
            //
            // txt_national_codeField
            //
            txt_national_codeField.Name = "txt_national_codeField";
            txt_national_codeField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            txt_national_codeField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txt_national_codeField.Dock = System.Windows.Forms.DockStyle.Top;
            txt_national_codeField.ColumnCount = 1;
            txt_national_codeField.RowCount = 2;
            txt_national_codeField.Padding = new System.Windows.Forms.Padding(0);
            txt_national_codeField.BackColor = System.Drawing.Color.White;
            txt_national_codeField.Size = new System.Drawing.Size(280, 64);
            txt_national_codeField.TabIndex = 15;
            txt_national_codeField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            txt_national_codeField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            txt_national_codeField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // txt_national_codeFieldLabel
            //
            txt_national_codeFieldLabel.Name = "txt_national_codeFieldLabel";
            txt_national_codeFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            txt_national_codeFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txt_national_codeFieldLabel.Text = "کد ملی *";
            txt_national_codeFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_national_codeFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            txt_national_codeFieldLabel.AutoSize = false;
            txt_national_codeFieldLabel.AutoEllipsis = true;
            txt_national_codeFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            txt_national_codeFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_national_codeFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txt_national_codeFieldLabel.TabIndex = 16;
            //
            // txt_mobile
            //
            txt_mobile.Name = "txt_mobile";
            txt_mobile.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txt_mobile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txt_mobile.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_mobile.MaxLength = 11;
            txt_mobile.PlaceholderText = "";
            txt_mobile.ReadOnly = false;
            txt_mobile.Multiline = false;
            txt_mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_mobile.BackColor = System.Drawing.Color.White;
            txt_mobile.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txt_mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_mobile.TabIndex = 0;
            txt_mobile.TabIndex = 17;
            //
            // txt_mobileField
            //
            txt_mobileField.Name = "txt_mobileField";
            txt_mobileField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            txt_mobileField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txt_mobileField.Dock = System.Windows.Forms.DockStyle.Top;
            txt_mobileField.ColumnCount = 1;
            txt_mobileField.RowCount = 2;
            txt_mobileField.Padding = new System.Windows.Forms.Padding(0);
            txt_mobileField.BackColor = System.Drawing.Color.White;
            txt_mobileField.Size = new System.Drawing.Size(280, 64);
            txt_mobileField.TabIndex = 18;
            txt_mobileField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            txt_mobileField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            txt_mobileField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // txt_mobileFieldLabel
            //
            txt_mobileFieldLabel.Name = "txt_mobileFieldLabel";
            txt_mobileFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            txt_mobileFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txt_mobileFieldLabel.Text = "موبایل *";
            txt_mobileFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_mobileFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            txt_mobileFieldLabel.AutoSize = false;
            txt_mobileFieldLabel.AutoEllipsis = true;
            txt_mobileFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            txt_mobileFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_mobileFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txt_mobileFieldLabel.TabIndex = 19;
            //
            // checkBox_isSpecial
            //
            checkBox_isSpecial.Name = "checkBox_isSpecial";
            checkBox_isSpecial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            checkBox_isSpecial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            checkBox_isSpecial.Text = "عضویت ویژه";
            checkBox_isSpecial.AutoSize = true;
            checkBox_isSpecial.Enabled = true;
            checkBox_isSpecial.TabIndex = 20;
            //
            // btn_save
            //
            btn_save.Name = "btn_save";
            btn_save.Margin = new System.Windows.Forms.Padding(4);
            btn_save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btn_save.Text = "ثبت عضو";
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
            btn_save.TabIndex = 21;
            //
            // button2
            //
            button2.Name = "button2";
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            button2.Text = "بازگشت";
            button2.Size = new System.Drawing.Size(128, 40);
            button2.MinimumSize = new System.Drawing.Size(112, 38);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.BackColor = System.Drawing.Color.White;
            button2.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            button2.UseVisualStyleBackColor = false;
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.AutoSize = false;
            button2.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            button2.TabIndex = 22;
            //
            // memberActions
            //
            memberActions.Name = "memberActions";
            memberActions.Margin = new System.Windows.Forms.Padding(0);
            memberActions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            memberActions.Dock = System.Windows.Forms.DockStyle.Top;
            memberActions.AutoSize = true;
            memberActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            memberActions.WrapContents = true;
            memberActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            memberActions.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            memberActions.TabIndex = 23;
            //
            // memberFieldsLayout
            //
            memberFieldsLayout.Name = "memberFieldsLayout";
            memberFieldsLayout.Margin = new System.Windows.Forms.Padding(0);
            memberFieldsLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            memberFieldsLayout.Dock = System.Windows.Forms.DockStyle.Top;
            memberFieldsLayout.ColumnCount = 1;
            memberFieldsLayout.RowCount = 6;
            memberFieldsLayout.Padding = new System.Windows.Forms.Padding(4);
            memberFieldsLayout.BackColor = System.Drawing.Color.White;
            memberFieldsLayout.AutoSize = true;
            memberFieldsLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            memberFieldsLayout.TabIndex = 24;
            memberFieldsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            memberFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            memberFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            memberFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            memberFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            memberFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            memberFieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize, 0F));
            //
            // memberFieldsScroll
            //
            memberFieldsScroll.Name = "memberFieldsScroll";
            memberFieldsScroll.Margin = new System.Windows.Forms.Padding(0);
            memberFieldsScroll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            memberFieldsScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            memberFieldsScroll.AutoScroll = true;
            memberFieldsScroll.BackColor = System.Drawing.Color.White;
            memberFieldsScroll.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            memberFieldsScroll.TabIndex = 25;
            //
            // memberFieldsCard
            //
            memberFieldsCard.Name = "memberFieldsCard";
            memberFieldsCard.Margin = new System.Windows.Forms.Padding(6);
            memberFieldsCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            memberFieldsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            memberFieldsCard.ColumnCount = 1;
            memberFieldsCard.RowCount = 2;
            memberFieldsCard.Padding = new System.Windows.Forms.Padding(12);
            memberFieldsCard.BackColor = System.Drawing.Color.White;
            memberFieldsCard.TabIndex = 26;
            memberFieldsCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            memberFieldsCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            memberFieldsCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // memberFieldsCardTitle
            //
            memberFieldsCardTitle.Name = "memberFieldsCardTitle";
            memberFieldsCardTitle.Margin = new System.Windows.Forms.Padding(0);
            memberFieldsCardTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            memberFieldsCardTitle.Text = "اطلاعات عضو";
            memberFieldsCardTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            memberFieldsCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            memberFieldsCardTitle.AutoSize = false;
            memberFieldsCardTitle.AutoEllipsis = true;
            memberFieldsCardTitle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            memberFieldsCardTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            memberFieldsCardTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            memberFieldsCardTitle.TabIndex = 27;
            //
            // picture_member
            //
            picture_member.Name = "picture_member";
            picture_member.Margin = new System.Windows.Forms.Padding(4);
            picture_member.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            picture_member.Dock = System.Windows.Forms.DockStyle.Fill;
            picture_member.Size = new System.Drawing.Size(220, 220);
            picture_member.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picture_member.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            picture_member.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picture_member.Cursor = System.Windows.Forms.Cursors.Hand;
            picture_member.TabStop = false;
            picture_member.TabIndex = 28;
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
            btn_choose_photo.TabIndex = 29;
            //
            // photoHint
            //
            photoHint.Name = "photoHint";
            photoHint.Margin = new System.Windows.Forms.Padding(0);
            photoHint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            photoHint.Text = "PNG یا JPEG؛ حداکثر فایل ورودی ۵ مگابایت";
            photoHint.Dock = System.Windows.Forms.DockStyle.Fill;
            photoHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            photoHint.AutoSize = false;
            photoHint.AutoEllipsis = true;
            photoHint.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            photoHint.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            photoHint.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            photoHint.TabIndex = 30;
            //
            // memberPhotoActions
            //
            memberPhotoActions.Name = "memberPhotoActions";
            memberPhotoActions.Margin = new System.Windows.Forms.Padding(0);
            memberPhotoActions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            memberPhotoActions.Dock = System.Windows.Forms.DockStyle.Top;
            memberPhotoActions.AutoSize = true;
            memberPhotoActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            memberPhotoActions.WrapContents = true;
            memberPhotoActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            memberPhotoActions.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            memberPhotoActions.TabIndex = 31;
            //
            // memberPhotoLayout
            //
            memberPhotoLayout.Name = "memberPhotoLayout";
            memberPhotoLayout.Margin = new System.Windows.Forms.Padding(0);
            memberPhotoLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            memberPhotoLayout.Dock = System.Windows.Forms.DockStyle.Top;
            memberPhotoLayout.ColumnCount = 1;
            memberPhotoLayout.RowCount = 3;
            memberPhotoLayout.Padding = new System.Windows.Forms.Padding(4);
            memberPhotoLayout.BackColor = System.Drawing.Color.White;
            memberPhotoLayout.AutoSize = true;
            memberPhotoLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            memberPhotoLayout.TabIndex = 32;
            memberPhotoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            memberPhotoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            memberPhotoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize, 0F));
            memberPhotoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            //
            // memberPhotoCard
            //
            memberPhotoCard.Name = "memberPhotoCard";
            memberPhotoCard.Margin = new System.Windows.Forms.Padding(6);
            memberPhotoCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            memberPhotoCard.Dock = System.Windows.Forms.DockStyle.Fill;
            memberPhotoCard.ColumnCount = 1;
            memberPhotoCard.RowCount = 2;
            memberPhotoCard.Padding = new System.Windows.Forms.Padding(12);
            memberPhotoCard.BackColor = System.Drawing.Color.White;
            memberPhotoCard.TabIndex = 33;
            memberPhotoCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            memberPhotoCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            memberPhotoCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // memberPhotoCardTitle
            //
            memberPhotoCardTitle.Name = "memberPhotoCardTitle";
            memberPhotoCardTitle.Margin = new System.Windows.Forms.Padding(0);
            memberPhotoCardTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            memberPhotoCardTitle.Text = "تصویر عضو";
            memberPhotoCardTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            memberPhotoCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            memberPhotoCardTitle.AutoSize = false;
            memberPhotoCardTitle.AutoEllipsis = true;
            memberPhotoCardTitle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            memberPhotoCardTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            memberPhotoCardTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            memberPhotoCardTitle.TabIndex = 34;
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
            bodyLayout.TabIndex = 35;
            bodyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            bodyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            bodyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            headingLayout.Controls.Add(headingLabel, 0, 0);
            headingLayout.Controls.Add(subtitleLabel, 0, 1);
            headerLayout.Controls.Add(userProfile1, 0, 0);
            headerLayout.Controls.Add(headingLayout, 1, 0);
            rootLayout.Controls.Add(headerLayout, 0, 0);
            rootLayout.Controls.Add(footerLabel, 0, 2);
            viewportPanel.Controls.Add(rootLayout);
            Controls.Add(viewportPanel);
            txt_nameField.Controls.Add(txt_nameFieldLabel, 0, 0);
            txt_nameField.Controls.Add(txt_name, 0, 1);
            txt_familyField.Controls.Add(txt_familyFieldLabel, 0, 0);
            txt_familyField.Controls.Add(txt_family, 0, 1);
            txt_national_codeField.Controls.Add(txt_national_codeFieldLabel, 0, 0);
            txt_national_codeField.Controls.Add(txt_national_code, 0, 1);
            txt_mobileField.Controls.Add(txt_mobileFieldLabel, 0, 0);
            txt_mobileField.Controls.Add(txt_mobile, 0, 1);
            memberActions.Controls.Add(btn_save);
            memberActions.Controls.Add(button2);
            memberFieldsLayout.Controls.Add(txt_nameField, 0, 0);
            memberFieldsLayout.Controls.Add(txt_familyField, 0, 1);
            memberFieldsLayout.Controls.Add(txt_national_codeField, 0, 2);
            memberFieldsLayout.Controls.Add(txt_mobileField, 0, 3);
            memberFieldsLayout.Controls.Add(checkBox_isSpecial, 0, 4);
            memberFieldsLayout.Controls.Add(memberActions, 0, 5);
            memberFieldsScroll.Controls.Add(memberFieldsLayout);
            memberFieldsCard.Controls.Add(memberFieldsCardTitle, 0, 0);
            memberFieldsCard.Controls.Add(memberFieldsScroll, 0, 1);
            memberPhotoActions.Controls.Add(btn_choose_photo);
            memberPhotoLayout.Controls.Add(picture_member, 0, 0);
            memberPhotoLayout.Controls.Add(memberPhotoActions, 0, 1);
            memberPhotoLayout.Controls.Add(photoHint, 0, 2);
            memberPhotoCard.Controls.Add(memberPhotoCardTitle, 0, 0);
            memberPhotoCard.Controls.Add(memberPhotoLayout, 0, 1);
            bodyLayout.Controls.Add(memberFieldsCard, 0, 0);
            bodyLayout.Controls.Add(memberPhotoCard, 1, 0);
            rootLayout.Controls.Add(bodyLayout, 0, 1);
            btn_save.Click += btn_save_Click;
            button2.Click += button2_Click;
            picture_member.Click += picture_member_Click;
            btn_choose_photo.Click += picture_member_Click;
            txt_national_code.KeyPress += txt_national_code_KeyPress;
            txt_mobile.KeyPress += txt_mobile_KeyPress;
            Load += FrmRegisterMember_Load;
            //
            // FrmRegisterMember
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Name = "FrmRegisterMember";
            ClientSize = new System.Drawing.Size(900, 670);
            MinimumSize = new System.Drawing.Size(720, 560);
            Text = "ثبت عضو جدید";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            RightToLeftLayout = false;
            ShowIcon = false;
            AcceptButton = btn_save;
            CancelButton = button2;
            bodyLayout.ResumeLayout(false);
            bodyLayout.PerformLayout();
            memberPhotoCard.ResumeLayout(false);
            memberPhotoCard.PerformLayout();
            memberPhotoLayout.ResumeLayout(false);
            memberPhotoLayout.PerformLayout();
            memberPhotoActions.ResumeLayout(false);
            memberPhotoActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_member).EndInit();
            memberFieldsCard.ResumeLayout(false);
            memberFieldsCard.PerformLayout();
            memberFieldsScroll.ResumeLayout(false);
            memberFieldsScroll.PerformLayout();
            memberFieldsLayout.ResumeLayout(false);
            memberFieldsLayout.PerformLayout();
            memberActions.ResumeLayout(false);
            memberActions.PerformLayout();
            txt_mobileField.ResumeLayout(false);
            txt_mobileField.PerformLayout();
            txt_national_codeField.ResumeLayout(false);
            txt_national_codeField.PerformLayout();
            txt_familyField.ResumeLayout(false);
            txt_familyField.PerformLayout();
            txt_nameField.ResumeLayout(false);
            txt_nameField.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TableLayoutPanel txt_nameField;
        private System.Windows.Forms.Label txt_nameFieldLabel;
        private System.Windows.Forms.TextBox txt_family;
        private System.Windows.Forms.TableLayoutPanel txt_familyField;
        private System.Windows.Forms.Label txt_familyFieldLabel;
        private System.Windows.Forms.TextBox txt_national_code;
        private System.Windows.Forms.TableLayoutPanel txt_national_codeField;
        private System.Windows.Forms.Label txt_national_codeFieldLabel;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TableLayoutPanel txt_mobileField;
        private System.Windows.Forms.Label txt_mobileFieldLabel;
        private System.Windows.Forms.CheckBox checkBox_isSpecial;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel memberActions;
        private System.Windows.Forms.TableLayoutPanel memberFieldsLayout;
        private System.Windows.Forms.Panel memberFieldsScroll;
        private System.Windows.Forms.TableLayoutPanel memberFieldsCard;
        private System.Windows.Forms.Label memberFieldsCardTitle;
        private System.Windows.Forms.PictureBox picture_member;
        private System.Windows.Forms.Button btn_choose_photo;
        private System.Windows.Forms.Label photoHint;
        private System.Windows.Forms.FlowLayoutPanel memberPhotoActions;
        private System.Windows.Forms.TableLayoutPanel memberPhotoLayout;
        private System.Windows.Forms.TableLayoutPanel memberPhotoCard;
        private System.Windows.Forms.Label memberPhotoCardTitle;
        private System.Windows.Forms.TableLayoutPanel bodyLayout;
    }
}
