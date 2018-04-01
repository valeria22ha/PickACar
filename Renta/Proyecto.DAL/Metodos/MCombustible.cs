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
    public class MCombustible : MBase, ICombustible
    {
        public void ActualizarCombustible(Combustible combustible)
        {
            _db.Update(combustible);
        }

        public Combustible BuscarCobustible(int idCombustible)
        {
            return _db.Select<Combustible>(x => x.ID == idCombustible)
                .FirstOrDefault();
        }

        public void EliminarCombustible(int idCombustible)
        {
            _db.Delete<Combustible>(x => x.ID == idCombustible);
        }

        public void InsertarCombustible(Combustible combustible)
        {
            _db.Insert(combustible);
        }

        public List<Combustible> ListarCombustible()
        {
            return _db.Select<Combustible>();
        }
    }
}
