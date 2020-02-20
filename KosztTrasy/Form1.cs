using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KosztTrasy
{
    public partial class Form1 : Form
    {
        double ilośćPaliwa;
        double koszt;
        public Form1()
        {
            InitializeComponent();
        }

        public void Wynik_Click(object sender, EventArgs e)
        {
            try
            {
                string trasa = dlugoscTrasy.Text;

                ilośćPaliwa = (double.Parse(dlugoscTrasy.Text) / 100 * double.Parse(srednieSpalanie.Text));

                koszt = ilośćPaliwa * double.Parse(cena.Text);

                answer.Text = "By przejechać " + trasa + " km potrzebujesz " + String.Format("{0:N2}", ilośćPaliwa) + " litrów paliwa.\n Koszt przejechania podanej trasy wyniesie zatem:\n" + String.Format("{0:N2}",koszt) + " zł.";
            }
            catch (Exception)
            {
                answer.Text = "Wprowadź poprawne dane";

            }
        }

        private void dlugoscTrasyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true ;
                SelectNextControl(dlugoscTrasy, true, true, true, true);
            }
        }

        private void srednieSpalanieEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(srednieSpalanie, true, true, true, true);
            }
        }

        private void cenaEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(cena, true, true, true, true);
            }
        }
    }
}
