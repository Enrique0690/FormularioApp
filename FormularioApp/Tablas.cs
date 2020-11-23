using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioApp
{
    public partial class Tablas : Form
    {
        public Tablas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtlimite_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtnumero.Text);
            int lim = int.Parse(this.txtlimite.Text);
            int resultado;
            for(int i=1;i<=lim;i++)
            {
                resultado = num * i;
                txtresultado.Items.Add(num+" x "+i+" = "+resultado);
            }
        }
    }
}
