#nullable disable
namespace LibraryManagementWindowsForm
{
    partial class FrmAdminManagement
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
            System.Windows.Forms.DataGridViewCellStyle dgvAdminsColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvAdminsDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvAdminsAlternatingRowsDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            rootLayout = new System.Windows.Forms.TableLayoutPanel();
            headerLayout = new System.Windows.Forms.TableLayoutPanel();
            headingLayout = new System.Windows.Forms.TableLayoutPanel();
            headingLabel = new System.Windows.Forms.Label();
            subtitleLabel = new System.Windows.Forms.Label();
            userProfile1 = new LibraryManagementWindowsForm.UserProfile();
            footerLabel = new System.Windows.Forms.Label();
            viewportPanel = new System.Windows.Forms.Panel();
            txt_search = new System.Windows.Forms.TextBox();
            btnRefresh = new System.Windows.Forms.Button();
            btnCreateAdmin = new System.Windows.Forms.Button();
            adminSearchLayout = new System.Windows.Forms.TableLayoutPanel();
            adminSearchField = new System.Windows.Forms.TableLayoutPanel();
            adminSearchFieldLabel = new System.Windows.Forms.Label();
            adminSearchActions = new System.Windows.Forms.FlowLayoutPanel();
            dgvAdmins = new System.Windows.Forms.DataGridView();
            dgvAdmins_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgvAdmins_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgvAdmins_IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            _status = new System.Windows.Forms.Label();
            adminListLayout = new System.Windows.Forms.TableLayoutPanel();
            adminsCard = new System.Windows.Forms.TableLayoutPanel();
            adminsCardTitle = new System.Windows.Forms.Label();
            txtUserName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            passwordHint = new System.Windows.Forms.Label();
            btnUpdate = new System.Windows.Forms.Button();
            btnEnable = new System.Windows.Forms.Button();
            btnDisable = new System.Windows.Forms.Button();
            adminNameField = new System.Windows.Forms.TableLayoutPanel();
            adminNameFieldLabel = new System.Windows.Forms.Label();
            adminPasswordField = new System.Windows.Forms.TableLayoutPanel();
            adminPasswordFieldLabel = new System.Windows.Forms.Label();
            adminEditorActions = new System.Windows.Forms.FlowLayoutPanel();
            adminEditorLayout = new System.Windows.Forms.TableLayoutPanel();
            adminEditorScroll = new System.Windows.Forms.Panel();
            adminEditorCard = new System.Windows.Forms.TableLayoutPanel();
            adminEditorCardTitle = new System.Windows.Forms.Label();
            bodyLayout = new System.Windows.Forms.TableLayoutPanel();
            rootLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            headingLayout.SuspendLayout();
            viewportPanel.SuspendLayout();
            adminSearchLayout.SuspendLayout();
            adminSearchField.SuspendLayout();
            adminSearchActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            adminListLayout.SuspendLayout();
            adminsCard.SuspendLayout();
            adminNameField.SuspendLayout();
            adminPasswordField.SuspendLayout();
            adminEditorActions.SuspendLayout();
            adminEditorLayout.SuspendLayout();
            adminEditorScroll.SuspendLayout();
            adminEditorCard.SuspendLayout();
            bodyLayout.SuspendLayout();
            SuspendLayout();
            dgvAdminsColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            dgvAdminsColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            dgvAdminsColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dgvAdminsColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dgvAdminsColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(6);
            dgvAdminsColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvAdminsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvAdminsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            dgvAdminsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 242, 238);
            dgvAdminsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            dgvAdminsDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dgvAdminsDefaultCellStyle.Padding = new System.Windows.Forms.Padding(6);
            dgvAdminsDefaultCellStyle.NullValue = "—";
            dgvAdminsDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvAdminsAlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(249, 251, 253);
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
            rootLayout.MinimumSize = new System.Drawing.Size(0, 580);
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
            headingLabel.Text = "مدیریت مدیران";
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
            subtitleLabel.Text = "حساب‌ها، نقش‌ها و وضعیت دسترسی بدون نمایش رمز";
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
            viewportPanel.AutoScrollMinSize = new System.Drawing.Size(0, 580);
            viewportPanel.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            viewportPanel.TabIndex = 7;
            //
            // txt_search
            //
            txt_search.Name = "txt_search";
            txt_search.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txt_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txt_search.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_search.MaxLength = 50;
            txt_search.PlaceholderText = "نام کاربری مدیر…";
            txt_search.ReadOnly = false;
            txt_search.Multiline = false;
            txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_search.BackColor = System.Drawing.Color.White;
            txt_search.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txt_search.TabIndex = 0;
            txt_search.TabIndex = 8;
            //
            // btnRefresh
            //
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btnRefresh.Text = "تازه‌سازی";
            btnRefresh.Size = new System.Drawing.Size(128, 40);
            btnRefresh.MinimumSize = new System.Drawing.Size(112, 38);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.BackColor = System.Drawing.Color.White;
            btnRefresh.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefresh.AutoSize = false;
            btnRefresh.FlatAppearance.BorderSize = 1;
            btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btnRefresh.TabIndex = 9;
            //
            // btnCreateAdmin
            //
            btnCreateAdmin.Name = "btnCreateAdmin";
            btnCreateAdmin.Margin = new System.Windows.Forms.Padding(4);
            btnCreateAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btnCreateAdmin.Text = "مدیر جدید";
            btnCreateAdmin.Size = new System.Drawing.Size(128, 40);
            btnCreateAdmin.MinimumSize = new System.Drawing.Size(112, 38);
            btnCreateAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreateAdmin.BackColor = System.Drawing.Color.FromArgb(12, 120, 113);
            btnCreateAdmin.ForeColor = System.Drawing.Color.White;
            btnCreateAdmin.UseVisualStyleBackColor = false;
            btnCreateAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCreateAdmin.AutoSize = false;
            btnCreateAdmin.FlatAppearance.BorderSize = 0;
            btnCreateAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btnCreateAdmin.TabIndex = 10;
            //
            // adminSearchLayout
            //
            adminSearchLayout.Name = "adminSearchLayout";
            adminSearchLayout.Margin = new System.Windows.Forms.Padding(0);
            adminSearchLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            adminSearchLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            adminSearchLayout.ColumnCount = 2;
            adminSearchLayout.RowCount = 1;
            adminSearchLayout.Padding = new System.Windows.Forms.Padding(0);
            adminSearchLayout.BackColor = System.Drawing.Color.White;
            adminSearchLayout.TabIndex = 11;
            adminSearchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            adminSearchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            adminSearchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            //
            // adminSearchField
            //
            adminSearchField.Name = "adminSearchField";
            adminSearchField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            adminSearchField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            adminSearchField.Dock = System.Windows.Forms.DockStyle.Top;
            adminSearchField.ColumnCount = 1;
            adminSearchField.RowCount = 2;
            adminSearchField.Padding = new System.Windows.Forms.Padding(0);
            adminSearchField.BackColor = System.Drawing.Color.White;
            adminSearchField.Size = new System.Drawing.Size(280, 64);
            adminSearchField.TabIndex = 12;
            adminSearchField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            adminSearchField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            adminSearchField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // adminSearchFieldLabel
            //
            adminSearchFieldLabel.Name = "adminSearchFieldLabel";
            adminSearchFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            adminSearchFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            adminSearchFieldLabel.Text = "جست‌وجوی نام کاربری";
            adminSearchFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            adminSearchFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            adminSearchFieldLabel.AutoSize = false;
            adminSearchFieldLabel.AutoEllipsis = true;
            adminSearchFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            adminSearchFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            adminSearchFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adminSearchFieldLabel.TabIndex = 13;
            //
            // adminSearchActions
            //
            adminSearchActions.Name = "adminSearchActions";
            adminSearchActions.Margin = new System.Windows.Forms.Padding(0);
            adminSearchActions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            adminSearchActions.Dock = System.Windows.Forms.DockStyle.Top;
            adminSearchActions.AutoSize = true;
            adminSearchActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            adminSearchActions.WrapContents = true;
            adminSearchActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            adminSearchActions.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            adminSearchActions.TabIndex = 14;
            //
            // dgvAdmins
            //
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.Margin = new System.Windows.Forms.Padding(0);
            dgvAdmins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dgvAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAdmins.AutoGenerateColumns = false;
            dgvAdmins.ReadOnly = true;
            dgvAdmins.AllowUserToAddRows = false;
            dgvAdmins.AllowUserToDeleteRows = false;
            dgvAdmins.AllowUserToResizeRows = false;
            dgvAdmins.MultiSelect = false;
            dgvAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAdmins.RowHeadersVisible = false;
            dgvAdmins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdmins.ColumnHeadersHeight = 42;
            dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAdmins.BackgroundColor = System.Drawing.Color.White;
            dgvAdmins.GridColor = System.Drawing.Color.FromArgb(222, 230, 239);
            dgvAdmins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvAdmins.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAdmins.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvAdmins.EnableHeadersVisualStyles = false;
            dgvAdmins.RowTemplate.Height = 36;
            dgvAdmins.Tag = "admins";
            dgvAdmins.ColumnHeadersDefaultCellStyle = dgvAdminsColumnHeadersDefaultCellStyle;
            dgvAdmins.DefaultCellStyle = dgvAdminsDefaultCellStyle;
            dgvAdmins.AlternatingRowsDefaultCellStyle = dgvAdminsAlternatingRowsDefaultCellStyle;
            dgvAdmins.TabIndex = 15;
            //
            // dgvAdmins_UserName
            //
            dgvAdmins_UserName.Name = "UserName";
            dgvAdmins_UserName.DataPropertyName = "UserName";
            dgvAdmins_UserName.HeaderText = "نام کاربری";
            dgvAdmins_UserName.MinimumWidth = 100;
            dgvAdmins_UserName.FillWeight = 210F;
            dgvAdmins_UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // dgvAdmins_Role
            //
            dgvAdmins_Role.Name = "Role";
            dgvAdmins_Role.DataPropertyName = "Role";
            dgvAdmins_Role.HeaderText = "نقش";
            dgvAdmins_Role.MinimumWidth = 100;
            dgvAdmins_Role.FillWeight = 150F;
            dgvAdmins_Role.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // dgvAdmins_IsActive
            //
            dgvAdmins_IsActive.Name = "IsActive";
            dgvAdmins_IsActive.DataPropertyName = "IsActive";
            dgvAdmins_IsActive.HeaderText = "وضعیت";
            dgvAdmins_IsActive.MinimumWidth = 100;
            dgvAdmins_IsActive.FillWeight = 110F;
            dgvAdmins_IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // _status
            //
            _status.Name = "_status";
            _status.Margin = new System.Windows.Forms.Padding(0);
            _status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            _status.Text = "برای ویرایش، یک مدیر را از فهرست انتخاب کنید.";
            _status.Dock = System.Windows.Forms.DockStyle.Fill;
            _status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            _status.AutoSize = false;
            _status.AutoEllipsis = true;
            _status.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            _status.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _status.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _status.TabIndex = 16;
            //
            // adminListLayout
            //
            adminListLayout.Name = "adminListLayout";
            adminListLayout.Margin = new System.Windows.Forms.Padding(0);
            adminListLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            adminListLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            adminListLayout.ColumnCount = 1;
            adminListLayout.RowCount = 3;
            adminListLayout.Padding = new System.Windows.Forms.Padding(0);
            adminListLayout.BackColor = System.Drawing.Color.White;
            adminListLayout.TabIndex = 17;
            adminListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            adminListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            adminListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            adminListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            //
            // adminsCard
            //
            adminsCard.Name = "adminsCard";
            adminsCard.Margin = new System.Windows.Forms.Padding(6);
            adminsCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            adminsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            adminsCard.ColumnCount = 1;
            adminsCard.RowCount = 2;
            adminsCard.Padding = new System.Windows.Forms.Padding(12);
            adminsCard.BackColor = System.Drawing.Color.White;
            adminsCard.TabIndex = 18;
            adminsCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            adminsCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            adminsCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // adminsCardTitle
            //
            adminsCardTitle.Name = "adminsCardTitle";
            adminsCardTitle.Margin = new System.Windows.Forms.Padding(0);
            adminsCardTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            adminsCardTitle.Text = "فهرست مدیران";
            adminsCardTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            adminsCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            adminsCardTitle.AutoSize = false;
            adminsCardTitle.AutoEllipsis = true;
            adminsCardTitle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            adminsCardTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            adminsCardTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adminsCardTitle.TabIndex = 19;
            //
            // txtUserName
            //
            txtUserName.Name = "txtUserName";
            txtUserName.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            txtUserName.MaxLength = 50;
            txtUserName.PlaceholderText = "";
            txtUserName.ReadOnly = false;
            txtUserName.Multiline = false;
            txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUserName.BackColor = System.Drawing.Color.White;
            txtUserName.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtUserName.TabIndex = 0;
            txtUserName.TabIndex = 20;
            //
            // txtPassword
            //
            txtPassword.Name = "txtPassword";
            txtPassword.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            txtPassword.MaxLength = 100;
            txtPassword.PlaceholderText = "خالی = حفظ رمز فعلی";
            txtPassword.ReadOnly = false;
            txtPassword.Multiline = false;
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.BackColor = System.Drawing.Color.White;
            txtPassword.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TabIndex = 21;
            //
            // passwordHint
            //
            passwordHint.Name = "passwordHint";
            passwordHint.Margin = new System.Windows.Forms.Padding(0);
            passwordHint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            passwordHint.Text = "برای حفظ رمز فعلی، کادر رمز را خالی بگذارید.";
            passwordHint.Dock = System.Windows.Forms.DockStyle.Fill;
            passwordHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            passwordHint.AutoSize = false;
            passwordHint.AutoEllipsis = true;
            passwordHint.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            passwordHint.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            passwordHint.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordHint.TabIndex = 22;
            //
            // btnUpdate
            //
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btnUpdate.Text = "ذخیرهٔ تغییرات";
            btnUpdate.Size = new System.Drawing.Size(128, 40);
            btnUpdate.MinimumSize = new System.Drawing.Size(112, 38);
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(12, 120, 113);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUpdate.AutoSize = false;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btnUpdate.TabIndex = 23;
            //
            // btnEnable
            //
            btnEnable.Name = "btnEnable";
            btnEnable.Margin = new System.Windows.Forms.Padding(4);
            btnEnable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btnEnable.Text = "فعال‌سازی";
            btnEnable.Size = new System.Drawing.Size(128, 40);
            btnEnable.MinimumSize = new System.Drawing.Size(112, 38);
            btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEnable.BackColor = System.Drawing.Color.White;
            btnEnable.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            btnEnable.UseVisualStyleBackColor = false;
            btnEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEnable.AutoSize = false;
            btnEnable.FlatAppearance.BorderSize = 1;
            btnEnable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btnEnable.TabIndex = 24;
            //
            // btnDisable
            //
            btnDisable.Name = "btnDisable";
            btnDisable.Margin = new System.Windows.Forms.Padding(4);
            btnDisable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btnDisable.Text = "غیرفعال‌سازی";
            btnDisable.Size = new System.Drawing.Size(128, 40);
            btnDisable.MinimumSize = new System.Drawing.Size(112, 38);
            btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDisable.BackColor = System.Drawing.Color.FromArgb(169, 49, 60);
            btnDisable.ForeColor = System.Drawing.Color.White;
            btnDisable.UseVisualStyleBackColor = false;
            btnDisable.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDisable.AutoSize = false;
            btnDisable.FlatAppearance.BorderSize = 0;
            btnDisable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btnDisable.TabIndex = 25;
            //
            // adminNameField
            //
            adminNameField.Name = "adminNameField";
            adminNameField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            adminNameField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            adminNameField.Dock = System.Windows.Forms.DockStyle.Top;
            adminNameField.ColumnCount = 1;
            adminNameField.RowCount = 2;
            adminNameField.Padding = new System.Windows.Forms.Padding(0);
            adminNameField.BackColor = System.Drawing.Color.White;
            adminNameField.Size = new System.Drawing.Size(280, 64);
            adminNameField.TabIndex = 26;
            adminNameField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            adminNameField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            adminNameField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // adminNameFieldLabel
            //
            adminNameFieldLabel.Name = "adminNameFieldLabel";
            adminNameFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            adminNameFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            adminNameFieldLabel.Text = "نام کاربری";
            adminNameFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            adminNameFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            adminNameFieldLabel.AutoSize = false;
            adminNameFieldLabel.AutoEllipsis = true;
            adminNameFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            adminNameFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            adminNameFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adminNameFieldLabel.TabIndex = 27;
            //
            // adminPasswordField
            //
            adminPasswordField.Name = "adminPasswordField";
            adminPasswordField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            adminPasswordField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            adminPasswordField.Dock = System.Windows.Forms.DockStyle.Top;
            adminPasswordField.ColumnCount = 1;
            adminPasswordField.RowCount = 2;
            adminPasswordField.Padding = new System.Windows.Forms.Padding(0);
            adminPasswordField.BackColor = System.Drawing.Color.White;
            adminPasswordField.Size = new System.Drawing.Size(280, 64);
            adminPasswordField.TabIndex = 28;
            adminPasswordField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            adminPasswordField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            adminPasswordField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // adminPasswordFieldLabel
            //
            adminPasswordFieldLabel.Name = "adminPasswordFieldLabel";
            adminPasswordFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            adminPasswordFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            adminPasswordFieldLabel.Text = "رمز جدید؛ اختیاری";
            adminPasswordFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            adminPasswordFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            adminPasswordFieldLabel.AutoSize = false;
            adminPasswordFieldLabel.AutoEllipsis = true;
            adminPasswordFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            adminPasswordFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            adminPasswordFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adminPasswordFieldLabel.TabIndex = 29;
            //
            // adminEditorActions
            //
            adminEditorActions.Name = "adminEditorActions";
            adminEditorActions.Margin = new System.Windows.Forms.Padding(0);
            adminEditorActions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            adminEditorActions.Dock = System.Windows.Forms.DockStyle.Top;
            adminEditorActions.AutoSize = true;
            adminEditorActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            adminEditorActions.WrapContents = true;
            adminEditorActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            adminEditorActions.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            adminEditorActions.MaximumSize = new System.Drawing.Size(280, 0);
            adminEditorActions.TabIndex = 30;
            //
            // adminEditorLayout
            //
            adminEditorLayout.Name = "adminEditorLayout";
            adminEditorLayout.Margin = new System.Windows.Forms.Padding(0);
            adminEditorLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            adminEditorLayout.Dock = System.Windows.Forms.DockStyle.Top;
            adminEditorLayout.ColumnCount = 1;
            adminEditorLayout.RowCount = 4;
            adminEditorLayout.Padding = new System.Windows.Forms.Padding(4);
            adminEditorLayout.BackColor = System.Drawing.Color.White;
            adminEditorLayout.AutoSize = true;
            adminEditorLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            adminEditorLayout.MaximumSize = new System.Drawing.Size(292, 0);
            adminEditorLayout.TabIndex = 31;
            adminEditorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            adminEditorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            adminEditorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            adminEditorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            adminEditorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize, 0F));
            //
            // adminEditorScroll
            //
            adminEditorScroll.Name = "adminEditorScroll";
            adminEditorScroll.Margin = new System.Windows.Forms.Padding(0);
            adminEditorScroll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            adminEditorScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            adminEditorScroll.AutoScroll = true;
            adminEditorScroll.BackColor = System.Drawing.Color.White;
            adminEditorScroll.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            adminEditorScroll.TabIndex = 32;
            //
            // adminEditorCard
            //
            adminEditorCard.Name = "adminEditorCard";
            adminEditorCard.Margin = new System.Windows.Forms.Padding(6);
            adminEditorCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            adminEditorCard.Dock = System.Windows.Forms.DockStyle.Fill;
            adminEditorCard.ColumnCount = 1;
            adminEditorCard.RowCount = 2;
            adminEditorCard.Padding = new System.Windows.Forms.Padding(12);
            adminEditorCard.BackColor = System.Drawing.Color.White;
            adminEditorCard.TabIndex = 33;
            adminEditorCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            adminEditorCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            adminEditorCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // adminEditorCardTitle
            //
            adminEditorCardTitle.Name = "adminEditorCardTitle";
            adminEditorCardTitle.Margin = new System.Windows.Forms.Padding(0);
            adminEditorCardTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            adminEditorCardTitle.Text = "حساب انتخاب‌شده";
            adminEditorCardTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            adminEditorCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            adminEditorCardTitle.AutoSize = false;
            adminEditorCardTitle.AutoEllipsis = true;
            adminEditorCardTitle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            adminEditorCardTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            adminEditorCardTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adminEditorCardTitle.TabIndex = 34;
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
            bodyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            bodyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            headingLayout.Controls.Add(headingLabel, 0, 0);
            headingLayout.Controls.Add(subtitleLabel, 0, 1);
            headerLayout.Controls.Add(userProfile1, 0, 0);
            headerLayout.Controls.Add(headingLayout, 1, 0);
            rootLayout.Controls.Add(headerLayout, 0, 0);
            rootLayout.Controls.Add(footerLabel, 0, 2);
            viewportPanel.Controls.Add(rootLayout);
            Controls.Add(viewportPanel);
            adminSearchField.Controls.Add(adminSearchFieldLabel, 0, 0);
            adminSearchField.Controls.Add(txt_search, 0, 1);
            adminSearchLayout.Controls.Add(adminSearchField, 0, 0);
            adminSearchActions.Controls.Add(btnRefresh);
            adminSearchActions.Controls.Add(btnCreateAdmin);
            adminSearchLayout.Controls.Add(adminSearchActions, 1, 0);
            adminListLayout.Controls.Add(adminSearchLayout, 0, 0);
            adminListLayout.Controls.Add(dgvAdmins, 0, 1);
            adminListLayout.Controls.Add(_status, 0, 2);
            adminsCard.Controls.Add(adminsCardTitle, 0, 0);
            adminsCard.Controls.Add(adminListLayout, 0, 1);
            adminNameField.Controls.Add(adminNameFieldLabel, 0, 0);
            adminNameField.Controls.Add(txtUserName, 0, 1);
            adminPasswordField.Controls.Add(adminPasswordFieldLabel, 0, 0);
            adminPasswordField.Controls.Add(txtPassword, 0, 1);
            adminEditorActions.Controls.Add(btnUpdate);
            adminEditorActions.Controls.Add(btnEnable);
            adminEditorActions.Controls.Add(btnDisable);
            adminEditorLayout.Controls.Add(adminNameField, 0, 0);
            adminEditorLayout.Controls.Add(adminPasswordField, 0, 1);
            adminEditorLayout.Controls.Add(passwordHint, 0, 2);
            adminEditorLayout.Controls.Add(adminEditorActions, 0, 3);
            adminEditorScroll.Controls.Add(adminEditorLayout);
            adminEditorCard.Controls.Add(adminEditorCardTitle, 0, 0);
            adminEditorCard.Controls.Add(adminEditorScroll, 0, 1);
            bodyLayout.Controls.Add(adminsCard, 0, 0);
            bodyLayout.Controls.Add(adminEditorCard, 1, 0);
            rootLayout.Controls.Add(bodyLayout, 0, 1);
            dgvAdmins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgvAdmins_UserName, dgvAdmins_Role, dgvAdmins_IsActive });
            btnRefresh.Click += btnRefresh_Click;
            btnCreateAdmin.Click += btnCreateAdmin_Click;
            btnUpdate.Click += btnEdit_Click;
            btnEnable.Click += button5_Click;
            btnDisable.Click += btnDisable_Click;
            txt_search.TextChanged += textBox1_TextChanged;
            dgvAdmins.CellClick += dgvAdmins_CellClick;
            Load += FrmAdminManagement_Load;
            //
            // FrmAdminManagement
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Name = "FrmAdminManagement";
            ClientSize = new System.Drawing.Size(1120, 740);
            MinimumSize = new System.Drawing.Size(860, 560);
            Text = "مدیریت مدیران";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            RightToLeftLayout = false;
            ShowIcon = false;
            bodyLayout.ResumeLayout(false);
            bodyLayout.PerformLayout();
            adminEditorCard.ResumeLayout(false);
            adminEditorCard.PerformLayout();
            adminEditorScroll.ResumeLayout(false);
            adminEditorScroll.PerformLayout();
            adminEditorLayout.ResumeLayout(false);
            adminEditorLayout.PerformLayout();
            adminEditorActions.ResumeLayout(false);
            adminEditorActions.PerformLayout();
            adminPasswordField.ResumeLayout(false);
            adminPasswordField.PerformLayout();
            adminNameField.ResumeLayout(false);
            adminNameField.PerformLayout();
            adminsCard.ResumeLayout(false);
            adminsCard.PerformLayout();
            adminListLayout.ResumeLayout(false);
            adminListLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            adminSearchActions.ResumeLayout(false);
            adminSearchActions.PerformLayout();
            adminSearchField.ResumeLayout(false);
            adminSearchField.PerformLayout();
            adminSearchLayout.ResumeLayout(false);
            adminSearchLayout.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCreateAdmin;
        private System.Windows.Forms.TableLayoutPanel adminSearchLayout;
        private System.Windows.Forms.TableLayoutPanel adminSearchField;
        private System.Windows.Forms.Label adminSearchFieldLabel;
        private System.Windows.Forms.FlowLayoutPanel adminSearchActions;
        private System.Windows.Forms.DataGridView dgvAdmins;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAdmins_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAdmins_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAdmins_IsActive;
        private System.Windows.Forms.Label _status;
        private System.Windows.Forms.TableLayoutPanel adminListLayout;
        private System.Windows.Forms.TableLayoutPanel adminsCard;
        private System.Windows.Forms.Label adminsCardTitle;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label passwordHint;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.TableLayoutPanel adminNameField;
        private System.Windows.Forms.Label adminNameFieldLabel;
        private System.Windows.Forms.TableLayoutPanel adminPasswordField;
        private System.Windows.Forms.Label adminPasswordFieldLabel;
        private System.Windows.Forms.FlowLayoutPanel adminEditorActions;
        private System.Windows.Forms.TableLayoutPanel adminEditorLayout;
        private System.Windows.Forms.Panel adminEditorScroll;
        private System.Windows.Forms.TableLayoutPanel adminEditorCard;
        private System.Windows.Forms.Label adminEditorCardTitle;
        private System.Windows.Forms.TableLayoutPanel bodyLayout;
    }
}
