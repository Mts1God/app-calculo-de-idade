
namespace nome_idade_pessoa
{
    partial class FRMPrincipal
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
            this.lblcalcular = new System.Windows.Forms.Label();
            this.LBLNOME = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcalcular
            // 
            this.lblcalcular.AutoSize = true;
            this.lblcalcular.Location = new System.Drawing.Point(171, 21);
            this.lblcalcular.Name = "lblcalcular";
            this.lblcalcular.Size = new System.Drawing.Size(123, 13);
            this.lblcalcular.TabIndex = 0;
            this.lblcalcular.Text = "calcular idade em meses";
            this.lblcalcular.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBLNOME
            // 
            this.LBLNOME.AutoSize = true;
            this.LBLNOME.Location = new System.Drawing.Point(41, 56);
            this.LBLNOME.Name = "LBLNOME";
            this.LBLNOME.Size = new System.Drawing.Size(92, 13);
            this.LBLNOME.TabIndex = 1;
            this.LBLNOME.Text = "Digite o seu nome";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(41, 95);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(83, 13);
            this.lblIdade.TabIndex = 1;
            this.lblIdade.Text = "Digite sua idade";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(174, 49);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 2;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(174, 95);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 2;
            this.txtIdade.TextChanged += new System.EventHandler(this.txtIdade_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Meses:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome:";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Location = new System.Drawing.Point(160, 177);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(35, 13);
            this.lblNome2.TabIndex = 1;
            this.lblNome2.Text = "label1";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(160, 213);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(35, 13);
            this.lblMeses.TabIndex = 1;
            this.lblMeses.Text = "label1";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(160, 250);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(35, 13);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "label1";
            // 
            // FRMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.LBLNOME);
            this.Controls.Add(this.lblcalcular);
            this.Name = "FRMPrincipal";
            this.Text = "ssazzsx";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcalcular;
        private System.Windows.Forms.Label LBLNOME;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.Label lblDia;
    }
}

