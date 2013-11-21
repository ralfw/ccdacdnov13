using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace samplehttpservice
{
    class Program
    {
        static void Main(string[] args)
        {
            var nancyHost = new Nancy.Hosting.Self.NancyHost(new Uri("http://localhost:1234"));
            nancyHost.Start();

            Console.ReadLine();

            nancyHost.Stop();
        }


        public class ResourceModule : NancyModule
        {
            public ResourceModule()
            {
                Get["/ping/{value}"] = parameters => "pong:" + parameters.value;
            }
        }
    }
}
