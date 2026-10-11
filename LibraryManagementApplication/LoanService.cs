using FrameworkApplication;
using Library_Manegment_Domain.Common;
using LibraryManagementContracts.Loan;

namespace LibraryManagementApplication;

public class LoanService(
    IUnitOfWork unitOfWork,
    TimeProvider clock) : ILoanService
{
    public async Task<OperationResult> ReturnLoanAsync(
        int loanId,
        DateTime? returnedAt = null)
    {
        try
        {
            unitOfWork.ResetTracking();

            var date = (returnedAt ?? clock.GetLocalNow().Date).Date;

            if (date > clock.GetLocalNow().Date)
            {
                return new OperationResult().Failed(
                    "تاریخ برگشت نمی‌تواند در آینده باشد.");
            }

            await unitOfWork.BeginTransactionAsync();

            var loan =
                await unitOfWork.LoanRepository.GetByIdAsync(loanId);

            if (loan is null)
            {
                return new OperationResult().Failed(
                    "امانت پیدا نشد.");
            }

            if (loan.Status)
            {
                return new OperationResult().Failed(
                    "این امانت قبلاً برگشت داده شده است.");
            }

            var book =
                await unitOfWork.BookRepository.GetByIdAsync(loan.BookId);

            if (book is null)
            {
                return new OperationResult().Failed(
                    "کتاب پیدا نشد.");
            }

            loan.Return(date);
            book.LoanedBack();

            await unitOfWork.SaveChangesAsync();
            await unitOfWork.CommitTransactionAsync();

            return new OperationResult().Succeded(
                "برگشت کتاب ثبت شد؛ سابقه امانت حفظ شد.");
        }
        catch (Exception error)
        {
            return ServiceSupport.Failure(unitOfWork, error);
        }
        finally
        {
            await unitOfWork.RollBackTrasactionAsync();
        }
    }
}