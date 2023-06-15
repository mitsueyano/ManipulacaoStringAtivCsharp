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
    public partial class ManipulacaoString : Form
    {
        int totalcarac;
        int vogA, vogE, vogI, vogO, vogU;

        public ManipulacaoString()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLetraLetra_Click(object sender, EventArgs e)
        {
            LetraLetra();
        }

        private void LetraLetra()
        {
            string palavra;

            lstLetraLetra.Items.Clear();
            palavra = txtFrase.Text;
            int a = txtFrase.Text.Length;
            for (int i = 0; i < a; i++)
            {
                string letra = txtFrase.Text.Substring(i, 1);
                lstLetraLetra.Items.Add(letra);
            }
        }
        private void btnPalavraPalavra_Click(object sender, EventArgs e)
        {
            PalavraPalavra();
        }
        private void PalavraPalavra()
        {
            string frase;

            lstPalavraPalavra.Items.Clear();
            frase = txtFrase.Text;
            int a = frase.Length;
            int numpalavra = 1;

            for (int i = 0; i < a; i++) //percorre a frase
            {
                
                if (frase[i] == ' ') //confere os espaços e define o número de palavras
                {
                    numpalavra++;
                }
            }

            int index = 0; //quantidade de letras percorridas
            for (int i = 0; i < numpalavra; i++)
            {
                String palavraatual = "";
                
                for (int j = index; j < a; j++)
                {
                    if (frase[j] != ' ') //escreve até encontrar um espaço
                    {
                        palavraatual += frase[j];
                    }
                    else
                    {
                        index = j + 1; //ao encontrar espaço, adiciona no index + 1 (caractere do espaço)
                        break;
                    }
                }
                lstPalavraPalavra.Items.Add(palavraatual);
            }
        }

        private void btnTamanho_Click(object sender, EventArgs e)
        {
            Tamanho();
        }
        private void Tamanho()
        {
            totalcarac = txtFrase.Text.Length;
            lblTotal.Text = totalcarac.ToString();
        }
        private void btnInverter_Click(object sender, EventArgs e)
        {
            Inverter();
        }
        private void Inverter()
        {
            int i;
            int size = txtFrase.Text.Length;
            string frase = txtFrase.Text;
            string frasetrocada = "";

            for (i = size - 1; i >= 0; i--)
            {
                frasetrocada += frase[i];
            }
            lblInvertida.Text = frasetrocada;
        }

        private void btnEspaco_Click(object sender, EventArgs e)
        {
            Espaco();
        }

        private void Espaco()
        {
            string fraseEspaco = txtFrase.Text.Replace(" ", "");
            lblEspaco.Text = fraseEspaco; 
        }

        private void btnVogais_Click(object sender, EventArgs e)
        {
            Vogais();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lstLetraLetra.Items.Clear();
            lstPalavraPalavra.Items.Clear();
            txtFrase.Text = "";
            lblA.Text = "";
            lblE.Text = "";
            lblI.Text = "";
            lblO.Text = "";
            lblU.Text = "";
            lblEspaco.Text = "";
            lblInvertida.Text = "";
            lblTotal.Text = "";
            vogA = vogE = vogI = vogO = vogU = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        private void Vogais()
        {
            vogA = vogE = vogI = vogO = vogU = 0;

            int a = txtFrase.Text.Length;
            string frasevogal = txtFrase.Text.ToLower();

            for (int i = 0; i < a; i++)
            {
                if (frasevogal.Substring(i, 1) == "a")
                {
                    vogA++;
                }
                if (frasevogal.Substring(i, 1) == "e")
                {
                    vogE++;
                }
                if (frasevogal.Substring(i, 1) == "i")
                {
                    vogI++;
                }
                if (frasevogal.Substring(i, 1) == "o")
                {
                    vogO++;
                }
                if (frasevogal.Substring(i, 1) == "u")
                {
                    vogU++;
                }
                lblA.Text = vogA.ToString();
                lblE.Text = vogE.ToString();
                lblI.Text = vogI.ToString();
                lblO.Text = vogO.ToString();
                lblU.Text = vogU.ToString();
            }
        }

        private void btnPalindrome_Click(object sender, EventArgs e)
        {
            Palindrome();
        }
        private void Palindrome()
        {
            string palavra = txtFrase.Text.ToLower();
            string fraseinvertida = "";
            int i;
            int size = txtFrase.Text.Length;        
            for (i = size - 1; i >= 0; i--)
            {
                fraseinvertida += palavra[i];
            }

            if (palavra == fraseinvertida.ToLower())
            {
                MessageBox.Show("É Palíndrome!","Palíndrome?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não é Palíndrome!", "Palíndrome?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnTodosAcima_Click(object sender, EventArgs e)
        {
            Tamanho();
            Inverter();
            Espaco();
            Vogais();
            LetraLetra();
            PalavraPalavra();
            Palindrome();
        }
    }

}
