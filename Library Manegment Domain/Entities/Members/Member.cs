using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Loans;
using Library_Manegment_Domain.Exeptions;

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
        public List<Loan> Loans { get; set; } = new List<Loan>();

        public Member(string name, string family, string nationalCode, string mobile, bool isSpecial, byte[] image)
        {
            Name = name;
            Family = family;
            NationalCode = nationalCode;
            Mobile = mobile;
            IsSpecial = isSpecial;
            Image = image;
            Status = true;
            Loans = new List<Loan>();
        }

        public void Update(string name, string family, string nationalCode, string mobile, bool isSpecial,bool status, byte[] image)
        {
            Name = name;
            Family = family;
            NationalCode = nationalCode;
            Mobile = mobile;
            IsSpecial = isSpecial;
            Status = status;
            Image = image;
        }


        public void addLoan(Loan loan)
        {
            if (Status == false)
                throw new MemberIsInactiveException();
            if (IsSpecial == false && Loans.Count >= 3)
                throw new NotAllowExeption(Loans.Count);
            if (IsSpecial == true && Loans.Count >= 5)
                throw new NotAllowExeption(Loans.Count);
            Loans.Add(loan);
        }

        public void RemoveLoan(Loan loan)
        {
            if (loan == null)
                throw new ArgumentNullException(nameof(loan));

            if (!Loans.Remove(loan))
                throw new InvalidOperationException("امانت برای عضو پیدا نشد");

            if (loan == null)
                throw new ArgumentNullException(nameof(loan));

            bool removed = Loans.Remove(loan);
            if (!removed)
                throw new InvalidOperationException("امانت برای عضو پیدا نشد");
        }
    }
}
