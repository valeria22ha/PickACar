using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DATOS
{
    public class Estilo
    {
        [AutoIncrement]
        public int IdEs { get; set; }
        public string tipoEstilo { get; set; }
    }
}
