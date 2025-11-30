using Library_Manegment_Domain.Entities.Loans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassLibraryInfrastructure.Mappings
{
    public class LoanMapping : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.Property(x => x.LoanDate).HasMaxLength(10);
            builder.Property(x => x.ReturnDate).HasMaxLength(10);
        }
    }
}
