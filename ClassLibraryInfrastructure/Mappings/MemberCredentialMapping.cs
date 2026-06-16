using Library_Manegment_Domain.Entities.Members;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassLibraryInfrastructure.Mappings
{
    public class MemberCredentialMapping : IEntityTypeConfiguration<MemberCredential>
    {
        public void Configure(EntityTypeBuilder<MemberCredential> builder)
        {
            builder.ToTable("MemberCredentials");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Password)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
