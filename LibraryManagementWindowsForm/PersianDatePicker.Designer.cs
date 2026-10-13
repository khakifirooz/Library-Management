#nullable disable
namespace LibraryManagementWindowsForm
{
    partial class PersianDatePicker
    {
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            _input = new System.Windows.Forms.TextBox();
            _open = new System.Windows.Forms.Button();
            SuspendLayout();
            //
            // _input
            //
            _input.Name = "PersianDateInput";
            _input.Margin = new System.Windows.Forms.Padding(0);
            _input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _input.Dock = System.Windows.Forms.DockStyle.Fill;
            _input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            _input.MaxLength = 10;
            _input.PlaceholderText = "۱۴۰۵/۰۷/۲۱";
            _input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            _input.TabIndex = 0;
            //
            // _open
            //
            _open.Name = "PersianCalendarOpen";
            _open.Margin = new System.Windows.Forms.Padding(4);
            _open.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            _open.Text = "▾";
            _open.Size = new System.Drawing.Size(30, 36);
            _open.MinimumSize = new System.Drawing.Size(30, 32);
            _open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            _open.BackColor = System.Drawing.Color.FromArgb(12, 120, 113);
            _open.ForeColor = System.Drawing.Color.White;
            _open.UseVisualStyleBackColor = false;
            _open.Cursor = System.Windows.Forms.Cursors.Hand;
            _open.AutoSize = false;
            _open.FlatAppearance.BorderSize = 0;
            _open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(222, 230, 239);
            _open.Dock = System.Windows.Forms.DockStyle.Right;
            _open.TabStop = false;
            _open.AccessibleName = "باز کردن تقویم شمسی";
            _open.TabIndex = 1;
            Controls.Add(_input);
            Controls.Add(_open);
            //
            // PersianDatePicker
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            Name = "PersianDatePicker";
            Size = new System.Drawing.Size(170, 36);
            MinimumSize = new System.Drawing.Size(140, 32);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TextBox _input;
        private System.Windows.Forms.Button _open;
    }
}
