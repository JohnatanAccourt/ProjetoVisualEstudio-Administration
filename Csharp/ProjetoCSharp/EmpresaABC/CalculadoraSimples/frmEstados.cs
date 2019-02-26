using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class frmEstados : Form
    {
        public frmEstados()
        {
            InitializeComponent();
            carregaCombo();
            
        }

        private void btnCarregaEstados_Click(object sender, EventArgs e)
        {
          //  carregaCombo();
        }

        private void cboCarregaEstados_MouseClick(object sender, MouseEventArgs e)
        {
           // carregaCombo();
        }

        
        private void frmEstados_Load(object sender, EventArgs e)
        {
            //  carregaCombo();
            carregaLista();
        }

        public void carregaCombo()
        {
            cboCarregaEstados.Items.Clear();

            cboCarregaEstados.Items.Add("São Paulo");
            cboCarregaEstados.Items.Add("Bahia");
            cboCarregaEstados.Items.Add("Rio de Janeiro");
            cboCarregaEstados.Items.Add("Acre");
            cboCarregaEstados.Items.Add("Pernambuco");
            cboCarregaEstados.Items.Add("Sergipe");
            cboCarregaEstados.Items.Add("Manaus");

        }

        private void btnCarregaLista_Click(object sender, EventArgs e)
        {
            carregaLista();
        }

        public void carregaLista()
        {
            ltbListaEstado.Items.Clear();

            ltbListaEstado.Items.Add("São Paulo");
            ltbListaEstado.Items.Add("Bahia");
            ltbListaEstado.Items.Add("Rio de Janeiro");
            ltbListaEstado.Items.Add("Acre");
            ltbListaEstado.Items.Add("Pernambuco");
            ltbListaEstado.Items.Add("Sergipe");
            ltbListaEstado.Items.Add("Manaus");
            ltbListaEstado.Items.Add("Paraná");
            ltbListaEstado.Items.Add("Minas Gerais");
            ltbListaEstado.Items.Add("Fortaleza");
            ltbListaEstado.Items.Add("Santa Catarina");
        }

        private void btnCarregaLabel_Click(object sender, EventArgs e)
        {
            //lblCarregaLabel.Text = cboCarregaEstados.Text;
            lblCarregaLabel.Text = cboCarregaEstados.SelectedItem.ToString();
        }

        private void lblCarregaLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void cboCarregaEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCarregaLabel.Text = cboCarregaEstados.SelectedItem.ToString();
            ltbListaEstado.SelectedIndex = cboCarregaEstados.SelectedIndex;
        }

        private void ltbListaEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCarregalista.Text = ltbListaEstado.SelectedItem.ToString();
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            lblRetorno.Text = "Masculino";
        }

        private void lblRetorno_Click(object sender, EventArgs e)
        {

        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            lblRetorno.Text = "Feminino";
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            if (rdbMasculino.Checked);
            {
                MessageBox.Show("Escolheu Masculino");
            }
            if (rdbFeminino.Checked);
            {
                MessageBox.Show("Escolheu Feminino");
            }
        }
    }
}
