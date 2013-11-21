using System;

namespace taschenrechner.rechenwerk
{
    public class Taschenrechner
    {
        private Zwischenergebnis _zwischenspeicher = new Zwischenergebnis();
        private Rechnen _rechnen = new Rechnen();


        public void Ziffer_verarbeiten(int ziffer)
        {
            var zahl = _zwischenspeicher.Ziffer_hinzufügen(ziffer);
            Ergebnis(zahl);
        }

        public void Operator_verarbeiten(char op)
        {
            var neuer_Wert = _rechnen.Berechnen(op, _zwischenspeicher.Wert);
            _zwischenspeicher.Wert = neuer_Wert;
            Ergebnis(neuer_Wert);
        }

        public event Action<int> Ergebnis;
    }
}