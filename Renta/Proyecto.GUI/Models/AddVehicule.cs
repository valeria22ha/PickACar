using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.GUI.Models
{
    public class AddVehicule
    {
        public string ID { get; set; }

        public Modelo Modelo { get; set; }
        public string VModelo { get; set; }
        public int SelectedModelo { get; set; }
        public List<Modelo> Modelos { get; set; }

        public string VMecanico { get; set; }
        public Mecanico Mecanico { get; set; }
        public int SelectedMecanico { get; set; }
        public List<Mecanico> Mecanicos { get; set; }

        public string VProveedor { get; set; }
        public Proveedor Proveedor { get; set; }
        public int SelectedProveedor { get; set; }
        public List<Proveedor> Proveedores { get; set; }

        public int Precio { get; set; }

    }
}
