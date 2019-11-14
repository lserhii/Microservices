using Microsoft.AspNetCore.Builder;

namespace MultiTenancy
{
    public static class MultiTenancyApplicationBuilderExtensions
    {
        public static void UseMultiTenancy(this IApplicationBuilder appBuilder, MultiTenancyMiddlewareOptions options)
        {
            appBuilder.UseMiddleware<MultiTenancyMiddleware>(options);
        }
    }
}
