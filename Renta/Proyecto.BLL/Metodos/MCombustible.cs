using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MCombustible : ICombustible
    {
        public DAL.Interfaces.ICombustible combu;
        public MCombustible()
        {
            combu = new DAL.Metodos.MCombustible();
        }
        public void ActualizarCombustible(Combustible combustible)
        {
            combu.ActualizarCombustible(combustible);
        }

        public Combustible BuscarCobustible(int idCombustible)
        {
            return combu.BuscarCobustible(idCombustible);
        }

        public void EliminarCombustible(int idCombustible)
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
