using LibraryManagementConfiguration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LibraryManagementWindowsForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<FrmMain>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices(services =>
            {
                services.WireUp();
                services.AddTransient<FrmMain>();
                services.AddTransient<FrmBook>();
                services.AddTransient<FrmManageMembers>();
                services.AddTransient<FrmRegisterMember>();
                services.AddTransient<FrmUpdateMember>();
                services.AddTransient<FrmLoan>();
                // ....
            });
        }
    }
}