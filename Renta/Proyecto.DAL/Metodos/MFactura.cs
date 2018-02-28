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
    public class MFactura : MBase, IFactura
    {
        public void ActualizarFactura(Factura factura)
        {
            _db.Update(factura); 
        }

        public Factura BuscarFactura(int idFactura)
        {
            return _db.Select<Factura>(x => x.IDF == idFactura)
                .FirstOrDefault();
        
    }

        public void InsertarFactura(Factura factura)
        {
            _db.Insert(factura);
        }

        public List<Factura> ListarFacturas()
        {
            return _db.Select<Factura>();
        }
    }
}
