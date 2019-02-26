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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;

            num1 = Double.Parse(textBox1.Text);
            num2 = Double.Parse(textBox2.Text);

            if (rdbAdicao.Checked)
            {
                resp = num1 + num2;

                lblResu.Text = resp.ToString();
            }

                if (rbdSubtracao.Checked)
                {
                    resp = num1 - num2;

                    lblResu.Text = resp.ToString();
                }

                if (rbdMultiplicacao.Checked)
                {
                    resp = num1 * num2;

                    lblResu.Text = resp.ToString();
                }

                if (rbdDivisao.Checked)
                {
                    resp = num1 / num2;

                    lblResu.Text = resp.ToString();

                if (num2 == 0)
                      {

                    lblResu.Text = "Impossivel divisão por 0";

                      }
                }
            }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResu.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
