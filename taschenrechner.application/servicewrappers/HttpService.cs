using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace servicewrappers
{
    public class HttpService : IDisposable
    {
        private readonly string _componentFilename;
        private readonly string _commandLineParams;
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


        public string Process(string process)
        {
            var request = (HttpWebRequest)WebRequest.Create(_endpoint);
            request.Method = "GET";
            request.ContentType = "text/html";
            throw new NotImplementedException();
        }


        public void Dispose()
        {
            _process.Close();
        }
    }
}
