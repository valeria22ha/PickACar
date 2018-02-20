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
        public string Combustible { get; set; }
        public int NumeroPuertas { get; set; }
        public string Transmicion { get; set; }
        public string Traccion { get; set; }
    }
}
