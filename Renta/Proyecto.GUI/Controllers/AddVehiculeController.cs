using AutoMapper;
using Proyecto.BLL.Interfaces;
using Proyecto.BLL.Metodos;
using Proyecto.GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.GUI.Controllers
{
    public class AddVehiculeController : Controller
    {
        IVehiculo veh;
        IMecanico mec;
        IModelo mod;
        IProveedor prov;

        public AddVehiculeController()
        {
            veh = new MVehiculo();
            mec = new MMecanico();
            mod = new MModelo();
            prov = new MProveedor();

        }



        // GET: AddVehicule
        public ActionResult Index()
        {
            return View();
        }

        // GET: AddVehicule/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddVehicule/Create
        public ActionResult Create()
        {
            var aVehicule = new AddVehicule();

            var vMecanicos = mec.ListarMecanicos();
            var mMecanicos = Mapper.Map<List<Models.Mecanico>>(vMecanicos);
            aVehicule.Mecanicos = mMecanicos;

            var vModelo = mod.ListarModelo();
            var mModelo = Mapper.Map<List<Models.Modelo>>(vModelo);
            aVehicule.Modelos = mModelo;

            var vProveedores = prov.ListarProveedores();
            var mProveedores = Mapper.Map<List<Models.Proveedor>>(vProveedores);
            aVehicule.Proveedores = mProveedores;

            return View(aVehicule);
        }

        // POST: AddVehicule/Create
        [HttpPost]
        public ActionResult Create(AddVehicule addVehicule)
        {
            try
            {
                if (ModelState.IsValid) {
                    
                    var vehiculo = new Vehiculo()
                    {
                        ID = addVehicule.ID,
                        IDMecanico = addVehicule.SelectedMecanico,
                        IDModelo = addVehicule.SelectedModelo,
                        IDProveedor = addVehicule.SelectedProveedor,
                        Precio = addVehicule.Precio
                    };
                    var vehiculoInsertar = Mapper.Map<DATOS.Vehiculo>(vehiculo);
                    veh.InsertarVehiculo(vehiculoInsertar);
                    return RedirectToAction("Index");
                } else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: AddVehicule/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddVehicule/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddVehicule/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddVehicule/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
