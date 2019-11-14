using System.Threading.Tasks;

namespace EmployeeProfilesLibrary
{
    public interface IEmployeeProfileManager
    {
        Task UpdateProfile(EmployeeProfileUpdateDetails updateDetails);
    }
}
