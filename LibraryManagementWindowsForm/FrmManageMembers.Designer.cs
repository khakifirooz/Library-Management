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
            btn_search = new Button();
            txt_search_national_code = new TextBox();
            label2 = new Label();
            txt_search_id = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGrid_members = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_members).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(txt_search_national_code);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_search_id);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(966, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Khaki;
            btn_search.Font = new Font("B Nazanin", 10.2F);
            btn_search.Location = new Point(7, 30);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(142, 33);
            btn_search.TabIndex = 4;
            btn_search.Text = "جستحو";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // txt_search_national_code
            // 
            txt_search_national_code.BackColor = SystemColors.Info;
            txt_search_national_code.BorderStyle = BorderStyle.FixedSingle;
            txt_search_national_code.Cursor = Cursors.IBeam;
            txt_search_national_code.Location = new Point(332, 60);
            txt_search_national_code.Name = "txt_search_national_code";
            txt_search_national_code.Size = new Size(162, 30);
            txt_search_national_code.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Nazanin", 10.2F);
            label2.Location = new Point(501, 60);
            label2.Name = "label2";
            label2.Size = new Size(57, 26);
            label2.TabIndex = 2;
            label2.Text = "کد ملی :";
            // 
            // txt_search_id
            // 
            txt_search_id.BackColor = SystemColors.Info;
            txt_search_id.BorderStyle = BorderStyle.FixedSingle;
            txt_search_id.Cursor = Cursors.IBeam;
            txt_search_id.Location = new Point(666, 56);
            txt_search_id.Name = "txt_search_id";
            txt_search_id.Size = new Size(162, 30);
            txt_search_id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Nazanin", 10.2F);
            label1.Location = new Point(835, 56);
            label1.Name = "label1";
            label1.Size = new Size(93, 26);
            label1.TabIndex = 0;
            label1.Text = "شماره عضویت :";
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.FlatAppearance.BorderColor = Color.DarkOrange;
            button1.FlatAppearance.BorderSize = 2;
            button1.Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            button1.Location = new Point(536, 151);
            button1.Name = "button1";
            button1.Size = new Size(175, 47);
            button1.TabIndex = 5;
            button1.Text = "ویرایش عضو";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.FlatAppearance.BorderColor = Color.DarkOrange;
            button2.FlatAppearance.BorderSize = 2;
            button2.Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            button2.Location = new Point(765, 151);
            button2.Name = "button2";
            button2.Size = new Size(175, 47);
            button2.TabIndex = 6;
            button2.Text = "ثبت عضو";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGrid_members
            // 
            dataGrid_members.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_members.Location = new Point(12, 217);
            dataGrid_members.Name = "dataGrid_members";
            dataGrid_members.ReadOnly = true;
            dataGrid_members.RightToLeft = RightToLeft.Yes;
            dataGrid_members.RowHeadersWidth = 51;
            dataGrid_members.Size = new Size(966, 314);
            dataGrid_members.TabIndex = 7;
            // 
            // FrmManageMembers
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 538);
            Controls.Add(dataGrid_members);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Font = new Font("B Nazanin", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Name = "FrmManageMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مدیریت اعضا";
            Load += FrmManageMembers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_members).EndInit();
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
        private DataGridView dataGrid_members;
    }
}