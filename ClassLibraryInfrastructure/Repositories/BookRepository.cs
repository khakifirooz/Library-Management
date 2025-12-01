using Library_Manegment_Domain.Entities.Books;

namespace ClassLibraryInfrastructure.Repositories
{
    public class BookRepository : GenericRepository<int,Book>,IBookRepository
    {
        private readonly LibraryMangementDbContext _context;

        public BookRepository(LibraryMangementDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
