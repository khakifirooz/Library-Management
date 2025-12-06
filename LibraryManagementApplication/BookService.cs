using System.Runtime.InteropServices;
using Contracts.Book;
using FrameworkApplication;
using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Books;
using LibraryManagementContracts.Book;

namespace LibraryManagementApplication
{
    public class BookService : IBookService
    {

        // private readonly IBookRepository _bookRepository;

        private readonly IUnitOfWork _unitOfWork;
        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<OperationResult> CreateAsync(BookDTO command)
        {
            OperationResult result = new();
            try
            {
                if (await _unitOfWork.BookRepository.ExistAsync(x => x.Title == command.Title))
                    return result.Failed(ApplicationMessages.DublicateRecord);
                var book = new Book(command.Title, command.Author, command.Language, command.Image);
                await _unitOfWork.BookRepository.CreateAsync(book);
                await _unitOfWork.SaveChangesAsync();
                return result.Succeded();
            }
            catch (Exception e)
            {
               return result.Failed(e.Message);
            }
        }
        

        public async Task<OperationResult> DeleteAsync(int id)
        {
            OperationResult result = new();
            try
            {
                var book = await _unitOfWork.BookRepository.GetByIdAsync(id);
                if (book is null)
                    return result.Failed(ApplicationMessages.RecordNotFound);
                book.Delete();
                await _unitOfWork.SaveChangesAsync();
                return result.Succeded();
            }
            catch (Exception e)
            {
                return result.Failed(e.Message);
            }
        }

        public async Task<List<BookDTO>> GetAllAsync()
        {
            var book = await _unitOfWork.BookRepository.GetAllWithoutDeleted();
            return book.Select(x => new BookDTO
            {
                Id = x.Id,
                Title = x.Title,
                Author = x.Author,
                Language = x.Language,
                Image = x.Image
            }).ToList();

        }

        public async Task<BookDTO> GetByIdAsync(int id)
        {
            var book = await _unitOfWork.BookRepository.GetByIdAsync(id);
            if (book is not null)
            {
                var bookDTO = new BookDTO
                {
                    Title = book.Title,
                    Author = book.Author,
                    Language = book.Language,
                    Image = book.Image
                };
                return bookDTO;
            }
            else
            {
                return new BookDTO();
            }
        }

        public async Task<List<BookDTO>> GetByTitleAsync(string title)
        {
            var books = await _unitOfWork.BookRepository.GetByTitleAsync(title);
            return books.Select(x => new BookDTO
            {
                Id = x.Id,
                Title = x.Title,
                Author = x.Author,
                Language = x.Language,
                Image = x.Image
            }).ToList();
        }

        public async Task<List<BookForComboDTO>> GetExistForComboAsync()
        {
            var book = await _unitOfWork.BookRepository.GetExistForComboAsync();
            return book.Select(x => new BookForComboDTO()
            {
                Id = x.Id,
                Title = x.Title
            }).ToList();
        }

        public async Task<OperationResult> UpdateAsync(BookDTO command)
        {
            OperationResult result = new();
            try
            {
                var book = await _unitOfWork.BookRepository.GetByIdAsync(command.Id);
                if (book is null)
                    return result.Failed(ApplicationMessages.RecordNotFound);

                if (await _unitOfWork.BookRepository.ExistAsync(x => x.Title == command.Title && x.Id != command.Id))
                    result.Failed(ApplicationMessages.DublicateRecord);

                book.Update(command.Title, command.Author, command.Language, command.Image);
                _unitOfWork.BookRepository.Update(book);
                await _unitOfWork.SaveChangesAsync();
                return result.Succeded();
            }
            catch (Exception e)
            {

                return result.Failed(e.Message);
            }
        }
    }
}
