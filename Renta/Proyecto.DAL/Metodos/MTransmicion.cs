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
    public class MTransmicion : MBase, ITransmicion
    {
        public void ActualizarTransmicion(Transmicion transmicion)
        {
            _db.Update(transmicion);
        }

        public Transmicion BuscarTransmicion(int idTransmicion)
        {
            return _db.Select<Transmicion>(x => x.ID == idTransmicion).FirstOrDefault();
        }

        public void EliminarTransmicion(int idTransmicion)
        {
            _db.Delete<Transmicion>(x => x.ID == idTransmicion);
        }

        public void InsertarTransmicion(Transmicion transmicion)
        {
            _db.Insert(transmicion);
        }

        public List<Transmicion> ListarTransmicion()
        {
            return _db.Select<Transmicion>();
        }
    }
}
