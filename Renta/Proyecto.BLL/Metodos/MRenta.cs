using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MRenta : MBase, IRenta
    {
        public void ActualizarRenta(Renta renta)
        {
            rent.ActualizarRenta(renta);
        }

        public Renta BuscarRenta(int idRenta)
        {
            return rent.BuscarRenta(idRenta);
        }

        public void EliminarRenta(int idRenta)
        {
            rent.EliminarRenta(idRenta);
        }

        public void InsertarRenta(Renta renta)
        {
            rent.InsertarRenta(renta);
        }

        public List<Renta> ListarRentas()
        {
            return rent.ListarRentas();
        }
    }
}
