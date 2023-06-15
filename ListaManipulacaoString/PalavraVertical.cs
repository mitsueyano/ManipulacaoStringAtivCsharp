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
    public partial class PalavraVertical : Form
    {
        string palavra, letra;
        int i, a;
        public PalavraVertical()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            lstPalavra.Items.Clear();
            palavra = txtPalavra.Text;
            a = txtPalavra.Text.Length;
            for (i = 0; i < a; i++)
            {
                letra = txtPalavra.Text.Substring(i, 1);
                lstPalavra.Items.Add(letra);
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }
    }
}
