using Library_Manegment_Domain.Entities.Loans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassLibraryInfrastructure.Mappings;

public class LoanMapping : IEntityTypeConfiguration<Loan>
{
    public void Configure(EntityTypeBuilder<Loan> builder)
    {
        builder.Property(x => x.LoanDate)
            .HasColumnType("datetime2");

        builder.Property(x => x.ReturnDate)
            .HasColumnType("datetime2");

        builder.Property(x => x.ReturnedAt)
            .HasColumnType("datetime2");

        builder.HasIndex(x => x.BookId);

        builder.HasIndex(x => x.BookId, "IX_Loans_BookId_Active")
            .IsUnique()
            .HasFilter("[Status] = 0");

        builder.HasOne(x => x.Member)
            .WithMany(x => x.Loans)
            .HasForeignKey(x => x.MemberId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Book)
            .WithMany(x => x.Loans)
            .HasForeignKey(x => x.BookId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}