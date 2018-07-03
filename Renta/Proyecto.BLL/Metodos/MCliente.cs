using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;
using System.Net.Mail;
using System.Net;

namespace Proyecto.BLL.Metodos
{
    public class MCliente : ICliente
    {
        public DAL.Interfaces.ICliente clie;
        public DATOS.Cliente ClientDatos;

        public MCliente()
        {
            clie = new DAL.Metodos.MCliente();
        }
        public void ActualizarCliente(Cliente cliente)
        {
            clie.ActualizarCliente(cliente);
        }

        public Cliente BuscarCliente(int idCliente)
        {
            return clie.BuscarCliente(idCliente);
        }

        public void EliminarCliente(int idCliente)
        {
            clie.EliminarCliente(idCliente);
        }

        public bool InsertarCliente(Cliente cliente)
        {
            if (clie.CheckEmailExists(cliente.Correo, cliente.Cedula))
            {
                clie.InsertarCliente(cliente);
                return true;
            }
            else
                return true;
        }

        public bool AutentificarCliente(Cliente cliente)
        {
            this.ClientDatos = clie.AutentificarCliente(cliente.Correo, cliente.Password);
            var resultado = (this.ClientDatos == null) ? false : true;
            return resultado;
        }

        public bool RecuperarPassword(string pCorreo)
        {
            var resultado = clie.ObtenerPasswordCliente(pCorreo);

            try
            {
                if (!string.IsNullOrEmpty(resultado))
                {

                    var from = "correo@gmail.com";
                    MailMessage m = new MailMessage(from, pCorreo);
                    m.Subject = "Recuperacion de Contraseña";
                    m.Body = "Su contraseña es: " + resultado;
                    m.IsBodyHtml = true;
                    m.From = new MailAddress(from);
                    m.To.Add(new MailAddress(pCorreo));
                    SmtpClient smtp = new SmtpClient()
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential("correo@gmail.com", "contrase;a"),
                        EnableSsl = true
                    };
                    smtp.Send(m);
                    return true;
                }
            }
            catch (Exception ex)
            {
                //TODO: Control de errores.
                return false;
            }

            return false;
        }



        public List<Cliente> ListarClientes()
        {
            return clie.ListarClientes();
        }

        public int ObtenerCedula(string email)
        {
            return clie.ObtenerCedula(email);
        }
    }
}

