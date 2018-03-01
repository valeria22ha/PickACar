using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MFactura : MBase, IFactura
    {
        public void ActualizarFactura(Factura factura)
        {
            fact.ActualizarFactura(factura);
        }

        public Factura BuscarFactura(int idFactura)
        {
            return fact.BuscarFactura(idFactura);
        }

        public void InsertarFactura(Factura factura)
        {
            fact.InsertarFactura(factura);
        }

        public List<Factura> ListarFacturas()
        {
            return fact.ListarFacturas();
        }
    }
}
