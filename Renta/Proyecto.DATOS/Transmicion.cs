using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DATOS
{
    public class Transmicion
    {
        [AutoIncrement]
        public int ID { get; set; }
        public string Descripcion { get; set; }
    }
}
