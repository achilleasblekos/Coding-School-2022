using FuelStation.EF.MockRepositories;
using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace FuelStation.Win
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddScoped<IEntityRepo<Customer>, MockCustomerRepo>();
            services.AddScoped<IEntityRepo<Item>, MockItemRepo>();
            services.AddScoped<IEntityRepo<Transaction>, MockTransactionRepo>();
            services.AddScoped<IEntityRepo<TransactionLine>, MockTransactionLineRepo>();
            services.AddScoped<CustomersForm>();
            services.AddScoped<ItemsForm>();
            services.AddScoped<TransactionsForm>();
            services.AddScoped<TransactionLinesForm>();
            services.AddScoped<FuelStationForm>();

            ServiceProvider = services.BuildServiceProvider();
            var fuelStationForm = ServiceProvider.GetRequiredService<FuelStationForm>();

            Application.Run(fuelStationForm);
        }
    }
}