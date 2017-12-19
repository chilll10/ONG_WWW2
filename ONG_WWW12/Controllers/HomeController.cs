using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONG_WWW12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "ONG PAGINA WEB ACERCA DE:";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "ONG PAGINA WEB CONTACTO:";

            return View();
        }
    }
}