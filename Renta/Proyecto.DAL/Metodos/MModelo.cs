using Lec03.DAL.Metodos;
using Proyecto.DAL.Interfaces;
using Proyecto.DATOS;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DAL.Metodos
{
    public class MModelo : MBase, IModelo
    {
        public void ActualizarModelo(Modelo modelo)
        {
            _db.Update(modelo);
        }
        

        public Modelo BuscarModelo(int idModelo)
        {
            return _db.Select<Modelo>(x => x.ID == idModelo)
               .FirstOrDefault();
        }

        public void EliminarModelo(int idModelo)
        {
            _db.Delete<Modelo>(x => x.ID == idModelo);
        }

        public void InsertarModelo(Modelo modelo)
        {
            _db.Insert(modelo);
        }
        
        public List<Modelo> ListarModelo()
        {
            return _db.Select<Modelo>();
        }
    }
}
