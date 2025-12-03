namespace LibraryManagementWindowsForm
{
    partial class FrmRegisterMember
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_name = new TextBox();
            txt_family = new TextBox();
            txt_national_code = new TextBox();
            txt_mobile = new TextBox();
            checkBox_isSpecial = new CheckBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(673, 47);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(34, 20);
            label1.TabIndex = 0;
            label1.Text = "نام :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(673, 96);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "فامیلی :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(673, 166);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "کد ملی :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(673, 226);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "موبایل :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(673, 289);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "عضو ویژه :";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(515, 47);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 5;
            // 
            // txt_family
            // 
            txt_family.Location = new Point(515, 96);
            txt_family.Name = "txt_family";
            txt_family.Size = new Size(125, 27);
            txt_family.TabIndex = 6;
            // 
            // txt_national_code
            // 
            txt_national_code.Location = new Point(515, 163);
            txt_national_code.Name = "txt_national_code";
            txt_national_code.Size = new Size(125, 27);
            txt_national_code.TabIndex = 7;
            // 
            // txt_mobile
            // 
            txt_mobile.Location = new Point(515, 226);
            txt_mobile.Name = "txt_mobile";
            txt_mobile.Size = new Size(125, 27);
            txt_mobile.TabIndex = 8;
            // 
            // checkBox_isSpecial
            // 
            checkBox_isSpecial.AutoSize = true;
            checkBox_isSpecial.Location = new Point(622, 292);
            checkBox_isSpecial.Name = "checkBox_isSpecial";
            checkBox_isSpecial.Size = new Size(18, 17);
            checkBox_isSpecial.TabIndex = 9;
            checkBox_isSpecial.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(112, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 206);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(261, 16);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(84, 20);
            label6.TabIndex = 11;
            label6.Text = "عکس کاربر :";
            // 
            // button1
            // 
            button1.Location = new Point(504, 370);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "ذخیره";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(287, 370);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "بازگشت";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmRegisterMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 477);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox_isSpecial);
            Controls.Add(txt_mobile);
            Controls.Add(txt_national_code);
            Controls.Add(txt_family);
            Controls.Add(txt_name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegisterMember";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ثبت کاربر";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_name;
        private TextBox txt_family;
        private TextBox txt_national_code;
        private TextBox txt_mobile;
        private CheckBox checkBox_isSpecial;
        private PictureBox pictureBox1;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}