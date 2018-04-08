using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MLugarEntregaC :  ILugarEntregaC
    {

        public DAL.Interfaces.ILugarEntregaC luga;
        public MLugarEntregaC()
        {
            luga = new DAL.Metodos.MLugarEntregaC();
        }
        public void ActualizarLugar(LugarEntregaC lugar)
        {
            luga.ActualizarLugar(lugar);
        }

        public LugarEntregaC BuscarLugar(int idLugar)
        {
            return luga.BuscarLugar(idLugar);
        }

        public void EliminarLugar(int idLugar)
        {
            luga.EliminarLugar(idLugar);
        }

        public void InsertarLugar(LugarEntregaC lugar)
        {
            luga.InsertarLugar(lugar);
        }

        public List<LugarEntregaC> ListarLugares()
        {
            return luga.ListarLugares();
        }
    }
}
