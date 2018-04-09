using AutoMapper;
using Proyecto.DAL.Interfaces;
using Proyecto.DAL.Metodos;
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
        static List<AddVehicule> vehiculosMostrar = new List<AddVehicule>();

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
            var listaVehiculos = veh.ListarVehiculos();
            var vehiculos = Mapper.Map<List<Vehiculo>>(listaVehiculos);
            List<AddVehicule> vehiculosMostrarIndex = new List<AddVehicule>();
            foreach (Vehiculo vehi in vehiculos)
            {
                var vVehiculo = new AddVehicule()
                {
                    ID = vehi.ID,
                    Precio = vehi.Precio,
                    VMecanico = mec.ListarMecanicos().Where(x => x.ID == vehi.IDMecanico).Select(x => x.Nombre).First(),
                    VModelo = mod.ListarModelo().Where(x => x.ID == vehi.IDModelo).Select(x => x.Descripcion).First(),
                    VProveedor = prov.ListarProveedores().Where(x => x.Cedula == vehi.IDProveedor).Select(x => x.Nombre).First(),
                };

                vehiculosMostrarIndex.Add(vVehiculo);
            }
            vehiculosMostrar.Clear();
            vehiculosMostrar = vehiculosMostrarIndex;
            return View(vehiculosMostrar);
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
        public ActionResult Edit(String id)
        {
            try
            {
                AddVehicule vVehiculo = vehiculosMostrar.Where(x => x.ID == id).FirstOrDefault();

                var vMecanicos = mec.ListarMecanicos();
                var mMecanicos = Mapper.Map<List<Models.Mecanico>>(vMecanicos);
                vVehiculo.Mecanicos = mMecanicos;

                var vModelo = mod.ListarModelo();
                var mModelo = Mapper.Map<List<Models.Modelo>>(vModelo);
                vVehiculo.Modelos = mModelo;

                var vProveedores = prov.ListarProveedores();
                var mProveedores = Mapper.Map<List<Models.Proveedor>>(vProveedores);
                vVehiculo.Proveedores = mProveedores;

                return View(vVehiculo);
            } catch
            {
                return RedirectToAction("Index");
            }
            
        }

        // POST: AddVehicule/Edit/5
        [HttpPost]
        public ActionResult Edit(AddVehicule addVehicule)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var vehiculo = new Vehiculo()
                    {
                        ID = addVehicule.ID,
                        IDMecanico = addVehicule.SelectedMecanico,
                        IDModelo = addVehicule.SelectedModelo,
                        IDProveedor = addVehicule.SelectedProveedor,
                        Precio = addVehicule.Precio
                    };
                    var vehiculoInsertar = Mapper.Map<DATOS.Vehiculo>(vehiculo);
                    veh.ActualizarVehiculo(vehiculoInsertar);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        // GET: AddVehicule/Delete/5
        public ActionResult Delete(String id)
        {
            AddVehicule vVehiculo = vehiculosMostrar.Where(x => x.ID == id).FirstOrDefault();
            return View(vVehiculo);
        }

        // POST: AddVehicule/Delete/5
        [HttpPost]
        public ActionResult Delete(AddVehicule vehicule)
        {
            try
            {
                veh.EliminarVehiculo(vehicule.ID);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
