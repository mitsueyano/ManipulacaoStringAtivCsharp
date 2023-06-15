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
    public partial class VerificadorEmail : Form
    {
        string email, provedor;
        int i, a, provA, provB, quant;

        public VerificadorEmail()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text;

            if (email == Email.pessoa1email)
            {
                lblEmailExist.Text = "Email existente!";
            }
            else if (email == Email.pessoa2email)
            {
                lblEmailExist.Text = "Email existente!";
            }
            else if (email == Email.pessoa3email)
            {
                lblEmailExist.Text = "Email existente!";
                lblEmailExist.Text = "Email existente!";
            }
            else
            {
                lblEmailExist.Text = "Email inexistente.";
            }
        }
        private void btnVerificarUsuario_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text;

            if (email == Email.pessoa1email)
            {
                quant = Email.pessoa1user.Length;
                lblUsuario.Text = Email.pessoa1user + Environment.NewLine + quant + " Caracteres";
            }
            else if (email == Email.pessoa2email)
            {
                quant = Email.pessoa2user.Length;
                lblUsuario.Text = Email.pessoa2user + Environment.NewLine + quant + " Caracteres";
            }
            else if (email == Email.pessoa3email)
            {
                quant = Email.pessoa3user.Length;
                lblUsuario.Text = Email.pessoa3user + Environment.NewLine + quant + " Caracteres";
            }
            else
            {
                lblUsuario.Text = "Usuário inexistente." + Environment.NewLine + "Verifique o E-mail!";
            }
        }

        private void btnVerificarProvedor_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text;

            if (email == Email.pessoa1email)
            {
                a = txtEmail.Text.Length;
                for (i = 0; i < a; i++)
                    if(email.Substring(i, 1) == "@")
                    {
                        provA = i;
                    }
                for (i = 0; i < a; i++)
                    if (email.Substring(i, 1) == ".")
                    {
                        provB = i;
                    }
               provedor = email.Substring(provA + 1, provB - provA - 1);
               lblProvedor.Text = provedor.ToUpper();
            }
            else if (email == Email.pessoa2email)
            {
                a = txtEmail.Text.Length;
                for (i = 0; i < a; i++)
                    if (email.Substring(i, 1) == "@")
                    {
                        provA = i;
                    }
                for (i = 0; i < a; i++)
                    if (email.Substring(i, 1) == ".")
                    {
                        provB = i;
                    }
                provedor = email.Substring(provA + 1, provB - provA - 1);
                lblProvedor.Text = provedor.ToUpper();
            }
            else if (email == Email.pessoa3email)
            {
                a = txtEmail.Text.Length;
                for (i = 0; i < a; i++)
                    if (email.Substring(i, 1) == "@")
                    {
                        provA = i;
                    }
                for (i = 0; i < a; i++)
                    if (email.Substring(i, 1) == ".")
                    {
                        provB = i;
                    }
                provedor = email.Substring(provA + 1, provB - provA - 1);
                lblProvedor.Text = provedor.ToUpper();
            }
            else
            {
                lblProvedor.Text = "E-mail e Usuário inexistente." + Environment.NewLine + "Verifique o E-mail!";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            lblEmailExist.Text = "";
            lblUsuario.Text = "";
            lblProvedor.Text = "";
            a = provA = provB = 0;
                
        }
    }
}
