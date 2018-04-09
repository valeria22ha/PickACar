using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.GUI
{
    public class AutoMapperConfig
    {
        public static void configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap< Models.Cliente, DATOS.Cliente>();
                cfg.CreateMap<DATOS.Cliente, Models.Cliente>();

                cfg.CreateMap< Models.Combustible, DATOS.Combustible>();
                cfg.CreateMap<DATOS.Combustible, Models.Combustible>();

                cfg.CreateMap< Models.Empleado, DATOS.Empleado>();
                cfg.CreateMap<DATOS.Empleado, Models.Empleado>();

                cfg.CreateMap< Models.Estilo, DATOS.Estilo>();
                cfg.CreateMap<DATOS.Estilo, Models.Estilo>();

                cfg.CreateMap< Models.Factura, DATOS.Factura>();
                cfg.CreateMap<DATOS.Factura, Models.Factura>();

                cfg.CreateMap< Models.LugarEntregaC, DATOS.LugarEntregaC>();
                cfg.CreateMap<DATOS.LugarEntregaC, Models.LugarEntregaC>();

                cfg.CreateMap< Models.Marca, DATOS.Marca>();
                cfg.CreateMap<DATOS.Marca, Models.Marca>();

                cfg.CreateMap< Models.Mecanico, DATOS.Mecanico>();
                cfg.CreateMap<DATOS.Mecanico, Models.Mecanico>();

                cfg.CreateMap<Models.Modelo, DATOS.Modelo>();
                cfg.CreateMap<DATOS.Modelo, Models.Modelo>();

                cfg.CreateMap< Models.Proveedor, DATOS.Proveedor>();
                cfg.CreateMap<DATOS.Proveedor, Models.Proveedor>();

                cfg.CreateMap<Models.Puertas, DATOS.Puertas>();
                cfg.CreateMap<DATOS.Puertas, Models.Puertas>();

                cfg.CreateMap<Models.Seguro, DATOS.Seguro>();
                cfg.CreateMap<DATOS.Seguro, Models.Seguro>();

                cfg.CreateMap<Models.Traccion, DATOS.Traccion>();
                cfg.CreateMap<DATOS.Traccion, Models.Traccion>();

                cfg.CreateMap<Models.Transmicion, DATOS.Transmicion>();
                cfg.CreateMap<DATOS.Transmicion, Models.Transmicion>();

                cfg.CreateMap<Models.Vehiculo, DATOS.Vehiculo>();
                cfg.CreateMap<DATOS.Vehiculo, Models.Vehiculo>();

            });
        }
    }
}