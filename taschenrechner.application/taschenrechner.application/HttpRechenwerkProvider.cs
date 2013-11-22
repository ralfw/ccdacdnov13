using System;
using servicewrappers;

namespace taschenrechner.application
{
    class HttpRechenwerkProvider : IDisposable
    {
        private readonly HttpService _service;

        public HttpRechenwerkProvider()
        {
            _service = new HttpService("taschenrechner.rechenwerk.httpservice.exe", "", new Uri("http://localhost:1234"));    
        }

        public int Hier_Ziffer(int ziffer)
        {
            var ergebnis = _service.Process(ziffer.ToString());
            return int.Parse(ergebnis);
        }

        public int Hier_Operator(char op)
        {
            var ergebnis = _service.Process(op.ToString());
            return int.Parse(ergebnis);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}