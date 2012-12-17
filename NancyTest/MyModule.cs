using Nancy;

namespace WebApplication40
{
    public class MyModule : NancyModule
    {
        public MyModule()
        {
            Get["/test"] = _ => "Hello World!";
        }
    }
}