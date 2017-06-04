using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NETMVCExample1.Models;

namespace ASP.NETMVCExample1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeDetails()
        {
            Employee employee = new Employee()
            {
                ID = 1,
                NAME = "Chandni",
                CITY = "PLANO",
                STATE = "TEXAS"
            };

            return View(employee);
           
        }
    }
}