    using AutoMapper;
using Proyecto.BLL.Interfaces;
using Proyecto.BLL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.GUI.Controllers
{
    public class RentaController : Controller
    {

        IVehiculo vehi;
        IModelo mode;
        IRenta rent;
        ITransmicion trans;
        ICombustible comb;
        ICliente clien;
        ITraccion trac;
        IPuertas puert;
        IMarca marc;
        IEstilo esti;
        IFactura fact;

        public RentaController()
        {
            vehi = new MVehiculo();       mode = new MModelo();
            rent = new MRenta();          trans = new MTransmicion();
            comb = new MCombustible();    clien = new MCliente();
            trac = new MTraccion();       puert = new MPuertas();
            marc = new MMarca();          esti = new MEstilo();
            fact = new MFactura();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DetallesRenta(int idModelo, string idCliente, string fechaEntr, string fechaDev)
        {
            //variables necesarias
            List<DATOS.Vehiculo> vehiculosM = new List<DATOS.Vehiculo>();
            DATOS.Vehiculo vehiculoF = new DATOS.Vehiculo();
            DATOS.Transmicion transmicion = new DATOS.Transmicion();
            DATOS.Modelo modelo = new DATOS.Modelo();
            DATOS.Combustible combustible = new DATOS.Combustible();
            DATOS.Traccion traccion = new DATOS.Traccion();
            DATOS.Puertas puertas = new DATOS.Puertas();
            DATOS.Marca marca = new DATOS.Marca();
            DATOS.Estilo estilo = new DATOS.Estilo();

            //llenado de listas y modelo
            modelo = mode.BuscarModelo(idModelo);
            var listaRentas = rent.ListarRentas();
            var vehiculos = vehi.ListarVehiculos();
            var lTransmicion = trans.ListarTransmicion();
            var lCombustibles = comb.ListarCombustible();
            var lTraccion = trac.ListarTraccion();
            var lPuertas = puert.ListarPuertas();
            var lMarcas = marc.ListarMarcas();
            var lEstilos = esti.ListarEstilos();

            //informacion sobre el modelo
            foreach (var transm in lTransmicion)
            {
                if (transm.ID == modelo.ID)
                {
                    transmicion = transm;
                }
            }
            foreach (var combus in lCombustibles)
            {
                if (combus.ID == modelo.IDCombustible)
                {
                    combustible = combus;
                }
            }
            foreach (var tra in lTraccion)
            {
                if (tra.ID == modelo.IDTraccion)
                {
                    traccion = tra;
                }
            }
            foreach (var puerta in lPuertas)
            {
                if (puerta.ID == modelo.IDNumeroPuertas)
                {
                    puertas = puerta;
                }
            }
            foreach (var mar in lMarcas)
            {
                if (mar.ID == modelo.IDMarca)
                {
                    marca = mar;
                }
            }
            foreach (var est in lEstilos)
            {
                if (est.ID == modelo.IDEstilo)
                {
                    estilo = est;
                }
            }
            
            //llenado de vehiculos que cumplan con el modelo solicitado
            foreach (var veh in vehiculos)
            {
                if (veh.IDModelo == idModelo)
                {
                    vehiculosM.Add(veh);
                }
            }
            int rentas;

            //asignacion del vehiculo a rentar
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
                        else
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
            ViewData["modelo"] = Mapper.Map<Models.Modelo>(modelo);
            ViewData["fechaEntr"] = fechaEntr;
            ViewData["fechaDev"] = fechaDev;
            ViewData["Cliente"] = (string)Session["cliente"];
            ViewData["transmision"] = Mapper.Map<Models.Transmicion>(transmicion);
            ViewData["combustible"] = Mapper.Map<Models.Combustible>(combustible);
            ViewData["traccion"] = Mapper.Map<Models.Traccion>(traccion);
            ViewData["puertas"] = Mapper.Map<Models.Puertas>(puertas);
            ViewData["marca"] = Mapper.Map<Models.Marca>(marca);
            ViewData["estilo"] = Mapper.Map<Models.Estilo>(estilo);

            return View();
        }


        public ActionResult RegistroRenta(Models.Renta renta, string idVehiculo,
            string fechaEntr, string fechaDev, int subtotal)
        {
            DATOS.Renta rentaNueva = new DATOS.Renta();
            DATOS.Factura facturaNueva = new DATOS.Factura();

            int cedula = clien.ObtenerCedula((string)Session["cliente"]);

            rentaNueva.IDVehiculo = idVehiculo;
            rentaNueva.FechaEntrega = Convert.ToDateTime(fechaEntr);
            rentaNueva.FechaDevolucion = Convert.ToDateTime(fechaDev);
            
            //envio de correo
            MailMessage mensaje = new MailMessage();

            mensaje.To.Add((string)System.Web.HttpContext.Current.Session["cliente"]);
            var cantidadFacts = fact.ListarFacturas().Last();
            var cantidadRentas = rent.ListarRentas().Last();

            AlternateView html = AlternateView.CreateAlternateViewFromString("<body style = 'background: black; color:white;' > " +
                " <div style = 'position:absolute; width:70%; height:70%; color:white; border:1px solid white;" +
                "font - family:'Segoe UI', 'Tahoma', 'Geneva', 'Verdana', 'sans - serif';'><br />" +
                "<h1 style = 'text-align:center; color:white;'> Detalle de venta de PickACar</h1 >" +
                "<br /><br /><br /><br />" +
                "<div style = 'width:50%;height:80%;margin-left:15%;border: 1px solid white; padding-left:15%;'>" +
                "<h3 > El vehiculo solicitado es de placa: " + idVehiculo+ "</h3>" +
                "<h3 > Las fechas son:</h3 >" +
                "<h3 > -Entrega: " + fechaEntr + "</h3>" +
                "<h3 > -Devolucion: " + fechaDev+ "</h3>" +
                "<br />" +
                "<h3 > Numero de Comprobante: " + (cantidadFacts.ID + 1) + "</h3>" +
                "<h3 > Numero de Factura: " + (cantidadRentas.ID + 1) + "</h3>" +
                "</div ><br /><br /><br />" +
                "<h1 style = 'text-align:center;' >¡Muchas Gracias por elegirnos!</h1 >" +
                "</div ><br />" +
                "</body >", null, "text/html");
            // 

            mensaje.AlternateViews.Add(html);
            mensaje.IsBodyHtml = true;

            mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
            mensaje.Subject = "Renta Realizada";

            mensaje.From = new MailAddress("correo@gmail.com");

            SmtpClient cliente = new SmtpClient();

            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new NetworkCredential("correo@gmail.com", "contrase;a");

            cliente.Host = "smtp.gmail.com"; //host, en caso de ser gmail = smtp.gmail.com
            cliente.EnableSsl = true;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.Port = 587;

            
            try
            {
                cliente.Send(mensaje);
                rent.InsertarRenta(rentaNueva);

                var lrentas = rent.ListarRentas();
                
                facturaNueva.IDCliente = cedula;
                facturaNueva.TotalPago = subtotal;
                facturaNueva.FechaPago = Convert.ToDateTime(fechaDev);
                var idrent = lrentas.Last();
                facturaNueva.IDRenta = idrent.ID;

                fact.InsertarFactura(facturaNueva);
                
            }
            catch (SmtpException ex)
            {
                throw;
            }
            return View();
        }
    }
}