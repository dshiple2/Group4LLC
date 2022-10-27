using System;
using Microsoft.EntityFrameworkCore;

namespace Project4.Models
{
    public class EmployeeDataContext : DbContext
    {
        public EmployeeDataContext(DbContextOptions<EmployeeDataContext> options) : base (options)
        {

        }

        public DbSet<Employee> employees { get; set; }
    }
}

