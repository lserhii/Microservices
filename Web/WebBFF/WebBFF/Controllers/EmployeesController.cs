using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebBFF.Contract.Queries;

namespace WebBFF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{employeeId}")]
        public async Task<IActionResult> GetEmployeeDetails(Guid employeeId)
        {
            var result = await _mediator.Send(new GetEmployeeDetailsQuery() { EmployeeId = employeeId });

            return Ok(result);
        }
    }
}
