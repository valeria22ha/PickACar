using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.BLL.Interfaces
{
    public interface IVehiculo
    {
        List<Vehiculo> ListarVehiculos();

        Vehiculo BuscarVehiculo(int idVehiculo);

        void InsertarVehiculo(Vehiculo vehiculo);

        void ActualizarVehiculo(Vehiculo vehiculo);

        void EliminarVehiculo(int idVehiculo);
    }
}
