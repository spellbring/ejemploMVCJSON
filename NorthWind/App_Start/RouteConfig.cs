using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NorthWind
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
                name: "GetCategorias",
                url: "Home/Obtener",
                defaults: new { controller = "Home", action = "Obtener", id = UrlParameter.Optional }
            );

            //Rutas Mantenedor Categoría

            routes.MapRoute(
                   name: "Categorias",
                   url: "Categories",
                   defaults: new { controller = "Categories", action = "Index", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                   name: "ObtenerCategorias",
                   url: "Categories",
                   defaults: new { controller = "Categories", action = "Obtener", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                   name: "GuardarCategorias",
                   url: "Categories/Guardar",
                   defaults: new { controller = "Categories", action = "Guardar", id = UrlParameter.Optional }
               );
        }
    }
}