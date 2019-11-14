using System;
using System.Threading.Tasks;

namespace EmployeeProfilesLibrary
{
    public interface IEmployeeProfileProvider
    {
        Task<EmployeeProfile> GetById(Guid employeeId);
    }
}
