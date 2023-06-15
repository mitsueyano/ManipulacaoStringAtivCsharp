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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }



        ///aaaaaaaaaaaaaaaaaa

        private void moverPalavrasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MoverPalavras moverPalavras = new MoverPalavras();
            this.Hide();
            moverPalavras.Show();
        }

        private void palavraNaVerticalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PalavraVertical palavraVertical = new PalavraVertical();
            this.Hide();
            palavraVertical.Show();
        }

        private void verificadorDeEmailToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VerificadorEmail verificadorEmail = new VerificadorEmail();
            this.Hide();
            verificadorEmail.Show();
        }

        private void manipulaçãoDeStringToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ManipulacaoString manipulacaoString = new ManipulacaoString();
            this.Hide();
            manipulacaoString.Show();
        }

        private void sairToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
