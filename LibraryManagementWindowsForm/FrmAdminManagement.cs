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

namespace LibraryManagementWindowsForm
{
    public partial class FrmAdminManagement : Form
    {

        private readonly IMemberService _memberService;

        private int _selectedAdminId;

        private async Task LoadData()
        {
            dgvAdmins.DataSource =
                await _memberService.GetAllAdminsAsync();

            dgvAdmins.Columns["Id"].Visible = false;
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
            await LoadData();
        }

        private void dgvAdmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dgvAdmins.Rows[e.RowIndex];

            _selectedAdminId =
                Convert.ToInt32(row.Cells["Id"].Value);

            txtUserName.Text =
                row.Cells["UserName"].Value?.ToString();

            txtPassword.Clear();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var result =
           await _memberService.UpdateAdminAsync(
            new UpdateAdminModel
            {
                Id = _selectedAdminId,
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            });

            MessageBox.Show(result.Message);

            await LoadData();
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
    }
}
