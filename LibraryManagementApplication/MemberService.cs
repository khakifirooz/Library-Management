using FrameworkApplication;
using Library_Manegment_Domain.Entities.Members;
using LibraryManagementContracts.Member;

namespace LibraryManagementApplication
{
    public class MemberService : IMemberService
    {
        public Task<OperationResult> CreateAsync(MemberCreateModel command)
        {
            throw new NotImplementedException();
        }

        public Task<List<MemberViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MemberViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<MemberViewModel>> SearchAsync(int id, string? nationalCode)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> UpdateAsync(MemberUpdateModel command)
        {
            throw new NotImplementedException();
        }
    }
}
