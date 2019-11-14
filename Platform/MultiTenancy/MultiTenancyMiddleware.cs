using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenancy
{
    public class MultiTenancyMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly MultiTenancyMiddlewareOptions _options;

        public MultiTenancyMiddleware(RequestDelegate next, MultiTenancyMiddlewareOptions options)
        {
            _next = next;
            _options = options;
        }

        public async Task Invoke(HttpContext context, ITenantContext tenantContext)
        {
            var tenantHeaderValue = context.Request.Headers[_options.TenantHeaderName].FirstOrDefault();

            if (Guid.TryParse(tenantHeaderValue, out var tenantId))
            {
                tenantContext.TenantId = tenantId;
            }

            await _next(context);
        }
    }
}
