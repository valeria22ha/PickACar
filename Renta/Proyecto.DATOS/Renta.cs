using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DATOS
{
    public class Renta
    {
        [AutoIncrement]
        public int IDRe { get; set; }
        public int IDVehiculo { get; set; }
        public int IDLugar { get; set; }
        public int IDSeguro { get; set; }
        public int IDEmpleado { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime fecha { get; set; }

    }
}
