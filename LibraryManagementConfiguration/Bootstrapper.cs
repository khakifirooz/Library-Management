using System.Runtime.CompilerServices;
using ClassLibraryInfrastructure;
using ClassLibraryInfrastructure.Repositories;
using Contracts.Book;
using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Books;
using Library_Manegment_Domain.Entities.Loans;
using Library_Manegment_Domain.Entities.Members;
using LibraryManagementApplication;
using LibraryManagementContracts.Loan;
using LibraryManagementContracts.Member;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementConfiguration
{
    public static class Bootstrapper
    {
        public static IServiceCollection WireUp(this IServiceCollection services)
        {
            // هرکسی که یک پیاده سازی از این خواست یک اینستنس از جنریک ریپازیتوری بهش بده
            services.AddScoped(typeof (IGenericRepository<,>), typeof(GenericRepository<,>));
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IMemberService, MemberService>();
            //   services.AddScoped<ILoanRepository, LoanRepository>();
            services.AddScoped<ILoanService, LoanService>();
            services.AddScoped<ILoanRepository, LoanRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>(); // unit of work


            services.AddDbContext<LibraryMangementDbContext>(x =>
            x.UseSqlServer("Data Source=.; Initial Catalog = LibraryManagementDB; Integrated Security = True; encrypt = True; TrustServerCertificate = True;"));
            return services;
        }
    }
}
