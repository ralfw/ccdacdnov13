using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taschenrechner.contracts
{
    public interface IUI
    {
        void Ergebnis_anzeigen(int ergebnis);

        event Action<char> Op_gedrückt;
        event Action<int> Ziffer_gedrückt;
    }
}
