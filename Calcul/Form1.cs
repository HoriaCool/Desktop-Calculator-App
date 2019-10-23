using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
{

    public partial class Form1 : Form
    {
        char c = '+';
        double val = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Afisare_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cifra0_Click(object sender, EventArgs e)
        {
            if (Afisare.Text != "0")
                Afisare.Text += '0';
        }

        private void Cifra1_Click(object sender, EventArgs e)
        {
            if (Afisare.Text != "0")
                Afisare.Text += '1';
        }

        private void Cifra2_Click(object sender, EventArgs e)
        {
            if (Afisare.Text != "0")
                Afisare.Text += '2';
        }

        private void Cifra3_Click(object sender, EventArgs e)
        {
            if (Afisare.Text != "0")
                Afisare.Text += '3';
        }

        private void Cifra4_Click(object sender, EventArgs e)
        {
            if (Afisare.Text != "0")
                Afisare.Text += '4';
        }

        private void Cifra5_Click(object sender, EventArgs e)
        {
            if (Afisare.Text != "0")
                Afisare.Text += '5';
        }

        private void Cifra6_Click(object sender, EventArgs e)
        {
            if (Afisare.Text != "0")
                Afisare.Text += '6';
        }

        private void Cifra7_Click(object sender, EventArgs e)
        {
            if (Afisare.Text != "0")
                Afisare.Text += '7';
        }

        private void Cifra8_Click(object sender, EventArgs e)
        {
            if (Afisare.Text != "0")
                Afisare.Text += '8';
        }

        private void Cifra9_Click(object sender, EventArgs e)
        {
            if (Afisare.Text != "0")
                Afisare.Text += '9';
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (Afisare.Text != null)
            {
                if (c == '+')
                    val = val + double.Parse(Afisare.Text);
                if (c == '-')
                    val = val - double.Parse(Afisare.Text);
                if (c == '*')
                    val = val * double.Parse(Afisare.Text);
                if (c == '/')
                    val = val / double.Parse(Afisare.Text);
            }

            c = '+';
            Afisare.Text = null;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (Afisare.Text != null)
            {
                if (c == '+')
                    val = val + double.Parse(Afisare.Text);
                if (c == '-')
                    val = val - double.Parse(Afisare.Text);
                if (c == '*')
                    val = val * double.Parse(Afisare.Text);
                if (c == '/')
                    val = val / double.Parse(Afisare.Text);
            }

            c = '-';
            Afisare.Text = null;
        }

        private void Ori_Click(object sender, EventArgs e)
        { 
            if (Afisare.Text != null)
            {
                if (c == '+')
                    val = val + double.Parse(Afisare.Text);
                if (c == '-')
                    val = val - double.Parse(Afisare.Text);
                if (c == '*')
                    val = val * double.Parse(Afisare.Text);
                if (c == '/')
                    val = val / double.Parse(Afisare.Text);
            }

            c = '*';
            Afisare.Text = null;
        }

        private void Div_Click(object sender, EventArgs e)
        {
            if (Afisare.Text != null)
            {
                if (c == '+')
                    val = val + double.Parse(Afisare.Text);
                if (c == '-')
                    val = val - double.Parse(Afisare.Text);
                if (c == '*')
                    val = val * double.Parse(Afisare.Text);
                if (c == '/')
                    val = val / double.Parse(Afisare.Text);
            }
            c = '/';
            Afisare.Text = null;
        }

        private void Egal_Click(object sender, EventArgs e)
        {
            if (c == ' ')
            {
                Afisare.Text = null;
                c = '+';
                val = 0;
                return;
            }
            else
            {
                if (Afisare.Text != null)
                {
                    if (c == '+')
                        val = val + double.Parse(Afisare.Text);
                    if (c == '-')
                        val = val - double.Parse(Afisare.Text);
                    if (c == '*')
                        val = val * double.Parse(Afisare.Text);
                    if (c == '/')
                        val = val / double.Parse(Afisare.Text);
                }
                c = ' ';
                Afisare.Text = val.ToString();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Afisare.Text = null;
            c = '+';
            val = 0;
        }

        private void Opusul_Click(object sender, EventArgs e)
        {
            double aux;
            if (Afisare.Text != null)
            {
                aux = -double.Parse(Afisare.Text);
                Afisare.Text = aux.ToString();
            }
        }
    }
}
