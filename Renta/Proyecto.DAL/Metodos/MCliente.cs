using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.DAL.Interfaces;
using System.Data;
using Lec03.DAL.Metodos;
using ServiceStack.OrmLite;

namespace Proyecto.DAL.Metodos
{
    public class MCliente: MBase, ICliente
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
    }
}
