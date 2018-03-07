using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.DAL.Interfaces
{
    public interface ICombustible
    {
        List<Combustible> ListarCombustible();

        Combustible BuscarCobustible(int idCombustible);

        void InsertarCombustible(Combustible combustible);

        void ActualizarCombustible(Combustible combustible);

        void EliminarCombustible(Combustible idCombustible);
    }
}
