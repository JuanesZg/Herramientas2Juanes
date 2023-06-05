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
    public partial class FormTipoConduc : Form
    {
        public FormTipoConduc()
        {
            InitializeComponent();
            dataGridViewTipoConduct.DataSource = AccesoLogicaTipoConduc.ObtenerTiposConduc();
            limpiarCampos();
        }
        void limpiarCampos()
        {
            txtIDTipoConduct.Text = "";
            txtNomTipoConduct.Text = "";
            txtIDTipoConduct.Focus();
        }
        private void FormTipoConduc_Load(object sender, EventArgs e)
        {

        }
        
        private void btnRegistrarTipoConduct_Click_1(object sender, EventArgs e)
        {
            AccesoLogicaTipoConduc negocio = new AccesoLogicaTipoConduc();
            int idtipo = Int32.Parse(txtIDTipoConduct.Text);
            string nombretipo = txtNomTipoConduct.Text;
            int resultado = negocio.Insert(idtipo, nombretipo);

            if (resultado > 0)
                lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente.";
            else
                lblMensaje.Text = "Id ya existe, agrege otro o no se inserto el dato";

            negocio = null;
            limpiarCampos();
        }

        private void btnConsultarTipoConduct_Click_1(object sender, EventArgs e)
        {
            dataGridViewTipoConduct.DataSource = AccesoLogicaTipoConduc.ObtenerTiposConduc();
            //dataGridView1.DataBindings();
        }

        private void btnModificarTipoConduct_Click_1(object sender, EventArgs e)
        {
            /*dataGridView1[0, pocision].Value = txtIDTipoVehi.Text;
            dataGridView1[1, pocision].Value = txtNomTipo.Text;
            limpiarCampos();*/

            AccesoLogicaTipoConduc negocioactualizar = new AccesoLogicaTipoConduc();
            int idtipo = Int32.Parse(txtIDTipoConduct.Text);
            string nombretipo = txtNomTipoConduct.Text;

            int resultadoActualizar = negocioactualizar.Update(idtipo, nombretipo);

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
        private void btnEliminarTipoConduct_Click_1(object sender, EventArgs e)
        {
            AccesoLogicaTipoConduc negocioeliminar = new AccesoLogicaTipoConduc();
            int idtipo = Int32.Parse(txtIDTipoConduct.Text);

            int resultadoeliminar = negocioeliminar.delete(idtipo);
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
