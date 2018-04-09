using AutoMapper;
using Proyecto.DAL.Interfaces;
using Proyecto.DAL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.GUI.Controllers
{
    public class RentaController : Controller
    {

        IVehiculo vehi;//se usan los de DAL
        IModelo mode;

        public RentaController()
        {
            vehi = new MVehiculo();
            mode = new MModelo();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistrarRenta(int idModelo, string idCliente, string fechaEntr, string fechaDev)
        {
            var modeloEnv = mode.BuscarModelo(idModelo);
            ViewData["modelo"] = Mapper.Map<Proyecto.GUI.Models.Modelo>(modeloEnv);
            return View();
        }
    }
}