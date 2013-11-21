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
            ergebnis = Strip_commandline(ergebnis.Trim());
            return int.Parse(ergebnis.Trim());
        }

        public int Hier_Operator(char op)
        {
            var service = new ConsoleService("rechenwerk.bat", "\"" + op.ToString() + "\"");
            var ergebnis = service.Process("");
            ergebnis = Strip_commandline(ergebnis.Trim());
            return int.Parse(ergebnis.Trim());
        }


        string Strip_commandline(string consoleOutput)
        {
            if (!consoleOutput.StartsWith("C:")) return consoleOutput;

            var eolIndex = consoleOutput.IndexOf("\n");
            return consoleOutput.Substring(eolIndex + 1);
        }
    }
}