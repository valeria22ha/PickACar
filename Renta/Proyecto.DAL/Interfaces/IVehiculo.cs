using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;

namespace Proyecto.DAL.Interfaces
{
    public interface IVehiculo
    {
        List<Vehiculo> ListarVehiculos();

        Vehiculo BuscarVehiculo(string idVehiculo);

        void InsertarVehiculo(Vehiculo vehiculo);

        void ActualizarVehiculo(Vehiculo vehiculo);

        void EliminarVehiculo(string idVehiculo);
    }
}
