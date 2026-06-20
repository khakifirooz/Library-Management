namespace LibraryManagementWindowsForm
{
    partial class FrmAdminManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAdmins = new DataGridView();
            btnCreateAdmin = new Button();
            btnUpdate = new Button();
            btnDisable = new Button();
            btnRefresh = new Button();
            btnEnable = new Button();
            label1 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            userProfile1 = new UserProfile();
            txt_search = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            SuspendLayout();
            // 
            // dgvAdmins
            // 
            dgvAdmins.AllowUserToAddRows = false;
            dgvAdmins.AllowUserToDeleteRows = false;
            dgvAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmins.Location = new Point(3, 224);
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.ReadOnly = true;
            dgvAdmins.RowHeadersWidth = 51;
            dgvAdmins.Size = new Size(794, 225);
            dgvAdmins.TabIndex = 0;
            dgvAdmins.CellClick += dgvAdmins_CellClick;
            // 
            // btnCreateAdmin
            // 
            btnCreateAdmin.Cursor = Cursors.Hand;
            btnCreateAdmin.Font = new Font("B Nazanin", 10.2F);
            btnCreateAdmin.Location = new Point(258, 12);
            btnCreateAdmin.Name = "btnCreateAdmin";
            btnCreateAdmin.Size = new Size(94, 34);
            btnCreateAdmin.TabIndex = 1;
            btnCreateAdmin.Text = "اضافه کردن";
            btnCreateAdmin.UseVisualStyleBackColor = true;
            btnCreateAdmin.Click += btnCreateAdmin_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("B Nazanin", 10.2F);
            btnUpdate.Location = new Point(377, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 34);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "ویرایش";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnEdit_Click;
            // 
            // btnDisable
            // 
            btnDisable.Cursor = Cursors.Hand;
            btnDisable.Font = new Font("B Nazanin", 10.2F);
            btnDisable.Location = new Point(258, 73);
            btnDisable.Name = "btnDisable";
            btnDisable.Size = new Size(94, 34);
            btnDisable.TabIndex = 3;
            btnDisable.Text = "غیر فعال";
            btnDisable.UseVisualStyleBackColor = true;
            btnDisable.Click += btnDisable_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("B Nazanin", 10.2F);
            btnRefresh.Location = new Point(328, 131);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 34);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "بازیابی";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnEnable
            // 
            btnEnable.Cursor = Cursors.Hand;
            btnEnable.Font = new Font("B Nazanin", 10.2F);
            btnEnable.Location = new Point(377, 73);
            btnEnable.Name = "btnEnable";
            btnEnable.Size = new Size(94, 34);
            btnEnable.TabIndex = 5;
            btnEnable.Text = "فعال کردن";
            btnEnable.UseVisualStyleBackColor = true;
            btnEnable.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label1.Location = new Point(666, 46);
            label1.Name = "label1";
            label1.Size = new Size(131, 29);
            label1.TabIndex = 6;
            label1.Text = "تنظیمات ادمین ها ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(499, 12);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(152, 27);
            txtUserName.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(499, 80);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(152, 27);
            txtPassword.TabIndex = 8;
            // 
            // userProfile1
            // 
            userProfile1.Location = new Point(508, 159);
            userProfile1.Name = "userProfile1";
            userProfile1.Size = new Size(289, 64);
            userProfile1.TabIndex = 9;
            userProfile1.UserName = "";
            userProfile1.Load += userProfile1_Load;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(12, 59);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(210, 27);
            txt_search.TabIndex = 10;
            txt_search.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(68, 15);
            label2.Name = "label2";
            label2.Size = new Size(108, 29);
            label2.TabIndex = 11;
            label2.Text = ": جستجو ادمین";
            label2.Click += label2_Click;
            // 
            // FrmAdminManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__3_;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txt_search);
            Controls.Add(userProfile1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Controls.Add(btnEnable);
            Controls.Add(btnRefresh);
            Controls.Add(btnDisable);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreateAdmin);
            Controls.Add(dgvAdmins);
            Name = "FrmAdminManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAdminManagement";
            Load += FrmAdminManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAdmins;
        private Label label1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private UserProfile userProfile1;
        public Button btnCreateAdmin;
        public Button btnUpdate;
        public Button btnDisable;
        public Button btnRefresh;
        public Button btnEnable;
        private TextBox txt_search;
        private Label label2;
    }
}