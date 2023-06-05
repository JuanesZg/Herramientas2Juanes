using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormTot : Form
    {
        public FormTot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void tipo_conductor_Click(object sender, EventArgs e)
        {
            FormTipoConduc FormTipoConduc = new FormTipoConduc();
            FormTipoConduc.Show();
        }

        private void vehiculo_Click(object sender, EventArgs e)
        {
            FormVehiculo FormVehiculo = new FormVehiculo();
            FormVehiculo.Show();
        }

        private void conductor_Click(object sender, EventArgs e)
        {
            FormConductor FormConductor = new FormConductor();
            FormConductor.Show();
        }

        private void ruta_Click(object sender, EventArgs e)
        {
            FormRuta FormRuta = new FormRuta();
            FormRuta.Show();
        }

        private void contrato_Click(object sender, EventArgs e)
        {
            FormContrato FormContrato = new FormContrato();
            FormContrato.Show();
        }
    }
}
