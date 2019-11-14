using Microsoft.Extensions.DependencyInjection;

namespace MicroserviceFx
{
    public interface ILibraryConfigurator
    {
        void ConfigureServices(IServiceCollection services);
    }
}
