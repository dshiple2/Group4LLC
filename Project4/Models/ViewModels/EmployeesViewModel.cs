using System;
using System.Linq;

namespace Project4.Models.ViewModels
{
    public class EmployeesViewModel
    {
        public IQueryable<Employee> employees {get; set;}
    }
}
