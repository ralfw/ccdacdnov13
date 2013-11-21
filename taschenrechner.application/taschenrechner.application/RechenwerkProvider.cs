using System;
using servicewrappers;

namespace taschenrechner.application
{
    class RechenwerkProvider
    {
        public int Hier_Ziffer(int ziffer)
        {
            var service = new ConsoleService("rechenwerk.bat", ziffer.ToString());
            var ergebnis = service.Process("");
            return int.Parse(ergebnis);
        }

        public int Hier_Operator(char op)
        {
            var service = new ConsoleService("rechenwerk.bat", "\"" + op.ToString() + "\"");
            var ergebnis = service.Process("");
            return int.Parse(ergebnis);
        }
    }
}