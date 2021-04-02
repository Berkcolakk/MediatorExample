using MediatR.BUS.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.BUS.Services.Employee
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeQuery, MediatR.BUS.Entities.Employee>
    {
        private MediatRContext _db;
        public GetEmployeeHandler(MediatRContext db)
        {
            _db = db;
        }
        public Task<Entities.Employee> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            return _db.Employee.FirstOrDefaultAsync(x => x.ID == request.ID);
        }
    }
}
