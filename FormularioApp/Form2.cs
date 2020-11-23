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
    public partial class Edad : Form
    {
        public Edad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Condiciones 
            int edad = int.Parse(txtEdad.Text);
            if (!(edad >= 15 && edad <= 80))
            {
                MessageBox.Show("Ingresa una edad entre 15 y 80 años", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEdad.Focus();
                return;
            }
            else if (edad >= 15 && edad <= 17)
            {
                txtfrase.Text = "Eres menor de edad dile no al alcohol";
            }
            else if (edad >= 18 && edad <= 25)
            {
                txtfrase.Text = "Eres mayor de edad se responsable";
            }
            else if (edad >= 26 && edad <= 30)
            {
                txtfrase.Text = "Deberias pensar en casarte";
            }
            else if (edad >= 31 && edad <= 50)
            {
                txtfrase.Text = "Trabaja, duerme y disfruta la vida solo es una";
            }
            else if (edad > 50)
            {
                txtfrase.Text = "Ya casi llegas a la tercera edad, suerte";
            }
        }
    }
}
