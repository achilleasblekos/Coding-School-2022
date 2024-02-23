using App.EF.Repository;
using App.Models.Entities;
using Microsoft.Extensions.DependencyInjection;
using Session_11;

namespace Session_14
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static IServiceProvider ServiceProvider { get; private set; }
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddSingleton<IEntityRepo<Customer>, CustomerRepo>();
            services.AddSingleton<IEntityRepo<Car>, CarRepo>();
            services.AddSingleton<IEntityRepo<Manager>, ManagerRepo>();
            services.AddSingleton<IEntityRepo<Engineer>, EngineerRepo>();
            services.AddSingleton<IEntityRepo<ServiceTask>, ServiceTaskRepo>();
            services.AddSingleton<IEntityRepo<Transaction>, TransactionRepo>();
            services.AddSingleton<CarCenter>();

            ServiceProvider = services.BuildServiceProvider();
            var mainForm = ServiceProvider.GetRequiredService<CarCenter>();
            Application.Run(mainForm);
        }
    }
}