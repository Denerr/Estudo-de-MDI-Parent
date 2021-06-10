
namespace Estudo_de_MDI_Parent
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCapital
            // 
            this.txtCapital.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.txtCapital.Location = new System.Drawing.Point(68, 173);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(174, 23);
            this.txtCapital.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira o Capital:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insira a Taxa Unitária:";
            // 
            // txtTaxa
            // 
            this.txtTaxa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.txtTaxa.Location = new System.Drawing.Point(68, 284);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(174, 23);
            this.txtTaxa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insira o Tempo:";
            // 
            // txtTempo
            // 
            this.txtTempo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.txtTempo.Location = new System.Drawing.Point(68, 415);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(174, 23);
            this.txtTempo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.txtResultado.Location = new System.Drawing.Point(315, 284);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(174, 23);
            this.txtResultado.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(315, 466);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(81, 33);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(408, 466);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 33);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(32, 34);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(81, 33);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 596);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCapital);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}