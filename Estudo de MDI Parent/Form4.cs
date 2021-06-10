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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double juros, capital, tempo, aux, resultado;

            juros = Double.Parse(txtJuros.Text);
            capital = Double.Parse(txtCapital.Text);
            tempo = Double.Parse(txtTempo.Text);
            aux = capital * tempo;
            resultado = juros / aux;

            txtResultado.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCapital.Text = "";
            txtJuros.Text = "";
            txtTempo.Text = "";
            txtResultado.Text = "";
        }

        private void btnPorcento_Click(object sender, EventArgs e)
        {
            double porcentagem, resultado;

            porcentagem = Double.Parse(txtResultado.Text);

            resultado = porcentagem * 100;
            txtResultado.Text = resultado.ToString()+"%";
        }
    }
}
