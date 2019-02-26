using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Farmacia
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();//executando um método
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão!!!!");
            correr();
            this.Close();          
            
        }

        public void correr()
        {
            //vai correr...

            MessageBox.Show("Estou correndo viu!!!!");
            
        }
    }

}
