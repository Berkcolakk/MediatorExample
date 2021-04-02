using System;
using System.Collections.Generic;
using System.Text;

namespace MediatR.BUS.Entities
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
