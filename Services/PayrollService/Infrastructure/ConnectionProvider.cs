using Microsoft.Extensions.Configuration;
using MultiTenancy;
using PayrollLibrary.Infrastructure.ResourceTypes;
using System;

namespace PayrollLibrary.Infrastructure
{
    public class ConnectionProvider : IConnectionProvider<IDatabase>
    {
        public ConnectionProvider(IConfiguration configuration)
        {
            var db = configuration.GetConnectionString("Payroll:Database");
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
