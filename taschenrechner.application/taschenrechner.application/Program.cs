using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using taschenrechner.contracts;
using taschenrechner.rechenwerk;

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
            
            //Integriere_mit_Java_Service(gui);

            Integriere_mit_CS_Bibliothek(gui);

            Application.Run((Form)gui);
        }


        private static void Integriere_mit_CS_Bibliothek(IUI gui)
        {
            var integration = new Taschenrechner();
            gui.Ziffer_gedrückt += integration.Ziffer_verarbeiten;
            integration.Ergebnis += gui.Ergebnis_anzeigen;

            gui.Op_gedrückt += integration.Operator_verarbeiten;
        }


        private static void Integriere_mit_Java_Service(IUI gui)
        {
            var rewe = new RechenwerkProvider();

            gui.Op_gedrückt += op => {
                var ergebnis = rewe.Hier_Operator(op);
                gui.Ergebnis_anzeigen(ergebnis);
            };

            gui.Ziffer_gedrückt += ziffer => {
                var ergebnis = rewe.Hier_Ziffer(ziffer);
                gui.Ergebnis_anzeigen(ergebnis);
            };
        }
    }
}
