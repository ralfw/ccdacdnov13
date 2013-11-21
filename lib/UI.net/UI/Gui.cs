using System;
using System.Windows.Forms;

namespace UI
    {
    public partial class Gui : Form, taschenrechner.contracts.IUI
        {
        public Gui()
            {
            InitializeComponent();
            }

        public void Ergebnis_anzeigen(int ergebnis)
            {
            NumberDisplay.Text = ergebnis.ToString();
            }

        public event Action<char> Op_gedrückt;
        public event Action<int> Ziffer_gedrückt;

        public void OnZiffer_gedrückt(int Ziffer)
            {
            Action<int> Tmp = Ziffer_gedrückt;
            if (Tmp != null) { Tmp(Ziffer); }
            }

        public void OnOp_gedrückt(char Operand)
            {
            Action<char> Tmp = Op_gedrückt;
            if (Tmp != null) { Tmp(Operand); }
            }

        private void db7_Click(object sender, EventArgs e)
            {
            OnZiffer_gedrückt(7);
            }

        private void db8_Click(object sender, EventArgs e)
            {
            OnZiffer_gedrückt(8);
            }

        private void db9_Click(object sender, EventArgs e)
            {
            OnZiffer_gedrückt(9);
            }

        private void db4_Click(object sender, EventArgs e)
            {
            OnZiffer_gedrückt(4);
            }

        private void db5_Click(object sender, EventArgs e)
            {
            OnZiffer_gedrückt(5);
            }

        private void db6_Click(object sender, EventArgs e)
            {
            OnZiffer_gedrückt(6);
            }

        private void db1_Click(object sender, EventArgs e)
            {
            OnZiffer_gedrückt(1);
            }

        private void db2_Click(object sender, EventArgs e)
            {
            OnZiffer_gedrückt(2);
            }

        private void db3_Click(object sender, EventArgs e)
            {
            OnZiffer_gedrückt(3);
            }

        private void db0_Click(object sender, EventArgs e)
            {
            OnZiffer_gedrückt(0);
            }

        private void opplus_Click(object sender, EventArgs e)
            {
            OnOp_gedrückt('+');
            }

        private void opminus_Click(object sender, EventArgs e)
            {
            OnOp_gedrückt('-');
            }

        private void opmal_Click(object sender, EventArgs e)
            {
            OnOp_gedrückt('*');
            }

        private void opdurch_Click(object sender, EventArgs e)
            {
            OnOp_gedrückt('/');
            }

        private void opgleich_Click(object sender, EventArgs e)
            {
            OnOp_gedrückt('=');
            }
        }
    }
