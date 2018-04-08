using Proyecto.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BLL.Interfaces
{
    public interface IModelo
    {
        List<Modelo> ListarModelo();

        Modelo BuscarModelo(int idModelo);

        void InsertarModelo(Modelo modelo);

        void ActualizarModelo(Modelo modelo);

        void EliminarModelo(int idModelo);
    }
}
