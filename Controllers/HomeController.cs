using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace armstrongkarate_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My Armstrong Kyokushinkai about page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Guestbook()
        {
            ViewBag.Message = "ID will data on comment page.";

            return View();
        }

       

        public ActionResult Product()
        {
            ViewBag.Message = "Martial Of Arts are sale page.";

            return View();
        }

        public ActionResult Customer()
        {
            ViewBag.Message = "ID customer is automally page.";

            return View();
        }

    



    }
}