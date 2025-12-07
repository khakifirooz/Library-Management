using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Loans;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryInfrastructure.Repositories
{
    public class LoanRepository : GenericRepository< int , Loan> , ILoanRepository
    {
        private readonly LibraryMangementDbContext _context;

        public LoanRepository(LibraryMangementDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Loan> GetLoanWithMemberAndBookAsync(int loanId)
        {
            return await _context.Loans
                .Include(l => l.Member)
                .ThenInclude(m => m.Loans)
                .Include(l => l.Book)
                .FirstOrDefaultAsync(l => l.Id == loanId);
        }
        //public async Task<Loan> GetReturnDate(DateTime date)
        //{

        //   // return await _context.Loans.Where(x => x.ReturnDate == date);
        //}
    }
}
