using Library_Manegment_Domain.Entities.Members;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Member>> SearchAsync(int id, string? nationalCode)
        {
            if (id == 0 && string.IsNullOrWhiteSpace(nationalCode))
            {
                return await _context.Members.ToListAsync();
            }
            return await _context.Members.Where(x => x.Id == id || x.NationalCode  == nationalCode).ToListAsync();
        }
    }
}
