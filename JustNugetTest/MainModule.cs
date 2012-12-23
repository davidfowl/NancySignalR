using Nancy;

namespace JustNugetTest
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = _ => "Hello, Nancy!";
        }
    }
}