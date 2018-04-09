using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Proyecto.BLL.Metodos;
using Proyecto.GUI.Models;
using Proyecto.DATOS;
using Proyecto.DAL.Interfaces;

namespace Proyecto.GUI.Controllers
{



    public class ClienteController : Controller
    {

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }


        ICliente clientI;

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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteInsertar = Mapper.Map<DATOS.Cliente>(cliente);
                clientI.InsertarCliente(clienteInsertar);
                return RedirectToAction("Login");
            }
            return View("Login");
                    
        }


        public ActionResult Details(int id)
        {
            var clienteBuscar = clientI.BuscarCliente(id);
            var clienteMostrar = Mapper.Map<Models.Cliente>(clienteBuscar);
            return View(clienteMostrar);

        }

        public ActionResult Edit(int id)
        {
            var clienteBuscar = clientI.BuscarCliente(id);
            var clienteMostrar = Mapper.Map<Models.Cliente>(clienteBuscar);
            return View(clienteMostrar);
        }

        [HttpPost]
        public ActionResult Edit(Models.Cliente cliente)
        {
            var clienteModificar = Mapper.Map<DATOS.Cliente>(cliente);
            if (ModelState.IsValid)
            {
                clientI.ActualizarCliente(clienteModificar);
                return RedirectToAction("Login");
            }
            return View(cliente);
        }
        
        public ActionResult Delete(int id)
        {
            clientI.EliminarCliente(id);
            return RedirectToAction("Login");
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

    }
}