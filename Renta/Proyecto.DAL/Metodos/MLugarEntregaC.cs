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
   public  class MLugarEntregaC : MBase, ILugarEntregaC
    {
        public void ActualizarLugar(LugarEntregaC lugar)
        {
            _db.Update(lugar);
        }

        public LugarEntregaC BuscarLugar(int idLugar)
        {
            return _db.Select<LugarEntregaC>(x => x.IDLu == idLugar)
               .FirstOrDefault();
        }

        public void EliminarLugar(int idLugar)
        {
            _db.Delete<LugarEntregaC>(x => x.IDLu == idLugar);
        }

        public void InsertarLugar(LugarEntregaC lugar)
        {
            _db.Insert(lugar);
        }

        public List<LugarEntregaC> ListarLugares()
        {
            return _db.Select<LugarEntregaC>();
        }
    }
}
