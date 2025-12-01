using Library_Manegment_Domain.Entities.Members;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ClassLibraryInfrastructure.Repositories
{
    public class MemberRepository : GenericRepository< int , Member>, IMemberRepository
    {
        private readonly LibraryMangementDbContext _context;

        public MemberRepository(LibraryMangementDbContext context) : base(context) 
        {
            _context = context;
        }
    }
}
