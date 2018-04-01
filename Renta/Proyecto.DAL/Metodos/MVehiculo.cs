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
    public class MVehiculo : MBase, IVehiculo
    {
        public void ActualizarVehiculo(Vehiculo vehiculo)
        {
            _db.Update(vehiculo);
        }

        public Vehiculo BuscarVehiculo(string idVehiculo)
        {
            return _db.Select<Vehiculo>(x => x.ID == idVehiculo)
                .FirstOrDefault();
        }

        public void EliminarVehiculo(string idVehiculo)
        {
            _db.Delete<Vehiculo>(x => x.ID == idVehiculo);
        }

        public void InsertarVehiculo(Vehiculo vehiculo)
        {
            _db.Insert(vehiculo);
        }

        public List<Vehiculo> ListarVehiculos()
        {
            return _db.Select<Vehiculo>();
        }
    }
}
