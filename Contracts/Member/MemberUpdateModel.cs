namespace LibraryManagementContracts.Member
{
    public class MemberUpdateModel : MemberCreateModel
    {
        public int Id { get; set; }
        public bool IsSpecial { get; set; }
    }
}
