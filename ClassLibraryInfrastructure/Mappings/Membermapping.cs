using Library_Manegment_Domain.Entities.Members;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassLibraryInfrastructure.Mappings
{
    public class Membermapping : DbContext, IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Family).HasMaxLength(30).IsRequired();
            builder.Property(x => x.NationalCode).HasColumnName("char(10)").IsRequired();
            builder.Property(x => x.Mobile).HasColumnName("char(11)").IsRequired();

        }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .HasMany(m => m.Loans)
                .WithOne(l => l.Member)  // make sure this matches your Loan entity
                .HasForeignKey(l => l.MemberId) // if you have a MemberId FK in Loan
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
