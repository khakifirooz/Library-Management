using System.ComponentModel;
using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm;

public partial class FrmUpdateMember : Form
{
    private readonly IMemberService _memberService;
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int MemberId { get; set; }
    public FrmUpdateMember(IMemberService memberService) { _memberService = memberService; InitializeComponent(); BuildUi(); }
    private async void FrmUpdateMember_Load(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    {
        var member = await _memberService.GetByIdAsync(MemberId);
        if (member is null) { MessageBox.Show("عضو پیدا نشد."); Close(); return; }
        txt_id.Text = member.Id.ToString(); txt_name.Text = member.Name; txt_family.Text = member.Family;
        txt_national_code.Text = member.NationalCode; txt_mobile.Text = member.Mobile;
        checkBox_isSpecial.Checked = member.IsSpecial; checkBox_status.Checked = member.Status;
        ImageHelper.SetImage(picture_member, member.Image); userProfile1.ShowOnline(GlobalUser.Username);
    });
    private void btn_close_Click(object sender, EventArgs e) => Close();
    private async void btn_save_Click(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    {
        var result = await _memberService.UpdateAsync(new MemberUpdateModel
        {
            Id = MemberId, Name = txt_name.Text, Family = txt_family.Text, NationalCode = txt_national_code.Text,
            Mobile = txt_mobile.Text, IsSpecial = checkBox_isSpecial.Checked, Status = checkBox_status.Checked,
            Image = ImageHelper.ToBytes(picture_member.Image)
        });
        MessageBox.Show(result.Message);
        if (result.Success) { DialogResult = DialogResult.OK; Close(); }
    });

    private void BuildUi()
    {
        txt_name.MaxLength = 20; txt_family.MaxLength = 30;
        txt_national_code.MaxLength = 10; txt_mobile.MaxLength = 11; txt_id.ReadOnly = true;
        checkBox_isSpecial.Text = "عضویت ویژه"; checkBox_status.Text = "عضو فعال";
        var fields = UiLayout.Card("اطلاعات عضو", UiLayout.ScrollFields(UiLayout.Field("شماره عضویت", txt_id),
            UiLayout.Field("نام", txt_name), UiLayout.Field("نام خانوادگی", txt_family),
            UiLayout.Field("کد ملی", txt_national_code), UiLayout.Field("موبایل", txt_mobile),
            checkBox_isSpecial, checkBox_status, UiLayout.Actions(btn_save, btn_close)));
        var photo = UiLayout.Card("تصویر عضو", UiLayout.ScrollFields(UiLayout.Photo(picture_member, ChoosePhoto)));
        UiLayout.Install(this, "ویرایش عضو", "اصلاح اطلاعات هویتی و وضعیت عضویت", UiLayout.Split(fields, photo, 250), userProfile1,
            880, 760, 760, 640);
        btn_save.Text = "ذخیرهٔ تغییرات"; btn_close.Text = "بازگشت"; UiTheme.Button(btn_close, false);
        picture_member.Click += ChoosePhoto; AcceptButton = btn_save; CancelButton = btn_close;
    }
    private void ChoosePhoto(object? sender, EventArgs e)
    { try { ImageHelper.Select(picture_member); } catch (Exception) { MessageBox.Show("فایل عکس معتبر نیست."); } }

}
