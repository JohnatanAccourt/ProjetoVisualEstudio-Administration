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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void btnCarregaEstados_Click(object sender, EventArgs e)
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
    }
}
