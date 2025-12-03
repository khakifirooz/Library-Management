namespace LibraryManagementWindowsForm
{
    partial class FrmManageMembers
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
            label1 = new Label();
            txt_search_id = new TextBox();
            txt_search_national_code = new TextBox();
            label2 = new Label();
            btn_search = new Button();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(txt_search_national_code);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_search_id);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(852, 103);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(742, 49);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "شماره عضویت :";
            // 
            // txt_search_id
            // 
            txt_search_id.Location = new Point(592, 49);
            txt_search_id.Name = "txt_search_id";
            txt_search_id.Size = new Size(144, 27);
            txt_search_id.TabIndex = 1;
            // 
            // txt_search_national_code
            // 
            txt_search_national_code.Location = new Point(295, 52);
            txt_search_national_code.Name = "txt_search_national_code";
            txt_search_national_code.Size = new Size(144, 27);
            txt_search_national_code.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 52);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "کد ملی :";
            // 
            // btn_search
            // 
            btn_search.Location = new Point(6, 26);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(126, 29);
            btn_search.TabIndex = 4;
            btn_search.Text = "جستحو";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(706, 147);
            button1.Name = "button1";
            button1.Size = new Size(126, 29);
            button1.TabIndex = 5;
            button1.Text = "جستحو کاربر";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(543, 147);
            button2.Name = "button2";
            button2.Size = new Size(126, 29);
            button2.TabIndex = 6;
            button2.Text = "ثبت کاربر";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmManageMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 568);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "FrmManageMembers";
            Text = "مدیریت اعضا";
            Load += FrmManageMembers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_search_id;
        private Label label1;
        private Button btn_search;
        private TextBox txt_search_national_code;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}