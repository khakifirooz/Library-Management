using FrameworkApplication;
using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm;

public partial class FrmManageMembers : Form
{
    private readonly IMemberService _memberService;
    private int _selectedMemberId;
    private readonly Label _status = UiTheme.Status();
    public FrmManageMembers(IMemberService memberService)
    {
        InitializeComponent(); BuildUi(); _memberService = memberService;
        dataGrid_members.ReadOnly = true; dataGrid_members.AllowUserToAddRows = false;
        dataGrid_members.MultiSelect = false; dataGrid_members.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        userProfile1.ShowOnline(GlobalUser.Username);
    }
    private async Task LoadMembersAsync()
    {
        var text = PersianDateHelper.NormalizeDigits(txt_search_id.Text).Trim();
        var id = 0;
        if (text.Length > 0 && (!int.TryParse(text, out id) || id <= 0))
        { MessageBox.Show("شماره عضویت معتبر وارد کنید."); return; }
        var rows = await _memberService.SearchAsync(id, txt_search_national_code.Text);
        dataGrid_members.DataSource = rows;
        _status.Text = rows.Count == 0 ? "عضوی با این مشخصات پیدا نشد." : $"{UiText.Digits(rows.Count)} عضو نمایش داده می‌شود";
        SetColumns(); dataGrid_members.ClearSelection(); _selectedMemberId = 0; btn_update.Enabled = false;
    }
    private async void FrmManageMembers_Load(object sender, EventArgs e) => await UiActions.RunAsync(this, LoadMembersAsync);
    private async void btn_search_Click(object sender, EventArgs e) => await UiActions.RunAsync(this, LoadMembersAsync);
    private async void button2_Click(object sender, EventArgs e)
    { if (Program.ShowDialog<FrmRegisterMember>() == DialogResult.OK) await UiActions.RunAsync(this, LoadMembersAsync); }
    private void dataGrid_members_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dataGrid_members.Rows[e.RowIndex].DataBoundItem is not MemberViewModel member) return;
        _selectedMemberId = member.Id; btn_update.Enabled = true;
    }
    private async void btn_update_Click(object sender, EventArgs e)
    {
        if (_selectedMemberId <= 0) return;
        if (Program.ShowDialog<FrmUpdateMember>(form => form.MemberId = _selectedMemberId) == DialogResult.OK)
            await UiActions.RunAsync(this, LoadMembersAsync);
    }
    private void SetColumns() { }

    private void BuildUi()
    {
        txt_search_id.MaxLength = 10; txt_search_national_code.MaxLength = 10;
        txt_search_id.PlaceholderText = "همهٔ اعضا"; txt_search_national_code.PlaceholderText = "همهٔ کدهای ملی";
        var search = UiLayout.Across(UiLayout.Field("شماره عضویت", txt_search_id),
            UiLayout.Field("کد ملی", txt_search_national_code), UiLayout.Actions(btn_search, button2, btn_update));
        UiLayout.Install(this, "مدیریت اعضا", "جست‌وجوی عضو، ثبت‌نام و ویرایش اطلاعات",
            UiLayout.Card("فهرست اعضا", UiLayout.GridArea(dataGrid_members, _status, search)), userProfile1);
        btn_search.Text = "جست‌وجو"; button2.Text = "عضو جدید"; btn_update.Text = "ویرایش عضو";
        UiTheme.Button(btn_search, false); UiTheme.Button(btn_update, false);
        UiGrids.Members(dataGrid_members); btn_update.Enabled = false;
        dataGrid_members.SelectionChanged += (_, _) =>
        {
            var member = dataGrid_members.SelectedRows.Count > 0
                ? dataGrid_members.SelectedRows[0].DataBoundItem as MemberViewModel : null;
            _selectedMemberId = member?.Id ?? 0; btn_update.Enabled = member is not null;
        };
    }

}
