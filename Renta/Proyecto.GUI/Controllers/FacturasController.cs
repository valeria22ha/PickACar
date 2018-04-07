using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Proyecto.BLL.Interfaces;
using Proyecto.BLL.Metodos; //Metodos extra 

namespace Proyecto.GUI.Controllers
{
    public class FacturasController : Controller
    {
        IFactura Factura;

        public FacturasController()
        {
            Factura = new MFactura();
        }

        // GET: Factura
        public ActionResult Index()
        {
            var listaFacturas = Factura.ListarFacturas();
            var Facturas = Mapper.Map<List<Models.Factura>>(listaFacturas);
            return View(Facturas);
        }

        // GET: Factura/Details/5
        public ActionResult Details(int id)
        {
            var vFactura = Factura.BuscarFactura(id);
            var FacturaMostrar = Mapper.Map<Models.Factura>(vFactura);
            return View(FacturaMostrar);
        }

        // GET: Factura/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Factura/Create
        [HttpPost]
        public ActionResult Create(Models.Factura pFactura)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var FacturaInsertar = Mapper.Map<DATOS.Factura>(pFactura);
                    Factura.InsertarFactura(FacturaInsertar);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Factura/Edit/5
        public ActionResult Edit(int id)
        {
            var vFactura = Factura.BuscarFactura(id);
            var FacturaMostrar = Mapper.Map<Models.Factura>(vFactura);
            return View(FacturaMostrar);
        }

        // POST: Factura/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Factura pFactura)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var FacturaModificar = Mapper.Map<DATOS.Factura>(pFactura);
                    Factura.ActualizarFactura(FacturaModificar);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }
    }
}
