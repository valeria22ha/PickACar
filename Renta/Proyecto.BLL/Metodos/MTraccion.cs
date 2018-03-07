using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MTraccion : MBase, ITraccion
    {
        public void ActualizarTraccion(Traccion traccion)
        {
            tracc.ActualizarTraccion(traccion);
        }

        public Traccion BuscarTraccion(int idTraccion)
        {
            return tracc.BuscarTraccion(idTraccion);
        }

        public void EliminarTraccion(int idTraccion)
        {
            tracc.EliminarTraccion(idTraccion);
        }

        public void InsertarTraccion(Traccion traccion)
        {
            tracc.InsertarTraccion(traccion);
        }

        public List<Traccion> ListarTraccion()
        {
            return tracc.ListarTraccion();
        }
    }
}
