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
    public class MMarca : MBase, IMarca
    {
        public void ActualizarMarca(Marca marca)
        {
            _db.Update(marca);
        }

        public Marca BuscarMarca(int idMarca)
        {
            return _db.Select<Marca>(x => x.IDMa == idMarca)
               .FirstOrDefault();
        }

        public void EliminarMarca(int idMarca)
        {
            _db.Delete<Marca>(x => x.IDMa
            == idMarca);
        }

        public void InsertarMarca(Marca marca)
        {
            _db.Insert(marca);
        }

        public List<Marca> ListarMarcas()
        {
            return _db.Select<Marca>();
        }
    }
}
