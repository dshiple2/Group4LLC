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

        public void AddEmployee(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
        }

        public void EditEmployee(Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Remove(employee);
            _context.SaveChanges();
        }
    }
}
