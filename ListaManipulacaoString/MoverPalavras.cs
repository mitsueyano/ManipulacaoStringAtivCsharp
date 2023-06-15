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
    public partial class MoverPalavras : Form
    {
        string palavra, selecionado;
        public MoverPalavras()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            palavra = txtPalavra.Text;
            if (palavra != "" && palavra != " ")
            {
                lstBox1.Items.Add(palavra);
                txtPalavra.Text = "";
            }
        }

        private void btnTodasDireita_Click(object sender, EventArgs e)
        {
            lstBox2.Items.AddRange(lstBox1.Items);
            lstBox1.Items.Clear();
        }

        private void btnTodasEsquerda_Click(object sender, EventArgs e)
        {
            lstBox1.Items.AddRange(lstBox2.Items);
            lstBox2.Items.Clear();
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            if (lstBox1.SelectedItem != null)
            {
                selecionado = lstBox1.SelectedItem.ToString();
                lstBox2.Items.Add(selecionado);
                lstBox1.Items.Remove(selecionado);
            }
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            if (lstBox2.SelectedItem != null)
            {
                selecionado = lstBox2.SelectedItem.ToString();
                lstBox1.Items.Add(selecionado);
                lstBox2.Items.Remove(selecionado);
            }
        }

        private void btnRemov1_Click(object sender, EventArgs e)
        {
            lstBox1.Items.Remove(lstBox1.SelectedItem);
;       }

        private void btnRemov2_Click(object sender, EventArgs e)
        {
            lstBox2.Items.Remove(lstBox2.SelectedItem);
        }

        private void btnOrder1_Click(object sender, EventArgs e)
        {
            List<string> palavras = new List<string>();//cria uma lista temporária
            for (int i = 0; i < lstBox1.Items.Count; i++)
            {
                palavras.Add(lstBox1.Items[i].ToString());
            }
            palavras.Sort(); //ordena em ordem alfabética
            lstBox1.Items.Clear();
            lstBox1.Items.AddRange(palavras.ToArray()); //"ToArray" transforma a lista em array - regra de tipos
        }

        private void btnOrder2_Click(object sender, EventArgs e)
        {
            List<string> palavras = new List<string>();
            for (int i = 0; i < lstBox2.Items.Count; i++)
            {
                palavras.Add(lstBox2.Items[i].ToString());
            }
            palavras.Sort();
            lstBox2.Items.Clear();
            lstBox2.Items.AddRange(palavras.ToArray());
        }

        private void btnLimparlst_Click(object sender, EventArgs e)
        {
            lstBox1.Items.Clear();
            lstBox2.Items.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }
    }

}
