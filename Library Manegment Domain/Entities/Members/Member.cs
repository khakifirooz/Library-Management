using Library_Manegment_Domain.Common;

namespace Library_Manegment_Domain.Entities.Members
{
    public class Member : BaseEntity<int>
    {
        public string Name { get; private set; }
        public string Family { get; private set; }
        public string NationalCode { get; private set; }
        public string Mobile { get; private set; }
        public bool IsSpecial { get; private set; }
        public bool Status { get; private set; }
        public byte[] Image { get; private set; }

        public Member(string name, string family, string nationalCode, string mobile, bool isSpecial, bool status, byte[] image)
        {
            Name = name;
            Family = family;
            NationalCode = nationalCode;
            Mobile = mobile;
            IsSpecial = isSpecial;
            Status = status;
            Image = image;
        }
    }
}
