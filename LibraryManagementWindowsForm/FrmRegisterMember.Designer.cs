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
            picture_member = new PictureBox();
            label6 = new Label();
            btn_save = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)picture_member).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(770, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(33, 26);
            label1.TabIndex = 0;
            label1.Text = "نام :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(751, 142);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(52, 26);
            label2.TabIndex = 1;
            label2.Text = "فامیلی :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(746, 220);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(57, 26);
            label3.TabIndex = 2;
            label3.Text = "کد ملی :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(752, 298);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(51, 26);
            label4.TabIndex = 3;
            label4.Text = "موبایل :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(738, 380);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(65, 26);
            label5.TabIndex = 4;
            label5.Text = "عضو ویژه :";
            // 
            // txt_name
            // 
            txt_name.BackColor = SystemColors.Info;
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Cursor = Cursors.IBeam;
            txt_name.Location = new Point(521, 65);
            txt_name.Margin = new Padding(4);
            txt_name.Name = "txt_name";
            txt_name.RightToLeft = RightToLeft.Yes;
            txt_name.Size = new Size(170, 33);
            txt_name.TabIndex = 5;
            // 
            // txt_family
            // 
            txt_family.BackColor = SystemColors.Info;
            txt_family.BorderStyle = BorderStyle.FixedSingle;
            txt_family.Cursor = Cursors.IBeam;
            txt_family.Location = new Point(521, 138);
            txt_family.Margin = new Padding(4);
            txt_family.Name = "txt_family";
            txt_family.RightToLeft = RightToLeft.Yes;
            txt_family.Size = new Size(170, 33);
            txt_family.TabIndex = 6;
            // 
            // txt_national_code
            // 
            txt_national_code.BackColor = SystemColors.Info;
            txt_national_code.BorderStyle = BorderStyle.FixedSingle;
            txt_national_code.Cursor = Cursors.IBeam;
            txt_national_code.Location = new Point(521, 216);
            txt_national_code.Margin = new Padding(4);
            txt_national_code.Name = "txt_national_code";
            txt_national_code.RightToLeft = RightToLeft.Yes;
            txt_national_code.Size = new Size(170, 33);
            txt_national_code.TabIndex = 7;
            txt_national_code.KeyPress += txt_national_code_KeyPress;
            // 
            // txt_mobile
            // 
            txt_mobile.BackColor = SystemColors.Info;
            txt_mobile.BorderStyle = BorderStyle.FixedSingle;
            txt_mobile.Cursor = Cursors.IBeam;
            txt_mobile.Location = new Point(521, 298);
            txt_mobile.Margin = new Padding(4);
            txt_mobile.Name = "txt_mobile";
            txt_mobile.RightToLeft = RightToLeft.Yes;
            txt_mobile.Size = new Size(170, 33);
            txt_mobile.TabIndex = 8;
            txt_mobile.KeyPress += txt_mobile_KeyPress;
            // 
            // checkBox_isSpecial
            // 
            checkBox_isSpecial.AutoSize = true;
            checkBox_isSpecial.BackColor = Color.Red;
            checkBox_isSpecial.Cursor = Cursors.Hand;
            checkBox_isSpecial.Location = new Point(668, 384);
            checkBox_isSpecial.Margin = new Padding(4);
            checkBox_isSpecial.Name = "checkBox_isSpecial";
            checkBox_isSpecial.Size = new Size(18, 17);
            checkBox_isSpecial.TabIndex = 9;
            checkBox_isSpecial.UseVisualStyleBackColor = false;
            // 
            // picture_member
            // 
            picture_member.BorderStyle = BorderStyle.FixedSingle;
            picture_member.Location = new Point(42, 65);
            picture_member.Margin = new Padding(4);
            picture_member.Name = "picture_member";
            picture_member.Size = new Size(320, 266);
            picture_member.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_member.TabIndex = 10;
            picture_member.TabStop = false;
            picture_member.Click += picture_member_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(288, 35);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(74, 26);
            label6.TabIndex = 11;
            label6.Text = "عکس عضو :";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Goldenrod;
            btn_save.Font = new Font("B Nazanin", 12F);
            btn_save.Location = new Point(562, 440);
            btn_save.Margin = new Padding(4);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(139, 38);
            btn_save.TabIndex = 12;
            btn_save.Text = "ذخیره";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.Font = new Font("B Nazanin", 12F);
            button2.Location = new Point(213, 440);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(139, 38);
            button2.TabIndex = 13;
            button2.Text = "بازگشت";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FrmRegisterMember
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(884, 525);
            Controls.Add(button2);
            Controls.Add(btn_save);
            Controls.Add(label6);
            Controls.Add(picture_member);
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
            Cursor = Cursors.Hand;
            Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Margin = new Padding(4);
            Name = "FrmRegisterMember";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ثبت عضو جدید";
            Load += FrmRegisterMember_Load;
            ((System.ComponentModel.ISupportInitialize)picture_member).EndInit();
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
        private PictureBox picture_member;
        private Label label6;
        private Button btn_save;
        private Button button2;
    }
}