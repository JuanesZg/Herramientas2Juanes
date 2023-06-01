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
    public partial class FormTipoConduct : Form
    {
        public FormTipoConduct()
        {
            InitializeComponent();
            dataGridViewTipoConduct.DataSource = AccesoLogica.ObtenerTiposConduct();
            limpiarCampos();
        }
        void limpiarCampos()
        {
            txtIDTipoConduct.Text = "";
            txtNomTipoConduct.Text = "";
            txtIDTipoConduct.Focus();
        }
        //Metodo registrar en una grid
        private void btnRegistrarTipoConduct_Click(object sender, EventArgs e)
        {
            //if (!Page.IsValid)
            //return;
            AccesoLogica negocio = new AccesoLogica();
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

        //Metodo mostrar registros en una grid
        private void btnConsultarTipoConduct_Click(object sender, EventArgs e)
        {
            dataGridViewTipoConduct.DataSource = AccesoLogica.ObtenerTiposConduct();
            //dataGridView1.DataBindings();

        }

        private void dataGridViewTipoConduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pocision = dataGridViewTipoConduct.CurrentRow.Index;
            txtIDTipoConduct.Text = dataGridViewTipoConduct[0, pocision].Value.ToString();
            txtNomTipoConduct.Text = dataGridViewTipoConduct[1, pocision].Value.ToString();
        }


        //Metodo modificar registros en una grid
        private void btnModificarTipoConduct_Click(object sender, EventArgs e)
        {
            /*dataGridView1[0, pocision].Value = txtIDTipoVehi.Text;
            dataGridView1[1, pocision].Value = txtNomTipo.Text;
            limpiarCampos();*/

            AccesoLogica negocioactualizar = new AccesoLogica();
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

        //Metodo eliminar registros en una grid
        private void btnEliminarTipoConduct_Click(object sender, EventArgs e)
        {
            AccesoLogica negocioeliminar = new AccesoLogica();
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








        private void FormTipoVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
