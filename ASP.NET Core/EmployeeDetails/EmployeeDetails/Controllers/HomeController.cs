using EmployeeDetails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EmployeeDetails.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetEmployeeList()
        {
            List<Models.Employee> employees = new List<Models.Employee>()
            {
                new Models.Employee{ Id=1, Name="John", Salary=10000, IsPermanent=true},
                new Models.Employee{ Id=2, Name="Smith", Salary=5000, IsPermanent=false},
                new Models.Employee{ Id=3, Name="Mark", Salary=5000, IsPermanent=false},
                new Models.Employee{ Id=4, Name="Mary", Salary=5000, IsPermanent=true},
            };
            return View(employees);
        }
    }
}
