using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Books;
using Library_Manegment_Domain.Entities.Members;

namespace Library_Manegment_Domain.Entities.Loans
{
    public class Loan : BaseEntity<int>
    {
        public int MemberId { get; private set; }
        public Member Member { get; private set; } = null!;

        public int BookId { get; private set; }
        public Book Book { get; private set; } = null!;

        public DateTime LoanDate { get; private set; }

        // موعد برگشت؛ همان ستون قبلی دیتابیس است.
        public DateTime ReturnDate { get; private set; }

        // تاریخ واقعی برگشت؛ تا قبل از برگشت خالی است.
        public DateTime? ReturnedAt { get; private set; }

        // false: در امانت
        // true: برگشت داده شده
        public bool Status { get; private set; }

        // برای بارگذاری رکوردهای موجود توسط EF Core
        private Loan()
        {
        }

        public Loan(
            int memberId,
            int bookId,
            DateTime loanDate,
            DateTime returnDate)
        {
            if (memberId <= 0 || bookId <= 0)
            {
                throw new ArgumentException(
                    "عضو و کتاب معتبر را انتخاب کنید.");
            }

            if (loanDate < new DateTime(622, 3, 22) ||
                returnDate < new DateTime(622, 3, 22))
            {
                throw new ArgumentException(
                    "تاریخ امانت و سررسید معتبر نیست.");
            }

            if (returnDate.Date < loanDate.Date)
            {
                throw new ArgumentException(
                    "سررسید نمی‌تواند قبل از تاریخ امانت باشد.");
            }

            MemberId = memberId;
            BookId = bookId;

            LoanDate = loanDate.Date;
            ReturnDate = returnDate.Date;

            Status = false;
        }

        public void Return(DateTime returnedAt)
        {
            if (Status)
            {
                throw new InvalidOperationException(
                    "این امانت قبلاً برگشت داده شده است.");
            }

            if (returnedAt < new DateTime(622, 3, 22) ||
                returnedAt.Date < LoanDate.Date)
            {
                throw new ArgumentException(
                    "تاریخ برگشت نمی‌تواند قبل از تاریخ امانت باشد.");
            }

            ReturnedAt = returnedAt.Date;
            Status = true;
        }

        public bool IsOverdue(DateTime today) =>
            !Status && today.Date > ReturnDate.Date;

        public int DaysOverdue(DateTime today) =>
            IsOverdue(today)
                ? (today.Date - ReturnDate.Date).Days
                : 0;
    }
}