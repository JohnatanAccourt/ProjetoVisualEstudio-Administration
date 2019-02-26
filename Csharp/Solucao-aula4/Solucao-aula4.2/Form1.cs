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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, calc;

            nota1 = Convert.ToDouble(textBox1.Text);
            nota2 = Convert.ToDouble(textBox2.Text);
            nota3 = Convert.ToDouble(textBox3.Text);
            nota4 = Convert.ToDouble(textBox4.Text);

            calc = nota1 + nota2 + nota3 + nota4;
            calc = calc / 4;
            label5.Text = String.Format("{0}", calc);
        }
    }
}
