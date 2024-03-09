using ProjectDemo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Users users = new Users();
            
            return View(users);
        }
        public ActionResult About()
        {
            ViewBag.Message = "My Appliction Name Is Project Demo.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Darshan Patanvadiya";

            return View();
        }
        [HttpPost]
        public ActionResult Savedata(Users request)
        {
            return Json("Hello");
        }
    }
}