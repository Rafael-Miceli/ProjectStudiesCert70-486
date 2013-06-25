using System.Web.Mvc;
using System.Web.Routing;

namespace RafaelStudyMvcApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // /Condo/CondoName

            routes.MapRoute(
                name: "Condos",
                url: "Condo/{action}/{Name}",
                defaults: new {controller = "Condo", action = "Search", Name = UrlParameter.Optional});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}