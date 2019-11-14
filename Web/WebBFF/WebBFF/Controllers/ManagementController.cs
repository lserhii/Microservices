using MicroserviceFx;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBFF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManagementController : ControllerBase
    {
        [HttpPost("migrate")]
        public async Task<IActionResult> MigrateDatabases([FromServices]IEnumerable<IDatabaseManager> databaseManagers)
        {
            var tenants = new List<Guid>() { new Guid("{06C5FA0C-4DBE-4B3B-8F27-5C329C7F1472}"), new Guid("{95345DB0-070C-4859-9AF4-EE7D73857D5F}") };

            foreach (var tenantId in tenants)
            {
                await Task.WhenAll(databaseManagers.Select(m => m.Migrate(tenantId)));
            }

            return NoContent();
        }
    }
}
