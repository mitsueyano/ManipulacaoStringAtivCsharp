
namespace ListaManipulacaoString
{
    partial class VerificadorEmail
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnVerificarUsuario = new System.Windows.Forms.Button();
            this.btnVerificarProvedor = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblEmailExist = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblProvedor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmail.Location = new System.Drawing.Point(155, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVerificar.Location = new System.Drawing.Point(18, 74);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(124, 49);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar @";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnVerificarUsuario
            // 
            this.btnVerificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVerificarUsuario.Location = new System.Drawing.Point(177, 74);
            this.btnVerificarUsuario.Name = "btnVerificarUsuario";
            this.btnVerificarUsuario.Size = new System.Drawing.Size(124, 49);
            this.btnVerificarUsuario.TabIndex = 5;
            this.btnVerificarUsuario.Text = "Verificar Usuário";
            this.btnVerificarUsuario.UseVisualStyleBackColor = true;
            this.btnVerificarUsuario.Click += new System.EventHandler(this.btnVerificarUsuario_Click);
            // 
            // btnVerificarProvedor
            // 
            this.btnVerificarProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVerificarProvedor.Location = new System.Drawing.Point(336, 74);
            this.btnVerificarProvedor.Name = "btnVerificarProvedor";
            this.btnVerificarProvedor.Size = new System.Drawing.Size(124, 49);
            this.btnVerificarProvedor.TabIndex = 6;
            this.btnVerificarProvedor.Text = "Verificar Provedor";
            this.btnVerificarProvedor.UseVisualStyleBackColor = true;
            this.btnVerificarProvedor.Click += new System.EventHandler(this.btnVerificarProvedor_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(41, 26);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "<";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblEmailExist
            // 
            this.lblEmailExist.AutoSize = true;
            this.lblEmailExist.Location = new System.Drawing.Point(18, 126);
            this.lblEmailExist.Name = "lblEmailExist";
            this.lblEmailExist.Size = new System.Drawing.Size(0, 13);
            this.lblEmailExist.TabIndex = 8;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(174, 126);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 9;
            // 
            // lblProvedor
            // 
            this.lblProvedor.AutoSize = true;
            this.lblProvedor.Location = new System.Drawing.Point(333, 126);
            this.lblProvedor.Name = "lblProvedor";
            this.lblProvedor.Size = new System.Drawing.Size(0, 13);
            this.lblProvedor.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button1.Location = new System.Drawing.Point(413, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerificadorEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblProvedor);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblEmailExist);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnVerificarProvedor);
            this.Controls.Add(this.btnVerificarUsuario);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "VerificadorEmail";
            this.Text = "Verificador de E-mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnVerificarUsuario;
        private System.Windows.Forms.Button btnVerificarProvedor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblEmailExist;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblProvedor;
        private System.Windows.Forms.Button button1;
    }
}