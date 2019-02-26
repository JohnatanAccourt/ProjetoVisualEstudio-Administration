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
            carregacombo();
        }

        private void btnCarregaEstados_Click(object sender, EventArgs e)
        {
            carregacombo();
        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregacombo();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cboEstados.Items.Clear();
            ltbLista.Items.Clear();
        }

        private void frmEstados_Load(object sender, EventArgs e)
        {
            carregacombo();
        }

        public void carregacombo()
        {
            cboEstados.Items.Clear();

            cboEstados.Items.Add("São Paulo");
            cboEstados.Items.Add("Bahia");
            cboEstados.Items.Add("Rio de Janeiro");
            cboEstados.Items.Add("Acre");
            cboEstados.Items.Add("Pernambuco");
            cboEstados.Items.Add("Sergipe");
            cboEstados.Items.Add("Manaus");
        }

        public void carregalista()
        {
            ltbLista.Items.Clear();

            ltbLista.Items.Add("São Paulo");
            ltbLista.Items.Add("Bahia");
            ltbLista.Items.Add("Rio de Janeiro");
            ltbLista.Items.Add("Acre");
            ltbLista.Items.Add("Pernambuco");
            ltbLista.Items.Add("Sergipe");
            ltbLista.Items.Add("Manaus");
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            carregalista();
        }

        private void ltb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
