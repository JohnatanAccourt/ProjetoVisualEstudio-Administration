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
    public partial class frmDadosPessoais : Form
    {
        //método construtor
        public frmDadosPessoais()
        {
            InitializeComponent();
            
        }

        private void frmDadosPessoais_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Passei por aqui!!!");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
