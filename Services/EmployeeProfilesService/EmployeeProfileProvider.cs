using EmployeeProfilesLibrary.Infrastructure.ResourceTypes;
using MultiTenancy;
using System;
using System.Threading.Tasks;

namespace EmployeeProfilesLibrary
{
    public class EmployeeProfileProvider : IEmployeeProfileProvider
    {
        public EmployeeProfileProvider(IConnectionProvider<IDatabase> connectionProvider)
        {

        }

        public async Task<EmployeeProfile> GetById(Guid employeeId)
        {
            await Task.Delay(100);

            return new EmployeeProfile() { EmployeeId = employeeId, FirstName = "John", LastName = "Smith" };
        }
    }
}
