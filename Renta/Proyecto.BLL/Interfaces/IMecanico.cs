using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.BLL.Interfaces
{
    public interface IMecanico
    {
        List<Mecanico> ListarMecanicos();

        Mecanico BuscarMecanico(int idMecanico);

        void InsertarMecanico(Mecanico mecanico);

        void ActualizarMecanico(Mecanico mecanico);

        void EliminarMecanico(int idMecanico);
    }
}
