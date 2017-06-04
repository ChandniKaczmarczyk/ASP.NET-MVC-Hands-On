using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETMVCExample1.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public string Index(string id, string name, string gender)
        //{
        //    return "Id is " + id + " Name is " + name + " Gender is " + gender;

        //} 

        public ActionResult Index()
        {
            ViewData["Countries"] = new List<string>()
            {
                "India",
                "USA",
                "Canada",
                "China",
                "Australia"
            };

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}