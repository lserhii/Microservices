using EmployeeProfilesLibrary.Infrastructure;
using EmployeeProfilesLibrary.Infrastructure.ResourceTypes;
using MicroserviceFx;
using Microsoft.Extensions.DependencyInjection;
using MultiTenancy;
using System.Collections.Generic;
using System.Text;

namespace EmployeeProfilesLibrary
{
    public class LibraryConfigurator : ILibraryConfigurator
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IEmployeeProfileManager, EmployeeProfileManager>();
            services.AddScoped<IEmployeeProfileProvider, EmployeeProfileProvider>();
            services.AddScoped<IDatabaseManager, DatabaseManager>();
            services.AddScoped<IConnectionProvider<IDatabase>, ConnectionProvider>();
        }
    }
}
