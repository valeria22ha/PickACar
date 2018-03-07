using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MCombustible : MBase, ICombustible
    {
        public void ActualizarCombustible(Combustible combustible)
        {
            combu.ActualizarCombustible(combustible);
        }

        public Combustible BuscarCobustible(int idCombustible)
        {
            return combu.BuscarCobustible(idCombustible);
        }

        public void EliminarCombustible(Combustible idCombustible)
        {
            combu.EliminarCombustible(idCombustible);
        }

        public void InsertarCombustible(Combustible combustible)
        {
            combu.InsertarCombustible(combustible);
        }

        public List<Combustible> ListarCombustible()
        {
            return combu.ListarCombustible();
        }
    }
}
