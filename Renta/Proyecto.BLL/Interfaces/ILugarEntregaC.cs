using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.BLL.Interfaces
{
    public interface ILugarEntregaC
    {
        List<LugarEntregaC> ListarLugares();

        LugarEntregaC BuscarLugar(int idLugar);

        void InsertarLugar(LugarEntregaC lugar);

        void ActualizarLugar(LugarEntregaC lugar);

        void EliminarLugar(int idLugar);
    }
}
