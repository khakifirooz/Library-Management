namespace Contracts.Book
{
    public interface IBookService
    {
        Task CreateAsync(BookDTO command);
        Task UpdateAsync(BookDTO command);
        Task DeleteAsync(int id);
        Task<BookDTO> GetByIdAsync(int id);
        Task<List<BookDTO>> GetAllAsync();
    }
}
