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
    public class MRenta : MBase, IRenta
    {
        public void ActualizarRenta(Renta renta)
        {
            _db.Update(renta);
        }

        public Renta BuscarRenta(int idRenta)
        {
            return _db.Select<Renta>(x => x.ID == idRenta)
                .FirstOrDefault();
        }

        public void EliminarRenta(int idRenta)
        {
            _db.Delete<Renta>(x => x.ID == idRenta);
        }

        public void InsertarRenta(Renta renta)
        {
            _db.Insert(renta);
        }

        public List<Renta> ListarRentas()
        {
            return _db.Select<Renta>();
        }
    }
}
