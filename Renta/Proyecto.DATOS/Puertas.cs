using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DATOS
{
    public class Puertas
    {
        [AutoIncrement]
        public int ID { get; set; }
        public int NumeroPuerta { get; set; }
    }
}
