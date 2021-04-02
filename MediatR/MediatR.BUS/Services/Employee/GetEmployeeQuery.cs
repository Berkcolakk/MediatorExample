using System;
using System.Collections.Generic;
using System.Text;

namespace MediatR.BUS.Services.Employee
{
    public class GetEmployeeQuery : IRequest<MediatR.BUS.Entities.Employee>
    {
        public int ID { get; set; }
    }
}
