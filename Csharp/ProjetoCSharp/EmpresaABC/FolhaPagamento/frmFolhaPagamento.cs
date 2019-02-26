using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class frmFolhaPagamento : Form
    {
        public frmFolhaPagamento()
        {
            InitializeComponent();
            CarregaLista();
        }

        private void cobClubeLazer_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaLista();
        }
        public void CarregaLista()
        {
            cboClubeLazer.Items.Clear();
                 
            cboClubeLazer.Items.Add("Clube A - R$: 100,00");
            cboClubeLazer.Items.Add("Clube B - R$: 50,00");
            cboClubeLazer.Items.Add("Clube C - R$: 10,00");
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            txtSalario.Text = txtSalariofolha.Text;
        }

        private void txtSalario_TextChanged_1(object sender, EventArgs e)
        {
            txtSalario.Text = txtSalariofolha.Text;
        }
    }
}
