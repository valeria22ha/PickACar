using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.GUI.Models
{
    public class Renta
    {
        public int ID { get; set; }
        public string IDVehiculo { get; set; }
        public int IDLugar { get; set; }
        public int IDSeguro { get; set; }
        public int IDEmpleado { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaDevolucion { get; set; }
    }
}
