using Library_Manegment_Domain.Common;

namespace Library_Manegment_Domain.Entities.Books
{
    public interface IBookRepository : IGenericRepository<int, Book>
    {
        Task<List<Book>> GetByTitleAsync(string title);
        Task<List<Book>> GetAllWithoutDeleted();
        Task<List<Book>> GetExistForComboAsync();
    }
}
