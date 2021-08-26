using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weiss_Jessica_Millionenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnausrechnen_Click(object sender, EventArgs e)
        {
            //Defaultwerte
            txtBoxZins.BackColor = Color.White;
            txtBoxKapital.BackColor = Color.White;

            //Variabel definieren
            double Kapital = 0;
            double Zins = 0;
            double Grenze = 1000000;
            int Jahre = 0;

            //Eingabekontrolle
            if (double.TryParse(txtBoxKapital.Text, out Kapital) == false)
            {
                txtBoxKapital.BackColor = Color.Red;
                txtBoxKapital.Focus();
                txtBoxKapital.Text = "";
                lblErgebnis.Text = "Bitte geben Sie einen korrekten Wert ein.";
                return;
            }

            if (double.TryParse(txtBoxZins.Text, out Zins) == false)
            {
                txtBoxZins.BackColor = Color.Red;
                txtBoxZins.Focus();
                txtBoxZins.Text = "";
                lblErgebnis.Text = "Bitte geben Sie einen korrekten Wert ein.";
                return;
            }

            //Rechnung
            while (Kapital <= Grenze)
            {
                Jahre++;
                Kapital = Berechnungen.zinsberechnung(Kapital, Zins);

            }

            lblErgebnis.Text = "Es dauert " + Jahre + " Jahre bis CHF 1Mio erreicht werden.";

        }
    }
}
