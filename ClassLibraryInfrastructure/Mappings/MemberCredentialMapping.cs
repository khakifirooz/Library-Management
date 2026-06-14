using Library_Manegment_Domain.Entities.Members;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassLibraryInfrastructure.Mappings
{
    public class MemberCredentialMapping : IEntityTypeConfiguration<MemberCredential>
    {
        public void Configure(EntityTypeBuilder<MemberCredential> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.Password)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasOne(x => x.Member)
                   .WithOne(x => x.Credential)
                   .HasForeignKey<MemberCredential>(x => x.MemberId);
        }
    }
}
