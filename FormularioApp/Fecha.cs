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
    public partial class Fecha : Form
    {
        public Fecha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int edadAnios = DateTime.Today.Year - dtpFecha.Value.Year;
                txtEdadAn.Text = Convert.ToString(edadAnios + " años de edad");

                int edadDias = (DateTime.Today.Year - dtpFecha.Value.Year) * 365;
                edadDias += (DateTime.Today.Month - dtpFecha.Value.Month) * 30;
                edadDias += 1;
                edadDias += DateTime.Today.Day - dtpFecha.Value.Day;
                txtEdadDias.Text = Convert.ToString(edadDias + " días de edad");
            }
        }
    }
}
