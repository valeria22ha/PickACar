using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DATOS
{
    public class Vehiculo
    {
        [AutoIncrement]
        public int IDVe { get; set; }
        public int IDMarca { get; set; }
        public int IDMecanico { get; set; }
        public int IDProveedor { get; set; }
        public int Precio { get; set; }
        public int IDCombustible { get; set; }
        public int IDNumeroPuertas { get; set; }
        public int IDTransmicion { get; set; }
        public int IDTraccion { get; set; }
    }
}
