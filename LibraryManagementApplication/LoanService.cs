using FrameworkApplication;
using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Books;
using Library_Manegment_Domain.Entities.Loans;
using LibraryManagementContracts.Loan;

namespace LibraryManagementApplication
{
    public class LoanService : ILoanService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoanRepository _loanRepository;
        private readonly IBookRepository _bookRepository;

        public LoanService(IUnitOfWork unitOfWork, ILoanRepository loanRepository, IBookRepository bookRepository)
        {
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

            book.LoanedBack();

             _bookRepository.Update(book);
            await _unitOfWork.SaveChangesAsync();

            return result.Succeded("Book returned successfully");
        }
    }
}
