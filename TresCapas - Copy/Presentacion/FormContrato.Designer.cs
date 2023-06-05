namespace Presentacion
{
    partial class FormContrato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIDConductor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dataGridViewContrato = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtIDVehiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDContrato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDConductor
            // 
            this.txtIDConductor.Location = new System.Drawing.Point(400, 165);
            this.txtIDConductor.Name = "txtIDConductor";
            this.txtIDConductor.Size = new System.Drawing.Size(100, 20);
            this.txtIDConductor.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Id Conductor";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(480, 223);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(332, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "VEHICULOS WCG";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(399, 223);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dataGridViewContrato
            // 
            this.dataGridViewContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContrato.Location = new System.Drawing.Point(218, 261);
            this.dataGridViewContrato.Name = "dataGridViewContrato";
            this.dataGridViewContrato.RowHeadersWidth = 51;
            this.dataGridViewContrato.Size = new System.Drawing.Size(364, 132);
            this.dataGridViewContrato.TabIndex = 31;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(318, 223);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 30;
            this.btnConsultar.Text = "Listar Tipos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(284, 195);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 29;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(237, 223);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 28;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtIDVehiculo
            // 
            this.txtIDVehiculo.Location = new System.Drawing.Point(400, 131);
            this.txtIDVehiculo.Name = "txtIDVehiculo";
            this.txtIDVehiculo.Size = new System.Drawing.Size(100, 20);
            this.txtIDVehiculo.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Id Vehiculo";
            // 
            // txtIDContrato
            // 
            this.txtIDContrato.Location = new System.Drawing.Point(400, 99);
            this.txtIDContrato.Name = "txtIDContrato";
            this.txtIDContrato.Size = new System.Drawing.Size(100, 20);
            this.txtIDContrato.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id Contrato";
            // 
            // FormContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIDConductor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridViewContrato);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtIDVehiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDContrato);
            this.Controls.Add(this.label1);
            this.Name = "FormContrato";
            this.Text = "FormContrato";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDConductor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dataGridViewContrato;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtIDVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDContrato;
        private System.Windows.Forms.Label label1;
    }
}