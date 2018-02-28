using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.DAL.Interfaces;
using System.Data;
using Lec03.DAL.Metodos;
using ServiceStack.OrmLite;

namespace Proyecto.DAL.Metodos
{
    public class MEmpleado : MBase, IEmpleado
    {
        public void ActualizarEmpleado(Empleado empleado)
        {
            _db.Update(empleado);
        }

        public Empleado BuscarEmpleado(int idEmpleado)
        {
            return _db.Select<Empleado>(x => x.Cedula == idEmpleado)
                 .FirstOrDefault();
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            _db.Delete<Empleado>(x => x.Cedula == idEmpleado);
        }

        public void InsertarEmpleado(Empleado empleado)
        {
            _db.Insert(empleado);
        }

        public List<Empleado> ListarEmpleados()
        {
            return _db.Select<Empleado>();
        }
    }
}
