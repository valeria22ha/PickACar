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
    public class VehiculoController : Controller
    {
        IVehiculo vehi;//se usan los de DAL
        IModelo mode;

        public VehiculoController()
        {
            vehi = new MVehiculo();
            mode = new MModelo();
        }

        // GET: Vehiculo
        public ActionResult Index()
        {
            var listaVehiculos = vehi.ListarVehiculos();
            var vehiculosListaFinal = Mapper.Map<List<Proyecto.GUI.Models.Vehiculo>>(listaVehiculos);

            var listaModelos = mode.ListarModelo();
            var modelosListaFinal = Mapper.Map<List<Proyecto.GUI.Models.Modelo>>(listaModelos);

            ViewData["Vehiculos"] = vehiculosListaFinal;
            ViewData["Modelos"] = modelosListaFinal;

            return View();
        }
    }
}