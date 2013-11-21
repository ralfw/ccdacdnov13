using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using taschenrechner.contracts;

namespace taschenrechner.application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IUI gui = new UI.Gui();
            var rewe = new RechenwerkProvider();

            gui.Op_gedrückt += op => {
                var ergebnis = rewe.Hier_Operator(op);
                Console.WriteLine(op);
                gui.Ergebnis_anzeigen(ergebnis);
            };

            gui.Ziffer_gedrückt += ziffer =>
            {
                var ergebnis = rewe.Hier_Ziffer(ziffer);
                gui.Ergebnis_anzeigen(ergebnis);
            };

            Application.Run((Form)gui);
        }
    }
}
