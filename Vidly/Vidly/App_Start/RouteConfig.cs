using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();                                 //Agrega rutas por atributo (van encima de cada action)

            #region Routeo de la manera convencional
            /*routes.MapRoute(
                "MoviesByReleaseDate",                                      //Nombre
                "movies/released/{year}/{month}",                           //Url
                new { controller = "Movies", action = "ByReleaseDate" },    //Ruta por defecto
                new { year = @"2015|2016", month = @"\d{2}" }               //Restricciones de los parámetros
            );*/
            #endregion


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
