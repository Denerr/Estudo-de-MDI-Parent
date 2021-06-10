using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo_de_MDI_Parent
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double montante, capital, tempo, resultado, aux1, aux2, poten;

            montante = Double.Parse(txtMontante.Text);
            capital = Double.Parse(txtCapital.Text);
            tempo = Double.Parse(txtTempo.Text);

            aux1 = montante / capital;
            aux2 = 1 / tempo;
            poten = Math.Pow(aux1, aux2);

            resultado = poten - 1;
            txtResultado.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMontante.Text = "";
            txtCapital.Text = "";
            txtTempo.Text = "";
            txtResultado.Text = "";
        }

        private void btnPorcento_Click(object sender, EventArgs e)
        {
            double resultado, porcento;

            porcento = Double.Parse(txtResultado.Text);

            resultado = porcento * 100;
            txtResultado.Text = resultado.ToString("0.000") + "%";
        }
    }
}
