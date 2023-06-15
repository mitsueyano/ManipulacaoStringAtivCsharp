using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaManipulacaoString
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVerificador_Click(object sender, EventArgs e)
        {
            VerificadorEmail verificadorEmail = new VerificadorEmail();
            this.Hide();
            verificadorEmail.Show();

        }

        private void btnPalavra_Click(object sender, EventArgs e)
        {
            PalavraVertical palavraVertical = new PalavraVertical();
            this.Hide();
            palavraVertical.Show();
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            MoverPalavras moverPalavras = new MoverPalavras();
            this.Hide();
            moverPalavras.Show();
        }
    }
}
