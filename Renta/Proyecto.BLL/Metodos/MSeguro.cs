using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MSeguro : ISeguro
    {
        public DAL.Interfaces.ISeguro segu;
        public MSeguro()
        {
            segu = new DAL.Metodos.MSeguro();
        }
        public void ActualizarSeguro(Seguro seguro)
        {
            segu.ActualizarSeguro(seguro);
        }

        public Seguro BuscarSeguro(int idSeguro)
        {
            return segu.BuscarSeguro(idSeguro);
        }

        public void EliminarSeguro(int idSeguro)
        {
            segu.EliminarSeguro(idSeguro);
        }

        public void InsertarSeguro(Seguro seguro)
        {
            segu.InsertarSeguro(seguro);
        }

        public List<Seguro> ListarSeguros()
        {
            return segu.ListarSeguros();
        }
    }
}
