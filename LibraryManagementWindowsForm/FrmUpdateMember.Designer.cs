namespace LibraryManagementWindowsForm
{
    partial class FrmUpdateMember
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
            button2 = new Button();
            btn_save = new Button();
            label6 = new Label();
            picture_member = new PictureBox();
            checkBox_isSpecial = new CheckBox();
            txt_mobile = new TextBox();
            txt_national_code = new TextBox();
            txt_family = new TextBox();
            txt_name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            txt_id = new TextBox();
            checkBox_status = new CheckBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)picture_member).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.Font = new Font("B Nazanin", 12F);
            button2.Location = new Point(216, 463);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(139, 38);
            button2.TabIndex = 8;
            button2.Text = "بازگشت";
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Goldenrod;
            btn_save.Font = new Font("B Nazanin", 12F);
            btn_save.Location = new Point(489, 463);
            btn_save.Margin = new Padding(4);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(139, 38);
            btn_save.TabIndex = 7;
            btn_save.Text = "ذخیره";
            btn_save.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 22);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(74, 26);
            label6.TabIndex = 24;
            label6.Text = "عکس عضو :";
            // 
            // picture_member
            // 
            picture_member.BorderStyle = BorderStyle.FixedSingle;
            picture_member.Location = new Point(30, 52);
            picture_member.Margin = new Padding(4);
            picture_member.Name = "picture_member";
            picture_member.Size = new Size(320, 266);
            picture_member.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_member.TabIndex = 23;
            picture_member.TabStop = false;
            // 
            // checkBox_isSpecial
            // 
            checkBox_isSpecial.AutoSize = true;
            checkBox_isSpecial.BackColor = Color.Red;
            checkBox_isSpecial.Cursor = Cursors.Hand;
            checkBox_isSpecial.Location = new Point(576, 385);
            checkBox_isSpecial.Margin = new Padding(4);
            checkBox_isSpecial.Name = "checkBox_isSpecial";
            checkBox_isSpecial.Size = new Size(18, 17);
            checkBox_isSpecial.TabIndex = 6;
            checkBox_isSpecial.UseVisualStyleBackColor = false;
            // 
            // txt_mobile
            // 
            txt_mobile.BackColor = SystemColors.Info;
            txt_mobile.BorderStyle = BorderStyle.FixedSingle;
            txt_mobile.Cursor = Cursors.IBeam;
            txt_mobile.Location = new Point(424, 311);
            txt_mobile.Margin = new Padding(4);
            txt_mobile.Name = "txt_mobile";
            txt_mobile.RightToLeft = RightToLeft.Yes;
            txt_mobile.Size = new Size(170, 33);
            txt_mobile.TabIndex = 5;
            // 
            // txt_national_code
            // 
            txt_national_code.BackColor = SystemColors.Info;
            txt_national_code.BorderStyle = BorderStyle.FixedSingle;
            txt_national_code.Cursor = Cursors.IBeam;
            txt_national_code.Location = new Point(424, 229);
            txt_national_code.Margin = new Padding(4);
            txt_national_code.Name = "txt_national_code";
            txt_national_code.RightToLeft = RightToLeft.Yes;
            txt_national_code.Size = new Size(170, 33);
            txt_national_code.TabIndex = 4;
            // 
            // txt_family
            // 
            txt_family.BackColor = SystemColors.Info;
            txt_family.BorderStyle = BorderStyle.FixedSingle;
            txt_family.Cursor = Cursors.IBeam;
            txt_family.Location = new Point(424, 151);
            txt_family.Margin = new Padding(4);
            txt_family.Name = "txt_family";
            txt_family.RightToLeft = RightToLeft.Yes;
            txt_family.Size = new Size(170, 33);
            txt_family.TabIndex = 3;
            // 
            // txt_name
            // 
            txt_name.BackColor = SystemColors.Info;
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Cursor = Cursors.IBeam;
            txt_name.Location = new Point(424, 78);
            txt_name.Margin = new Padding(4);
            txt_name.Name = "txt_name";
            txt_name.RightToLeft = RightToLeft.Yes;
            txt_name.Size = new Size(170, 33);
            txt_name.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(637, 376);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(65, 26);
            label5.TabIndex = 17;
            label5.Text = "عضو ویژه :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(651, 311);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(51, 26);
            label4.TabIndex = 16;
            label4.Text = "موبایل :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(645, 233);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(57, 26);
            label3.TabIndex = 15;
            label3.Text = "کد ملی :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(650, 153);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(52, 26);
            label2.TabIndex = 14;
            label2.Text = "فامیلی :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(669, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(33, 26);
            label1.TabIndex = 27;
            label1.Text = "نام :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(649, 20);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(53, 26);
            label7.TabIndex = 29;
            label7.Text = "شناسه :";
            // 
            // txt_id
            // 
            txt_id.BackColor = SystemColors.Info;
            txt_id.BorderStyle = BorderStyle.FixedSingle;
            txt_id.Cursor = Cursors.IBeam;
            txt_id.Location = new Point(424, 18);
            txt_id.Margin = new Padding(4);
            txt_id.Name = "txt_id";
            txt_id.RightToLeft = RightToLeft.Yes;
            txt_id.Size = new Size(170, 33);
            txt_id.TabIndex = 1;
            // 
            // checkBox_status
            // 
            checkBox_status.AutoSize = true;
            checkBox_status.BackColor = Color.Red;
            checkBox_status.Cursor = Cursors.Hand;
            checkBox_status.Location = new Point(374, 385);
            checkBox_status.Margin = new Padding(4);
            checkBox_status.Name = "checkBox_status";
            checkBox_status.Size = new Size(18, 17);
            checkBox_status.TabIndex = 30;
            checkBox_status.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(435, 376);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(57, 26);
            label8.TabIndex = 31;
            label8.Text = "وضعیت :";
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 514);
            Controls.Add(checkBox_status);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txt_id);
            Controls.Add(label1);
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
            Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmUpdateMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ویرایش عضو";
            ((System.ComponentModel.ISupportInitialize)picture_member).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button btn_save;
        private Label label6;
        private PictureBox picture_member;
        private CheckBox checkBox_isSpecial;
        private TextBox txt_mobile;
        private TextBox txt_national_code;
        private TextBox txt_family;
        private TextBox txt_name;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox txt_id;
        private CheckBox checkBox_status;
        private Label label8;
    }
}