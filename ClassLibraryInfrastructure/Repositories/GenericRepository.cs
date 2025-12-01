using System.Linq.Expressions;
using Library_Manegment_Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryInfrastructure.Repositories
{
    public class GenericRepository<TKey, T> : IGenericRepository<TKey, T> where T : class
    {
        private readonly LibraryMangementDbContext _context;

        public GenericRepository(LibraryMangementDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task<bool> ExistAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).AnyAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(TKey id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task SavaChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
