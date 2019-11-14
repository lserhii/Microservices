using MicroserviceFx;
using Microsoft.Extensions.DependencyInjection;
using MultiTenancy;
using PayrollLibrary.Infrastructure;
using PayrollLibrary.Infrastructure.ResourceTypes;
using System.Collections.Generic;
using System.Text;

namespace PayrollLibrary
{
    public class LibraryConfigurator : ILibraryConfigurator
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IPayrollProvider, PayrollProvider>();
            services.AddScoped<IDatabaseManager, DatabaseManager>();
            services.AddScoped<IConnectionProvider<IDatabase>, ConnectionProvider>();
        }
    }
}
