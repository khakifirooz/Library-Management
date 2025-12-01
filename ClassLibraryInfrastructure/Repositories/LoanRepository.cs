using Library_Manegment_Domain.Entities.Loans;

namespace ClassLibraryInfrastructure.Repositories
{
    public class LoanRepository : GenericRepository< int , Loan> , ILoanRepository
    {
        private readonly LibraryMangementDbContext _context;

        public LoanRepository(LibraryMangementDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
