using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.BLL.Interfaces
{
    public interface ITraccion
    {
        List<Traccion> ListarTraccion();

        Traccion BuscarTraccion(int idTraccion);

        void InsertarTraccion(Traccion traccion);

        void ActualizarTraccion(Traccion traccion);

        void EliminarTraccion(int idTraccion);
    }
}
