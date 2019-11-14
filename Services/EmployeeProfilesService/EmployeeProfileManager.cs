using EmployeeProfilesLibrary.Infrastructure.ResourceTypes;
using MultiTenancy;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProfilesLibrary
{
    public class EmployeeProfileManager : IEmployeeProfileManager
    {
        public EmployeeProfileManager(IConnectionProvider<IDatabase> connectionProvider)
        {

        }

        public async Task UpdateProfile(EmployeeProfileUpdateDetails updateDetails)
        {
            await Task.Delay(100);
        }
    }
}
