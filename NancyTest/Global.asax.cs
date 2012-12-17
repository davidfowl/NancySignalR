using System;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;


namespace WebApplication40
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.MapHubs();

            RouteTable.Routes.MapNancy();
        }
    }
}