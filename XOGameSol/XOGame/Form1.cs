using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOGame
{
    public partial class Form1 : Form
    {
        int _brojac;
        string _pobjeda_text = "";

        public Form1()
        {
            InitializeComponent();
            _brojac = 1;
        }

        void Izmjeni(Control control)
        {
            if (_brojac % 2 == 0)
                control.Text = "X";
            else
                control.Text = "O";

            _brojac++;

            if (Rezultat())
            {
                MessageBox.Show($"Pobijedio je griac koji je koristio {_pobjeda_text}");
                Ponisti();
            }

        }

        private void Ponisti()
        {
            btn1.Text = string.Empty;
            btn2.Text = string.Empty;
            btn3.Text = string.Empty;
            btn4.Text = string.Empty;
            btn5.Text = string.Empty;
            btn6.Text = string.Empty;
            btn7.Text = string.Empty;
            bnt8.Text = string.Empty;
            btn9.Text = string.Empty;

            _brojac = 1;
            _pobjeda_text = string.Empty;

        }

        private bool Rezultat()
        {
            if (!string.IsNullOrEmpty(btn1.Text)
                && (string.Compare(btn1.Text, btn2.Text) == 0 && string.Compare(btn1.Text, btn3.Text) == 0))
            {
                _pobjeda_text = btn1.Text;
                return true;
            }
            else if (!string.IsNullOrEmpty(btn4.Text)
               && (string.Compare(btn4.Text, btn5.Text) == 0 && string.Compare(btn4.Text, btn6.Text) == 0))
            {
                _pobjeda_text = btn4.Text;
                return true;
            }
            else if (!string.IsNullOrEmpty(btn7.Text)
                && (string.Compare(btn7.Text, bnt8.Text) == 0 && string.Compare(btn7.Text, btn9.Text) == 0))
            {
                _pobjeda_text = btn7.Text;
                return true;
            }
            else if (!string.IsNullOrEmpty(btn1.Text)
                && (string.Compare(btn1.Text, btn4.Text) == 0 && string.Compare(btn1.Text, btn7.Text) == 0))
            {
                _pobjeda_text = btn1.Text;
                return true;
            }
            else if (!string.IsNullOrEmpty(btn2.Text)
                && (string.Compare(btn2.Text, btn5.Text) == 0 && string.Compare(btn2.Text, bnt8.Text) == 0))
            {
                _pobjeda_text = btn2.Text;
                return true;
            }
            else if (!string.IsNullOrEmpty(btn3.Text)
                && (string.Compare(btn3.Text, btn6.Text) == 0 && string.Compare(btn3.Text, btn9.Text) == 0))
            {
                _pobjeda_text = btn3.Text;
                return true;
            }
            else if (!string.IsNullOrEmpty(btn1.Text)
                && (string.Compare(btn1.Text, btn5.Text) == 0 && string.Compare(btn1.Text, btn9.Text) == 0))
            {
                _pobjeda_text = btn1.Text;
                return true;
            }
            else if (!string.IsNullOrEmpty(btn3.Text)
                && (string.Compare(btn3.Text, btn5.Text) == 0 && string.Compare(btn3.Text, btn7.Text) == 0))
            {
                _pobjeda_text = btn3.Text;
                return true;
            }

            return false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Izmjeni(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Izmjeni(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Izmjeni(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Izmjeni(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Izmjeni(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Izmjeni(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Izmjeni(btn7);
        }

        private void bnt8_Click(object sender, EventArgs e)
        {
            Izmjeni(bnt8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Izmjeni(btn9);
        }
    }
}
