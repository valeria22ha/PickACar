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
    public class MecanicoController : Controller
    {
        IMecanico Mecanico;

        public MecanicoController()
        {
            Mecanico = new MMecanico();
        }

        // GET: Mecanico
        public ActionResult Index()
        {
            var listaMecanicos = Mecanico.ListarMecanicos();
            var Mecanicos = Mapper.Map<List<Models.Mecanico>>(listaMecanicos);
            return View(Mecanicos);
        }

        // GET: Mecanico/Details/5
        public ActionResult Details(int id)
        {
            var vMecanico = Mecanico.BuscarMecanico(id);
            var MecanicoMostrar = Mapper.Map<Models.Mecanico>(vMecanico);
            return View(MecanicoMostrar);
        }

        // GET: Mecanico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mecanico/Create
        [HttpPost]
        public ActionResult Create(Models.Mecanico pMecanico)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var MecanicoInsertar = Mapper.Map<DATOS.Mecanico>(pMecanico);
                    Mecanico.InsertarMecanico(MecanicoInsertar);
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

        // GET: Mecanico/Edit/5
        public ActionResult Edit(int id)
        {
            var vMecanico = Mecanico.BuscarMecanico(id);
            var MecanicoMostrar = Mapper.Map<Models.Mecanico>(vMecanico);
            return View(MecanicoMostrar);
        }

        // POST: Mecanico/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Mecanico pMecanico)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var MecanicoModificar = Mapper.Map<DATOS.Mecanico>(pMecanico);
                    Mecanico.ActualizarMecanico(MecanicoModificar);
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

        // GET: Mecanico/Delete/5
        public ActionResult Delete(int id)
        {
            Mecanico.EliminarMecanico(id);
            return RedirectToAction("Index");
        }
    }
}

