using Microsoft.Extensions.DependencyInjection;

namespace MultiTenancy
{
    public static class MultiTenancyServiceCollectionExtensions
    {
        public static void AddMultiTenancy(this IServiceCollection services)
        {
            services.AddScoped<ITenantContext, TenantContext>();
        }
    }
}
