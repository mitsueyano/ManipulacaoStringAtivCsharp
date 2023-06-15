
namespace ListaManipulacaoString
{
    partial class Menu
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
            this.btnVerificador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPalavra = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerificador
            // 
            this.btnVerificador.Location = new System.Drawing.Point(20, 44);
            this.btnVerificador.Name = "btnVerificador";
            this.btnVerificador.Size = new System.Drawing.Size(205, 36);
            this.btnVerificador.TabIndex = 0;
            this.btnVerificador.Text = "Verificador de E-mail";
            this.btnVerificador.UseVisualStyleBackColor = true;
            this.btnVerificador.Click += new System.EventHandler(this.btnVerificador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione:";
            // 
            // btnPalavra
            // 
            this.btnPalavra.Location = new System.Drawing.Point(20, 104);
            this.btnPalavra.Name = "btnPalavra";
            this.btnPalavra.Size = new System.Drawing.Size(205, 36);
            this.btnPalavra.TabIndex = 2;
            this.btnPalavra.Text = "Palavra na Vertical";
            this.btnPalavra.UseVisualStyleBackColor = true;
            this.btnPalavra.Click += new System.EventHandler(this.btnPalavra_Click);
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(20, 163);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(205, 36);
            this.btnMover.TabIndex = 3;
            this.btnMover.Text = "Mover Palavras";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 211);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.btnPalavra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPalavra;
        private System.Windows.Forms.Button btnMover;
    }
}

