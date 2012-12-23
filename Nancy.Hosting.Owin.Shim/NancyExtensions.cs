using Nancy.Bootstrapper;
using Nancy.Hosting.Owin;

namespace Owin
{
    public static class NancyExtensions
    {
        public static void UseNancy(this IAppBuilder app)
        {
            NancyAutoStartup.SetNancyFlag(app);
            app.Use(typeof(NancyMiddleware));
        }

        public static void UseNancy(this IAppBuilder app, INancyBootstrapper bootstrapper)
        {
            NancyAutoStartup.SetNancyFlag(app);
            app.Use(typeof(NancyMiddleware), bootstrapper);
        }
    }
}