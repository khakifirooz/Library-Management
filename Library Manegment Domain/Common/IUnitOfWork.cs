using Library_Manegment_Domain.Entities.Books;
using Library_Manegment_Domain.Entities.Loans;
using Library_Manegment_Domain.Entities.Members;

namespace Library_Manegment_Domain.Common
{
    public interface IUnitOfWork
    {
        IMemberRepository MemberRepository { get; }
        IBookRepository BookRepository { get; }
        ILoanRepository LoanRepository { get; }
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollBackTrasactionAsync();
        Task SaveChangesAsync();
    }
}
