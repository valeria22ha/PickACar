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
    public class EmpleadoController : Controller
    {
        IEmpleado Empleado;

        public EmpleadoController()
        {
            Empleado = new MEmpleado();
        }

        // GET: Empleado
        public ActionResult Index()
        {
            var listaEmpleados = Empleado.ListarEmpleados();
            var Empleados = Mapper.Map<List<Models.Empleado>>(listaEmpleados);
            return View(Empleados);
        }

        // GET: Empleado/Details/5
        public ActionResult Details(int id)
        {
            var vEmpleado = Empleado.BuscarEmpleado(id);
            var EmpleadoMostrar = Mapper.Map<List<Models.Empleado>>(vEmpleado);
            return View(EmpleadoMostrar);
        }

        // GET: Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleado/Create
        [HttpPost]
        public ActionResult Create(Models.Empleado pEmpleado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var EmpleadoInsertar = Mapper.Map<DATOS.Empleado>(pEmpleado);
                    Empleado.InsertarEmpleado(EmpleadoInsertar);
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

        // GET: Empleado/Edit/5
        public ActionResult Edit(int id)
        {
            var vEmpleado = Empleado.BuscarEmpleado(id);
            var EmpleadoMostrar = Mapper.Map<Models.Empleado>(vEmpleado);
            return View();
        }

        // POST: Empleado/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Empleado pEmpleado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var EmpleadoModificar = Mapper.Map<DATOS.Empleado>(pEmpleado);
                    Empleado.ActualizarEmpleado(EmpleadoModificar);
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

        // GET: Empleado/Delete/5
        public ActionResult Delete(int id)
        {
            Empleado.EliminarEmpleado(id);
            return RedirectToAction("Index");
        }
    }
}

