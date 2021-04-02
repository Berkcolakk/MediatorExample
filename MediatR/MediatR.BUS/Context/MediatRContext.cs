using MediatR.BUS.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatR.BUS.Context
{
    public class MediatRContext : DbContext
    {
        public MediatRContext(DbContextOptions<MediatRContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee() { ID = 1, Name = "Ahmet",Surname = "Kır"}, new Employee() { ID = 2, Name = "Mehmet", Surname = "Can" }, new Employee() { ID = 1, Name = "Hüseyin", Surname = "Dal" });
            base.OnModelCreating(modelBuilder);
        } 
    }
}
