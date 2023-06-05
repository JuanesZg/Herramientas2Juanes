namespace Presentacion
{
    partial class FormTot
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
            this.label3 = new System.Windows.Forms.Label();
            this.tipo_vehiculo = new System.Windows.Forms.Button();
            this.vehiculo = new System.Windows.Forms.Button();
            this.ruta = new System.Windows.Forms.Button();
            this.tipo_conductor = new System.Windows.Forms.Button();
            this.conductor = new System.Windows.Forms.Button();
            this.contrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(452, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "VEHICULOS WCG";
            // 
            // tipo_vehiculo
            // 
            this.tipo_vehiculo.Location = new System.Drawing.Point(324, 150);
            this.tipo_vehiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipo_vehiculo.Name = "tipo_vehiculo";
            this.tipo_vehiculo.Size = new System.Drawing.Size(152, 78);
            this.tipo_vehiculo.TabIndex = 38;
            this.tipo_vehiculo.Text = "Tipo Vehiculo";
            this.tipo_vehiculo.UseVisualStyleBackColor = true;
            this.tipo_vehiculo.Click += new System.EventHandler(this.button1_Click);
            // 
            // vehiculo
            // 
            this.vehiculo.Location = new System.Drawing.Point(324, 252);
            this.vehiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vehiculo.Name = "vehiculo";
            this.vehiculo.Size = new System.Drawing.Size(152, 78);
            this.vehiculo.TabIndex = 39;
            this.vehiculo.Text = "Vehiculo";
            this.vehiculo.UseVisualStyleBackColor = true;
            this.vehiculo.Click += new System.EventHandler(this.vehiculo_Click);
            // 
            // ruta
            // 
            this.ruta.Location = new System.Drawing.Point(324, 358);
            this.ruta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ruta.Name = "ruta";
            this.ruta.Size = new System.Drawing.Size(152, 78);
            this.ruta.TabIndex = 40;
            this.ruta.Text = "Ruta";
            this.ruta.UseVisualStyleBackColor = true;
            this.ruta.Click += new System.EventHandler(this.ruta_Click);
            // 
            // tipo_conductor
            // 
            this.tipo_conductor.Location = new System.Drawing.Point(577, 150);
            this.tipo_conductor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipo_conductor.Name = "tipo_conductor";
            this.tipo_conductor.Size = new System.Drawing.Size(152, 78);
            this.tipo_conductor.TabIndex = 41;
            this.tipo_conductor.Text = "Tipo Conductor";
            this.tipo_conductor.UseVisualStyleBackColor = true;
            this.tipo_conductor.Click += new System.EventHandler(this.tipo_conductor_Click);
            // 
            // conductor
            // 
            this.conductor.Location = new System.Drawing.Point(577, 252);
            this.conductor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conductor.Name = "conductor";
            this.conductor.Size = new System.Drawing.Size(152, 78);
            this.conductor.TabIndex = 42;
            this.conductor.Text = "Conductor";
            this.conductor.UseVisualStyleBackColor = true;
            this.conductor.Click += new System.EventHandler(this.conductor_Click);
            // 
            // contrato
            // 
            this.contrato.Location = new System.Drawing.Point(577, 358);
            this.contrato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contrato.Name = "contrato";
            this.contrato.Size = new System.Drawing.Size(152, 78);
            this.contrato.TabIndex = 43;
            this.contrato.Text = "Contrato";
            this.contrato.UseVisualStyleBackColor = true;
            this.contrato.Click += new System.EventHandler(this.contrato_Click);
            // 
            // FormTot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.contrato);
            this.Controls.Add(this.conductor);
            this.Controls.Add(this.tipo_conductor);
            this.Controls.Add(this.ruta);
            this.Controls.Add(this.vehiculo);
            this.Controls.Add(this.tipo_vehiculo);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTot";
            this.Text = "Panel de Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tipo_vehiculo;
        private System.Windows.Forms.Button vehiculo;
        private System.Windows.Forms.Button ruta;
        private System.Windows.Forms.Button tipo_conductor;
        private System.Windows.Forms.Button conductor;
        private System.Windows.Forms.Button contrato;
    }
}