using Library_Manegment_Domain.Common;

namespace Library_Manegment_Domain.Entities.Members
{
    public interface IMemberRepository:IGenericRepository<int,Member>
    {
        Task<List<Member>> SearchAsync(int id, string? nationalCode);
        Task<Member?> GetMemberWithLoanByIdAsync(int id);
    }
}
