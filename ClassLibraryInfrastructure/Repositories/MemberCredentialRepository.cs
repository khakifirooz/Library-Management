using Library_Manegment_Domain.Entities.Members;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryInfrastructure.Repositories
{
    public class MemberCredentialRepository
        : GenericRepository<int, MemberCredential>, IMemberCredentialRepository
    {
        private readonly LibraryMangementDbContext _context;

        public MemberCredentialRepository(LibraryMangementDbContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<MemberCredential?> GetByUserNameAsync(string username)
        {
            return await _context.MemberCredentials
                .FirstOrDefaultAsync(x => x.UserName == username);
        }
    }
}
