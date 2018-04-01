using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiecto.GUI.App_Start
{
    public class AutoMapperConfig
    {
        public static void configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap< Proyecto.GUI.Models.Cliente, Proyecto.DATOS.Cliente>();
                cfg.CreateMap< Proyecto.DATOS.Cliente,  Proyecto.GUI.Models.Cliente>();

                cfg.CreateMap< Proyecto.GUI.Models.Combustible, Proyecto.DATOS.Combustible>();
                cfg.CreateMap< Proyecto.DATOS.Combustible, Proyecto.GUI.Models.Combustible>();

                cfg.CreateMap< Proyecto.GUI.Models.Empleado, Proyecto.DATOS.Empleado>();
                cfg.CreateMap< Proyecto.DATOS.Empleado,  Proyecto.GUI.Models.Empleado>();

                cfg.CreateMap< Proyecto.GUI.Models.Estilo, Proyecto.DATOS.Estilo>();
                cfg.CreateMap< Proyecto.DATOS.Estilo,  Proyecto.GUI.Models.Estilo>();

                cfg.CreateMap< Proyecto.GUI.Models.Factura, Proyecto.DATOS.Factura>();
                cfg.CreateMap< Proyecto.DATOS.Factura,  Proyecto.GUI.Models.Factura>();

                cfg.CreateMap< Proyecto.GUI.Models.LugarEntregaC, Proyecto.DATOS.LugarEntregaC>();
                cfg.CreateMap< Proyecto.DATOS.LugarEntregaC,  Proyecto.GUI.Models.LugarEntregaC>();

                cfg.CreateMap< Proyecto.GUI.Models.Marca, Proyecto.DATOS.Marca>();
                cfg.CreateMap< Proyecto.DATOS.Marca,  Proyecto.GUI.Models.Marca>();

                cfg.CreateMap< Proyecto.GUI.Models.Mecanico, Proyecto.DATOS.Mecanico>();
                cfg.CreateMap< Proyecto.DATOS.Mecanico,  Proyecto.GUI.Models.Mecanico>();

                cfg.CreateMap<Proyecto.GUI.Models.Modelo, Proyecto.DATOS.Modelo>();
                cfg.CreateMap<Proyecto.DATOS.Modelo, Proyecto.GUI.Models.Modelo>();

                cfg.CreateMap< Proyecto.GUI.Models.Proveedor, Proyecto.DATOS.Proveedor>();
                cfg.CreateMap< Proyecto.DATOS.Proveedor,  Proyecto.GUI.Models.Proveedor>();

                cfg.CreateMap< Proyecto.GUI.Models.Puertas, Proyecto.DATOS.Puertas>();
                cfg.CreateMap< Proyecto.DATOS.Puertas, Proyecto.GUI.Models.Puertas>();

                cfg.CreateMap< Proyecto.GUI.Models.Seguro, Proyecto.DATOS.Seguro>();
                cfg.CreateMap< Proyecto.DATOS.Seguro,  Proyecto.GUI.Models.Seguro>();

                cfg.CreateMap< Proyecto.GUI.Models.Traccion, Proyecto.DATOS.Traccion>();
                cfg.CreateMap< Proyecto.DATOS.Traccion,  Proyecto.GUI.Models.Traccion>();

                cfg.CreateMap< Proyecto.GUI.Models.Transmicion, Proyecto.DATOS.Transmicion>();
                cfg.CreateMap< Proyecto.DATOS.Transmicion, Proyecto.GUI.Models.Transmicion>();

                cfg.CreateMap< Proyecto.GUI.Models.Vehiculo, Proyecto.DATOS.Vehiculo>();
                cfg.CreateMap< Proyecto.DATOS.Vehiculo, Proyecto.GUI.Models.Vehiculo>();
            });
        }
    }
}