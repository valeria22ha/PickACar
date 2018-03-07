using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.DAL.Interfaces
{
    public interface ITransmicion
    {
        List<Transmicion> ListarTransmicion();

        Transmicion BuscarTransmicion(int idTransmicion);

        void InsertarTransmicion(Transmicion transmicion);

        void ActualizarTransmicion(Transmicion transmicion);

        void EliminarTransmicion(int idTransmicion);
    }
}
