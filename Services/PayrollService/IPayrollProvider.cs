using System;
using System.Threading.Tasks;

namespace PayrollLibrary
{
    public interface IPayrollProvider
    {
        Task<PayrollData> GetById(Guid employeeId);
    }
}
