using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Proyecto.GUI.Models;
using Proyecto.DATOS;
using Proyecto.DAL.Interfaces;
using Proyecto.DAL.Metodos;

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
                System.Web.HttpContext.Current.Session["cliente"] = pCliente.Correo;
                return RedirectToAction("index", "home");
            }
            else
            {
                ViewBag.ValMessages = "Usuario o contraseña incorrecto.";
                return View("Login");
            }

        }

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


        public ActionResult Details(int id)
        {
            var clienteBuscar = clien.BuscarCliente(id);
            var clienteMostrar = Mapper.Map<Models.Cliente>(clienteBuscar);
            return View(clienteMostrar);

        }

        public ActionResult Edit(int id)
        {
            var clienteBuscar = clien.BuscarCliente(id);
            var clienteMostrar = Mapper.Map<Models.Cliente>(clienteBuscar);
            return View(clienteMostrar);
        }

        [HttpPost]
        public ActionResult Edit(Models.Cliente cliente)
        {
            var clienteModificar = Mapper.Map<DATOS.Cliente>(cliente);
            if (ModelState.IsValid)
            {
                clien.ActualizarCliente(clienteModificar);
                return RedirectToAction("Login");
            }
            return View(cliente);
        }

        public ActionResult Delete(int id)
        {
            clien.EliminarCliente(id);
            return RedirectToAction("Login");
        }

        public ActionResult EnviarClave(Models.Cliente pCliente)
        {
            if (pCliente != null && !string.IsNullOrEmpty(pCliente.Correo))
            {
                BLL.Metodos.MCliente client = new BLL.Metodos.MCliente();
                var resultado = client.RecuperarPassword(pCliente.Correo);

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

        public ActionResult CerrarS()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Cliente");
        }
    }
}