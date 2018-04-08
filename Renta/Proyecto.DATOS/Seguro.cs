using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DATOS
{
    public class Seguro
    {
        [AutoIncrement]
        public int ID { get; set; }
        public string Tipo { get; set; }
        public int Precio { get; set; }
    }
}
