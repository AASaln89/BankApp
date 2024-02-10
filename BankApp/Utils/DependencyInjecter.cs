using BankApp.Repository.Interfaces;
using BankApp.Repository.PostgreSQL;
using BankApp.Services.Interfaces;
using BankApp.Services.ServiceImplementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;

namespace BankApp.Utils
{
    public static class DependencyInjecter
    {
        private static readonly ServiceProvider _serviceProvider;

        static DependencyInjecter()
        {
            ServiceCollection services = new ServiceCollection();

            string fileConfig = File.ReadAllText("config.json");

            JObject jObject = JObject.Parse(fileConfig);

            string connectionString = jObject["ConnectionStrings"]["PostgreSQL"].Value<string>();

            //Добить сервисы, добавить сюда все сервисы и репозитории
            services.AddSingleton<IBankRepository, BankRepository>();
            services.AddSingleton<IClientRepository, ClientRepository>();
            services.AddSingleton<IDepositRepository, DepositRepository>();
            services.AddSingleton<ILoanRepository, LoanRepository>();

            services.AddDbContext<BankAppContext>(options => options.UseNpgsql(connectionString));

            services.AddSingleton<IBankService, BankService>();
            services.AddSingleton<IClientService, ClientServices>();
            services.AddSingleton<IDepositService, DepositService>();
            services.AddSingleton<ILoanService, LoanService>();

            _serviceProvider = services.BuildServiceProvider();
        }

        public static T GetService<T>()
        {
            return _serviceProvider.GetRequiredService<T>();
        }
    }
}
