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
    public class MMecanico : MBase, IMecanico
    {
        public void ActualizarMecanico(Mecanico mecanico)
        {
            _db.Update(mecanico);
        }

        public Mecanico BuscarMecanico(int idMecanico)
        {
            return _db.Select<Mecanico>(x => x.IDMe == idMecanico)
                .FirstOrDefault();
        }

        public void EliminarMecanico(int idMecanico)
        {
            _db.Delete<Mecanico>(x => x.IDMe
            == idMecanico);
        }

        public void InsertarMecanico(Mecanico mecanico)
        {
            _db.Insert(mecanico);
        }

        public List<Mecanico> ListarMecanicos()
        {
            return _db.Select<Mecanico>();
        }
    }
}
