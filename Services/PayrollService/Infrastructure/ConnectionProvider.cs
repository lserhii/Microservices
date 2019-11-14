using Microsoft.Extensions.Configuration;
using MultiTenancy;
using PayrollLibrary.Infrastructure.ResourceTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollLibrary.Infrastructure
{
    public class ConnectionProvider : IConnectionProvider<IDatabase>
    {
        public ConnectionProvider(IConfiguration configuration)
        {

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
