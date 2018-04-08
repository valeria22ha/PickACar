using Proyecto.BLL.Interfaces;
using Proyecto.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BLL.Metodos
{
    public class MModelo : IModelo
    {
        public DAL.Interfaces.IModelo mode;
        public MModelo()
        {
            mode = new DAL.Metodos.MModelo();
        }
        public void ActualizarModelo(Modelo modelo)
        {
            mode.ActualizarModelo(modelo);
        }

        public Modelo BuscarModelo(int idModelo)
        {
            return mode.BuscarModelo(idModelo);
        }

        public void EliminarModelo(int idModelo)
        {
            mode.EliminarModelo(idModelo);
        }

        public void InsertarModelo(Modelo modelo)
        {
            mode.InsertarModelo(modelo);
        }

        public List<Modelo> ListarModelo()
        {
            return mode.ListarModelo();
        }
    }
}
