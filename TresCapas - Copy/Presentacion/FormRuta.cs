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
    public partial class FormRuta : Form
    {
        public FormRuta()
        {
            InitializeComponent();
            dataGridViewRuta.DataSource = AccesoLogicaRuta.ObtenerRuta();
            limpiarCampos();
        }

        void limpiarCampos()
        {
            txtIDRuta.Text = "";
            txtEstacion.Text = "";
            txtEstacion.Text = "";
            txtIDRuta.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //if (!Page.IsValid)
            //return;
            AccesoLogicaRuta negocio = new AccesoLogicaRuta();
            int idruta = Int32.Parse(txtIDRuta.Text);
            string estacion = txtEstacion.Text;
            int vehiculo = Int32.Parse(txtIDRuta.Text);
            int resultado = negocio.Insert(idruta, estacion, vehiculo);

            if (resultado > 0)
                lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente.";
            else
                lblMensaje.Text = "Id ya existe, agrege otro o no se inserto el dato";

            negocio = null;
            limpiarCampos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridViewRuta.DataSource = AccesoLogicaRuta.ObtenerRuta();
            //dataGridView1.DataBindings();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            /*dataGridView1[0, pocision].Value = txtIDTipoVehi.Text;
            dataGridView1[1, pocision].Value = txtNomTipo.Text;
            limpiarCampos();*/

            AccesoLogicaRuta negocioactualizar = new AccesoLogicaRuta();
            int idruta = Int32.Parse(txtIDRuta.Text);
            string estacion = txtEstacion.Text;
            int vehiculo = Int32.Parse(txtIDRuta.Text);

            int resultadoActualizar = negocioactualizar.Update(idruta, estacion, vehiculo);

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
            AccesoLogicaRuta negocioeliminar = new AccesoLogicaRuta();
            int idruta = Int32.Parse(txtIDRuta.Text);

            int resultadoeliminar = negocioeliminar.delete(idruta);
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
