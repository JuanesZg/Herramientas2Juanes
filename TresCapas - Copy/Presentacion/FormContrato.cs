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
    public partial class FormContrato : Form
    {
        public FormContrato()
        {
            InitializeComponent();
            dataGridViewContrato.DataSource = AccesoLogicaContrato.ObtenerContrato();
            limpiarCampos();
        }

        void limpiarCampos()
        {
            txtIDContrato.Text = "";
            txtIDVehiculo.Text = "";
            txtIDConductor.Text = "";
            txtIDContrato.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //if (!Page.IsValid)
            //return;
            AccesoLogicaContrato negocio = new AccesoLogicaContrato();
            int idcontrato = Int32.Parse(txtIDContrato.Text);
            int idvehi = Int32.Parse(txtIDVehiculo.Text);
            int idcondu = Int32.Parse(txtIDConductor.Text);
            int resultado = negocio.Insert(idcontrato, idvehi, idcondu);

            if (resultado > 0)
                lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente.";
            else
                lblMensaje.Text = "Id ya existe, agrege otro o no se inserto el dato";

            negocio = null;
            limpiarCampos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridViewContrato.DataSource = AccesoLogicaContrato.ObtenerContrato();
            //dataGridView1.DataBindings();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            /*dataGridView1[0, pocision].Value = txtIDTipoVehi.Text;
                        dataGridView1[1, pocision].Value = txtNomTipo.Text;
                        limpiarCampos();*/

            AccesoLogicaContrato negocioactualizar = new AccesoLogicaContrato();
            int idcontrato = Int32.Parse(txtIDContrato.Text);
            int idvehi = Int32.Parse(txtIDVehiculo.Text);
            int idcondu = Int32.Parse(txtIDConductor.Text);

            int resultadoActualizar = negocioactualizar.Update(idcontrato, idvehi, idcondu);

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AccesoLogicaContrato negocioeliminar = new AccesoLogicaContrato();
            int idcontrato = Int32.Parse(txtIDContrato.Text);

            int resultadoeliminar = negocioeliminar.delete(idcontrato);
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
