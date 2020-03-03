using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BandoInteractive_CMS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{pageURL}/{id}/{controller}/{action}",
                defaults: new { pageURL = "HomePage", controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BandoInteractive_CMS.Controllers" }
            );
        }
    }
}
