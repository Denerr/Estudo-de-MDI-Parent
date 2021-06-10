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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double capital, taxa, tempo, resultado, aux, poten;

            capital = Double.Parse(txtCapital.Text);
            taxa = Double.Parse(txtTaxa.Text);
            tempo = Double.Parse(txtTempo.Text);

            taxa = taxa / 100;
            aux = 1 + taxa;
            poten = Math.Pow(aux, tempo);

            resultado = capital * poten;
            txtResultado.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCapital.Text = "";
            txtTaxa.Text = "";
            txtTempo.Text = "";
            txtResultado.Text = "";
        }
    }
}
