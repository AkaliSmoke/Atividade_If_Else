namespace Atividade_If_Else
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
            this.txtCampo1 = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnVerificarNumero = new System.Windows.Forms.Button();
            this.btnDeterminarMaior = new System.Windows.Forms.Button();
            this.btnValidarLetra = new System.Windows.Forms.Button();
            this.btnConsultarMes = new System.Windows.Forms.Button();
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.btnCalcularAumento = new System.Windows.Forms.Button();
            this.txtCampo2 = new System.Windows.Forms.TextBox();
            this.txtCampo3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCampo1
            // 
            this.txtCampo1.Location = new System.Drawing.Point(12, 103);
            this.txtCampo1.Name = "txtCampo1";
            this.txtCampo1.Size = new System.Drawing.Size(361, 20);
            this.txtCampo1.TabIndex = 0;
            this.txtCampo1.TextChanged += new System.EventHandler(this.txtCampo_TextChanged);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbResultado.Location = new System.Drawing.Point(134, 9);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(113, 22);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "RESULTADO";
            this.lbResultado.Click += new System.EventHandler(this.lbResultado_Click);
            // 
            // btnVerificarNumero
            // 
            this.btnVerificarNumero.Location = new System.Drawing.Point(12, 142);
            this.btnVerificarNumero.Name = "btnVerificarNumero";
            this.btnVerificarNumero.Size = new System.Drawing.Size(116, 53);
            this.btnVerificarNumero.TabIndex = 2;
            this.btnVerificarNumero.Text = "Verificar Positivo/Negativo";
            this.btnVerificarNumero.UseVisualStyleBackColor = true;
            this.btnVerificarNumero.Click += new System.EventHandler(this.btnVerificarNumero_Click);
            // 
            // btnDeterminarMaior
            // 
            this.btnDeterminarMaior.Location = new System.Drawing.Point(134, 142);
            this.btnDeterminarMaior.Name = "btnDeterminarMaior";
            this.btnDeterminarMaior.Size = new System.Drawing.Size(113, 53);
            this.btnDeterminarMaior.TabIndex = 3;
            this.btnDeterminarMaior.Text = "Achar Maior Número";
            this.btnDeterminarMaior.UseVisualStyleBackColor = true;
            this.btnDeterminarMaior.Click += new System.EventHandler(this.btnDeterminarMaior_Click);
            // 
            // btnValidarLetra
            // 
            this.btnValidarLetra.Location = new System.Drawing.Point(253, 142);
            this.btnValidarLetra.Name = "btnValidarLetra";
            this.btnValidarLetra.Size = new System.Drawing.Size(120, 53);
            this.btnValidarLetra.TabIndex = 4;
            this.btnValidarLetra.Text = "Verificar Letra";
            this.btnValidarLetra.UseVisualStyleBackColor = true;
            this.btnValidarLetra.Click += new System.EventHandler(this.btnValidarLetra_Click);
            // 
            // btnConsultarMes
            // 
            this.btnConsultarMes.Location = new System.Drawing.Point(12, 201);
            this.btnConsultarMes.Name = "btnConsultarMes";
            this.btnConsultarMes.Size = new System.Drawing.Size(116, 53);
            this.btnConsultarMes.TabIndex = 7;
            this.btnConsultarMes.Text = "Ver Quantidade de Dias\r\n";
            this.btnConsultarMes.UseVisualStyleBackColor = true;
            this.btnConsultarMes.Click += new System.EventHandler(this.btnConsultarMes_Click);
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.Location = new System.Drawing.Point(134, 201);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(113, 53);
            this.btnCalcularMedia.TabIndex = 6;
            this.btnCalcularMedia.Text = "Calcular a Media";
            this.btnCalcularMedia.UseVisualStyleBackColor = true;
            this.btnCalcularMedia.Click += new System.EventHandler(this.btnCalcularMedia_Click);
            // 
            // btnCalcularAumento
            // 
            this.btnCalcularAumento.Location = new System.Drawing.Point(253, 201);
            this.btnCalcularAumento.Name = "btnCalcularAumento";
            this.btnCalcularAumento.Size = new System.Drawing.Size(120, 53);
            this.btnCalcularAumento.TabIndex = 5;
            this.btnCalcularAumento.Text = "Reajustar Salário";
            this.btnCalcularAumento.UseVisualStyleBackColor = true;
            this.btnCalcularAumento.Click += new System.EventHandler(this.btnCalcularAumento_Click);
            // 
            // txtCampo2
            // 
            this.txtCampo2.Location = new System.Drawing.Point(12, 77);
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.Size = new System.Drawing.Size(361, 20);
            this.txtCampo2.TabIndex = 8;
            // 
            // txtCampo3
            // 
            this.txtCampo3.Location = new System.Drawing.Point(12, 51);
            this.txtCampo3.Name = "txtCampo3";
            this.txtCampo3.Size = new System.Drawing.Size(361, 20);
            this.txtCampo3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(390, 272);
            this.Controls.Add(this.txtCampo3);
            this.Controls.Add(this.txtCampo2);
            this.Controls.Add(this.btnConsultarMes);
            this.Controls.Add(this.btnCalcularMedia);
            this.Controls.Add(this.btnCalcularAumento);
            this.Controls.Add(this.btnValidarLetra);
            this.Controls.Add(this.btnDeterminarMaior);
            this.Controls.Add(this.btnVerificarNumero);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.txtCampo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCampo1;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnVerificarNumero;
        private System.Windows.Forms.Button btnDeterminarMaior;
        private System.Windows.Forms.Button btnValidarLetra;
        private System.Windows.Forms.Button btnConsultarMes;
        private System.Windows.Forms.Button btnCalcularMedia;
        private System.Windows.Forms.Button btnCalcularAumento;
        private System.Windows.Forms.TextBox txtCampo2;
        private System.Windows.Forms.TextBox txtCampo3;
    }
}

