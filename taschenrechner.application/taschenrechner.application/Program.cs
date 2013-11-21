using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using taschenrechner.contracts;
using ui.attrappe;

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

            IUI ui = new UI();
            var rewe = new RechenwerkProvider();

            ui.Op_gedrückt += op => {
                var ergebnis = rewe.Hier_Operator(op);
                ui.Ergebnis_anzeigen(ergebnis);
            };

            ui.Ziffer_gedrückt += ziffer =>
            {
                var ergebnis = rewe.Hier_Ziffer(ziffer);
                ui.Ergebnis_anzeigen(ergebnis);
            };

            Application.Run((Form)ui);
        }
    }
}
