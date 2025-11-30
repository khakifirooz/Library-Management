using Library_Manegment_Domain.Entities.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassLibraryInfrastructure.Mappings
{
    public class BookMapping : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(50).IsRequired(); 
            builder.Property(x => x.Author).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Language).HasMaxLength(50).IsRequired();
        }
    }
}
