using System.Data;
using Library_Manegment_Domain.Entities.Books;
using Library_Manegment_Domain.Entities.Loans;
using Library_Manegment_Domain.Entities.Members;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryInfrastructure
{
    public class LibraryMangementDbContext : DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Loan> Loans { get; set; }

        public LibraryMangementDbContext(DbContextOptions<LibraryMangementDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LibraryMangementDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
