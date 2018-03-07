using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.DAL.Interfaces
{
    public interface IPuertas
    {
        List<Puertas> ListarPuertas();

        Puertas BuscarPuertas(int idPuerta);

        void InsertarPuertas(Puertas puerta);

        void ActualizarPuertas(Puertas puerta);

        void EliminarPuertas(int idPuerta);
    }
}
