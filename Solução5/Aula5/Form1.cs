using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Height += 15;
            pictureBox1.Width += 20;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double conta;

            pictureBox1.Width += 25;
            pictureBox1.Height += 20;

            conta = Convert.ToDouble(contador.Text);

            contador.Text = String.Format("{0}", conta +1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Width -= 25;
            pictureBox1.Height -= 20;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = 141;
            pictureBox1.Height = 107;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
