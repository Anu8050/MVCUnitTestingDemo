using MVCUnitTestingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;


namespace MVCUnitTestingDemo.Controllers
{
    public class EmployeeController : Controller
    {
        [NonAction]
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public List<Employee> GetEmployeesList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "anusha",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 23
                },
                new Employee
                {
                    Id = 2,
                    Name = "anu",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 23
                }
            };
        }

        public ActionResult Employees()
        {
            var employees = from e in GetEmployeesList()
                            orderby e.Id
                            select e;
            return View(employees);
        }

        
    }
}