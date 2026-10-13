#nullable disable
namespace LibraryManagementWindowsForm
{
    partial class FrmCreateAdmin
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
            userProfile1 = new UserProfile();
            headingLayout = new TableLayoutPanel();
            headingLabel = new Label();
            subtitleLabel = new Label();
            footerLabel = new Label();
            newAdminCard = new TableLayoutPanel();
            newAdminCardTitle = new Label();
            adminCreateScroll = new Panel();
            adminCreateLayout = new TableLayoutPanel();
            adminUserField = new TableLayoutPanel();
            adminUserFieldLabel = new Label();
            txtUserName = new TextBox();
            adminPassField = new TableLayoutPanel();
            adminPassFieldLabel = new Label();
            txtPassword = new TextBox();
            adminCreateHint = new Label();
            adminCreateActions = new FlowLayoutPanel();
            btnSave = new Button();
            btn_cancel = new Button();
            viewportPanel = new Panel();
            rootLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            headingLayout.SuspendLayout();
            newAdminCard.SuspendLayout();
            adminCreateScroll.SuspendLayout();
            adminCreateLayout.SuspendLayout();
            adminUserField.SuspendLayout();
            adminPassField.SuspendLayout();
            adminCreateActions.SuspendLayout();
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
            rootLayout.Controls.Add(newAdminCard, 0, 1);
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
            rootLayout.Size = new Size(700, 530);
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
            headerLayout.Size = new Size(668, 92);
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
            headingLayout.Size = new Size(424, 68);
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
            headingLabel.Size = new Size(424, 32);
            headingLabel.TabIndex = 3;
            headingLabel.Text = "ثبت مدیر جدید";
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
            subtitleLabel.Size = new Size(424, 36);
            subtitleLabel.TabIndex = 4;
            subtitleLabel.Text = "ایجاد حساب مدیریت کتابخانه";
            subtitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // footerLabel
            // 
            footerLabel.AutoEllipsis = true;
            footerLabel.Dock = DockStyle.Fill;
            footerLabel.Font = new Font("Tahoma", 9F);
            footerLabel.ForeColor = Color.FromArgb(94, 110, 132);
            footerLabel.Location = new Point(16, 490);
            footerLabel.Margin = new Padding(0);
            footerLabel.Name = "footerLabel";
            footerLabel.Padding = new Padding(4, 0, 4, 0);
            footerLabel.RightToLeft = RightToLeft.Yes;
            footerLabel.Size = new Size(668, 24);
            footerLabel.TabIndex = 6;
            footerLabel.Text = "مدیریت کتابخانه  •  ثبت و پیگیری اطلاعات";
            footerLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // newAdminCard
            // 
            newAdminCard.BackColor = Color.White;
            newAdminCard.ColumnCount = 1;
            newAdminCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            newAdminCard.Controls.Add(newAdminCardTitle, 0, 0);
            newAdminCard.Controls.Add(adminCreateScroll, 0, 1);
            newAdminCard.Dock = DockStyle.Fill;
            newAdminCard.Location = new Point(22, 126);
            newAdminCard.Margin = new Padding(6);
            newAdminCard.Name = "newAdminCard";
            newAdminCard.Padding = new Padding(12);
            newAdminCard.RightToLeft = RightToLeft.No;
            newAdminCard.RowCount = 2;
            newAdminCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            newAdminCard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            newAdminCard.Size = new Size(656, 358);
            newAdminCard.TabIndex = 20;
            // 
            // newAdminCardTitle
            // 
            newAdminCardTitle.AutoEllipsis = true;
            newAdminCardTitle.Dock = DockStyle.Fill;
            newAdminCardTitle.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            newAdminCardTitle.ForeColor = Color.FromArgb(25, 42, 66);
            newAdminCardTitle.Location = new Point(12, 12);
            newAdminCardTitle.Margin = new Padding(0);
            newAdminCardTitle.Name = "newAdminCardTitle";
            newAdminCardTitle.Padding = new Padding(4, 0, 4, 0);
            newAdminCardTitle.RightToLeft = RightToLeft.Yes;
            newAdminCardTitle.Size = new Size(632, 32);
            newAdminCardTitle.TabIndex = 21;
            newAdminCardTitle.Text = "اطلاعات حساب";
            newAdminCardTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // adminCreateScroll
            // 
            adminCreateScroll.AutoScroll = true;
            adminCreateScroll.BackColor = Color.White;
            adminCreateScroll.Controls.Add(adminCreateLayout);
            adminCreateScroll.Dock = DockStyle.Fill;
            adminCreateScroll.Location = new Point(12, 44);
            adminCreateScroll.Margin = new Padding(0);
            adminCreateScroll.Name = "adminCreateScroll";
            adminCreateScroll.Padding = new Padding(0, 0, 4, 0);
            adminCreateScroll.RightToLeft = RightToLeft.No;
            adminCreateScroll.Size = new Size(632, 302);
            adminCreateScroll.TabIndex = 19;
            // 
            // adminCreateLayout
            // 
            adminCreateLayout.AutoSize = true;
            adminCreateLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            adminCreateLayout.BackColor = Color.White;
            adminCreateLayout.ColumnCount = 1;
            adminCreateLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            adminCreateLayout.Controls.Add(adminUserField, 0, 0);
            adminCreateLayout.Controls.Add(adminPassField, 0, 1);
            adminCreateLayout.Controls.Add(adminCreateHint, 0, 2);
            adminCreateLayout.Controls.Add(adminCreateActions, 0, 3);
            adminCreateLayout.Dock = DockStyle.Top;
            adminCreateLayout.Location = new Point(0, 0);
            adminCreateLayout.Margin = new Padding(0);
            adminCreateLayout.Name = "adminCreateLayout";
            adminCreateLayout.Padding = new Padding(4);
            adminCreateLayout.RightToLeft = RightToLeft.No;
            adminCreateLayout.RowCount = 4;
            adminCreateLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            adminCreateLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            adminCreateLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            adminCreateLayout.RowStyles.Add(new RowStyle());
            adminCreateLayout.Size = new Size(628, 250);
            adminCreateLayout.TabIndex = 18;
            // 
            // adminUserField
            // 
            adminUserField.BackColor = Color.White;
            adminUserField.ColumnCount = 1;
            adminUserField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            adminUserField.Controls.Add(adminUserFieldLabel, 0, 0);
            adminUserField.Controls.Add(txtUserName, 0, 1);
            adminUserField.Dock = DockStyle.Top;
            adminUserField.Location = new Point(8, 4);
            adminUserField.Margin = new Padding(4, 0, 4, 8);
            adminUserField.Name = "adminUserField";
            adminUserField.RightToLeft = RightToLeft.No;
            adminUserField.RowCount = 2;
            adminUserField.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            adminUserField.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            adminUserField.Size = new Size(612, 64);
            adminUserField.TabIndex = 13;
            // 
            // adminUserFieldLabel
            // 
            adminUserFieldLabel.AutoEllipsis = true;
            adminUserFieldLabel.Dock = DockStyle.Fill;
            adminUserFieldLabel.Font = new Font("Tahoma", 9F);
            adminUserFieldLabel.ForeColor = Color.FromArgb(94, 110, 132);
            adminUserFieldLabel.Location = new Point(0, 0);
            adminUserFieldLabel.Margin = new Padding(0);
            adminUserFieldLabel.Name = "adminUserFieldLabel";
            adminUserFieldLabel.Padding = new Padding(4, 0, 4, 0);
            adminUserFieldLabel.RightToLeft = RightToLeft.Yes;
            adminUserFieldLabel.Size = new Size(612, 24);
            adminUserFieldLabel.TabIndex = 14;
            adminUserFieldLabel.Text = "نام کاربری";
            adminUserFieldLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Dock = DockStyle.Fill;
            txtUserName.ForeColor = Color.FromArgb(25, 42, 66);
            txtUserName.Location = new Point(0, 27);
            txtUserName.Margin = new Padding(0, 3, 18, 3);
            txtUserName.MaxLength = 50;
            txtUserName.Name = "txtUserName";
            txtUserName.RightToLeft = RightToLeft.No;
            txtUserName.Size = new Size(594, 28);
            txtUserName.TabIndex = 8;
            // 
            // adminPassField
            // 
            adminPassField.BackColor = Color.White;
            adminPassField.ColumnCount = 1;
            adminPassField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            adminPassField.Controls.Add(adminPassFieldLabel, 0, 0);
            adminPassField.Controls.Add(txtPassword, 0, 1);
            adminPassField.Dock = DockStyle.Top;
            adminPassField.Location = new Point(8, 76);
            adminPassField.Margin = new Padding(4, 0, 4, 8);
            adminPassField.Name = "adminPassField";
            adminPassField.RightToLeft = RightToLeft.No;
            adminPassField.RowCount = 2;
            adminPassField.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            adminPassField.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            adminPassField.Size = new Size(612, 64);
            adminPassField.TabIndex = 15;
            // 
            // adminPassFieldLabel
            // 
            adminPassFieldLabel.AutoEllipsis = true;
            adminPassFieldLabel.Dock = DockStyle.Fill;
            adminPassFieldLabel.Font = new Font("Tahoma", 9F);
            adminPassFieldLabel.ForeColor = Color.FromArgb(94, 110, 132);
            adminPassFieldLabel.Location = new Point(0, 0);
            adminPassFieldLabel.Margin = new Padding(0);
            adminPassFieldLabel.Name = "adminPassFieldLabel";
            adminPassFieldLabel.Padding = new Padding(4, 0, 4, 0);
            adminPassFieldLabel.RightToLeft = RightToLeft.Yes;
            adminPassFieldLabel.Size = new Size(612, 24);
            adminPassFieldLabel.TabIndex = 16;
            adminPassFieldLabel.Text = "رمز عبور";
            adminPassFieldLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.ForeColor = Color.FromArgb(25, 42, 66);
            txtPassword.Location = new Point(0, 27);
            txtPassword.Margin = new Padding(0, 3, 18, 3);
            txtPassword.MaxLength = 100;
            txtPassword.Name = "txtPassword";
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.Size = new Size(594, 28);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // adminCreateHint
            // 
            adminCreateHint.AutoEllipsis = true;
            adminCreateHint.Dock = DockStyle.Fill;
            adminCreateHint.Font = new Font("Tahoma", 9F);
            adminCreateHint.ForeColor = Color.FromArgb(94, 110, 132);
            adminCreateHint.Location = new Point(4, 148);
            adminCreateHint.Margin = new Padding(0);
            adminCreateHint.Name = "adminCreateHint";
            adminCreateHint.Padding = new Padding(4, 0, 4, 0);
            adminCreateHint.RightToLeft = RightToLeft.Yes;
            adminCreateHint.Size = new Size(620, 42);
            adminCreateHint.TabIndex = 12;
            adminCreateHint.Text = "نام کاربری و رمز عبور را وارد کنید.";
            adminCreateHint.TextAlign = ContentAlignment.MiddleRight;
            // 
            // adminCreateActions
            // 
            adminCreateActions.AutoSize = true;
            adminCreateActions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            adminCreateActions.Controls.Add(btnSave);
            adminCreateActions.Controls.Add(btn_cancel);
            adminCreateActions.Dock = DockStyle.Top;
            adminCreateActions.FlowDirection = FlowDirection.RightToLeft;
            adminCreateActions.Location = new Point(4, 190);
            adminCreateActions.Margin = new Padding(0);
            adminCreateActions.Name = "adminCreateActions";
            adminCreateActions.Padding = new Padding(0, 4, 0, 4);
            adminCreateActions.RightToLeft = RightToLeft.No;
            adminCreateActions.Size = new Size(620, 56);
            adminCreateActions.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(12, 120, 113);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(488, 8);
            btnSave.Margin = new Padding(4);
            btnSave.MinimumSize = new Size(112, 38);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(128, 40);
            btnSave.TabIndex = 10;
            btnSave.Text = "ثبت مدیر";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.White;
            btn_cancel.Cursor = Cursors.Hand;
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(222, 230, 239);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.ForeColor = Color.FromArgb(25, 42, 66);
            btn_cancel.Location = new Point(352, 8);
            btn_cancel.Margin = new Padding(4);
            btn_cancel.MinimumSize = new Size(112, 38);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.RightToLeft = RightToLeft.Yes;
            btn_cancel.Size = new Size(128, 40);
            btn_cancel.TabIndex = 11;
            btn_cancel.Text = "بازگشت";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += Cancel_Click;
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
            viewportPanel.Size = new Size(700, 530);
            viewportPanel.TabIndex = 7;
            // 
            // FrmCreateAdmin
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 245, 249);
            CancelButton = btn_cancel;
            ClientSize = new Size(700, 530);
            Controls.Add(viewportPanel);
            Font = new Font("Tahoma", 10F);
            ForeColor = Color.FromArgb(25, 42, 66);
            MinimumSize = new Size(580, 450);
            Name = "FrmCreateAdmin";
            RightToLeft = RightToLeft.Yes;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ثبت مدیر جدید";
            Load += FrmCreateAdmin_Load;
            rootLayout.ResumeLayout(false);
            rootLayout.PerformLayout();
            headerLayout.ResumeLayout(false);
            headingLayout.ResumeLayout(false);
            newAdminCard.ResumeLayout(false);
            adminCreateScroll.ResumeLayout(false);
            adminCreateScroll.PerformLayout();
            adminCreateLayout.ResumeLayout(false);
            adminCreateLayout.PerformLayout();
            adminUserField.ResumeLayout(false);
            adminUserField.PerformLayout();
            adminPassField.ResumeLayout(false);
            adminPassField.PerformLayout();
            adminCreateActions.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label adminCreateHint;
        private System.Windows.Forms.TableLayoutPanel adminUserField;
        private System.Windows.Forms.Label adminUserFieldLabel;
        private System.Windows.Forms.TableLayoutPanel adminPassField;
        private System.Windows.Forms.Label adminPassFieldLabel;
        private System.Windows.Forms.FlowLayoutPanel adminCreateActions;
        private System.Windows.Forms.TableLayoutPanel adminCreateLayout;
        private System.Windows.Forms.Panel adminCreateScroll;
        private System.Windows.Forms.TableLayoutPanel newAdminCard;
        private System.Windows.Forms.Label newAdminCardTitle;
    }
}
