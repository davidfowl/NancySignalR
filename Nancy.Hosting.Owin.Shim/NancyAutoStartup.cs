using System;
using Nancy.Hosting.Owin;
using Owin;

[assembly: OwinAutoStartup(Type = typeof(NancyAutoStartup), MethodName = "Configuration")]

internal class OwinAutoStartupAttribute : Attribute
{
    public Type Type { get; set; }
    public string MethodName { get; set; }
}

namespace Nancy.Hosting.Owin
{
    public class NancyAutoStartup
    {
        public void Configuration(IAppBuilder app)
        {
            if (SetNancyFlag(app))
            {
                app.UseNancy();
            }
        }

        internal static bool SetNancyFlag(IAppBuilder app)
        {
            object value;
            if (app.Properties.TryGetValue("nancy.Registered", out value))
            {
                return false;
            }

            app.Properties["nancy.Registered"] = null;
            return true;
        }
    }
}
