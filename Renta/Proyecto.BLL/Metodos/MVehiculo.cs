using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DATOS;
using Proyecto.BLL.Interfaces;

namespace Proyecto.BLL.Metodos
{
    public class MVehiculo : IVehiculo
    {
        public DAL.Interfaces.IVehiculo vehi;
        public MVehiculo()
        {
            vehi = new DAL.Metodos.MVehiculo();
        }
        public void ActualizarVehiculo(Vehiculo vehiculo)
        {
            vehi.ActualizarVehiculo(vehiculo);
        }

        public Vehiculo BuscarVehiculo(string idVehiculo)
        {
            return vehi.BuscarVehiculo(idVehiculo);
        }

        public void EliminarVehiculo(string idVehiculo)
        {
            vehi.EliminarVehiculo(idVehiculo);
        }

        public void InsertarVehiculo(Vehiculo vehiculo)
        {
            vehi.InsertarVehiculo(vehiculo);
        }

        public List<Vehiculo> ListarVehiculos()
        {
            return vehi.ListarVehiculos();
        }
    }
}
