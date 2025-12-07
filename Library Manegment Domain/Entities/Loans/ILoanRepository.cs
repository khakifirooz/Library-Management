using Library_Manegment_Domain.Common;

namespace Library_Manegment_Domain.Entities.Loans
{
    public interface ILoanRepository : IGenericRepository< int , Loan>
    {
        Task<Loan> GetLoanWithMemberAndBookAsync(int loanId);

    }
}
