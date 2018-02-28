using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;


namespace Proyecto.DAL.Interfaces
{
    public interface ICliente
    {
        List<Cliente> ListarClientes();

       Cliente BuscarCliente(int idCliente);

        void InsertarCliente(Cliente cliente);

        void ActualizarCliente(Cliente cliente);

        void EliminarCliente(int idCliente);
    }
}
