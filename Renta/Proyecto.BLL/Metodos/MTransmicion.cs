using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MTransmicion : MBase, ITransmicion
    {
        public void ActualizarTransmicion(Transmicion transmicion)
        {
            trans.ActualizarTransmicion(transmicion);
        }

        public Transmicion BuscarTransmicion(int idTransmicion)
        {
            return trans.BuscarTransmicion(idTransmicion);
        }

        public void EliminarTransmicion(int idTransmicion)
        {
            trans.EliminarTransmicion(idTransmicion);
        }

        public void InsertarTransmicion(Transmicion transmicion)
        {
            trans.InsertarTransmicion(transmicion);
        }

        public List<Transmicion> ListarTransmicion()
        {
            return trans.ListarTransmicion();
        }
    }
}
