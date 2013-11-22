using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Nancy;

namespace taschenrechner.rechenwerk.httpservice
{
    class Program
    {
        static void Main(string[] args)
        {
            var nancyHost = new Nancy.Hosting.Self.NancyHost(new Uri("http://localhost:1234"));
            nancyHost.Start();

            Console.WriteLine("Serving... - until being killed");
            Console.ReadLine();

            nancyHost.Stop();
        }
    }

    public class HttpService : NancyModule
    {
        private static Taschenrechner _taschenrechner;
        private static int _ergebnis;


        public HttpService()
        {
            if (_taschenrechner == null)
            {
                _taschenrechner = new Taschenrechner();
                _taschenrechner.Ergebnis += _ => _ergebnis = _;
                // Keine schöne Lösung, in einem Webservice mit einem Event zu arbeiten.
                // Aber ich lasse den API des Taschenrechners mal so.
                // So ist er ein mahnendes Beispiel dafür, dass man APIs nicht völlig unabhängig von Technologien definieren kann.
            }

            Post["/"] = _ =>
            {
                var sr = new StreamReader(Request.Body, Encoding.UTF8);
                var text = sr.ReadToEnd();

                int ziffer;
                if (int.TryParse(text, out ziffer))
                    _taschenrechner.Ziffer_verarbeiten(ziffer);
                else
                    _taschenrechner.Operator_verarbeiten(text[0]);

                return Response.AsText(_ergebnis.ToString());
            };
        }
    }
}
