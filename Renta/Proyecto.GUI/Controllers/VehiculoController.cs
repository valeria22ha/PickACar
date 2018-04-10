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
        IMarca marc;
        IRenta rent;

        public VehiculoController()
        {
            vehi = new MVehiculo();
            mode = new MModelo();
            marc = new MMarca();
            rent = new MRenta();
        }

        // GET: Vehiculo
        public ActionResult Index()
        {
            var listaVehiculos = vehi.ListarVehiculos();
            var vehiculosListaFinal = Mapper.Map<List<Models.Vehiculo>>(listaVehiculos);

            var listaModelos = mode.ListarModelo();
            var modelosListaFinal = Mapper.Map<List<Proyecto.GUI.Models.Modelo>>(listaModelos);

            ViewData["Vehiculos"] = vehiculosListaFinal;
            ViewData["Modelos"] = modelosListaFinal;

            return View();
        }

        public ActionResult VerDisponibles(string fechaEntr, string fechaDev)
        {
            try
            {
                DateTime fechaE = Convert.ToDateTime(fechaEntr);
                DateTime fechaD = Convert.ToDateTime(fechaDev);
                if (fechaE.CompareTo(DateTime.Now) > 0)
                {
                    if (fechaE.CompareTo(fechaD) <= 0)
                    {
                        //hacer validacion de disponibles
                        var listaVehiculos = vehi.ListarVehiculos();
                        var vehiculosListaFinal = Mapper.Map<List<Models.Vehiculo>>(listaVehiculos);

                        var listaModelos = mode.ListarModelo();
                        var modelosListaFinal = Mapper.Map<List<Proyecto.GUI.Models.Modelo>>(listaModelos);

                        var listaMarcas = marc.ListarMarcas();
                        var marcasListaFinal = Mapper.Map<List<Models.Marca>>(listaMarcas);

                        var listaRentas = rent.ListarRentas();
                        var rentasListaFinal = Mapper.Map<List<Models.Renta>>(listaRentas);

                        List<string> listaFechas = new List<string>();
                        listaFechas.Add(fechaEntr);
                        listaFechas.Add(fechaDev);

                        ViewData["Vehiculos"] = vehiculosListaFinal;
                        ViewData["Modelos"] = modelosListaFinal;
                        ViewData["Marca"] = marcasListaFinal;
                        ViewData["Rentas"] = rentasListaFinal;
                        ViewData["Fechas"] = listaFechas;

                        return View();
                    }
                    else
                    {
                        return RedirectToAction("IndexError", "Home");
                    }
                }
                else
                {
                    return RedirectToAction("IndexError", "Home");
                }
            }
            catch (Exception e)
            {
                return RedirectToAction("IndexError", "Home");

            }

        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        
    }
}