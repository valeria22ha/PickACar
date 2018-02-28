using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.BLL.Interfaces
{
   public interface IRenta
    {
        List<Renta> ListarRentas();

        Renta BuscarRenta(int idRenta);

        void InsertarRenta(Renta renta);

        void ActualizarRenta(Renta renta);

        void EliminarRenta(int idRenta);
    }
}
