using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Question1.Models;

namespace Question1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "This is my Index Page";

            List<Employee> emp = new List<Employee>()
            {
                new Employee{Id=1,Name="Swati",Designation="Manager",Contact=9988774455},
                   new Employee{Id=2,Name="Jaya",Designation="HR",Contact=9888774455},
                      new Employee{Id=3,Name="Ketan",Designation="Developer",Contact=9999774455},
                         new Employee{Id=4,Name="Megha",Designation="Team Lead",Contact=88988774455}
            };
            ViewData["EmpList"] = emp;
            return View();
        }
    }
}