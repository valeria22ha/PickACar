using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DATOS
{
    public class LugarEntregaC
    {
        [AutoIncrement]
        public int IDLu { get; set; }
        public string LugarEntrega { get; set; }
        public string LugarSalida { get; set; }
    }
}
