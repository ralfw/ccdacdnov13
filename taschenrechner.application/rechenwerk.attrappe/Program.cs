using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rechenwerk.attrappe
{
    class Program
    {
        static void Main(string[] args)
        {
            int ziffer;
            if (int.TryParse(args[0], out ziffer))
                Console.Write(ziffer*10);
            else
                Console.Write(ASCIIEncoding.ASCII.GetBytes(args[0])[0]);
        }
    }
}
