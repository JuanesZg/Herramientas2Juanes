using Negocio;
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
    public partial class FormConductor : Form
    {
        public FormConductor()
        {
            InitializeComponent();
            dataGridViewConductor.DataSource = AccesoLogicaConductor.ObtenerConductor();
            limpiarCampos();
        }
        void limpiarCampos()
        {
            txtIDConductor.Text = "";
            txtNombreConductor.Text = "";
            txtTipoLicencia.Text = "";
            txtIDVehiculo.Text = "";
            txtIDTipoConductor.Text = "";
            txtIDConductor.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            AccesoLogicaConductor negocio = new AccesoLogicaConductor();
            int idcondu = Int32.Parse(txtIDConductor.Text);
            string nombre = txtNombreConductor.Text;
            string tipolicencia = txtTipoLicencia.Text;
            int idvehi = Int32.Parse(txtIDVehiculo.Text);
            int idtipocondu = Int32.Parse(txtIDTipoConductor.Text);
            int resultado = negocio.Insert(idcondu, nombre, tipolicencia, idvehi, idtipocondu);

            if (resultado > 0)
                lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente.";
            else
                lblMensaje.Text = "Id ya existe, agrege otro o no se inserto el dato";

            negocio = null;
            limpiarCampos();
        }

        private void btnConsultarVehiculo_Click(object sender, EventArgs e)
        {
            dataGridViewConductor.DataSource = AccesoLogicaConductor.ObtenerConductor();
            //dataGridView1.DataBindings();
        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            /*dataGridView1[0, pocision].Value = txtIDTipoVehi.Text;
            dataGridView1[1, pocision].Value = txtNomTipo.Text;
            limpiarCampos();*/

            AccesoLogicaConductor negocioactualizar = new AccesoLogicaConductor();
            int idcondu = Int32.Parse(txtIDConductor.Text);
            string nombre = txtNombreConductor.Text;
            string tipolicencia = txtTipoLicencia.Text;
            int idvehi = Int32.Parse(txtIDVehiculo.Text);
            int idtipocondu = Int32.Parse(txtIDTipoConductor.Text);

            int resultadoActualizar = negocioactualizar.Update(idcondu, nombre, tipolicencia, idvehi, idtipocondu);

            if (resultadoActualizar > 0)
            {
                lblMensaje.Text = "Registro Actualizado";
            }
            else
            {
                lblMensaje.Text = "Registro no Actualizado";
                negocioactualizar = null;
            }
        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            AccesoLogicaConductor negocioeliminar = new AccesoLogicaConductor();
            int idcondu = Int32.Parse(txtIDConductor.Text);

            int resultadoeliminar = negocioeliminar.delete(idcondu);
            if (resultadoeliminar > 0)
            {
                lblMensaje.Text = "Registro Eliminado";
            }
            else
            {
                lblMensaje.Text = "Registro no Eliminado";
                negocioeliminar = null;
            }
        }
    }
}
