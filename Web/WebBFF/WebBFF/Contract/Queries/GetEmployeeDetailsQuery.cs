using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBFF.Contract.Queries.Model;

namespace WebBFF.Contract.Queries
{
    public class GetEmployeeDetailsQuery : IRequest<GetEmployeeDetailsQueryResult>
    {
        public Guid EmployeeId { get; set; }
    }

    public class GetEmployeeDetailsQueryResult
    {
        public GetEmployeeDetailsQueryStatus Status { get; set; }
        public EmployeeDetails Result { get; set; }
    }

    public enum GetEmployeeDetailsQueryStatus
    {
        Ok,
        NotFound
    }
}
