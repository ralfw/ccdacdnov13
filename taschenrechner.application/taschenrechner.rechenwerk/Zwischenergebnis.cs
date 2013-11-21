using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taschenrechner.rechenwerk
{
    public class Zwischenergebnis
    {
        private int _zwischenergebnis = 0;
        private bool _zurücksetzen = false;


        public int Wert
        {
            get { return _zwischenergebnis; }
            set { 
                 _zwischenergebnis = value;
                 _zurücksetzen = true;
            }
        }

        public int Ziffer_hinzufügen(int ziffer)
        {
            if (_zurücksetzen) _zwischenergebnis = 0;
            _zurücksetzen = false;
            _zwischenergebnis *= 10;
            _zwischenergebnis += ziffer;
            return _zwischenergebnis;
        }
    }
}
