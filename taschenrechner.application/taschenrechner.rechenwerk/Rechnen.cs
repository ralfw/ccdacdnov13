using System;

namespace taschenrechner.rechenwerk
{
    public class Rechnen
    {
        private int _altes_Ergebnis;
        private char _alter_op;

        public int Berechnen(char op, int aktuelle_Zahl)
        {
            var neues_Ergebnis = Operator_anwenden(_altes_Ergebnis, aktuelle_Zahl, _alter_op);
            Aktualisiere_altes_Zeug(op, neues_Ergebnis);
            return neues_Ergebnis;
        }


        private int Operator_anwenden(int altesErgebnis, int aktuelleZahl, char alterOp)
        {
            Console.WriteLine(alterOp);
            switch (alterOp)
            {
                case '+':
                    return altesErgebnis + aktuelleZahl;
                case '-':
                    return altesErgebnis - aktuelleZahl;
                case '*':
                    return altesErgebnis*aktuelleZahl;
                case '/':
                    return altesErgebnis/aktuelleZahl;
                default:
                    return aktuelleZahl;
            }
        }

        private void Aktualisiere_altes_Zeug(char op, int neues_Ergebnis)
        {
            _altes_Ergebnis = neues_Ergebnis;
            _alter_op = op;
        }
    }
}