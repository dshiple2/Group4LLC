using System;
using System.Linq;

namespace Project4.Models
{
    public class EFEmpRepository : IEmpRepository
    {
        private EmployeeDataContext _context { get; set; }
        public EFEmpRepository(EmployeeDataContext temp)
        {
            _context = temp;
        }

        public IQueryable<Employee> employees => _context.employees;
    }
}
