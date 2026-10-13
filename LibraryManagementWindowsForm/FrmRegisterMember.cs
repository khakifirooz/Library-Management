using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm;

public partial class FrmRegisterMember : Form
{
    private readonly IMemberService _memberService = null!;
    public FrmRegisterMember() { InitializeComponent(); }

    public FrmRegisterMember(IMemberService memberService) : this()
    {
        _memberService = memberService;
    }
    private void button2_Click(object sender, EventArgs e) => Close();
    private void FrmRegisterMember_Load(object sender, EventArgs e) { if (!UiDesigner.IsDesignMode(this)) userProfile1.ShowOnline(GlobalUser.Username); }
    private void picture_member_Click(object sender, EventArgs e)
    { try { ImageHelper.Select(picture_member); } catch (Exception) { MessageBox.Show("فایل عکس معتبر نیست."); } }
    private async void btn_save_Click(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    {
        var result = await _memberService.CreateAsync(new MemberCreateModel
        {
            Name = txt_name.Text, Family = txt_family.Text, NationalCode = txt_national_code.Text,
            Mobile = txt_mobile.Text, IsSpecial = checkBox_isSpecial.Checked, Image = ImageHelper.ToBytes(picture_member)
        });
        MessageBox.Show(result.Message);
        if (result.Success) { DialogResult = DialogResult.OK; Close(); }
    });
    private void txt_national_code_KeyPress(object sender, KeyPressEventArgs e)
    { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); }
    private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
    { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); }
    private void txt_mobile_TextChanged(object sender, EventArgs e) { }



    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        UiDesigner.FitToScreen(this);
    }
}
