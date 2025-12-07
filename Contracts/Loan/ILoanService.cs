using FrameworkApplication;

namespace LibraryManagementContracts.Loan
{
    public interface ILoanService
    {
        Task<OperationResult> ReturnLoanAsync(int loanId);

    }
}
