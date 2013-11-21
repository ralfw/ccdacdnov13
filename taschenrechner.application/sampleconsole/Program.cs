using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                if (input != "") input += "\n";
                input += line;
            }

            Console.Write("<<<{0}>>>", input.ToUpper());
        }
    }
}
