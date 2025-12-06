namespace LibraryManagementContracts.Loan
{
    public class LoanCreateModel
    {
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
