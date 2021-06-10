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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomDesign();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomDesign()
        {
            pnlSubmenuSimples.Visible = false;
            pnlSubmenuComposto.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlSubmenuSimples.Visible == true)
                pnlSubmenuSimples.Visible = false;
            if (pnlSubmenuComposto.Visible == true)
                pnlSubmenuComposto.Visible = false;
        }

        private void showSubMenu(Panel Submenu)
        {
            if(Submenu.Visible == false)
            {
                hideSubMenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }

        }

        private void btnSimples_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubmenuSimples);
        }

        private void btnJurosSimples_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Form2());
            //...
            //Codigo aqui
            //..
            //Deixar o hideSubmenu() sempre em ultimo;
            hideSubMenu();
        }

        private void btnCapitalSimples_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Form3());
            //...
            //Codigo aqui
            //..
            //Deixar o hideSubmenu() sempre em ultimo;
            hideSubMenu();
        }

        private void btnTaxaSimples_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Form4());
            //...
            //Codigo aqui
            //..
            //Deixar o hideSubmenu() sempre em ultimo;
            hideSubMenu();
        }

        private void btnTempoSimples_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Form5());
            //...
            //Codigo aqui;
            //..
            //Deixar o hideSubmenu() sempre em ultimo;
            hideSubMenu();
        }

        private void btnComposto_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubmenuComposto);
        }

        private void btnJurosComposto_Click(object sender, EventArgs e)
        {
            //...
            //Codigo aqui;
            //..
            //Deixar o hideSubmenu() sempre em ultimo;
            hideSubMenu();
        }

        private void btnCapitalComposto_Click(object sender, EventArgs e)
        {
            //...
            //Codigo aqui;
            //..
            //Deixar o hideSubmenu() sempre em ultimo;
            hideSubMenu();
        }

        private void btnTaxaComposto_Click(object sender, EventArgs e)
        {
            //...
            //Codigo aqui;
            //..
            //Deixar o hideSubmenu() sempre em ultimo;
            hideSubMenu();
        }

        private void btnTempoComposto_Click(object sender, EventArgs e)
        {
            //...
            //Codigo aqui;
            //..
            //Deixar o hideSubmenu() sempre em ultimo;
            hideSubMenu();
        }

        private Form formAtivo = null;
        private void abrirChildForm(Form childForm)
        {
            if (formAtivo != null)
                formAtivo.Close();
            formAtivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.Show();
        }
    }
}
