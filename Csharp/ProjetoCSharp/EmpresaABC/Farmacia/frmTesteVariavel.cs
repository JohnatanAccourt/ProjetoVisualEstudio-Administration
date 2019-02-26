using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class frmTesteVariavel : Form
    {
        //variáveis globais

        const double pi = 3.14182536849678241728; // constante

        bool bandeira = false;

        public frmTesteVariavel()
        {
            InitializeComponent();
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            //variaveis locais

            int idade;

            idade = 50;

            lblMostrar.Text = "Senac Largo Treze";
            lblNCompleto.Text = "Turma TI92";

            bandeira = true;

            lblNum.Text = "1";


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
  

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            //variaveis locais

            int idade;
           
            double valor1, valor2, resp = 0.0;

            idade = 20;
          
            valor1 = 10.50;
            valor2 = 20.50;
            resp = valor1 + valor2 + pi;

            bandeira = true;


        }

        private void btnBandeira_Click(object sender, EventArgs e)
        {
            bandeira = true;

            lblBandeira.Text = bandeira.ToString();

        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "";
            lblNCompleto.Text = "";

            bandeira = false;

            lblBandeira.Text = bandeira.ToString();

            lblNum.Text = "0";
        }
    }
}
