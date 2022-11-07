﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project4.Models;

namespace Project4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private EmployeeDataContext dbContext { get; set; }

        public HomeController(ILogger<HomeController> logger, EmployeeDataContext context)
        {
            _logger = logger;
            dbContext = context;
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
            dbContext.Add(employee);
            dbContext.SaveChanges();

            return View("Index");
        }

        [HttpGet]
        public IActionResult Employees(string searchString)
        {
            var employees = dbContext.employees.ToList();
            var searchEmp = from e in employees
                            select e;
            if (!String.IsNullOrEmpty(searchString))
            {
                searchEmp = searchEmp.Where(s => s.FirstName.Contains(searchString));
            }
            return View(searchEmp.ToList());
        }


        [HttpPost]
        public string Employees(string searchString, bool notUsed)
        {
            return "From [HttpPost]Employees: filter on " + searchString; 
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

