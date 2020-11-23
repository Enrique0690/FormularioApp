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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrNumeroBinario frm1 = new FrNumeroBinario();
            frm1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinarioDecimal frm1 = new BinarioDecimal();
            frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fecha frm1 = new Fecha();
            frm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Numerosp frm1 = new Numerosp();
            frm1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Edad frm1 = new Edad();
            frm1.Show();
        }
    }
}
