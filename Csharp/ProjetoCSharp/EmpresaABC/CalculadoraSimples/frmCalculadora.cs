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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;

            num1 = Double.Parse(txtVal1.Text);

            num2 = Convert.ToDouble(txtVal2.Text);





            if (rdbAdicao.Checked)
            {
                resp = num1 + num2;
                lblResposta.Text = resp.ToString();
            }
            if (rdbSubtracao.Checked)
            {
                resp = num1 - num2;
                lblResposta.Text = resp.ToString();
            }
            if (rdbMultiplicacao.Checked)
            {
                resp = num1 * num2;
                lblResposta.Text = resp.ToString();
            }
            if (rdbDivisao.Checked)
            {
                if (num2 == 0)
                {
                    lblResposta.Text = "Impossível divisão por 0";
                }
                else
                {
                    resp = num1 / num2;
                    lblResposta.Text = resp.ToString();
                }
            }

        }

        private void txtVal1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResposta_Click(object sender, EventArgs e)
        {

        }
    }
}
