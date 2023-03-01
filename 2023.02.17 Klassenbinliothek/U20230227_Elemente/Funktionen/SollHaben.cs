using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funktionen
{
    public partial class SollHaben : UserControl
    {
        public SollHaben()
        {
            InitializeComponent();
        }

        private double _betrag;
        public double betrag
        {
            get
            {
                return _betrag;
            }
            set
            {
                _betrag = value;
                txtHaben.Clear();
                txtSoll.Clear();
                if(_betrag>=0)
                {
                    txtSoll.Text = _betrag.ToString();
                }
                else
                {
                    txtHaben.Text = (-_betrag).ToString();
                }
            }
        }

        private void txtSoll_KeyUp(object sender, KeyEventArgs e)
        {

            //try // ohne e.keyChar
            //{
            //    Convert.ToDouble(txtSoll.Text);
            //}
            //catch
            //{
            //    txtSoll.Clear();
            //    return;

            //}
            if (txtSoll.Text.Length > 0)
            {


                _betrag = Convert.ToDouble(txtSoll.Text);
                txtHaben.Clear();
            }
        }

        private void txtHaben_KeyUp(object sender, KeyEventArgs e)
        {
            //try ohne e.keyChar
            //{
            //    Convert.ToDouble(txtHaben.Text);
            //}
            //catch
            //{
            //    txtHaben.Clear();
            //    return;

            //}

            if (txtHaben.Text.Length > 0)
            {
                _betrag = -Convert.ToDouble(txtHaben.Text);
                txtSoll.Clear();
            }
        }

        private void txtSoll_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <'0' || e.KeyChar >'9')&& e.KeyChar!= ','&& e.KeyChar !=(char)8)
            {
                e.Handled = true;
            }
        }

       
    }
}
