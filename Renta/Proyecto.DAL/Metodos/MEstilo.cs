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
    public class MEstilo: MBase, IEstilo
    {
        List<Estilo> IEstilo.ListarEstilos()
        {
            return _db.Select<Estilo>();
        }

        Estilo IEstilo.BuscarEstilo(int idEstilo)
        {
            return _db.Select<Estilo>(x => x.ID == idEstilo)
                .FirstOrDefault();
        }

        void IEstilo.InsertarEstilo(Estilo estilo)
        {
            _db.Insert(estilo);
        }

        void IEstilo.ActualizarEstilo(Estilo estilo)
        {
            _db.Update(estilo);
        }

        void IEstilo.EliminarEstilo(int idEstilo)
        {
            _db.Delete<Estilo>(x => x.ID == idEstilo);
        }
    }
}
