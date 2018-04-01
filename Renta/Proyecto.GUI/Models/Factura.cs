using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.GUI.Models
{
    public class Factura
    {
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public DateTime FechaPago { get; set; }
        public int TotalPago { get; set; }
        public int IDRenta { get; set; }
    }
    
}
