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
    public class ClienteController : Controller
    {

        ICliente cliente;

        public ClienteController()
        {
            cliente = new MCliente();
        }

        // GET: Cliente
        public ActionResult Index()
        {
            var listaClientes = cliente.ListarClientes();
            var clientes = Mapper.Map<List<Models.Cliente>>(listaClientes);
            return View(clientes);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var vCliente = cliente.BuscarCliente(id);
            var clienteMostrar = Mapper.Map<Models.Cliente>(vCliente);
            return View(clienteMostrar);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Models.Cliente pCliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var clienteInsertar = Mapper.Map<DATOS.Cliente>(pCliente);
                    cliente.InsertarCliente(clienteInsertar);
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

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            var vCliente = cliente.BuscarCliente(id);
            var clienteMostrar = Mapper.Map<Models.Cliente>(vCliente);
            return View(clienteMostrar);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Cliente pCliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var clienteModificar = Mapper.Map<DATOS.Cliente>(pCliente);
                    cliente.ActualizarCliente(clienteModificar);
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

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            cliente.EliminarCliente(id);
            return RedirectToAction("Index");
        }
    }
}
