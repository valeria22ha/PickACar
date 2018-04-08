using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DATOS
{
    public class Modelo
    {
        [AutoIncrement]
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public int IDCombustible { get; set; }
        public int IDEstilo { get; set; }
        public int IDMarca { get; set; }
        public int IDNumeroPuertas { get; set; }
        public int IDTraccion { get; set; }
        public int IDTransmicion { get; set; }
    }
}
