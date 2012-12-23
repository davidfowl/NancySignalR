using Microsoft.Owin.Host.SystemWeb;
using Nancy.Bootstrapper;
using Owin;

namespace System.Web.Routing
{
    public static class NancyRouteExtensions
    {
        public static void MapNancy(this RouteCollection routes)
        {
            routes.MapOwinRoute("nancy", String.Empty, app => app.UseNancy());
        }

        public static void MapNancy(this RouteCollection routes, INancyBootstrapper bootstrapper)
        {
            routes.MapOwinRoute("nancy", String.Empty, app => app.UseNancy(bootstrapper));
        }
    }
}