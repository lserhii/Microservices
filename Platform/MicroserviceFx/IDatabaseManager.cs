using System;
using System.Threading.Tasks;

namespace MicroserviceFx
{
    public interface IDatabaseManager
    {
        Task Migrate(Guid tenantId);
    }
}
