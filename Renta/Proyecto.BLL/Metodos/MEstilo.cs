using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MEstilo :  IEstilo
    {
        public DAL.Interfaces.IEstilo esti;

        public MEstilo()
        {
            esti = new DAL.Metodos.MEstilo();
        }
        public void ActualizarEstilo(Estilo estilo)
        {
            esti.ActualizarEstilo(estilo);
        }

        public Estilo BuscarEstilo(int idEstilo)
        {
            return esti.BuscarEstilo(idEstilo);
        }

        public void EliminarEstilo(int idEstilo)
        {
            esti.EliminarEstilo(idEstilo);
        }

        public void InsertarEstilo(Estilo estilo)
        {
            esti.InsertarEstilo(estilo);
        }

        public List<Estilo> ListarEstilos()
        {
            return esti.ListarEstilos();
        }
    }
}
