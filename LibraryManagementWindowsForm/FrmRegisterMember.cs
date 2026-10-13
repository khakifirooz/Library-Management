using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm;

public partial class FrmRegisterMember : Form
{
    private readonly IMemberService _memberService;
    public FrmRegisterMember(IMemberService memberService) { InitializeComponent(); BuildUi(); _memberService = memberService; }
    private void button2_Click(object sender, EventArgs e) => Close();
    private void FrmRegisterMember_Load(object sender, EventArgs e) => userProfile1.ShowOnline(GlobalUser.Username);
    private void picture_member_Click(object sender, EventArgs e)
    { try { ImageHelper.Select(picture_member); } catch (Exception) { MessageBox.Show("فایل عکس معتبر نیست."); } }
    private async void btn_save_Click(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    {
        var result = await _memberService.CreateAsync(new MemberCreateModel
        {
            Name = txt_name.Text, Family = txt_family.Text, NationalCode = txt_national_code.Text,
            Mobile = txt_mobile.Text, IsSpecial = checkBox_isSpecial.Checked, Image = ImageHelper.ToBytes(picture_member.Image)
        });
        MessageBox.Show(result.Message);
        if (result.Success) { DialogResult = DialogResult.OK; Close(); }
    });
    private void txt_national_code_KeyPress(object sender, KeyPressEventArgs e)
    { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); }
    private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
    { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); }
    private void txt_mobile_TextChanged(object sender, EventArgs e) { }

    private void BuildUi()
    {
        txt_name.MaxLength = 20; txt_family.MaxLength = 30;
        txt_national_code.MaxLength = 10; txt_mobile.MaxLength = 11;
        checkBox_isSpecial.Text = "عضویت ویژه";
        var fields = UiLayout.Card("مشخصات عضو", UiLayout.ScrollFields(UiLayout.Field("نام", txt_name),
            UiLayout.Field("نام خانوادگی", txt_family), UiLayout.Field("کد ملی", txt_national_code),
            UiLayout.Field("موبایل", txt_mobile), checkBox_isSpecial, UiLayout.Actions(btn_save, button2)));
        var photo = UiLayout.Card("تصویر عضو", UiLayout.ScrollFields(UiLayout.Photo(picture_member, picture_member_Click)));
        UiLayout.Install(this, "ثبت عضو جدید", "اطلاعات هویتی و نوع عضویت", UiLayout.Split(fields, photo, 250), userProfile1,
            880, 720, 760, 620);
        btn_save.Text = "ثبت عضو"; button2.Text = "بازگشت"; UiTheme.Button(button2, false);
        AcceptButton = btn_save; CancelButton = button2;
    }

}
