namespace LibraryManagementContracts.Member
{
    public class MemberCreateModel
    {
        public string Name { get; private set; }
        public string Family { get; private set; }
        public string NationalCode { get; private set; }
        public string Mobile { get; private set; }
        public bool IsSpecial { get; private set; }
        public byte[] Image { get; private set; }
    }
}
