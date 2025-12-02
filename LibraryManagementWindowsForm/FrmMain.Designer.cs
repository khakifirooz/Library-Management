namespace LibraryManagementWindowsForm
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btnBook = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnBook
            // 
            btnBook.BackColor = SystemColors.ActiveCaption;
            btnBook.FlatAppearance.BorderColor = Color.Blue;
            btnBook.FlatAppearance.BorderSize = 2;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Location = new Point(872, 31);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(129, 38);
            btnBook.TabIndex = 0;
            btnBook.Text = "مدیریت کتاب ها";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(872, 93);
            button1.Name = "button1";
            button1.Size = new Size(129, 38);
            button1.TabIndex = 1;
            button1.Text = "مدیریت اعضا";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(872, 156);
            button2.Name = "button2";
            button2.Size = new Size(129, 38);
            button2.TabIndex = 2;
            button2.Text = "مدیریت امانات";
            button2.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1033, 581);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnBook);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فرم اصلی";
            Load += FrmMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBook;
        private Button button1;
        private Button button2;
    }
}
