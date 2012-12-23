using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nancy.Bootstrapper;

namespace Nancy.Hosting.Owin
{
    public class NancyMiddleware
    {
        private readonly Func<IDictionary<string, object>, Task> _next;
        private readonly NancyOwinHost _owinHost;

        public NancyMiddleware(Func<IDictionary<string, object>, Task> next)
        {
            _next = next;
            _owinHost = new NancyOwinHost();
        }

        public NancyMiddleware(Func<IDictionary<string, object>, Task> next, INancyBootstrapper bootstrapper)
        {
            _next = next;
            _owinHost = new NancyOwinHost(bootstrapper);
        }

        public Task Invoke(IDictionary<string, object> env)
        {
            return _owinHost.ProcessRequest(env);
        }
    }
}