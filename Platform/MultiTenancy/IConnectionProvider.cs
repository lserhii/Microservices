using System;

namespace MultiTenancy
{
    public interface IConnectionProvider<TResource>
    {
        string GetConnectionStringForCurrentTenant();
        string GetConnectionStringForTenant(Guid tenantId);
    }
}
