using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBFF.Contract.Queries.Model
{
    public class EmployeeDetails
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Salary { get; set; }
    }
}
