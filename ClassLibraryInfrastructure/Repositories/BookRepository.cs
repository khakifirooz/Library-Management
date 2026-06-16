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

        public async Task<List<Book>> GetAllWithoutDeleted()
        {
            return await _context.Books.Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<List<Book>> GetByTitleAsync(string title)
        {

            title = title?.Trim();

            if (string.IsNullOrWhiteSpace(title))
                return new List<Book>();

            return await _context.Books
                .Where(x => !x.IsDeleted)
                .Where(x => x.Title != null && EF.Functions.Like(x.Title, $"%{title}%"))
                .ToListAsync();

            //if (!string.IsNullOrEmpty(title))
            //    return await _context.Books
            //        .Where(x => x.Title.Contains(title) && x.IsDeleted == false).ToListAsync();
            //else
            //    return null;
        }

        public Task<List<Book>> GetExistForComboAsync()
        {
            return _context.Books.Where(x => x.IsLoaned == false && x.IsDeleted == false).ToListAsync();
        }
    }
}
