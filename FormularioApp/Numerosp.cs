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
    public partial class Numerosp : Form
    {
        public Numerosp()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtnumero.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar un numero");
                this.txtnumero.Focus();
                return;
            }
            int numero = int.Parse(this.txtnumero.Text);
            comprobacion(numero);
            return;
        }

        void comprobacion(int numero)
        {
            int a=0;
            for(int i=1; i<=numero;i++)
            {
                if ((numero%i)== 0)
                    a = a + 1;
            }
            if (a > 2)
                this.lbrespuesta.Text = "El numero no es Primo";
            else
                this.lbrespuesta.Text = "El numero es Primo";
        }
    }
}
