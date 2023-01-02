using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());          //Configura la aplicación para requerir autorización en todos lados
            filters.Add(new RequireHttpsAttribute());       //Configura la aplicación para requerir una conexion https
        }
    }
}
