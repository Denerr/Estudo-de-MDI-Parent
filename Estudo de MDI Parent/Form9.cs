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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double montante, capital, taxa, log1, log2, resultado;

            montante = Double.Parse(txtMontante.Text);
            capital = Double.Parse(txtCapital.Text);
            taxa = Double.Parse(txtTaxa.Text);

            taxa = taxa / 100;
            log1 = Math.Log(montante / capital);
            log2 = Math.Log(1 + taxa);

            resultado = log1 / log2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMontante.Text = "";
            txtCapital.Text = "";
            txtTaxa.Text = "";
            txtResultado.Text = "";
        }
    }
}
