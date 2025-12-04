namespace LibraryManagementContracts.Member
{
    public class MemberViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public bool IsSpecial { get; set; }
        public bool Status { get; set; }
        public byte[] Image { get; set; }
    }
}
