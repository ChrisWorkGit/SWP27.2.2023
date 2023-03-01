using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funktionen; //

namespace Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_Addieren_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_zahl1.Text);
            double b = Convert.ToDouble(txt_Zahl2.Text);
            // double s = Funktionen.Math2.add(a, b);   ohne using 
            double s = Math2.add(a, b);  // mit using
            txt_Summe.Text = s.ToString();
        }

        private void cmd_Schreiben_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_zahl1.Text);
            shz_test.betrag = a;
        }

        private void cmd_Lesen_Click(object sender, EventArgs e)
        {
            txt_Zahl2.Text = shz_test.betrag.ToString();
        }

      
    }
}
