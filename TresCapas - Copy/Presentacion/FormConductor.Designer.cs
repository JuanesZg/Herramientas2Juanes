namespace Presentacion
{
    partial class FormConductor
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
            this.txtIDTipoConductor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDVehiculo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipoLicencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificarVehiculo = new System.Windows.Forms.Button();
            this.dataGridViewConductor = new System.Windows.Forms.DataGridView();
            this.btnConsultarVehiculo = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnRegistrarVehiculo = new System.Windows.Forms.Button();
            this.txtNombreConductor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDConductor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConductor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDTipoConductor
            // 
            this.txtIDTipoConductor.Location = new System.Drawing.Point(608, 253);
            this.txtIDTipoConductor.Name = "txtIDTipoConductor";
            this.txtIDTipoConductor.Size = new System.Drawing.Size(100, 20);
            this.txtIDTipoConductor.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Id Vehiculo";
            // 
            // txtIDVehiculo
            // 
            this.txtIDVehiculo.Location = new System.Drawing.Point(608, 218);
            this.txtIDVehiculo.Name = "txtIDVehiculo";
            this.txtIDVehiculo.Size = new System.Drawing.Size(100, 20);
            this.txtIDVehiculo.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Id Tipo Conductor";
            // 
            // txtTipoLicencia
            // 
            this.txtTipoLicencia.Location = new System.Drawing.Point(608, 180);
            this.txtTipoLicencia.Name = "txtTipoLicencia";
            this.txtTipoLicencia.Size = new System.Drawing.Size(100, 20);
            this.txtTipoLicencia.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Tipo_licencia";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(599, 348);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarVehiculo.TabIndex = 51;
            this.btnEliminarVehiculo.Text = "Eliminar";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = true;
            this.btnEliminarVehiculo.Click += new System.EventHandler(this.btnEliminarVehiculo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(168, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "VEHICULOS WCG";
            // 
            // btnModificarVehiculo
            // 
            this.btnModificarVehiculo.Location = new System.Drawing.Point(512, 348);
            this.btnModificarVehiculo.Name = "btnModificarVehiculo";
            this.btnModificarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnModificarVehiculo.TabIndex = 49;
            this.btnModificarVehiculo.Text = "Modificar";
            this.btnModificarVehiculo.UseVisualStyleBackColor = true;
            this.btnModificarVehiculo.Click += new System.EventHandler(this.btnModificarVehiculo_Click);
            // 
            // dataGridViewConductor
            // 
            this.dataGridViewConductor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConductor.Location = new System.Drawing.Point(70, 95);
            this.dataGridViewConductor.Name = "dataGridViewConductor";
            this.dataGridViewConductor.RowHeadersWidth = 51;
            this.dataGridViewConductor.Size = new System.Drawing.Size(334, 300);
            this.dataGridViewConductor.TabIndex = 48;
            // 
            // btnConsultarVehiculo
            // 
            this.btnConsultarVehiculo.Location = new System.Drawing.Point(599, 304);
            this.btnConsultarVehiculo.Name = "btnConsultarVehiculo";
            this.btnConsultarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarVehiculo.TabIndex = 47;
            this.btnConsultarVehiculo.Text = "Listar Tipos";
            this.btnConsultarVehiculo.UseVisualStyleBackColor = true;
            this.btnConsultarVehiculo.Click += new System.EventHandler(this.btnConsultarVehiculo_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(488, 53);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 46;
            // 
            // btnRegistrarVehiculo
            // 
            this.btnRegistrarVehiculo.Location = new System.Drawing.Point(512, 304);
            this.btnRegistrarVehiculo.Name = "btnRegistrarVehiculo";
            this.btnRegistrarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarVehiculo.TabIndex = 45;
            this.btnRegistrarVehiculo.Text = "Registrar";
            this.btnRegistrarVehiculo.UseVisualStyleBackColor = true;
            this.btnRegistrarVehiculo.Click += new System.EventHandler(this.btnRegistrarVehiculo_Click);
            // 
            // txtNombreConductor
            // 
            this.txtNombreConductor.Location = new System.Drawing.Point(608, 143);
            this.txtNombreConductor.Name = "txtNombreConductor";
            this.txtNombreConductor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreConductor.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre";
            // 
            // txtIDConductor
            // 
            this.txtIDConductor.Location = new System.Drawing.Point(608, 108);
            this.txtIDConductor.Name = "txtIDConductor";
            this.txtIDConductor.Size = new System.Drawing.Size(100, 20);
            this.txtIDConductor.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Id Conductor";
            // 
            // Conductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIDTipoConductor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIDVehiculo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTipoLicencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarVehiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificarVehiculo);
            this.Controls.Add(this.dataGridViewConductor);
            this.Controls.Add(this.btnConsultarVehiculo);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnRegistrarVehiculo);
            this.Controls.Add(this.txtNombreConductor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDConductor);
            this.Controls.Add(this.label1);
            this.Name = "Conductor";
            this.Text = "Conductor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDTipoConductor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDVehiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipoLicencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificarVehiculo;
        private System.Windows.Forms.DataGridView dataGridViewConductor;
        private System.Windows.Forms.Button btnConsultarVehiculo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnRegistrarVehiculo;
        private System.Windows.Forms.TextBox txtNombreConductor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDConductor;
        private System.Windows.Forms.Label label1;
    }
}