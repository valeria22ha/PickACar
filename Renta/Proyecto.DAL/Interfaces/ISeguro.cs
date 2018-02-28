using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.DAL.Interfaces
{
    public interface ISeguro
    {
        List<Seguro> ListarSeguros();

        Seguro BuscarSeguro(int idSeguro);

        void InsertarSeguro(Seguro seguro);

        void ActualizarSeguro(Seguro seguro);

        void EliminarSeguro(int idSeguro);
    }
}
