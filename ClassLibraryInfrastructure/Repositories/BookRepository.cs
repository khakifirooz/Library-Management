using Library_Manegment_Domain.Entities.Books;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryInfrastructure.Repositories
{
    public class BookRepository : GenericRepository<int, Book>, IBookRepository
    {
        private readonly LibraryMangementDbContext _context;

        public BookRepository(LibraryMangementDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetByTitleAsync(string title)
        {
            return await _context.Books.Where(x => x.Title.Contains(title)).ToListAsync();
        }
    }
}
