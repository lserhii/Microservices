using MultiTenancy;
using PayrollLibrary.Infrastructure.ResourceTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary
{
    public class PayrollProvider : IPayrollProvider
    {
        public PayrollProvider(IConnectionProvider<IDatabase> connectionProvider)
        {

        }
        public async Task<PayrollData> GetById(Guid employeeId)
        {
            await Task.Delay(100);

            return new PayrollData() { EmployeeId = employeeId, Salary = 45000 };
        }
    }
}
