using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.BLL.Interfaces
{
    public interface IMarca
    {
        List<Marca> ListarMarcas();

        Marca BuscarMarca(int idMarca);

        void InsertarMarca(Marca marca);

        void ActualizarMarca(Marca marca);

        void EliminarMarca(int idMarca);
    }
}
