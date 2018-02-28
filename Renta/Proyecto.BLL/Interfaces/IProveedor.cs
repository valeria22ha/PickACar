using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
namespace Proyecto.BLL.Interfaces
{
    public interface IProveedor
    {
        List<Proveedor> ListarProveedores();

        Proveedor BuscarProveedor(int idProveedor);

        void InsertarProveedor(Proveedor proveedor);

        void ActualizarProveedor(Proveedor proveedor);

        void EliminarProveedor(int idProveedor);
    }
}
