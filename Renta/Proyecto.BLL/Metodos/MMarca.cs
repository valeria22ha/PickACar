using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MMarca :  IMarca
    {
        public DAL.Interfaces.IMarca marc;
        public MMarca()
        {
            marc = new DAL.Metodos.MMarca();
        }
        public void ActualizarMarca(Marca marca)
        {
            marc.ActualizarMarca(marca);
        }

        public Marca BuscarMarca(int idMarca)
        {
            return marc.BuscarMarca(idMarca);
        }

        public void EliminarMarca(int idMarca)
        {
            marc.EliminarMarca(idMarca);
        }

        public void InsertarMarca(Marca marca)
        {
            marc.InsertarMarca(marca);
        }

        public List<Marca> ListarMarcas()
        {
            return marc.ListarMarcas();
        }
    }
}
