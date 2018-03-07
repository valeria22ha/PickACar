using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MPuertas : MBase, IPuertas
    {
        public void ActualizarPuertas(Puertas puerta)
        {
            puer.ActualizarPuertas(puerta);
        }

        public Puertas BuscarPuertas(int idPuerta)
        {
            return puer.BuscarPuertas(idPuerta);
        }

        public void EliminarPuertas(int idPuerta)
        {
            puer.EliminarPuertas(idPuerta);
        }

        public void InsertarPuertas(Puertas puerta)
        {
            puer.InsertarPuertas(puerta);
        }

        public List<Puertas> ListarPuertas()
        {
            return puer.ListarPuertas();
        }
    }
}
