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
    public class MSeguro : MBase, ISeguro
    {
        public void ActualizarSeguro(Seguro seguro)
        {
            _db.Update(seguro);
        }

        public Seguro BuscarSeguro(int idSeguro)
        {
            return _db.Select<Seguro>(x => x.IDSe == idSeguro)
                .FirstOrDefault();
        }

        public void EliminarSeguro(int idSeguro)
        {
            _db.Delete<Seguro>(x => x.IDSe
            == idSeguro);
        }

        public void InsertarSeguro(Seguro seguro)
        {
            _db.Insert(seguro);
        }

        public List<Seguro> ListarSeguros()
        {
            return _db.Select<Seguro>();
        }
    }
}
