using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Books;
using Library_Manegment_Domain.Entities.Loans;
using Library_Manegment_Domain.Entities.Members;
using Microsoft.EntityFrameworkCore.Storage;

namespace ClassLibraryInfrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly LibraryMangementDbContext _context;
        private IDbContextTransaction _transaction;
        private readonly IMemberCredentialRepository _memberCredentialRepository;
        public IMemberCredentialRepository MemberCredentialRepository => _memberCredentialRepository;


        //  public IMemberCredentialRepository MemberCredentialRepository { get; }

        public UnitOfWork(LibraryMangementDbContext context)
        {
            _context = context;
            MemberRepository = new MemberRepository(context);
            BookRepository = new BookRepository(context);
            LoanRepository = new LoanRepository(context);
            _memberCredentialRepository = new MemberCredentialRepository(context);

            //  MemberCredentialRepository = new MemberCredentialRepository(_context);

        }
        public IMemberRepository MemberRepository { get; }

        public IBookRepository BookRepository { get; }

        public ILoanRepository LoanRepository { get; }

     //   public IUserRepository UserRepository { get; }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
           await _transaction.CommitAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task RollBackTrasactionAsync()
        {
            await _transaction.RollbackAsync();
            await _transaction.DisposeAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
