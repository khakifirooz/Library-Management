using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementContracts.Admin;
using LibraryManagementContracts.Member;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementWindowsForm
{
    public partial class FrmAdminManagement : Form
    {

        private readonly IMemberService _memberService;

        private int _selectedAdminId;

        private string _originalUserName;
        private string _originalPassword;
        private bool _isDataChanged = false;


        private async Task LoadData()
        {
            dgvAdmins.DataSource = await _memberService.GetAllAdminsAsync();

            // dgvAdmins.Columns["Id"].Visible = false;

            if (dgvAdmins.Columns.Contains("Id"))
                dgvAdmins.Columns["Id"].Visible = false;

            // این خط باعث می‌شود ستون پسورد در گرید مخفی شود
            if (dgvAdmins.Columns.Contains("Password"))
                dgvAdmins.Columns["Password"].Visible = false;
        }
        public FrmAdminManagement(IMemberService memberService)
        {
            InitializeComponent();
            _memberService = memberService;
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            await _memberService
                .EnableAdminAsync(_selectedAdminId);

            await LoadData();
        }

        private async void FrmAdminManagement_Load(object sender, EventArgs e)
        {

            txtUserName.TextChanged += TextBoxes_TextChanged;
            txtPassword.TextChanged += TextBoxes_TextChanged;


            txtPassword.PasswordChar = '*';

            await LoadData();

            if (GlobalUser.Username != null)
            {
                userProfile1.ShowOnline(GlobalUser.Username);
            }
        }
        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            _isDataChanged =
                txtUserName.Text != _originalUserName ||
                txtPassword.Text != _originalPassword;
        }


        private void dgvAdmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dgvAdmins.Rows[e.RowIndex];

            _selectedAdminId = Convert.ToInt32(row.Cells["Id"].Value);

            txtUserName.Text = row.Cells["UserName"].Value?.ToString();

            if (dgvAdmins.Columns.Contains("Password"))
            {
                txtPassword.Text = row.Cells["Password"].Value?.ToString();
            }
            else
            {
                txtPassword.Text = "";
            }

            _originalUserName = txtUserName.Text;
            _originalPassword = txtPassword.Text;
            _isDataChanged = false;

            //txtUserName.Text = row.Cells["UserName"].Value?.ToString();  // نمایش یوزر نیم تو تکست باکسه

            //// اگر پسورد در مدل وجود داشته باشد، اینجا نمایش داده می‌شود
            //if (dgvAdmins.Columns.Contains("Password"))
            //{
            //    txtPassword.Text = row.Cells["Password"].Value?.ToString();
            //}

            //txtPassword.Clear();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {

            // ۱. بررسی انتخاب ادمین
            if (_selectedAdminId <= 0)
            {
                MessageBox.Show("لطفاً ابتدا یک ادمین را انتخاب کنید.");
                return;
            }

            if (!_isDataChanged)
            {
                MessageBox.Show("هیچ تغییری انجام نشده است.");
                return;
            }

            // ۲. بررسی خالی نبودن و طول پسورد (حداقل ۳ کاراکتر)
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("رمز عبور نباید خالی باشد.");
                return;
            }

            if (txtPassword.Text.Length < 3)
            {
                MessageBox.Show("رمز عبور باید حداقل ۳ کاراکتر باشد.");
                return;
            }

            var confirm = MessageBox.Show(
                      "اطلاعات تغییر کرده است. آیا می‌خواهید ذخیره شود؟",
                          "تأیید ذخیره",
                          MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question
                           );

            if (confirm != DialogResult.Yes)
                return;

            var result =
           await _memberService.UpdateAdminAsync(
            new UpdateAdminModel
            {
                Id = _selectedAdminId,
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            });

            MessageBox.Show(result.Message);

            if (result.Success)
            {
                await LoadData();
            }
        }

        private async void btnDisable_Click(object sender, EventArgs e)
        {

            var role =
                dgvAdmins.CurrentRow.Cells["Role"]
                .Value?.ToString();

            if (role == "SuperAdmin")
            {
                MessageBox.Show(
                    "SuperAdmin cannot be disabled");

                return;
            }

            await _memberService
              .DisableAdminAsync(_selectedAdminId);

            await LoadData();

        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void userProfile1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            var form = new FrmCreateAdmin(_memberService);
            form.ShowDialog();
        }
    }
}
