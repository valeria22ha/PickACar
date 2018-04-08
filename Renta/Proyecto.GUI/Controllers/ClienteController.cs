using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.BLL.Metodos;
using Proyecto.GUI.Models;

namespace Proyecto.GUI.Controllers
{
    public class ClienteController : Controller
    {
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


        public ActionResult RecobrarPassword()
        {

     


            return View();

        }

        public ActionResult EnviarClave(Cliente pCliente)
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