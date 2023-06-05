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
    public partial class FormVehiculo : Form
    {
        public FormVehiculo()
        {
            InitializeComponent();
            dataGridViewVehiculo.DataSource = AccesoLogicaVehiculo.ObtenerVehiculo();
            limpiarCampos();
        }
        void limpiarCampos()
        {
            txtIDVehiculo.Text = "";
            txtMarcaVehiculo.Text = "";
            txtModeloVehiculo.Text = "";
            txtMatriculaVehiculo.Text = "";
            txtAnioVehiculo.Text = "";
            txtTipoVehiculo.Text = "";
            txtIDVehiculo.Focus();
        }
        private void dataGridViewTipoConduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            AccesoLogicaVehiculo negocio = new AccesoLogicaVehiculo();
            int idvehi = Int32.Parse(txtIDVehiculo.Text);
            string marca = txtMarcaVehiculo.Text;
            string modelo = txtModeloVehiculo.Text;
            string matricula = txtMatriculaVehiculo.Text;
            int anio = Int32.Parse(txtAnioVehiculo.Text);
            int tipovehi = Int32.Parse(txtTipoVehiculo.Text);
            int resultado = negocio.Insert(idvehi, marca, modelo, matricula, anio, tipovehi);

            if (resultado > 0)
                lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente.";
            else
                lblMensaje.Text = "Id ya existe, agrege otro o no se inserto el dato";

            negocio = null;
            limpiarCampos();
        }
        private void btnConsultarVehiculo_Click(object sender, EventArgs e)
        {
            dataGridViewVehiculo.DataSource = AccesoLogicaVehiculo.ObtenerVehiculo();
        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            /*dataGridView1[0, pocision].Value = txtIDTipoVehi.Text;
            dataGridView1[1, pocision].Value = txtNomTipo.Text;
            limpiarCampos();*/

            AccesoLogicaVehiculo negocioactualizar = new AccesoLogicaVehiculo();
            int idvehi = Int32.Parse(txtIDVehiculo.Text);
            string marca = txtMarcaVehiculo.Text;
            string modelo = txtModeloVehiculo.Text;
            string matricula = txtMatriculaVehiculo.Text;
            int anio = Int32.Parse(txtAnioVehiculo.Text);
            int tipovehi = Int32.Parse(txtTipoVehiculo.Text);

            int resultadoActualizar = negocioactualizar.Update(idvehi, marca, modelo, matricula, anio, tipovehi);

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
            AccesoLogicaVehiculo negocioeliminar = new AccesoLogicaVehiculo();
            int idvehi = Int32.Parse(txtIDVehiculo.Text);

            int resultadoeliminar = negocioeliminar.delete(idvehi);
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
