using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ESTACIONAMIENTO.Models;

namespace ESTACIONAMIENTO.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Auto aut)
        {
           //creo el modelo de objetos
            Acceso auto = new Acceso(
                @"C:\Users\Gabriel Garcia\Documents\Visual Studio 2013\Projects\ESTACIONAMIENTO\ESTACIONAMIENTO\Models\carro.csv");

            //busco el auto dado su numero de tarjeton
            var lugar = auto.GetAutoByTarjeton(aut.Tarjeton);
            if (ModelState.IsValid)
            {
                return View("EstacionaView", lugar);
    }
            else
            {
                return View();
            }
        }
    }
}
