using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.BLL.Interfaces
{
    public interface IEstilo
    {
        List<Estilo> ListarEstilos();

        Estilo BuscarEstilo(int idEstilo);

        void InsertarEstilo(Estilo estilo);

        void ActualizarEstilo(Estilo estilo);
        void EliminarEstilo(int idEstilo);
    }
}
