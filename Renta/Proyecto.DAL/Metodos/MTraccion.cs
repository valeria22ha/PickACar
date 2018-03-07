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
    public class MTraccion : MBase, ITraccion
    {
        public void ActualizarTraccion(Traccion traccion)
        {
            _db.Update(traccion);
        }

        public Traccion BuscarTraccion(int idTraccion)
        {
            return _db.Select<Traccion>(x => x.IDTrac == idTraccion)
               .FirstOrDefault();
        }

        public void EliminarTraccion(int idTraccion)
        {
            _db.Delete<Traccion>(x => x.IDTrac
           == idTraccion);
        }

        public void InsertarTraccion(Traccion traccion)
        {
            _db.Insert(traccion);
        }

        public List<Traccion> ListarTraccion()
        {
            return _db.Select<Traccion>();
        }
    }
}
