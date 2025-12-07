using FrameworkApplication;
using LibraryManagementContracts.Loan;

namespace LibraryManagementContracts.Member
{
    public interface IMemberService
    {
        Task<OperationResult> CreateAsync(MemberCreateModel command);
        Task<OperationResult> UpdateAsync(MemberUpdateModel command);
        Task<OperationResult> AddLoanAsync(LoanCreateModel command);
   //     Task<OperationResult> LoanBackAsync(LoanBackModel command);
        Task<MemberViewModel> GetByIdAsync(int id);
        Task<List<MemberViewModel>> GetAllAsync();
        Task<List<MemberViewModel>> SearchAsync(int id, string? nationalCode);
        Task<MemberViewModel> GetMemberWithLoanByIdAsync(int id);
    }
}
