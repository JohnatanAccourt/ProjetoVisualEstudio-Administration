using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmacia
{
    public partial class frmTesteVariavel : Form
    {
        bool bandeira = false;

        public frmTesteVariavel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "Senac Largo Treze";
            lblNCompleto.Text = "Turma TI92";
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnBandeira_Click(object sender, EventArgs e)
        {
            bandeira = true;
            lblBandeira.Text = bandeira.ToString(); 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "";
            lblNCompleto.Text = "";

            bandeira = false;
            lblBandeira.Text = bandeira.ToString();

            double num1;

            


        }
    }
}
