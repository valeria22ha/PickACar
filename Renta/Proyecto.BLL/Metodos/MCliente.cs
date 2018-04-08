using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MCliente :  ICliente
    {
        public DAL.Interfaces.ICliente clie;

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

        public void InsertarCliente(Cliente cliente)
        {
            clie.InsertarCliente(cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return clie.ListarClientes();
        }
    }
}
