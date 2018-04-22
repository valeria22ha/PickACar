using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Proyecto.DAL.Interfaces;
using Proyecto.DAL.Metodos; //Metodos extra 


namespace Proyecto.GUI.Controllers
{
    public class ProveedorController : Controller
    {
        IProveedor Proveedor;

        public ProveedorController()
        {
            Proveedor = new MProveedor();
        }

        // GET: Proveedor
        public ActionResult Index()
        {
            var listaProveedors = Proveedor.ListarProveedores();
            var Proveedors = Mapper.Map<List<Models.Proveedor>>(listaProveedors);
            return View(Proveedors);
        }

        // GET: Proveedor/Details/5
        public ActionResult Details(int id)
        {
            var vProveedor = Proveedor.BuscarProveedor(id);
            var ProveedorMostrar = Mapper.Map<Models.Proveedor>(vProveedor);
            return View(ProveedorMostrar);
        }

        // GET: Proveedor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proveedor/Create
        [HttpPost]
        public ActionResult Create(Models.Proveedor pProveedor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var ProveedorInsertar = Mapper.Map<DATOS.Proveedor>(pProveedor);
                    Proveedor.InsertarProveedor(ProveedorInsertar);
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

        // GET: Proveedor/Edit/5
        public ActionResult Edit(int id)
        {
            var vProveedor = Proveedor.BuscarProveedor(id);
            var ProveedorMostrar = Mapper.Map<Models.Proveedor>(vProveedor);
            return View(ProveedorMostrar);
        }

        // POST: Proveedor/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Proveedor pProveedor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var ProveedorModificar = Mapper.Map<DATOS.Proveedor>(pProveedor);
                    Proveedor.ActualizarProveedor(ProveedorModificar);
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

        // GET: Proveedor/Delete/5
        public ActionResult Delete(int id)
        {
            Proveedor.EliminarProveedor(id);
            return RedirectToAction("Index");
        }
    }
}
