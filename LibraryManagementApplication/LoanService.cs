using FrameworkApplication;
using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Books;
using Library_Manegment_Domain.Entities.Loans;
using Library_Manegment_Domain.Entities.Members;
using LibraryManagementContracts.Book;
using LibraryManagementContracts.Loan;

namespace LibraryManagementApplication
{
    public class LoanService : ILoanService
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoanRepository _loanRepository;
        private readonly IBookRepository _bookRepository;

        public LoanService(IMemberRepository memberRepository,
                           IUnitOfWork unitOfWork,
                           ILoanRepository loanRepository, IBookRepository bookRepository)
        {
            _memberRepository = memberRepository;
            _unitOfWork = unitOfWork;
            _loanRepository = loanRepository;
            _bookRepository = bookRepository;
        }

        public async Task<OperationResult> ReturnLoanAsync(int loanId)
        {
            var result = new OperationResult();
            var loan = await _loanRepository.GetByIdAsync(loanId);
            if (loan == null)
                return result.Failed("Loan not found");

            var book = await _bookRepository.GetByIdAsync(loan.BookId);
            if (book == null)
                return result.Failed("Book not found");

            // آزاد شدن کتاب
            book.LoanedBack();

            // تاریخ بازگشت Loan (اختیاری)
            //  loan.ReturnDate = DateTime.Now;

            // Save در DB
            //   await _loanRepository.UpdateAsync(loan);
             _bookRepository.Update(book);
            await _unitOfWork.SaveChangesAsync();

            return result.Succeded("Book returned successfully");
        }

        //public async Task<OperationResult> ReturnLoanAsync(int loanId)
        //{
        //    //var result = new OperationResult();

        //    //var loan = await _loanRepository.GetLoanWithMemberAndBookAsync(loanId);

        //    //if (loan == null)
        //    //    return result.Failed("Loan not found");

        //    //// حذف از لیست عضو
        //    //loan.Member.RemoveLoan(loan);

        //    //// آزاد کردن کتاب
        //    //loan.Book.SetIsLoaned(false);

        //    //// حذف loan
        //    //_loanRepository.Remove(loan);

        //    //await _unitOfWork.CommitAsync();

        //    //return result.Succeeded("Book returned successfully");
        //}
    }
}
