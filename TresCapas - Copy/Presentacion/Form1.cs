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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = AccesoLogicaTipoVehi.ObtenerTiposVehiculo();
            limpiarCampos();
        }

        void limpiarCampos()
        {
            txtIDTipoVehi.Text = "";
            txtNomTipo.Text = "";
            txtIDTipoVehi.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {            
             //if (!Page.IsValid)
             //return;
             AccesoLogicaTipoVehi negocio = new AccesoLogicaTipoVehi();
             int idtipo = Int32.Parse(txtIDTipoVehi.Text);
             string nombretipo = txtNomTipo.Text;
             int resultado = negocio.Insert(idtipo, nombretipo);
                
            if (resultado > 0)
                lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente.";
            else
                lblMensaje.Text = "Id ya existe, agrege otro o no se inserto el dato";

            negocio = null;
            limpiarCampos();
        }

        //Metodo mostrar registros en una grid
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AccesoLogicaTipoVehi.ObtenerTiposVehiculo();
            //dataGridView1.DataBindings();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pocision = dataGridView1.CurrentRow.Index;
            txtIDTipoVehi.Text = dataGridView1[0, pocision].Value.ToString();
            txtNomTipo.Text = dataGridView1[1, pocision].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            /*dataGridView1[0, pocision].Value = txtIDTipoVehi.Text;
            dataGridView1[1, pocision].Value = txtNomTipo.Text;
            limpiarCampos();*/

            AccesoLogicaTipoVehi negocioactualizar = new AccesoLogicaTipoVehi();
            int idtipo = Int32.Parse(txtIDTipoVehi.Text);
            string nombretipo = txtNomTipo.Text;

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AccesoLogicaTipoVehi negocioeliminar = new AccesoLogicaTipoVehi();
            int idtipo = Int32.Parse(txtIDTipoVehi.Text);

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


        //Metodo mostrar registros en una grid
        /*
        protected void gvMostrar(object sender, EventArgs e)
        {
            GridView.DataSource = AccesoLogica.ObtenerEmpleados();
            GridView.DataBind();
            txtEdad.Text = txtNombre.Text = txtApellido.Text = "";
        }  */
}
