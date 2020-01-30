using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace transactionservice.Models
{
    public partial class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext()
        {
        }

        public EmployeesDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Employee> Employees { get; set; }
        
    }
}
