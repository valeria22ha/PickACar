using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Proyecto.DATOS;
using Proyecto.DAL.Interfaces;
using Proyecto.DAL.Metodos;
using Proyecto.GUI.Models;

namespace Proyecto.GUI.Controllers
{
    public class ClienteController : Controller
    {

        ICliente clien;//se usan los de DAL

        public ClienteController()
        {
            clien = new MCliente();
        }

        // GET: Cliente
        public ActionResult Index()
        {

            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult VerificarUsuario(GUI.Models.Cliente pCliente)
        {
            var a = GUI.Models.Cliente.VerficarLogin(pCliente);
            if (a)
            {
                //Setiar variables de usuario.
                return new RedirectResult("\\");

            }
            else
            {

                ViewBag.ValMessages = "Usuario o contraseña incorrecto.";
                return View("Login");
            }

        }

        //    var listaClientes = cliente.ListarClientes();
        //    var clientes = Mapper.Map<List<Models.Cliente>>(listaClientes);
        //    return View(clientes);
        //}

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var vCliente = clien.BuscarCliente(id);
            var clienteMostrar = Mapper.Map<Models.Cliente>(vCliente);
            return View(clienteMostrar);
        }

        // GET: Cliente/Create

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Models.Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                DATOS.Cliente clienteInsertar = new DATOS.Cliente();
                clienteInsertar.Apellido = cliente.Apellido;
                clienteInsertar.Cedula = cliente.Cedula;
                clienteInsertar.Correo = cliente.Correo;
                clienteInsertar.Direccion = cliente.Direccion;
                clienteInsertar.Nombre = cliente.Nombre;
                clienteInsertar.Password = cliente.Password;
                clienteInsertar.Telefono = cliente.Telefono;
                clienteInsertar.Tipo = false;

                clien.InsertarCliente(clienteInsertar);
                return RedirectToAction("Login");
            }
            return View("Login");

        }

        public ActionResult RecobrarPassword()
        {




            return View();

        }

        public ActionResult EnviarClave(Models.Cliente pCliente)
        {
            if (pCliente != null && !string.IsNullOrEmpty(pCliente.Correo))
            {
                MCliente clien = new MCliente();
                var resultado = clien.RecuperarPassword(pCliente.Correo);
                if (resultado)
                {
                    ViewBag.ValMessages = "Correo se ha enviado";
                    return View("Login");
                }
                else
                {
                    ViewBag.ValMessages = "No se pudo enviar un correo";
                    return View("RecobrarPassword");
                }


            }
            return View("RecobrarPassword");
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
                    clien.InsertarCliente(clienteInsertar);
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
            var vCliente = clien.BuscarCliente(id);
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
                    clien.ActualizarCliente(clienteModificar);
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

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            clien.EliminarCliente(id);
            return RedirectToAction("Index");
        }
    }
}


    
