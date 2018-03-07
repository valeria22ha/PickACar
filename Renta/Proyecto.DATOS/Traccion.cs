using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DATOS
{
   public class Traccion
    {
        [AutoIncrement]
        public int IDTrac { get; set; }
        public string Descripcion { get; set; }
    }
}
