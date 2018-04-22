using AutoMapper;
using Proyecto.BLL.Interfaces;
using Proyecto.BLL.Metodos;
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
        IRenta rent;
        ITransmicion trans;

        public RentaController()
        {
            vehi = new MVehiculo();
            mode = new MModelo();
            rent = new MRenta();
            trans = new MTransmicion();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DetallesRenta(int idModelo, string idCliente, string fechaEntr, string fechaDev)
        {
            var modeloEnv = mode.BuscarModelo(idModelo);

            var vehiculo = vehi.ListarVehiculos();
            List<DATOS.Vehiculo> vehiculosM = new List<DATOS.Vehiculo>();
            var listaRentas = rent.ListarRentas();
            DATOS.Vehiculo vehiculoF = new DATOS.Vehiculo();
            List<DATOS.Transmicion> lTransmicion = new List<DATOS.Transmicion>();
            DATOS.Transmicion transmicion = new DATOS.Transmicion();
            DATOS.Modelo modelo = new DATOS.Modelo();

            modelo = mode.BuscarModelo(idModelo);
            lTransmicion = trans.ListarTransmicion();

            foreach (var transm in lTransmicion)
            {
                if (transm.ID == modelo.ID)
                {
                    transmicion = transm;
                }
            }

            foreach (var veh in vehiculo)
            {
                if (veh.IDModelo == idModelo)
                {
                    vehiculosM.Add(veh);
                }
            }
            int rentas;

            foreach (var veh in vehiculosM)
            {
                rentas = 0;
                foreach (var renta in listaRentas)
                {
                    if (renta.IDVehiculo == veh.ID)
                    {
                        rentas++;
                        if (renta.FechaEntrega > Convert.ToDateTime(fechaEntr)
                            && renta.FechaDevolucion < Convert.ToDateTime(fechaEntr)
                            && renta.FechaEntrega > Convert.ToDateTime(fechaDev)
                            && renta.FechaDevolucion < Convert.ToDateTime(fechaDev)
                            )
                        {
                            vehiculoF = veh;
                        }
                    }
                }
                if (rentas == 0)
                {
                    vehiculoF = veh;
                }
            }

            ViewData["vehiculo"] = Mapper.Map<Models.Vehiculo>(vehiculoF);
            ViewData["modelo"] = Mapper.Map<Models.Modelo>(modeloEnv);
            ViewData["fechaEntr"] = fechaEntr;
            ViewData["fechaDev"] = fechaDev;
            ViewData["cliente"] = idCliente;
            ViewData["transmicion"] = Mapper.Map<Models.Transmicion>(transmicion);
            return View();
        }


        public ActionResult RegistroRenta(string idCliente, string idVehiculo,
            string fechaEntr, string fechaDev, int idSeguro, int idLugar)
        {
            idSeguro = 1; // esto por ahora
            idLugar = 1;  // esto por ahora

            DATOS.Renta rentaNueva = new DATOS.Renta();
            rentaNueva.IDEmpleado = 117203909;
            rentaNueva.IDVehiculo = idVehiculo;
            rentaNueva.IDSeguro = idSeguro;
            rentaNueva.IDLugar = idLugar;
            rentaNueva.FechaEntrega = Convert.ToDateTime(fechaEntr);
            rentaNueva.FechaDevolucion = Convert.ToDateTime(fechaDev);

            rent.InsertarRenta(rentaNueva);
            return View();
        }
    }
}