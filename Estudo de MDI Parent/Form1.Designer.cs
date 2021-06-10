
namespace Estudo_de_MDI_Parent
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSubmenuComposto = new System.Windows.Forms.Panel();
            this.btnTempoComposto = new System.Windows.Forms.Button();
            this.btnTaxaComposto = new System.Windows.Forms.Button();
            this.btnCapitalComposto = new System.Windows.Forms.Button();
            this.btnJurosComposto = new System.Windows.Forms.Button();
            this.btnComposto = new System.Windows.Forms.Button();
            this.pnlSubmenuSimples = new System.Windows.Forms.Panel();
            this.btnTempoSimples = new System.Windows.Forms.Button();
            this.btnTaxaSimples = new System.Windows.Forms.Button();
            this.btnCapitalSimples = new System.Windows.Forms.Button();
            this.btnJurosSimples = new System.Windows.Forms.Button();
            this.btnSimples = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlSubmenuComposto.SuspendLayout();
            this.pnlSubmenuSimples.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.pnlSubmenuComposto);
            this.panel1.Controls.Add(this.btnComposto);
            this.panel1.Controls.Add(this.pnlSubmenuSimples);
            this.panel1.Controls.Add(this.btnSimples);
            this.panel1.Controls.Add(this.pnlLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 596);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlSubmenuComposto
            // 
            this.pnlSubmenuComposto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(3)))), ((int)(((byte)(58)))));
            this.pnlSubmenuComposto.Controls.Add(this.btnTempoComposto);
            this.pnlSubmenuComposto.Controls.Add(this.btnTaxaComposto);
            this.pnlSubmenuComposto.Controls.Add(this.btnCapitalComposto);
            this.pnlSubmenuComposto.Controls.Add(this.btnJurosComposto);
            this.pnlSubmenuComposto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuComposto.Location = new System.Drawing.Point(0, 363);
            this.pnlSubmenuComposto.Name = "pnlSubmenuComposto";
            this.pnlSubmenuComposto.Size = new System.Drawing.Size(200, 170);
            this.pnlSubmenuComposto.TabIndex = 3;
            // 
            // btnTempoComposto
            // 
            this.btnTempoComposto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTempoComposto.FlatAppearance.BorderSize = 0;
            this.btnTempoComposto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempoComposto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnTempoComposto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnTempoComposto.Location = new System.Drawing.Point(0, 120);
            this.btnTempoComposto.Name = "btnTempoComposto";
            this.btnTempoComposto.Size = new System.Drawing.Size(200, 40);
            this.btnTempoComposto.TabIndex = 3;
            this.btnTempoComposto.Text = "Calcular Tempo";
            this.btnTempoComposto.UseVisualStyleBackColor = true;
            this.btnTempoComposto.Click += new System.EventHandler(this.btnTempoComposto_Click);
            // 
            // btnTaxaComposto
            // 
            this.btnTaxaComposto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaxaComposto.FlatAppearance.BorderSize = 0;
            this.btnTaxaComposto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaxaComposto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnTaxaComposto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnTaxaComposto.Location = new System.Drawing.Point(0, 80);
            this.btnTaxaComposto.Name = "btnTaxaComposto";
            this.btnTaxaComposto.Size = new System.Drawing.Size(200, 40);
            this.btnTaxaComposto.TabIndex = 2;
            this.btnTaxaComposto.Text = "Calcular Taxa Unitária";
            this.btnTaxaComposto.UseVisualStyleBackColor = true;
            this.btnTaxaComposto.Click += new System.EventHandler(this.btnTaxaComposto_Click);
            // 
            // btnCapitalComposto
            // 
            this.btnCapitalComposto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCapitalComposto.FlatAppearance.BorderSize = 0;
            this.btnCapitalComposto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapitalComposto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnCapitalComposto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnCapitalComposto.Location = new System.Drawing.Point(0, 40);
            this.btnCapitalComposto.Name = "btnCapitalComposto";
            this.btnCapitalComposto.Size = new System.Drawing.Size(200, 40);
            this.btnCapitalComposto.TabIndex = 1;
            this.btnCapitalComposto.Text = "Calcular Capital";
            this.btnCapitalComposto.UseVisualStyleBackColor = true;
            this.btnCapitalComposto.Click += new System.EventHandler(this.btnCapitalComposto_Click);
            // 
            // btnJurosComposto
            // 
            this.btnJurosComposto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJurosComposto.FlatAppearance.BorderSize = 0;
            this.btnJurosComposto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJurosComposto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnJurosComposto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnJurosComposto.Location = new System.Drawing.Point(0, 0);
            this.btnJurosComposto.Name = "btnJurosComposto";
            this.btnJurosComposto.Size = new System.Drawing.Size(200, 40);
            this.btnJurosComposto.TabIndex = 0;
            this.btnJurosComposto.Text = "Calcular Juros";
            this.btnJurosComposto.UseVisualStyleBackColor = true;
            this.btnJurosComposto.Click += new System.EventHandler(this.btnJurosComposto_Click);
            // 
            // btnComposto
            // 
            this.btnComposto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComposto.FlatAppearance.BorderSize = 0;
            this.btnComposto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComposto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComposto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnComposto.Location = new System.Drawing.Point(0, 318);
            this.btnComposto.Name = "btnComposto";
            this.btnComposto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnComposto.Size = new System.Drawing.Size(200, 45);
            this.btnComposto.TabIndex = 2;
            this.btnComposto.Text = "Juros Compostos";
            this.btnComposto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComposto.UseVisualStyleBackColor = true;
            this.btnComposto.Click += new System.EventHandler(this.btnComposto_Click);
            // 
            // pnlSubmenuSimples
            // 
            this.pnlSubmenuSimples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(3)))), ((int)(((byte)(58)))));
            this.pnlSubmenuSimples.Controls.Add(this.btnTempoSimples);
            this.pnlSubmenuSimples.Controls.Add(this.btnTaxaSimples);
            this.pnlSubmenuSimples.Controls.Add(this.btnCapitalSimples);
            this.pnlSubmenuSimples.Controls.Add(this.btnJurosSimples);
            this.pnlSubmenuSimples.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuSimples.Location = new System.Drawing.Point(0, 145);
            this.pnlSubmenuSimples.Name = "pnlSubmenuSimples";
            this.pnlSubmenuSimples.Size = new System.Drawing.Size(200, 173);
            this.pnlSubmenuSimples.TabIndex = 1;
            // 
            // btnTempoSimples
            // 
            this.btnTempoSimples.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTempoSimples.FlatAppearance.BorderSize = 0;
            this.btnTempoSimples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempoSimples.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnTempoSimples.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnTempoSimples.Location = new System.Drawing.Point(0, 120);
            this.btnTempoSimples.Name = "btnTempoSimples";
            this.btnTempoSimples.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTempoSimples.Size = new System.Drawing.Size(200, 40);
            this.btnTempoSimples.TabIndex = 4;
            this.btnTempoSimples.Text = "Calcular Tempo";
            this.btnTempoSimples.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTempoSimples.UseVisualStyleBackColor = true;
            this.btnTempoSimples.Click += new System.EventHandler(this.btnTempoSimples_Click);
            // 
            // btnTaxaSimples
            // 
            this.btnTaxaSimples.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaxaSimples.FlatAppearance.BorderSize = 0;
            this.btnTaxaSimples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaxaSimples.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnTaxaSimples.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnTaxaSimples.Location = new System.Drawing.Point(0, 80);
            this.btnTaxaSimples.Name = "btnTaxaSimples";
            this.btnTaxaSimples.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTaxaSimples.Size = new System.Drawing.Size(200, 40);
            this.btnTaxaSimples.TabIndex = 3;
            this.btnTaxaSimples.Text = "Calcular Taxa Unitária";
            this.btnTaxaSimples.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaxaSimples.UseVisualStyleBackColor = true;
            this.btnTaxaSimples.Click += new System.EventHandler(this.btnTaxaSimples_Click);
            // 
            // btnCapitalSimples
            // 
            this.btnCapitalSimples.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCapitalSimples.FlatAppearance.BorderSize = 0;
            this.btnCapitalSimples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapitalSimples.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapitalSimples.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnCapitalSimples.Location = new System.Drawing.Point(0, 40);
            this.btnCapitalSimples.Name = "btnCapitalSimples";
            this.btnCapitalSimples.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCapitalSimples.Size = new System.Drawing.Size(200, 40);
            this.btnCapitalSimples.TabIndex = 2;
            this.btnCapitalSimples.Text = "Calcular Capital";
            this.btnCapitalSimples.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapitalSimples.UseVisualStyleBackColor = true;
            this.btnCapitalSimples.Click += new System.EventHandler(this.btnCapitalSimples_Click);
            // 
            // btnJurosSimples
            // 
            this.btnJurosSimples.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJurosSimples.FlatAppearance.BorderSize = 0;
            this.btnJurosSimples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJurosSimples.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJurosSimples.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnJurosSimples.Location = new System.Drawing.Point(0, 0);
            this.btnJurosSimples.Name = "btnJurosSimples";
            this.btnJurosSimples.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnJurosSimples.Size = new System.Drawing.Size(200, 40);
            this.btnJurosSimples.TabIndex = 1;
            this.btnJurosSimples.Text = "Calculo de Juros";
            this.btnJurosSimples.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJurosSimples.UseVisualStyleBackColor = true;
            this.btnJurosSimples.Click += new System.EventHandler(this.btnJurosSimples_Click);
            // 
            // btnSimples
            // 
            this.btnSimples.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSimples.FlatAppearance.BorderSize = 0;
            this.btnSimples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimples.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimples.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnSimples.Location = new System.Drawing.Point(0, 100);
            this.btnSimples.Name = "btnSimples";
            this.btnSimples.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSimples.Size = new System.Drawing.Size(200, 45);
            this.btnSimples.TabIndex = 0;
            this.btnSimples.Text = "Juros Simples";
            this.btnSimples.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimples.UseVisualStyleBackColor = true;
            this.btnSimples.Click += new System.EventHandler(this.btnSimples_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(1)))), ((int)(((byte)(19)))));
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(200, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(534, 596);
            this.pnlChildForm.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 596);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calculadora Financeira";
            this.panel1.ResumeLayout(false);
            this.pnlSubmenuComposto.ResumeLayout(false);
            this.pnlSubmenuSimples.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSubmenuSimples;
        private System.Windows.Forms.Button btnCapitalSimples;
        private System.Windows.Forms.Button btnJurosSimples;
        private System.Windows.Forms.Button btnSimples;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnTempoSimples;
        private System.Windows.Forms.Button btnTaxaSimples;
        private System.Windows.Forms.Panel pnlSubmenuComposto;
        private System.Windows.Forms.Button btnJurosComposto;
        private System.Windows.Forms.Button btnComposto;
        private System.Windows.Forms.Button btnTempoComposto;
        private System.Windows.Forms.Button btnTaxaComposto;
        private System.Windows.Forms.Button btnCapitalComposto;
        private System.Windows.Forms.Panel pnlChildForm;
    }
}

