using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm
{
    partial class LoginForm
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
            label1 = new Label();
            btn1 = new Button();
            txt_user = new TextBox();
            txt_pass = new TextBox();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.Chartreuse;
            label1.Location = new Point(342, 101);
            label1.Name = "label1";
            label1.Size = new Size(103, 29);
            label1.TabIndex = 0;
            label1.Text = "لطفا وارد شوید";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseWaitCursor = true;
            // 
            // btn1
            // 
            btn1.BackColor = Color.LightSalmon;
            btn1.Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(351, 259);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 43);
            btn1.TabIndex = 1;
            btn1.Text = "ورود ادمین";
            btn1.UseVisualStyleBackColor = false;
            btn1.UseWaitCursor = true;
            btn1.Click += btn1_Click;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(300, 153);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(204, 27);
            txt_user.TabIndex = 2;
            txt_user.UseWaitCursor = true;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(300, 212);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(204, 27);
            txt_pass.TabIndex = 3;
            txt_pass.UseWaitCursor = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(487, 268);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(128, 24);
            chkShowPassword.TabIndex = 4;
            chkShowPassword.Text = "نمایش رمز عبور";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.UseWaitCursor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(chkShowPassword);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Controls.Add(btn1);
            Controls.Add(label1);
            ForeColor = Color.LawnGreen;
            Name = "LoginForm";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فرم ورود";
            UseWaitCursor = true;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn1;
        private TextBox txt_user;
        private TextBox txt_pass;
        private CheckBox chkShowPassword;
    }
}