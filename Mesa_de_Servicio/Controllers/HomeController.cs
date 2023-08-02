using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mesa_de_Servicio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //esto es una prueba
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Traducir a prueba3";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}