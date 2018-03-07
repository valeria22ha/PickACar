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
    public class MPuertas : MBase, IPuertas
    {
        public void ActualizarPuertas(Puertas puerta)
        {
            _db.Update(puerta);
        }

        public Puertas BuscarPuertas(int idPuerta)
        {
            return _db.Select<Puertas>(x => x.IDPuer == idPuerta)
                .FirstOrDefault();
        }

        public void EliminarPuertas(int idPuerta)
        {
            _db.Delete<Puertas>(x => x.IDPuer
            == idPuerta);
        }

        public void InsertarPuertas(Puertas puerta)
        {
            _db.Insert(puerta);
        }

        public List<Puertas> ListarPuertas()
        {
            return _db.Select<Puertas>();
        }
    }
}
