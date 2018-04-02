using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.GUI.Controllers
{
    public class RentaController : Controller
    {
        // GET: Renta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistrarRenta(string idVehiculo, string idCliente, string fechaEntr, string fechaDev)
        {
            return View();
        }
    }
}