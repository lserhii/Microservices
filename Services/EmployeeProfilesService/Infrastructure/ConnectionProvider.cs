using EmployeeProfilesLibrary.Infrastructure.ResourceTypes;
using Microsoft.Extensions.Configuration;
using MultiTenancy;
using System;

namespace EmployeeProfilesLibrary.Infrastructure
{
    public class ConnectionProvider : IConnectionProvider<IDatabase>
    {
        public ConnectionProvider(IConfiguration configuration)
        {
            var db = configuration.GetConnectionString("EmployeeProfiles:Database");   
        }

        public string GetConnectionStringForCurrentTenant()
        {
            return "";
        }

        public string GetConnectionStringForTenant(Guid tenantId)
        {
            return "";
        }
    }
}
