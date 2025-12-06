using FrameworkApplication;
using LibraryManagementContracts.Book;

namespace Contracts.Book
{
    public interface IBookService
    {
        Task<OperationResult> CreateAsync(BookDTO command);
        Task<OperationResult> UpdateAsync(BookDTO command);
        Task<OperationResult> DeleteAsync(int id);
        Task<BookDTO> GetByIdAsync(int id);
        Task<List<BookDTO>> GetAllAsync();
        Task<List<BookDTO>> GetByTitleAsync(string title);
        Task<List<BookForComboDTO>> GetExistForComboAsync();
    }
}
