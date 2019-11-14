using EmployeeProfilesLibrary;
using MediatR;
using PayrollLibrary;
using System.Threading;
using System.Threading.Tasks;
using WebBFF.Contract.Queries;

namespace WebBFF.ApplicationServices.Handlers
{
    public class GetEmployeeDetailsQueryHandler : IRequestHandler<GetEmployeeDetailsQuery, GetEmployeeDetailsQueryResult>
    {
        private readonly IEmployeeProfileProvider _employeeProfileProvider;
        private readonly IPayrollProvider _payrollProvider;

        public GetEmployeeDetailsQueryHandler(IEmployeeProfileProvider employeeProfileProvider, IPayrollProvider payrollProvider)
        {
            _employeeProfileProvider = employeeProfileProvider;
            _payrollProvider = payrollProvider;
        }

        public async Task<GetEmployeeDetailsQueryResult> Handle(GetEmployeeDetailsQuery request, CancellationToken cancellationToken)
        {
            var result = new GetEmployeeDetailsQueryResult
            {
                Result = new Contract.Queries.Model.EmployeeDetails()
                {
                    EmployeeId = request.EmployeeId
                },
                Status = GetEmployeeDetailsQueryStatus.Ok
            };

            await Task.WhenAll(_employeeProfileProvider.GetById(request.EmployeeId)
                .ContinueWith(t =>
                {
                    result.Result.FirstName = t.Result.FirstName;
                    result.Result.LastName = t.Result.LastName;
                }),
                _payrollProvider.GetById(request.EmployeeId)
                .ContinueWith(t =>
                {
                    result.Result.Salary = t.Result.Salary;
                }));

            return result;
        }
    }
}
