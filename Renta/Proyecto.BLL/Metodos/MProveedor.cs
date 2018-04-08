using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MProveedor : IProveedor
    {
        public DAL.Interfaces.IProveedor prove;
        public MProveedor()
        {
            prove = new DAL.Metodos.MProveedor();
        }
        public void ActualizarProveedor(Proveedor proveedor)
        {
            prove.ActualizarProveedor(proveedor);
        }

        public Proveedor BuscarProveedor(int idProveedor)
        {
            return prove.BuscarProveedor(idProveedor);
        }

        public void EliminarProveedor(int idProveedor)
        {
            prove.EliminarProveedor(idProveedor);
        }

        public void InsertarProveedor(Proveedor proveedor)
        {
            prove.InsertarProveedor(proveedor);
        }

        public List<Proveedor> ListarProveedores()
        {
            return prove.ListarProveedores();
        }
    }
}
