using EmployeePartial.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace EmployeePartial.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<EmployeeDetails> employees = new List<EmployeeDetails>()
            {
                new EmployeeDetails{Id=1,Name="John",Salary=10000,IsPermanent=true},
                new EmployeeDetails{Id=2,Name="Smith",Salary=5000,IsPermanent=false},
                new EmployeeDetails{Id=3,Name="Mark",Salary=5000,IsPermanent=false},
                new EmployeeDetails{Id=4,Name="Mary",Salary=5000,IsPermanent=false},
            };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View(employees);
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
            return View(employees);
        }
    }
}