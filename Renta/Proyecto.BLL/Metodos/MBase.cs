using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BLL.Metodos
{
    public class MBase
    {
        public DAL.Interfaces.ICliente clie;
        public DAL.Interfaces.IEmpleado emple;
        public DAL.Interfaces.IFactura fact;
        public DAL.Interfaces.ILugarEntregaC luga;
        public DAL.Interfaces.IMarca marc;
        public DAL.Interfaces.IMecanico meca;
        public DAL.Interfaces.IProveedor prove;
        public DAL.Interfaces.IRenta rent;
        public DAL.Interfaces.ISeguro segu;
        public DAL.Interfaces.IVehiculo vehi;

        public MBase()
        {
            clie = new DAL.Metodos.MCliente();
            emple = new DAL.Metodos.MEmpleado();
            fact = new DAL.Metodos.MFactura();
            luga = new DAL.Metodos.MLugarEntregaC();
            marc = new DAL.Metodos.MMarca();
            meca = new DAL.Metodos.MMecanico();
            prove = new DAL.Metodos.MProveedor();
            rent = new DAL.Metodos.MRenta();
            segu = new DAL.Metodos.MSeguro();
            vehi = new DAL.Metodos.MVehiculo();
        }
    }
}
