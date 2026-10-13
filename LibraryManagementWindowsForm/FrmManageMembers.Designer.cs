#nullable disable
namespace LibraryManagementWindowsForm
{
    partial class FrmManageMembers
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
            System.Windows.Forms.DataGridViewCellStyle dataGrid_membersColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGrid_membersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGrid_membersAlternatingRowsDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            rootLayout = new System.Windows.Forms.TableLayoutPanel();
            headerLayout = new System.Windows.Forms.TableLayoutPanel();
            headingLayout = new System.Windows.Forms.TableLayoutPanel();
            headingLabel = new System.Windows.Forms.Label();
            subtitleLabel = new System.Windows.Forms.Label();
            userProfile1 = new LibraryManagementWindowsForm.UserProfile();
            footerLabel = new System.Windows.Forms.Label();
            viewportPanel = new System.Windows.Forms.Panel();
            txt_search_id = new System.Windows.Forms.TextBox();
            txt_search_national_code = new System.Windows.Forms.TextBox();
            btn_search = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            btn_update = new System.Windows.Forms.Button();
            searchLayout = new System.Windows.Forms.TableLayoutPanel();
            searchIdField = new System.Windows.Forms.TableLayoutPanel();
            searchIdFieldLabel = new System.Windows.Forms.Label();
            searchNationalField = new System.Windows.Forms.TableLayoutPanel();
            searchNationalFieldLabel = new System.Windows.Forms.Label();
            searchActions = new System.Windows.Forms.FlowLayoutPanel();
            dataGrid_members = new System.Windows.Forms.DataGridView();
            dataGrid_members_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGrid_members_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGrid_members_Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGrid_members_NationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGrid_members_Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGrid_members_IsSpecial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGrid_members_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            _status = new System.Windows.Forms.Label();
            membersListLayout = new System.Windows.Forms.TableLayoutPanel();
            membersCard = new System.Windows.Forms.TableLayoutPanel();
            membersCardTitle = new System.Windows.Forms.Label();
            rootLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            headingLayout.SuspendLayout();
            viewportPanel.SuspendLayout();
            searchLayout.SuspendLayout();
            searchIdField.SuspendLayout();
            searchNationalField.SuspendLayout();
            searchActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_members).BeginInit();
            membersListLayout.SuspendLayout();
            membersCard.SuspendLayout();
            SuspendLayout();
            dataGrid_membersColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            dataGrid_membersColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            dataGrid_membersColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGrid_membersColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGrid_membersColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(6);
            dataGrid_membersColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGrid_membersDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGrid_membersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            dataGrid_membersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 242, 238);
            dataGrid_membersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            dataGrid_membersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGrid_membersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(6);
            dataGrid_membersDefaultCellStyle.NullValue = "—";
            dataGrid_membersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGrid_membersAlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(249, 251, 253);
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
            rootLayout.MinimumSize = new System.Drawing.Size(0, 500);
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
            headingLabel.Text = "مدیریت اعضا";
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
            subtitleLabel.Text = "جست‌وجوی عضو، ثبت‌نام و اصلاح اطلاعات عضویت";
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
            viewportPanel.AutoScrollMinSize = new System.Drawing.Size(0, 500);
            viewportPanel.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            viewportPanel.TabIndex = 7;
            //
            // txt_search_id
            //
            txt_search_id.Name = "txt_search_id";
            txt_search_id.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txt_search_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txt_search_id.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_search_id.MaxLength = 10;
            txt_search_id.PlaceholderText = "همهٔ اعضا";
            txt_search_id.ReadOnly = false;
            txt_search_id.Multiline = false;
            txt_search_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_search_id.BackColor = System.Drawing.Color.White;
            txt_search_id.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txt_search_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_search_id.TabIndex = 0;
            txt_search_id.TabIndex = 8;
            //
            // txt_search_national_code
            //
            txt_search_national_code.Name = "txt_search_national_code";
            txt_search_national_code.Margin = new System.Windows.Forms.Padding(0, 3, 18, 3);
            txt_search_national_code.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txt_search_national_code.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_search_national_code.MaxLength = 10;
            txt_search_national_code.PlaceholderText = "همهٔ کدهای ملی";
            txt_search_national_code.ReadOnly = false;
            txt_search_national_code.Multiline = false;
            txt_search_national_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_search_national_code.BackColor = System.Drawing.Color.White;
            txt_search_national_code.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            txt_search_national_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_search_national_code.TabIndex = 0;
            txt_search_national_code.TabIndex = 9;
            //
            // btn_search
            //
            btn_search.Name = "btn_search";
            btn_search.Margin = new System.Windows.Forms.Padding(4);
            btn_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btn_search.Text = "جست‌وجو";
            btn_search.Size = new System.Drawing.Size(128, 40);
            btn_search.MinimumSize = new System.Drawing.Size(112, 38);
            btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_search.BackColor = System.Drawing.Color.White;
            btn_search.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_search.AutoSize = false;
            btn_search.FlatAppearance.BorderSize = 1;
            btn_search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btn_search.TabIndex = 10;
            //
            // button2
            //
            button2.Name = "button2";
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            button2.Text = "عضو جدید";
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
            button2.TabIndex = 11;
            //
            // btn_update
            //
            btn_update.Name = "btn_update";
            btn_update.Margin = new System.Windows.Forms.Padding(4);
            btn_update.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btn_update.Text = "ویرایش عضو";
            btn_update.Size = new System.Drawing.Size(128, 40);
            btn_update.MinimumSize = new System.Drawing.Size(112, 38);
            btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_update.BackColor = System.Drawing.Color.White;
            btn_update.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_update.AutoSize = false;
            btn_update.FlatAppearance.BorderSize = 1;
            btn_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            btn_update.TabIndex = 12;
            //
            // searchLayout
            //
            searchLayout.Name = "searchLayout";
            searchLayout.Margin = new System.Windows.Forms.Padding(0);
            searchLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            searchLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            searchLayout.ColumnCount = 3;
            searchLayout.RowCount = 1;
            searchLayout.Padding = new System.Windows.Forms.Padding(0);
            searchLayout.BackColor = System.Drawing.Color.White;
            searchLayout.TabIndex = 13;
            searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            searchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            searchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            //
            // searchIdField
            //
            searchIdField.Name = "searchIdField";
            searchIdField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            searchIdField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            searchIdField.Dock = System.Windows.Forms.DockStyle.Top;
            searchIdField.ColumnCount = 1;
            searchIdField.RowCount = 2;
            searchIdField.Padding = new System.Windows.Forms.Padding(0);
            searchIdField.BackColor = System.Drawing.Color.White;
            searchIdField.Size = new System.Drawing.Size(280, 64);
            searchIdField.TabIndex = 14;
            searchIdField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            searchIdField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            searchIdField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // searchIdFieldLabel
            //
            searchIdFieldLabel.Name = "searchIdFieldLabel";
            searchIdFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            searchIdFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            searchIdFieldLabel.Text = "شماره عضویت";
            searchIdFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            searchIdFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            searchIdFieldLabel.AutoSize = false;
            searchIdFieldLabel.AutoEllipsis = true;
            searchIdFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            searchIdFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            searchIdFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            searchIdFieldLabel.TabIndex = 15;
            //
            // searchNationalField
            //
            searchNationalField.Name = "searchNationalField";
            searchNationalField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            searchNationalField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            searchNationalField.Dock = System.Windows.Forms.DockStyle.Top;
            searchNationalField.ColumnCount = 1;
            searchNationalField.RowCount = 2;
            searchNationalField.Padding = new System.Windows.Forms.Padding(0);
            searchNationalField.BackColor = System.Drawing.Color.White;
            searchNationalField.Size = new System.Drawing.Size(280, 64);
            searchNationalField.TabIndex = 16;
            searchNationalField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            searchNationalField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            searchNationalField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            //
            // searchNationalFieldLabel
            //
            searchNationalFieldLabel.Name = "searchNationalFieldLabel";
            searchNationalFieldLabel.Margin = new System.Windows.Forms.Padding(0);
            searchNationalFieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            searchNationalFieldLabel.Text = "کد ملی";
            searchNationalFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            searchNationalFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            searchNationalFieldLabel.AutoSize = false;
            searchNationalFieldLabel.AutoEllipsis = true;
            searchNationalFieldLabel.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            searchNationalFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            searchNationalFieldLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            searchNationalFieldLabel.TabIndex = 17;
            //
            // searchActions
            //
            searchActions.Name = "searchActions";
            searchActions.Margin = new System.Windows.Forms.Padding(0);
            searchActions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            searchActions.Dock = System.Windows.Forms.DockStyle.Top;
            searchActions.AutoSize = true;
            searchActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            searchActions.WrapContents = true;
            searchActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            searchActions.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            searchActions.TabIndex = 18;
            //
            // dataGrid_members
            //
            dataGrid_members.Name = "dataGrid_members";
            dataGrid_members.Margin = new System.Windows.Forms.Padding(0);
            dataGrid_members.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGrid_members.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGrid_members.AutoGenerateColumns = false;
            dataGrid_members.ReadOnly = true;
            dataGrid_members.AllowUserToAddRows = false;
            dataGrid_members.AllowUserToDeleteRows = false;
            dataGrid_members.AllowUserToResizeRows = false;
            dataGrid_members.MultiSelect = false;
            dataGrid_members.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGrid_members.RowHeadersVisible = false;
            dataGrid_members.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_members.ColumnHeadersHeight = 42;
            dataGrid_members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid_members.BackgroundColor = System.Drawing.Color.White;
            dataGrid_members.GridColor = System.Drawing.Color.FromArgb(222, 230, 239);
            dataGrid_members.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGrid_members.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid_members.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGrid_members.EnableHeadersVisualStyles = false;
            dataGrid_members.RowTemplate.Height = 36;
            dataGrid_members.Tag = "members";
            dataGrid_members.ColumnHeadersDefaultCellStyle = dataGrid_membersColumnHeadersDefaultCellStyle;
            dataGrid_members.DefaultCellStyle = dataGrid_membersDefaultCellStyle;
            dataGrid_members.AlternatingRowsDefaultCellStyle = dataGrid_membersAlternatingRowsDefaultCellStyle;
            dataGrid_members.TabIndex = 19;
            //
            // dataGrid_members_Id
            //
            dataGrid_members_Id.Name = "Id";
            dataGrid_members_Id.DataPropertyName = "Id";
            dataGrid_members_Id.HeaderText = "شناسه";
            dataGrid_members_Id.MinimumWidth = 60;
            dataGrid_members_Id.FillWeight = 60F;
            dataGrid_members_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // dataGrid_members_Name
            //
            dataGrid_members_Name.Name = "Name";
            dataGrid_members_Name.DataPropertyName = "Name";
            dataGrid_members_Name.HeaderText = "نام";
            dataGrid_members_Name.MinimumWidth = 100;
            dataGrid_members_Name.FillWeight = 110F;
            dataGrid_members_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // dataGrid_members_Family
            //
            dataGrid_members_Family.Name = "Family";
            dataGrid_members_Family.DataPropertyName = "Family";
            dataGrid_members_Family.HeaderText = "نام خانوادگی";
            dataGrid_members_Family.MinimumWidth = 100;
            dataGrid_members_Family.FillWeight = 145F;
            dataGrid_members_Family.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // dataGrid_members_NationalCode
            //
            dataGrid_members_NationalCode.Name = "NationalCode";
            dataGrid_members_NationalCode.DataPropertyName = "NationalCode";
            dataGrid_members_NationalCode.HeaderText = "کد ملی";
            dataGrid_members_NationalCode.MinimumWidth = 100;
            dataGrid_members_NationalCode.FillWeight = 125F;
            dataGrid_members_NationalCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // dataGrid_members_Mobile
            //
            dataGrid_members_Mobile.Name = "Mobile";
            dataGrid_members_Mobile.DataPropertyName = "Mobile";
            dataGrid_members_Mobile.HeaderText = "موبایل";
            dataGrid_members_Mobile.MinimumWidth = 100;
            dataGrid_members_Mobile.FillWeight = 130F;
            dataGrid_members_Mobile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // dataGrid_members_IsSpecial
            //
            dataGrid_members_IsSpecial.Name = "IsSpecial";
            dataGrid_members_IsSpecial.DataPropertyName = "IsSpecial";
            dataGrid_members_IsSpecial.HeaderText = "عضویت";
            dataGrid_members_IsSpecial.MinimumWidth = 90;
            dataGrid_members_IsSpecial.FillWeight = 90F;
            dataGrid_members_IsSpecial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // dataGrid_members_Status
            //
            dataGrid_members_Status.Name = "Status";
            dataGrid_members_Status.DataPropertyName = "Status";
            dataGrid_members_Status.HeaderText = "وضعیت";
            dataGrid_members_Status.MinimumWidth = 90;
            dataGrid_members_Status.FillWeight = 90F;
            dataGrid_members_Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // _status
            //
            _status.Name = "_status";
            _status.Margin = new System.Windows.Forms.Padding(0);
            _status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            _status.Text = "برای مشاهدهٔ همهٔ اعضا، جست‌وجو را خالی بگذارید.";
            _status.Dock = System.Windows.Forms.DockStyle.Fill;
            _status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            _status.AutoSize = false;
            _status.AutoEllipsis = true;
            _status.ForeColor = System.Drawing.Color.FromArgb(94, 110, 132);
            _status.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _status.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _status.TabIndex = 20;
            //
            // membersListLayout
            //
            membersListLayout.Name = "membersListLayout";
            membersListLayout.Margin = new System.Windows.Forms.Padding(0);
            membersListLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            membersListLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            membersListLayout.ColumnCount = 1;
            membersListLayout.RowCount = 3;
            membersListLayout.Padding = new System.Windows.Forms.Padding(0);
            membersListLayout.BackColor = System.Drawing.Color.White;
            membersListLayout.TabIndex = 21;
            membersListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            membersListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            membersListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            membersListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            //
            // membersCard
            //
            membersCard.Name = "membersCard";
            membersCard.Margin = new System.Windows.Forms.Padding(6);
            membersCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            membersCard.Dock = System.Windows.Forms.DockStyle.Fill;
            membersCard.ColumnCount = 1;
            membersCard.RowCount = 2;
            membersCard.Padding = new System.Windows.Forms.Padding(12);
            membersCard.BackColor = System.Drawing.Color.White;
            membersCard.TabIndex = 22;
            membersCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            membersCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            membersCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // membersCardTitle
            //
            membersCardTitle.Name = "membersCardTitle";
            membersCardTitle.Margin = new System.Windows.Forms.Padding(0);
            membersCardTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            membersCardTitle.Text = "فهرست اعضا";
            membersCardTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            membersCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            membersCardTitle.AutoSize = false;
            membersCardTitle.AutoEllipsis = true;
            membersCardTitle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            membersCardTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            membersCardTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            membersCardTitle.TabIndex = 23;
            headingLayout.Controls.Add(headingLabel, 0, 0);
            headingLayout.Controls.Add(subtitleLabel, 0, 1);
            headerLayout.Controls.Add(userProfile1, 0, 0);
            headerLayout.Controls.Add(headingLayout, 1, 0);
            rootLayout.Controls.Add(headerLayout, 0, 0);
            rootLayout.Controls.Add(footerLabel, 0, 2);
            viewportPanel.Controls.Add(rootLayout);
            Controls.Add(viewportPanel);
            searchIdField.Controls.Add(searchIdFieldLabel, 0, 0);
            searchIdField.Controls.Add(txt_search_id, 0, 1);
            searchLayout.Controls.Add(searchIdField, 0, 0);
            searchNationalField.Controls.Add(searchNationalFieldLabel, 0, 0);
            searchNationalField.Controls.Add(txt_search_national_code, 0, 1);
            searchLayout.Controls.Add(searchNationalField, 1, 0);
            searchActions.Controls.Add(btn_search);
            searchActions.Controls.Add(button2);
            searchActions.Controls.Add(btn_update);
            searchLayout.Controls.Add(searchActions, 2, 0);
            membersListLayout.Controls.Add(searchLayout, 0, 0);
            membersListLayout.Controls.Add(dataGrid_members, 0, 1);
            membersListLayout.Controls.Add(_status, 0, 2);
            membersCard.Controls.Add(membersCardTitle, 0, 0);
            membersCard.Controls.Add(membersListLayout, 0, 1);
            rootLayout.Controls.Add(membersCard, 0, 1);
            dataGrid_members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGrid_members_Id, dataGrid_members_Name, dataGrid_members_Family, dataGrid_members_NationalCode, dataGrid_members_Mobile, dataGrid_members_IsSpecial, dataGrid_members_Status });
            btn_search.Click += btn_search_Click;
            button2.Click += button2_Click;
            btn_update.Click += btn_update_Click;
            dataGrid_members.CellClick += dataGrid_members_CellClick;
            Load += FrmManageMembers_Load;
            //
            // FrmManageMembers
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Name = "FrmManageMembers";
            ClientSize = new System.Drawing.Size(1120, 720);
            MinimumSize = new System.Drawing.Size(860, 540);
            Text = "مدیریت اعضا";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            RightToLeftLayout = false;
            ShowIcon = false;
            membersCard.ResumeLayout(false);
            membersCard.PerformLayout();
            membersListLayout.ResumeLayout(false);
            membersListLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_members).EndInit();
            searchActions.ResumeLayout(false);
            searchActions.PerformLayout();
            searchNationalField.ResumeLayout(false);
            searchNationalField.PerformLayout();
            searchIdField.ResumeLayout(false);
            searchIdField.PerformLayout();
            searchLayout.ResumeLayout(false);
            searchLayout.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_search_id;
        private System.Windows.Forms.TextBox txt_search_national_code;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TableLayoutPanel searchLayout;
        private System.Windows.Forms.TableLayoutPanel searchIdField;
        private System.Windows.Forms.Label searchIdFieldLabel;
        private System.Windows.Forms.TableLayoutPanel searchNationalField;
        private System.Windows.Forms.Label searchNationalFieldLabel;
        private System.Windows.Forms.FlowLayoutPanel searchActions;
        private System.Windows.Forms.DataGridView dataGrid_members;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_members_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_members_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_members_Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_members_NationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_members_Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_members_IsSpecial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_members_Status;
        private System.Windows.Forms.Label _status;
        private System.Windows.Forms.TableLayoutPanel membersListLayout;
        private System.Windows.Forms.TableLayoutPanel membersCard;
        private System.Windows.Forms.Label membersCardTitle;
    }
}
