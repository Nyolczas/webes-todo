using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Todo2.Controllers
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

        public ActionResult TodoList()
        {
            // bevásárló lista
            var lista = new List<string>();

            lista.Add("Banán");
            lista.Add("Citrom");
            lista.Add("Kenyér");
            lista.Add("Fogkrém");
            lista.Add("Paradicsom");
            lista.Add("Folpack");
            lista.Add("Felvágott");
            lista.Add("Sajt");
            lista.Add("Vaj");

            // a ViewBag-be tett adatokat a nézeten ki tudjuk olvasni
            ViewBag.Lista = lista;

            return View();
        }
    }
}