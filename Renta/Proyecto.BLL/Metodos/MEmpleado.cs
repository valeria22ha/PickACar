using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MEmpleado :  IEmpleado
    {
        public DAL.Interfaces.IEmpleado emple;
        
        public MEmpleado()
        {
            emple = new DAL.Metodos.MEmpleado();
        }
        public void ActualizarEmpleado(Empleado empleado)
        {
            emple.ActualizarEmpleado(empleado);
        }

        public Empleado BuscarEmpleado(int idEmpleado)
        {
            return emple.BuscarEmpleado(idEmpleado);
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            emple.EliminarEmpleado(idEmpleado);
        }

        public void InsertarEmpleado(Empleado empleado)
        {
            emple.InsertarEmpleado(empleado);
        }

        public List<Empleado> ListarEmpleados()
        {
            return emple.ListarEmpleados();
        }
    }
}
