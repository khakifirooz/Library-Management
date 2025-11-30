using Library_Manegment_Domain.Entities.Members;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassLibraryInfrastructure.Mappings
{
    public class Membermapping : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Family).HasMaxLength(30).IsRequired();
            builder.Property(x => x.NationalCode).HasColumnName("char(10)").IsRequired();
            builder.Property(x => x.Mobile).HasColumnName("char(11)").IsRequired();

        }
    }
}
