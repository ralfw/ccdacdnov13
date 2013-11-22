using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace servicewrappers
{
    public class HttpService : IDisposable
    {
        private readonly Uri _endpoint;

        private readonly Process _process;


        public HttpService(string componentFilename, string commandLineParams, Uri endpoint)
        {
            _endpoint = endpoint;

            var _pinfo = new ProcessStartInfo(componentFilename, commandLineParams)
            {
                UseShellExecute = false,
                CreateNoWindow = true
            };

            _process = new Process { StartInfo = _pinfo };
            _process.Start();
        }


        public string Process(string input)
        {
            var http = (HttpWebRequest)WebRequest.Create(_endpoint);
            http.Method = "POST";

            var inputBytes = Encoding.UTF8.GetBytes(input);
            http.ContentLength = inputBytes.Length;

            using (var req = http.GetRequestStream())
            {
                req.Write(inputBytes,0,inputBytes.Length);
            }

            using (var resp = new StreamReader(http.GetResponse().GetResponseStream(), Encoding.UTF8))
            {
                return resp.ReadToEnd();
            }
        }


        public void Dispose()
        {
            _process.Kill();
        }
    }
}
