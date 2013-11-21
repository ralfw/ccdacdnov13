using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using taschenrechner.contracts;

namespace ui.attrappe
{
    public partial class UI : Form, IUI
    {
        public UI()
        {
            InitializeComponent();
        }



        public void Ergebnis_anzeigen(int ergebnis)
        {
            lblErgebnis.Text = ergebnis.ToString();
        }

        public event Action<char> Op_gedrückt;
        public event Action<int> Ziffer_gedrückt;



        private void btnZiffer_Click(object sender, EventArgs e)
        {
            Ziffer_gedrückt(int.Parse(txtZiffer.Text));
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            Op_gedrückt(txtOp.Text[0]);
        }
    }
}
