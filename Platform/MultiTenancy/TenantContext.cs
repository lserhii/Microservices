using System;

namespace MultiTenancy
{
    public class TenantContext : ITenantContext
    {
        public Guid TenantId { get; set; }
    }
}
