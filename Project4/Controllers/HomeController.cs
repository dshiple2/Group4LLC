using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project4.Models;
using System.Data;
using System.Text;
using System.Configuration;
using Microsoft.AspNetCore.Http;
using Project4.Models.ViewModels;

namespace Project4.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        //private EmployeeDataContext dbContext { get; set; }

        //public HomeController(ILogger<HomeController> logger, EmployeeDataContext context)
        //{
        //    _logger = logger;
        //    dbContext = context;
        //}

        private IEmpRepository repo { get; set; }

        public HomeController(IEmpRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EmployeeForm()
        {

            return View();
        }

        [HttpPost]
        public IActionResult EmployeeForm(Employee employee)
        {
            repo.AddEmployee(employee);

            return View("Index");
        }

        [HttpGet]
        public IActionResult Edit(int employee)
        {
            var editEmployee = repo.employees.Single(x => x.EmployeeId == employee);

            return View("EmployeeForm", editEmployee);
        }

        [HttpPost]
        public IActionResult Edit(Employee editEmployee)
        {
            repo.EditEmployee(editEmployee);

            return View("Index");
        }

        [HttpGet]
        public IActionResult Delete(int employee)
        {
            var delEmployee = repo.employees.Single(x => x.EmployeeId == employee);

            return View(delEmployee);
        }

        [HttpPost]
        public IActionResult Delete(Employee deleteEmployee)
        {
            repo.DeleteEmployee(deleteEmployee);

            return View("Index");
        }

        //[HttpGet]
        //public IActionResult Employees()
        //{
        //    var employees = dbContext.employees.ToList();
        //    return View(employees);
        //}
        [HttpGet]
        public IActionResult Employees(string positiontype)
        {
            StringBuilder QParam = new StringBuilder();

            var x = new EmployeesViewModel
            {
                employees = repo.employees
                .Where(x => x.PositionType == positiontype || positiontype == null)
            };
            return View(x);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

