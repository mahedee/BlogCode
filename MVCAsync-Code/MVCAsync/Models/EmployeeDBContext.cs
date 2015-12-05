using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAsync.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}