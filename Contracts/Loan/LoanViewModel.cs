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
        public DateTime? ReturnedAt { get; set; }

        public string? LoanDatePersian { get; set; }
        public string? ReturnDatePersian { get; set; }
        public string? ReturnedAtPersian { get; set; }

        public bool Status { get; set; }

        public bool IsOverdue { get; set; }
        public int DaysOverdue { get; set; }

        public string StatusText { get; set; } = "";
    }
}