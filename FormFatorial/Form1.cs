using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numero;

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (textBoxFatorial.Text.Equals("") == false)
            {
                numero = int.Parse(textBoxFatorial.Text);
            }
            int f = CalcFatorial(numero);
            lblResultado.Text = "O resultado fatorial de " + numero + " é " + f.ToString();
        }

        public int CalcFatorial(int parametro)
        {
            int fatorial = 1;

            for (int i = 1; i <= parametro; i++)
            {
                fatorial = fatorial * i;
            }
            return fatorial;
        }
    }
}
