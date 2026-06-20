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
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            SuspendLayout();
            // 
            // dgvAdmins
            // 
            dgvAdmins.AllowUserToAddRows = false;
            dgvAdmins.AllowUserToDeleteRows = false;
            dgvAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmins.Location = new Point(3, 204);
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.ReadOnly = true;
            dgvAdmins.RowHeadersWidth = 51;
            dgvAdmins.Size = new Size(794, 241);
            dgvAdmins.TabIndex = 0;
            dgvAdmins.CellClick += dgvAdmins_CellClick;
            // 
            // btnCreateAdmin
            // 
            btnCreateAdmin.Location = new Point(333, 24);
            btnCreateAdmin.Name = "btnCreateAdmin";
            btnCreateAdmin.Size = new Size(94, 29);
            btnCreateAdmin.TabIndex = 1;
            btnCreateAdmin.Text = "اضافه کردن";
            btnCreateAdmin.UseVisualStyleBackColor = true;
            btnCreateAdmin.Click += btnCreateAdmin_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(333, 73);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "ویرایش";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnEdit_Click;
            // 
            // btnDisable
            // 
            btnDisable.Location = new Point(198, 24);
            btnDisable.Name = "btnDisable";
            btnDisable.Size = new Size(94, 29);
            btnDisable.TabIndex = 3;
            btnDisable.Text = "غیر فعال";
            btnDisable.UseVisualStyleBackColor = true;
            btnDisable.Click += btnDisable_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(267, 126);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "بازیابی";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnEnable
            // 
            btnEnable.Location = new Point(198, 73);
            btnEnable.Name = "btnEnable";
            btnEnable.Size = new Size(94, 29);
            btnEnable.TabIndex = 5;
            btnEnable.Text = "فعال کردن";
            btnEnable.UseVisualStyleBackColor = true;
            btnEnable.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(637, 55);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 6;
            label1.Text = "برای تغییرات کلیک کنید";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(459, 26);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(152, 27);
            txtUserName.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(459, 74);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(152, 27);
            txtPassword.TabIndex = 8;
            // 
            // userProfile1
            // 
            userProfile1.Location = new Point(508, 126);
            userProfile1.Name = "userProfile1";
            userProfile1.Size = new Size(289, 56);
            userProfile1.TabIndex = 9;
            userProfile1.UserName = "";
            userProfile1.Load += userProfile1_Load;
            // 
            // FrmAdminManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Text = "FrmAdminManagement";
            Load += FrmAdminManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAdmins;
        private Button btnCreateAdmin;
        private Button btnUpdate;
        private Button btnDisable;
        private Button btnRefresh;
        private Button btnEnable;
        private Label label1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private UserProfile userProfile1;
    }
}