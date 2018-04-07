using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Proyecto.GUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Admin",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "IndexAdmin", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Vehiculo",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Vehiculo", action = "Index", id = UrlParameter.Optional }
            );

            //Para Administrador

            routes.MapRoute(
                name: "Cliente",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Cliente", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Empleado",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Empleado", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Factura",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Factura", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Proveedor",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Proveedor", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Mecanico",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Mecanico", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
