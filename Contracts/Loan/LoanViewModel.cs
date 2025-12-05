namespace LibraryManagementContracts.Loan
{
    public class LoanViewModel
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string? MemberName { get; set; }
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool Status { get; set; }
    }
}
