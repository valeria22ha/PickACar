using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MMecanico : MBase, IMecanico
    {
        public void ActualizarMecanico(Mecanico mecanico)
        {
            meca.ActualizarMecanico(mecanico);
        }

        public Mecanico BuscarMecanico(int idMecanico)
        {
            return meca.BuscarMecanico(idMecanico);
        }

        public void EliminarMecanico(int idMecanico)
        {
            meca.EliminarMecanico(idMecanico);
        }

        public void InsertarMecanico(Mecanico mecanico)
        {
            meca.InsertarMecanico(mecanico);
        }

        public List<Mecanico> ListarMecanicos()
        {
            return meca.ListarMecanicos();
        }
    }
}
