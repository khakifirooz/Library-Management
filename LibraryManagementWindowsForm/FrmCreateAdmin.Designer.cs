namespace LibraryManagementWindowsForm
{
    partial class FrmCreateAdmin
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(79, 40);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(172, 27);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(79, 128);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(172, 27);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 91);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 2;
            label1.Text = "اضافه کردن ادمین جدید";
            label1.Click += label1_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(116, 187);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmCreateAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 241);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Name = "FrmCreateAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCreateAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Button btnSave;
    }
}