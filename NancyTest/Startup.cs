﻿using Owin;

namespace WebApplication40
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapHubs("/signalr");

            app.UseNancy();
        }
    }
}