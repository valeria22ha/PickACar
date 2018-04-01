using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.DAL.Interfaces
{
    public interface IFactura
    {
        List<Factura> ListarFacturas();

        Factura BuscarFactura(int idFactura);

        void InsertarFactura(Factura factura);

        void ActualizarFactura(Factura factura);

        
    }
}
