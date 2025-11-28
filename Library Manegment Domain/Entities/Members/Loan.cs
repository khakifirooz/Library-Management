using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Books;

namespace Library_Manegment_Domain.Entities.Members
{
    public class Loan : BaseEntity<int>
    {
        public int MemberId { get; private set; }
        public Member Member { get; private set; }
        public int BookId { get; private set; }
        public Book Book { get; private set; }
        public DateTime LoanDate { get; private set; }
        public DateTime ReturnDate { get; private set; }
        public bool Status { get; private set; }

        public Loan(int memberId, int bookId, DateTime loanDate, DateTime returnDate)
        {
            MemberId = memberId;
            BookId = bookId;
            LoanDate = loanDate;
            ReturnDate = returnDate;
            Status = false;
        }
    }
}
