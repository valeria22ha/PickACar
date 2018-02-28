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
    public class MProveedor : MBase, IProveedor
    {
        public void ActualizarProveedor(Proveedor proveedor)
        {
            _db.Update(proveedor);
        }

        public Proveedor BuscarProveedor(int idProveedor)
        {
            return _db.Select<Proveedor>(x => x.Cedula == idProveedor)
                .FirstOrDefault();
        }

        public void EliminarProveedor(int idProveedor)
        {
            _db.Delete<Proveedor>(x => x.Cedula
            == idProveedor);
        }

        public void InsertarProveedor(Proveedor proveedor)
        {
            _db.Insert(proveedor);
        }

        public List<Proveedor> ListarProveedores()
        {
            return _db.Select<Proveedor>();
        }
    }
}
