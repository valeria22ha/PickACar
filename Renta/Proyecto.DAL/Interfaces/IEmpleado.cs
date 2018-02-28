using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.DAL.Interfaces
{
    public interface IEmpleado
    {
        List<Empleado> ListarEmpleados();

        Empleado BuscarEmpleado(int idEmpleado);

        void InsertarEmpleado(Empleado empleado);

        void ActualizarEmpleado(Empleado empleado);

        void EliminarEmpleado(int idEmpleado);
    }
}
