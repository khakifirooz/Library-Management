using Library_Manegment_Domain.Common;

namespace Library_Manegment_Domain.Entities.Members
{
    public interface IMemberCredentialRepository : IGenericRepository<int, MemberCredential>
    {
        Task<MemberCredential> GetByUserNameAsync(string username);
    }
}
