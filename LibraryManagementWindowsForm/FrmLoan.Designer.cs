namespace LibraryManagementWindowsForm
{
    partial class FrmLoan
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            txt_family = new TextBox();
            label2 = new Label();
            checkBox_isSpecial = new CheckBox();
            checkBox_status = new CheckBox();
            pictureBox_member = new PictureBox();
            txt_search_id = new TextBox();
            label1 = new Label();
            btn_reneview = new Button();
            groupBox2 = new GroupBox();
            btn_save = new Button();
            dateTimePicker_return = new DateTimePicker();
            dateTimePicker_loan = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            comboBox_books = new ComboBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_member).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(txt_family);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(checkBox_isSpecial);
            groupBox1.Controls.Add(checkBox_status);
            groupBox1.Controls.Add(pictureBox_member);
            groupBox1.Controls.Add(txt_search_id);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_reneview);
            groupBox1.Location = new Point(4, 3);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(792, 453);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجوی عضو";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 239);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(784, 207);
            dataGridView1.TabIndex = 8;
            // 
            // txt_family
            // 
            txt_family.BackColor = SystemColors.Info;
            txt_family.Location = new Point(507, 128);
            txt_family.Margin = new Padding(4);
            txt_family.MaxLength = 10;
            txt_family.Multiline = true;
            txt_family.Name = "txt_family";
            txt_family.Size = new Size(170, 39);
            txt_family.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(718, 131);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 26);
            label2.TabIndex = 6;
            label2.Text = "فامیلی :";
            // 
            // checkBox_isSpecial
            // 
            checkBox_isSpecial.AutoSize = true;
            checkBox_isSpecial.Location = new Point(563, 187);
            checkBox_isSpecial.Name = "checkBox_isSpecial";
            checkBox_isSpecial.RightToLeft = RightToLeft.No;
            checkBox_isSpecial.Size = new Size(80, 30);
            checkBox_isSpecial.TabIndex = 5;
            checkBox_isSpecial.Text = "عضو ویژه";
            checkBox_isSpecial.UseVisualStyleBackColor = true;
            // 
            // checkBox_status
            // 
            checkBox_status.AutoSize = true;
            checkBox_status.Location = new Point(698, 187);
            checkBox_status.Name = "checkBox_status";
            checkBox_status.RightToLeft = RightToLeft.No;
            checkBox_status.Size = new Size(72, 30);
            checkBox_status.TabIndex = 4;
            checkBox_status.Text = "وضعیت";
            checkBox_status.UseVisualStyleBackColor = true;
            // 
            // pictureBox_member
            // 
            pictureBox_member.Location = new Point(7, 33);
            pictureBox_member.Name = "pictureBox_member";
            pictureBox_member.Size = new Size(248, 183);
            pictureBox_member.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_member.TabIndex = 3;
            pictureBox_member.TabStop = false;
            // 
            // txt_search_id
            // 
            txt_search_id.BackColor = SystemColors.Info;
            txt_search_id.Location = new Point(507, 33);
            txt_search_id.Margin = new Padding(4);
            txt_search_id.MaxLength = 10;
            txt_search_id.Multiline = true;
            txt_search_id.Name = "txt_search_id";
            txt_search_id.Size = new Size(170, 39);
            txt_search_id.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(677, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 26);
            label1.TabIndex = 1;
            label1.Text = "شماره عضویت :";
            // 
            // btn_reneview
            // 
            btn_reneview.BackColor = Color.White;
            btn_reneview.FlatAppearance.BorderColor = Color.IndianRed;
            btn_reneview.FlatAppearance.BorderSize = 2;
            btn_reneview.FlatStyle = FlatStyle.Flat;
            btn_reneview.Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btn_reneview.Location = new Point(365, 33);
            btn_reneview.Margin = new Padding(4);
            btn_reneview.Name = "btn_reneview";
            btn_reneview.Size = new Size(112, 39);
            btn_reneview.TabIndex = 0;
            btn_reneview.Text = "بازیابی";
            btn_reneview.UseVisualStyleBackColor = false;
            btn_reneview.Click += btn_reneview_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_save);
            groupBox2.Controls.Add(dateTimePicker_return);
            groupBox2.Controls.Add(dateTimePicker_loan);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBox_books);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(300, 455);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(496, 221);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "امانت کتاب";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.White;
            btn_save.FlatAppearance.BorderColor = Color.IndianRed;
            btn_save.FlatAppearance.BorderSize = 2;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btn_save.Location = new Point(7, 46);
            btn_save.Margin = new Padding(4);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(112, 39);
            btn_save.TabIndex = 9;
            btn_save.Text = "ثبت امانت";
            btn_save.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker_return
            // 
            dateTimePicker_return.Font = new Font("Book Antiqua", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_return.Format = DateTimePickerFormat.Short;
            dateTimePicker_return.Location = new Point(149, 165);
            dateTimePicker_return.Name = "dateTimePicker_return";
            dateTimePicker_return.Size = new Size(250, 29);
            dateTimePicker_return.TabIndex = 14;
            // 
            // dateTimePicker_loan
            // 
            dateTimePicker_loan.Font = new Font("Book Antiqua", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_loan.Format = DateTimePickerFormat.Short;
            dateTimePicker_loan.Location = new Point(149, 106);
            dateTimePicker_loan.Name = "dateTimePicker_loan";
            dateTimePicker_loan.Size = new Size(250, 29);
            dateTimePicker_loan.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 165);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 26);
            label5.TabIndex = 12;
            label5.Text = "تاریخ تحویل :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(412, 106);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 26);
            label4.TabIndex = 11;
            label4.Text = "تاریخ امانت :";
            // 
            // comboBox_books
            // 
            comboBox_books.FormattingEnabled = true;
            comboBox_books.Location = new Point(149, 46);
            comboBox_books.Name = "comboBox_books";
            comboBox_books.Size = new Size(250, 34);
            comboBox_books.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 46);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 26);
            label3.TabIndex = 9;
            label3.Text = "نام کتاب :";
            // 
            // FrmLoan
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(803, 673);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Margin = new Padding(4);
            Name = "FrmLoan";
            Text = "مدیریت امانات";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_member).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_search_id;
        private Label label1;
        private Button btn_reneview;
        private PictureBox pictureBox_member;
        private CheckBox checkBox_status;
        private CheckBox checkBox_isSpecial;
        private DataGridView dataGridView1;
        private TextBox txt_family;
        private Label label2;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private ComboBox comboBox_books;
        private Label label3;
        private Button btn_save;
        private DateTimePicker dateTimePicker_return;
        private DateTimePicker dateTimePicker_loan;
    }
}