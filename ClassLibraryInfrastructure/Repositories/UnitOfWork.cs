using System.Data;
using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Books;
using Library_Manegment_Domain.Entities.Loans;
using Library_Manegment_Domain.Entities.Members;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace ClassLibraryInfrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly LibraryMangementDbContext _context;
        private IDbContextTransaction? _transaction;

        public IMemberRepository MemberRepository { get; }
        public IBookRepository BookRepository { get; }
        public ILoanRepository LoanRepository { get; }

        public IMemberCredentialRepository MemberCredentialRepository
        {
            get;
        }

        public UnitOfWork(LibraryMangementDbContext context)
        {
            _context = context;

            MemberRepository = new MemberRepository(context);
            BookRepository = new BookRepository(context);
            LoanRepository = new LoanRepository(context);

            MemberCredentialRepository =
                new MemberCredentialRepository(context);
        }

        public async Task BeginTransactionAsync()
        {
            if (_transaction is not null)
            {
                throw new InvalidOperationException(
                    "تراکنش قبلی هنوز باز است.");
            }

            _transaction =
                await _context.Database.BeginTransactionAsync(
                    IsolationLevel.Serializable);
        }

        public async Task CommitTransactionAsync()
        {
            if (_transaction is null)
            {
                throw new InvalidOperationException(
                    "تراکنش باز وجود ندارد.");
            }

            await _transaction.CommitAsync();
            await _transaction.DisposeAsync();

            _transaction = null;
        }

        public async Task RollBackTrasactionAsync()
        {
            if (_transaction is null)
            {
                return;
            }

            try
            {
                await _transaction.RollbackAsync();
            }
            catch (InvalidOperationException)
                when (_transaction.GetDbTransaction().Connection is null)
            {
                // ممکن است SQL Server تراکنش را به علت
                // Deadlock از قبل لغو کرده باشد.
            }
            finally
            {
                await _transaction.DisposeAsync();

                _transaction = null;
                _context.ChangeTracker.Clear();
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void ResetTracking()
        {
            _context.ChangeTracker.Clear();
        }

        public void Dispose()
        {
            // طول عمر DbContext توسط DI مدیریت می‌شود.
            _transaction?.Dispose();
            _transaction = null;
        }
    }
}