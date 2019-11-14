using System;

namespace MultiTenancy
{
    public interface ITenantContext
    {
        Guid TenantId { get; set; }
    }
}
