using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaDePagamento
{
    public partial class frmFolha : Form
    {
        public frmFolha()
        {
            InitializeComponent();
            CarregaLista();
        }

        private void cboClubeLazer_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {

        }
    }
}
