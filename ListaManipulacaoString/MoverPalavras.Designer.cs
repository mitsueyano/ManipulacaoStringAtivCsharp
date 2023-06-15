
namespace ListaManipulacaoString
{
    partial class MoverPalavras
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBox1 = new System.Windows.Forms.ListBox();
            this.lstBox2 = new System.Windows.Forms.ListBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnTodasDireita = new System.Windows.Forms.Button();
            this.btnDireita = new System.Windows.Forms.Button();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.btnTodasEsquerda = new System.Windows.Forms.Button();
            this.btnRemov1 = new System.Windows.Forms.Button();
            this.btnOrder1 = new System.Windows.Forms.Button();
            this.btnOrder2 = new System.Windows.Forms.Button();
            this.btnRemov2 = new System.Windows.Forms.Button();
            this.btnLimparlst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(250, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 26);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPalavra
            // 
            this.txtPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPalavra.Location = new System.Drawing.Point(116, 49);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(128, 23);
            this.txtPalavra.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Palavra:";
            // 
            // lstBox1
            // 
            this.lstBox1.FormattingEnabled = true;
            this.lstBox1.Location = new System.Drawing.Point(15, 149);
            this.lstBox1.Name = "lstBox1";
            this.lstBox1.Size = new System.Drawing.Size(133, 199);
            this.lstBox1.TabIndex = 13;
            // 
            // lstBox2
            // 
            this.lstBox2.FormattingEnabled = true;
            this.lstBox2.Location = new System.Drawing.Point(224, 149);
            this.lstBox2.Name = "lstBox2";
            this.lstBox2.Size = new System.Drawing.Size(133, 199);
            this.lstBox2.TabIndex = 14;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(41, 26);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "<";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnTodasDireita
            // 
            this.btnTodasDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTodasDireita.Location = new System.Drawing.Point(166, 156);
            this.btnTodasDireita.Name = "btnTodasDireita";
            this.btnTodasDireita.Size = new System.Drawing.Size(41, 26);
            this.btnTodasDireita.TabIndex = 16;
            this.btnTodasDireita.Text = ">>";
            this.btnTodasDireita.UseVisualStyleBackColor = true;
            this.btnTodasDireita.Click += new System.EventHandler(this.btnTodasDireita_Click);
            // 
            // btnDireita
            // 
            this.btnDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDireita.Location = new System.Drawing.Point(166, 216);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(41, 26);
            this.btnDireita.TabIndex = 17;
            this.btnDireita.Text = ">";
            this.btnDireita.UseVisualStyleBackColor = true;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEsquerda.Location = new System.Drawing.Point(166, 248);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(41, 26);
            this.btnEsquerda.TabIndex = 18;
            this.btnEsquerda.Text = "<";
            this.btnEsquerda.UseVisualStyleBackColor = true;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // btnTodasEsquerda
            // 
            this.btnTodasEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTodasEsquerda.Location = new System.Drawing.Point(166, 286);
            this.btnTodasEsquerda.Name = "btnTodasEsquerda";
            this.btnTodasEsquerda.Size = new System.Drawing.Size(41, 26);
            this.btnTodasEsquerda.TabIndex = 19;
            this.btnTodasEsquerda.Text = "<<";
            this.btnTodasEsquerda.UseVisualStyleBackColor = true;
            this.btnTodasEsquerda.Click += new System.EventHandler(this.btnTodasEsquerda_Click);
            // 
            // btnRemov1
            // 
            this.btnRemov1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnRemov1.Location = new System.Drawing.Point(87, 122);
            this.btnRemov1.Name = "btnRemov1";
            this.btnRemov1.Size = new System.Drawing.Size(61, 21);
            this.btnRemov1.TabIndex = 21;
            this.btnRemov1.Text = "Remover";
            this.btnRemov1.UseVisualStyleBackColor = true;
            this.btnRemov1.Click += new System.EventHandler(this.btnRemov1_Click);
            // 
            // btnOrder1
            // 
            this.btnOrder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnOrder1.Location = new System.Drawing.Point(15, 122);
            this.btnOrder1.Name = "btnOrder1";
            this.btnOrder1.Size = new System.Drawing.Size(61, 21);
            this.btnOrder1.TabIndex = 23;
            this.btnOrder1.Text = "Ordenar";
            this.btnOrder1.UseVisualStyleBackColor = true;
            this.btnOrder1.Click += new System.EventHandler(this.btnOrder1_Click);
            // 
            // btnOrder2
            // 
            this.btnOrder2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnOrder2.Location = new System.Drawing.Point(224, 122);
            this.btnOrder2.Name = "btnOrder2";
            this.btnOrder2.Size = new System.Drawing.Size(61, 21);
            this.btnOrder2.TabIndex = 24;
            this.btnOrder2.Text = "Ordenar";
            this.btnOrder2.UseVisualStyleBackColor = true;
            this.btnOrder2.Click += new System.EventHandler(this.btnOrder2_Click);
            // 
            // btnRemov2
            // 
            this.btnRemov2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnRemov2.Location = new System.Drawing.Point(296, 122);
            this.btnRemov2.Name = "btnRemov2";
            this.btnRemov2.Size = new System.Drawing.Size(61, 21);
            this.btnRemov2.TabIndex = 25;
            this.btnRemov2.Text = "Remover";
            this.btnRemov2.UseVisualStyleBackColor = true;
            this.btnRemov2.Click += new System.EventHandler(this.btnRemov2_Click);
            // 
            // btnLimparlst
            // 
            this.btnLimparlst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnLimparlst.Location = new System.Drawing.Point(154, 327);
            this.btnLimparlst.Name = "btnLimparlst";
            this.btnLimparlst.Size = new System.Drawing.Size(64, 21);
            this.btnLimparlst.TabIndex = 26;
            this.btnLimparlst.Text = "Limpar";
            this.btnLimparlst.UseVisualStyleBackColor = true;
            this.btnLimparlst.Click += new System.EventHandler(this.btnLimparlst_Click);
            // 
            // MoverPalavras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 362);
            this.Controls.Add(this.btnLimparlst);
            this.Controls.Add(this.btnRemov2);
            this.Controls.Add(this.btnOrder2);
            this.Controls.Add(this.btnOrder1);
            this.Controls.Add(this.btnRemov1);
            this.Controls.Add(this.btnTodasEsquerda);
            this.Controls.Add(this.btnEsquerda);
            this.Controls.Add(this.btnDireita);
            this.Controls.Add(this.btnTodasDireita);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lstBox2);
            this.Controls.Add(this.lstBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.label1);
            this.Name = "MoverPalavras";
            this.Text = "Mover Palavras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBox1;
        private System.Windows.Forms.ListBox lstBox2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnTodasDireita;
        private System.Windows.Forms.Button btnDireita;
        private System.Windows.Forms.Button btnEsquerda;
        private System.Windows.Forms.Button btnTodasEsquerda;
        private System.Windows.Forms.Button btnRemov1;
        private System.Windows.Forms.Button btnOrder1;
        private System.Windows.Forms.Button btnOrder2;
        private System.Windows.Forms.Button btnRemov2;
        private System.Windows.Forms.Button btnLimparlst;
    }
}