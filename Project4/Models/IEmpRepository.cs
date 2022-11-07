using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4.Models
{
    public interface IEmpRepository
    {
        IQueryable<Employee> employees { get; }

        void AddEmployee(Employee employee);

        void EditEmployee(Employee employee);

        void DeleteEmployee(Employee employee);
    }
}
