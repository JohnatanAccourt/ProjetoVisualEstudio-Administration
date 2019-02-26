using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucao_aula4._2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, soma;

            num1 = Convert.ToDouble(textBox1
                .Text);

            soma = num1 * 0.05;
            soma = soma + num1;

            label2.Text = String.Format("Novo Salário: {0:c}", soma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, soma;

            num1 = Convert.ToDouble(textBox1.Text);

            soma = num1 * 0.10;
            soma = soma + num1;

            label2.Text = String.Format("Novo Salário: {0:c}", soma);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, soma;

            num1 = Convert.ToDouble(textBox1.Text);

            soma = num1 * 0.15;
            soma = soma + num1;

            label2.Text = String.Format("Novo Salário: {0:c}", soma);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1, soma;

            num1 = Convert.ToDouble(textBox1.Text);

            soma = num1 * 0.20;
            soma = soma + num1;

            label2.Text = String.Format("Novo Salário: {0:c}", soma);
        }
    }
}
