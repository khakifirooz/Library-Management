#nullable disable
namespace LibraryManagementWindowsForm
{
    partial class UserProfile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            statusDot = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            SuspendLayout();
            //
            // statusDot
            //
            statusDot.Name = "statusDot";
            statusDot.Margin = new System.Windows.Forms.Padding(0);
            statusDot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            statusDot.Text = "●";
            statusDot.Dock = System.Windows.Forms.DockStyle.Left;
            statusDot.Size = new System.Drawing.Size(26, 40);
            statusDot.ForeColor = System.Drawing.Color.FromArgb(12, 120, 113);
            statusDot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            statusDot.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.Name = "lblTitle";
            lblTitle.Margin = new System.Windows.Forms.Padding(0);
            lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblTitle.Text = "کاربر  •  آنلاین";
            lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblTitle.AutoSize = false;
            lblTitle.AutoEllipsis = true;
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(12, 120, 113);
            lblTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.TabIndex = 1;
            Controls.Add(lblTitle);
            Controls.Add(statusDot);
            Load += UserProfile_Load;
            //
            // UserProfile
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ForeColor = System.Drawing.Color.FromArgb(25, 42, 66);
            Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Name = "UserProfile";
            Size = new System.Drawing.Size(220, 40);
            MinimumSize = new System.Drawing.Size(160, 32);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label statusDot;
        private System.Windows.Forms.Label lblTitle;
    }
}
