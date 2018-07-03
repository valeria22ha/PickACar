using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.DAL.Interfaces;
using System.Data;
using Lec03.DAL.Metodos;
using Proyecto.DAL.Metodos;
using ServiceStack.OrmLite;

namespace Proyecto.DAL.Metodos
{
    public class MCliente : MBase, ICliente
    { 
        List<Cliente> ICliente.ListarClientes()
        {
            return _db.Select<Cliente>();
        }

        Cliente ICliente.BuscarCliente(int idCliente)
        {
            return _db.Select<Cliente>(x => x.Cedula == idCliente)
                .FirstOrDefault();
        }

        void ICliente.InsertarCliente(Cliente cliente)
        {   
            _db.Insert(cliente);
        }

        void ICliente.ActualizarCliente(Cliente cliente)
        {
            _db.Update(cliente);
        }

        void ICliente.EliminarCliente(int idCliente)
        {
            _db.Delete<Cliente>(x => x.Cedula == idCliente);
        }

        Proyecto.DATOS.Cliente ICliente.AutentificarCliente(string pLoginUser, string pPassword)
        {
            //TODO: Encriptacion de password.
            var client = _db.Select<Cliente>(a => a.Correo == pLoginUser && a.Password == pPassword).FirstOrDefault();
         
            return client;
        }


        string ICliente.ObtenerPasswordCliente(string pEmail)
        {
            var lvCliente = _db.Select<Cliente>(x => x.Correo == pEmail).FirstOrDefault();

            if (lvCliente != null)
            {
                //TODO: Desencriptar contraseña
                return lvCliente.Password;
            }
            else
                return string.Empty;

        }


        bool ICliente.CheckEmailExists(string pEmail, int pIdClient)
        {
            var lvCliente = _db.Select<Cliente>(x => x.Correo == pEmail).FirstOrDefault();

            if (lvCliente != null)
            {
                if (pIdClient != lvCliente.Cedula)
                {
                    return true;
                }
                else
                    return false;


            }
            else
                return false;


        }

        public int ObtenerCedula(string email)
        {
            var clie = _db.Select<Cliente>(x => x.Correo == email).FirstOrDefault();
            if (clie != null)
            {
                return clie.Cedula;
            }
            else
            {
                return -1;
            }
        }
    }
}
