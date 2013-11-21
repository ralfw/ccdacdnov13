using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Nancy;

namespace samplehttpservice
{
    class Program
    {
        public static AutoResetEvent __exit;


        static void Main(string[] args)
        {
            __exit = new AutoResetEvent(false);

            var nancyHost = new Nancy.Hosting.Self.NancyHost(new Uri("http://localhost:1234"));
            nancyHost.Start();

            Console.WriteLine("Serving...");
            __exit.WaitOne();

            nancyHost.Stop();
        }
    }

    public class HttpService : NancyModule
    {
        public HttpService()
        {
            Get["/hello"] = _ => "world";
            Get["/ping/{value}"] = parameters => "pong:" + parameters.value;
            Get["/close"] = _ =>
                {
                    Program.__exit.Set();
                    return "ack";
                };
        }
    }
}
