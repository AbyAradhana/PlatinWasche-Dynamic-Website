using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlatinWaschee.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult aboutus()
        {
            return View();
        }
        public ActionResult contactus()
        {
            return View();
        }
        public ActionResult gallery()
        {
            return View();
        }
        public ActionResult offers()
        {
            return View();
        }
        public ActionResult packages()
        {
            return View();

        }
        public ActionResult services()
        {
            return View();
        }
    }
}