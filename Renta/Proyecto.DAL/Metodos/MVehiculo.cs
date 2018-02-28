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

        public Vehiculo BuscarVehiculo(int idVehiculo)
        {
            return _db.Select<Vehiculo>(x => x.IDVe == idVehiculo)
                .FirstOrDefault();
        }

        public void EliminarVehiculo(int idVehiculo)
        {
            _db.Delete<Vehiculo>(x => x.IDVe
            == idVehiculo);
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
