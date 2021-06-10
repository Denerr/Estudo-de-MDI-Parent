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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double juros, capital, taxa, resultado;

            juros = Double.Parse(txtJuros.Text);
            capital = Double.Parse(txtCapital.Text);
            taxa = Double.Parse(txtTaxa.Text);

            taxa = taxa / 100;

            resultado = juros / (capital * taxa);
            txtResultado.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtJuros.Text = "";
            txtCapital.Text = "";
            txtTaxa.Text = "";
            txtResultado.Text = "";
        }
    }
}
