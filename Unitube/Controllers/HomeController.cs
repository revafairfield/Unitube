using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Unitube.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This project is focused on connecting students from universities to communicate effectively on an intranet platform";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Our contact page";

            return View();
        }
    }
}