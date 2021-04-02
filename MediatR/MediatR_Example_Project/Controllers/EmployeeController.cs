using MediatR;
using MediatR.BUS.Services.Employee;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR_Example_Project.Controllers
{
    public class EmployeeController : Controller
    {
        private IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> GetEmployeeById([FromRoute] GetEmployeeQuery req)
        {
            return Ok(await _mediator.Send(req));
        }
    }
}
