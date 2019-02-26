using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTeste
{
    public partial class fmrEscolha : Form
    {
        public fmrEscolha()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            double resp = 0, v1 = 50, v2 = 35;

            resp = v1 + v2;

            DialogResult mensagem = MessageBox.Show("A soma de " + v1 + "+" + v2 + "=" + resp, "Escolha Valor",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button3);

            if (mensagem == DialogResult.Yes)
            {
                MessageBox.Show("você clicou no sim");

            }
            if (mensagem == DialogResult.No)
            {
                MessageBox.Show("você clicou no não");

            }
            if (mensagem == DialogResult.Cancel)
            {
                MessageBox.Show("você clicou no cancel");
            }
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            String valor = "";

            //if (txtEscolha.Text.Equals""))
            {

                MessageBox.Show("Escolha um item de 1 a 5");


            }

            switch (Convert.ToInt32(txtEscolha.Text))
            {
                case 1:
                    valor = "1";
                    break;
                case 2:
                    valor = "2";
                    break;
                case 3:
                    valor = "3";
                    break;
                case 4:
                    valor = "4";
                    break;
                case 5:
                    valor = "5";
                    break;

                default:
                    MessageBox.Show("Escolha um item de 1 a 5");
                    break;
            }
    }

    private void btnNome_Click(object sender, EventArgs e)
        {
            txtNome.Text = "Senac";

            string nome = "Senac";

            if (txtNome.Text.Equals (nome))
            {
                string 
                MessageBox.Show("Olá, seja bem vindo " +nome, "Escolha", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else 
            {
                MessageBox.Show("Favor inserir nome correto!!! ", "Escolha", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }
    }
}
