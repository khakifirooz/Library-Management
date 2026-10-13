using System.ComponentModel;
using LibraryManagementContracts.Member;

namespace LibraryManagementWindowsForm;

public partial class FrmUpdateMember : Form
{
    private readonly IMemberService _memberService = null!;
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int MemberId { get; set; }
    public FrmUpdateMember() { InitializeComponent(); }

    public FrmUpdateMember(IMemberService memberService) : this()
    {
        _memberService = memberService;
    }
    private async void FrmUpdateMember_Load(object sender, EventArgs e) => await UiActions.RunAsync(this, async () =>
    {
        if (_memberService is null || UiDesigner.IsDesignMode(this)) return;
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
            Image = ImageHelper.ToBytes(picture_member)
        });
        MessageBox.Show(result.Message);
        if (result.Success) { DialogResult = DialogResult.OK; Close(); }
    });


    private void ChoosePhoto(object? sender, EventArgs e)
    { try { ImageHelper.Select(picture_member); } catch (Exception) { MessageBox.Show("فایل عکس معتبر نیست."); } }

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        UiDesigner.FitToScreen(this);
    }
}
