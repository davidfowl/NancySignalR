using Microsoft.Owin.Host.SystemWeb;
using Nancy;
using Nancy.Bootstrapper;
using Owin;

namespace System.Web.Routing
{
    public static class NancyRouteExtensions
    {
        public static void MapNancy(this RouteCollection routes)
        {
            MapNancy(routes, new DefaultNancyBootstrapper());
        }

        public static void MapNancy(this RouteCollection routes, INancyBootstrapper bootstrapper)
        {
            routes.MapOwinRoute("nancy", String.Empty, app => app.UseNancy(bootstrapper));
        }
    }
}