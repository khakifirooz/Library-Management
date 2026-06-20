using FrameworkApplication;
using LibraryManagementContracts.Admin;
using LibraryManagementContracts.Loan;

namespace LibraryManagementContracts.Member
{
    public interface IMemberService
    {

       // Task<OperationResult> CheckAth(string name);
        Task<OperationResult> CreateAsync(MemberCreateModel command);
        Task<OperationResult> UpdateAsync(MemberUpdateModel command);
        Task<OperationResult> AddLoanAsync(LoanCreateModel command);
        Task<MemberViewModel> GetByIdAsync(int id);
        Task<List<MemberViewModel>> GetAllAsync();
        Task<List<MemberViewModel>> SearchAsync(int id, string? nationalCode);
        Task<MemberViewModel> GetMemberWithLoanByIdAsync(int id);
        Task<MemberViewModel> Login(string username, string password);

        // برای ادمین 
        Task<List<AdminViewModel>> GetAllAdminsAsync();

        Task<OperationResult> CreateAdminAsync(CreateAdminModel command);

        Task<OperationResult> UpdateAdminAsync(UpdateAdminModel command);

        Task<OperationResult> DisableAdminAsync(int id);

        Task<OperationResult> EnableAdminAsync(int id);


        //  Task<MemberViewModel?> LoginAsync(string nationalCode, string mobile);
    }
}
