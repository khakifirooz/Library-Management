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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 91);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "لطفا وارد شوید";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn1
            // 
            btn1.Location = new Point(351, 275);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 1;
            btn1.Text = "ورود";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += this.btn1_Click;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(338, 153);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(125, 27);
            txt_user.TabIndex = 2;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(338, 212);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(125, 27);
            txt_pass.TabIndex = 3;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Controls.Add(btn1);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn1;
        private TextBox txt_user;
        private TextBox txt_pass;
    }
}