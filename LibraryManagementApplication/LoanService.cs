using FrameworkApplication;
using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Books;
using Library_Manegment_Domain.Entities.Loans;
using Library_Manegment_Domain.Entities.Members;
using LibraryManagementContracts.Loan;

namespace LibraryManagementApplication
{
    public class LoanService : ILoanService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoanRepository _loanRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IMemberRepository _memberRepository;

        public LoanService(IUnitOfWork unitOfWork, ILoanRepository loanRepository,
            IBookRepository bookRepository, IMemberRepository memberRepository)
        {
            _unitOfWork = unitOfWork;
            _loanRepository = loanRepository;
            _bookRepository = bookRepository;
            _memberRepository = memberRepository;
        }

        public async Task<OperationResult> ReturnLoanAsync(int loanId)
        {

            var result = new OperationResult();

            var loan = await _loanRepository.GetByIdAsync(loanId);
            if (loan == null)
                return result.Failed("امانت مورد نظر پیدا نشد");

            var member = await _memberRepository.GetByIdAsync(loan.MemberId);
            if (member == null)
                return result.Failed("عضو مربوط به این امانت پیدا نشد");

            var book = await _bookRepository.GetByIdAsync(loan.BookId);
            if (book == null)
                return result.Failed("کتاب پیدا نشد");

            try
            {
                member.RemoveLoan(loan);

                book.LoanedBack();

                _memberRepository.Update(member);
                _bookRepository.Update(book);

                await _unitOfWork.SaveChangesAsync();

                return result.Succeded("با موفقیت پس گرفته شد");
            }
            catch (Exception ex)
            {
                return result.Failed($"خطا در برگشت کتاب: {ex.Message}");
            }

            //var result = new OperationResult();

            //var loan = await _loanRepository.GetByIdAsync(loanId);
            //if (loan == null)
            //    return result.Failed("امانت مورد نظر پیدا نشد");

            //var book = await _bookRepository.GetByIdAsync(loan.BookId);
            //if (book == null)
            //    return result.Failed("کتاب پیدا نشد");

            //book.LoanedBack();

            // _bookRepository.Update(book);
            //await _unitOfWork.SaveChangesAsync();

            //return result.Succeded("با موفقیت پس گرفته شد");
        }
    }
}
