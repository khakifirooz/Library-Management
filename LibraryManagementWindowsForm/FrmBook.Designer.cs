namespace LibraryManagementWindowsForm
{
    partial class FrmBook
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
            dataGrid_books = new DataGridView();
            groupBox1 = new GroupBox();
            btn_delete = new Button();
            btn_edite = new Button();
            btn_save = new Button();
            label5 = new Label();
            picture_book = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_language = new TextBox();
            txt_author = new TextBox();
            txt_name = new TextBox();
            groupBox2 = new GroupBox();
            txt_search = new TextBox();
            label6 = new Label();
            lbl_id = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid_books).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_book).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid_books
            // 
            dataGrid_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_books.Location = new Point(12, 273);
            dataGrid_books.Name = "dataGrid_books";
            dataGrid_books.RowHeadersWidth = 51;
            dataGrid_books.Size = new Size(834, 216);
            dataGrid_books.TabIndex = 0;
            dataGrid_books.CellClick += dataGrid_books_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btn_edite);
            groupBox1.Controls.Add(btn_save);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(picture_book);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_language);
            groupBox1.Controls.Add(txt_author);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Location = new Point(338, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 255);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.PowderBlue;
            btn_delete.FlatAppearance.BorderColor = Color.Green;
            btn_delete.FlatAppearance.BorderSize = 4;
            btn_delete.Font = new Font("B Nazanin", 13.8F);
            btn_delete.Location = new Point(204, 201);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 42);
            btn_delete.TabIndex = 10;
            btn_delete.Text = "حذف";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edite
            // 
            btn_edite.BackColor = Color.PowderBlue;
            btn_edite.FlatAppearance.BorderColor = Color.Green;
            btn_edite.FlatAppearance.BorderSize = 4;
            btn_edite.Font = new Font("B Nazanin", 13.8F);
            btn_edite.Location = new Point(304, 201);
            btn_edite.Name = "btn_edite";
            btn_edite.Size = new Size(94, 42);
            btn_edite.TabIndex = 9;
            btn_edite.Text = "ویرایش";
            btn_edite.UseVisualStyleBackColor = false;
            btn_edite.Click += btn_edite_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.PowderBlue;
            btn_save.FlatAppearance.BorderColor = Color.Green;
            btn_save.FlatAppearance.BorderSize = 4;
            btn_save.Font = new Font("B Nazanin", 13.8F);
            btn_save.Location = new Point(404, 201);
            btn_save.Name = "btn_save";
            btn_save.RightToLeft = RightToLeft.No;
            btn_save.Size = new Size(94, 42);
            btn_save.TabIndex = 8;
            btn_save.Text = "ثبت";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("B Nazanin", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label5.ForeColor = SystemColors.InactiveCaptionText;
            label5.Location = new Point(57, 16);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(79, 26);
            label5.TabIndex = 7;
            label5.Text = "عکس کتاب :";
            // 
            // picture_book
            // 
            picture_book.BorderStyle = BorderStyle.FixedSingle;
            picture_book.Cursor = Cursors.Hand;
            picture_book.Location = new Point(6, 45);
            picture_book.Name = "picture_book";
            picture_book.Size = new Size(192, 198);
            picture_book.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_book.TabIndex = 2;
            picture_book.TabStop = false;
            picture_book.Click += picture_book_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("B Nazanin", 12F);
            label4.ForeColor = SystemColors.InactiveCaptionText;
            label4.Location = new Point(410, 45);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(93, 29);
            label4.TabIndex = 6;
            label4.Text = "عنوان کتاب :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Nazanin", 12F);
            label3.ForeColor = SystemColors.InactiveCaptionText;
            label3.Location = new Point(420, 146);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(83, 29);
            label3.TabIndex = 5;
            label3.Text = "زبان کتاب :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Nazanin", 12F);
            label2.ForeColor = SystemColors.InactiveCaptionText;
            label2.Location = new Point(397, 93);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(106, 29);
            label2.TabIndex = 4;
            label2.Text = "نویسنده کتاب :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Nazanin", 12F);
            label1.Location = new Point(426, 48);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(0, 29);
            label1.TabIndex = 3;
            // 
            // txt_language
            // 
            txt_language.BackColor = SystemColors.InactiveCaption;
            txt_language.BorderStyle = BorderStyle.FixedSingle;
            txt_language.Cursor = Cursors.IBeam;
            txt_language.Font = new Font("B Nazanin", 9F);
            txt_language.Location = new Point(204, 145);
            txt_language.MaxLength = 50;
            txt_language.Name = "txt_language";
            txt_language.RightToLeft = RightToLeft.Yes;
            txt_language.Size = new Size(194, 30);
            txt_language.TabIndex = 2;
            // 
            // txt_author
            // 
            txt_author.BackColor = SystemColors.InactiveCaption;
            txt_author.BorderStyle = BorderStyle.FixedSingle;
            txt_author.Cursor = Cursors.IBeam;
            txt_author.Font = new Font("B Nazanin", 9F);
            txt_author.Location = new Point(204, 92);
            txt_author.MaxLength = 50;
            txt_author.Name = "txt_author";
            txt_author.RightToLeft = RightToLeft.Yes;
            txt_author.Size = new Size(194, 30);
            txt_author.TabIndex = 1;
            // 
            // txt_name
            // 
            txt_name.BackColor = SystemColors.InactiveCaption;
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Cursor = Cursors.IBeam;
            txt_name.Font = new Font("B Nazanin", 9F);
            txt_name.Location = new Point(204, 45);
            txt_name.MaxLength = 50;
            txt_name.Name = "txt_name";
            txt_name.RightToLeft = RightToLeft.Yes;
            txt_name.Size = new Size(194, 30);
            txt_name.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_search);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(320, 220);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "جستجو :";
            // 
            // txt_search
            // 
            txt_search.BackColor = SystemColors.InactiveCaption;
            txt_search.BorderStyle = BorderStyle.FixedSingle;
            txt_search.Cursor = Cursors.IBeam;
            txt_search.Font = new Font("B Nazanin", 9F);
            txt_search.Location = new Point(66, 75);
            txt_search.MaxLength = 50;
            txt_search.Name = "txt_search";
            txt_search.RightToLeft = RightToLeft.Yes;
            txt_search.Size = new Size(236, 30);
            txt_search.TabIndex = 11;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("B Nazanin", 12F);
            label6.ForeColor = SystemColors.InactiveCaptionText;
            label6.Location = new Point(108, 43);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(206, 29);
            label6.TabIndex = 11;
            label6.Text = " جستجو بر اساس عنوان کتاب :";
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("B Nazanin", 12F);
            lbl_id.ForeColor = SystemColors.InactiveCaptionText;
            lbl_id.Location = new Point(129, 241);
            lbl_id.Name = "lbl_id";
            lbl_id.RightToLeft = RightToLeft.Yes;
            lbl_id.Size = new Size(0, 29);
            lbl_id.TabIndex = 11;
            lbl_id.Visible = false;
            // 
            // FrmBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(858, 495);
            Controls.Add(lbl_id);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGrid_books);
            Name = "FrmBook";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مدیریت کتاب ها";
            Load += FrmBook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_books).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_book).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid_books;
        private GroupBox groupBox1;
        private TextBox txt_language;
        private TextBox txt_author;
        private TextBox txt_name;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private PictureBox picture_book;
        private Button btn_delete;
        private Button btn_edite;
        private Button btn_save;
        private GroupBox groupBox2;
        private TextBox txt_search;
        private Label label6;
        private Label lbl_id;
    }
}