using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_aula4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2, div;

            num1 = Convert.ToDouble(textBox5.Text);
            num2 = Convert.ToDouble(textBox6.Text);

            div = num2 - num1;

            label3.Text = String.Format("{0}", div);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double raio, area;

            raio = Convert.ToDouble(textBox4.Text);

            area = raio * raio * 3.1416;

            label5.Text = String.Format("{0}", area);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B, C, X;

        }
    }
}
