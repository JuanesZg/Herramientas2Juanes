﻿namespace Presentacion
{
    partial class FormVehiculo
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
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificarVehiculo = new System.Windows.Forms.Button();
            this.dataGridViewVehiculo = new System.Windows.Forms.DataGridView();
            this.btnConsultarVehiculo = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnRegistrarVehiculo = new System.Windows.Forms.Button();
            this.txtMarcaVehiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDVehiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatriculaVehiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModeloVehiculo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoVehiculo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnioVehiculo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(175, 429);
            this.btnEliminarVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarVehiculo.TabIndex = 32;
            this.btnEliminarVehiculo.Text = "Eliminar";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = true;
            this.btnEliminarVehiculo.Click += new System.EventHandler(this.btnEliminarVehiculo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(338, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "VEHICULOS WCG";
            // 
            // btnModificarVehiculo
            // 
            this.btnModificarVehiculo.Location = new System.Drawing.Point(58, 429);
            this.btnModificarVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarVehiculo.Name = "btnModificarVehiculo";
            this.btnModificarVehiculo.Size = new System.Drawing.Size(100, 28);
            this.btnModificarVehiculo.TabIndex = 30;
            this.btnModificarVehiculo.Text = "Modificar";
            this.btnModificarVehiculo.UseVisualStyleBackColor = true;
            this.btnModificarVehiculo.Click += new System.EventHandler(this.btnModificarVehiculo_Click);
            // 
            // dataGridViewVehiculo
            // 
            this.dataGridViewVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculo.Location = new System.Drawing.Point(342, 88);
            this.dataGridViewVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewVehiculo.Name = "dataGridViewVehiculo";
            this.dataGridViewVehiculo.RowHeadersWidth = 51;
            this.dataGridViewVehiculo.Size = new System.Drawing.Size(445, 369);
            this.dataGridViewVehiculo.TabIndex = 29;
            this.dataGridViewVehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTipoConduct_CellContentClick);
            // 
            // btnConsultarVehiculo
            // 
            this.btnConsultarVehiculo.Location = new System.Drawing.Point(175, 375);
            this.btnConsultarVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarVehiculo.Name = "btnConsultarVehiculo";
            this.btnConsultarVehiculo.Size = new System.Drawing.Size(100, 28);
            this.btnConsultarVehiculo.TabIndex = 28;
            this.btnConsultarVehiculo.Text = "Listar Tipos";
            this.btnConsultarVehiculo.UseVisualStyleBackColor = true;
            this.btnConsultarVehiculo.Click += new System.EventHandler(this.btnConsultarVehiculo_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(358, 68);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 27;
            // 
            // btnRegistrarVehiculo
            // 
            this.btnRegistrarVehiculo.Location = new System.Drawing.Point(58, 375);
            this.btnRegistrarVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarVehiculo.Name = "btnRegistrarVehiculo";
            this.btnRegistrarVehiculo.Size = new System.Drawing.Size(100, 28);
            this.btnRegistrarVehiculo.TabIndex = 26;
            this.btnRegistrarVehiculo.Text = "Registrar";
            this.btnRegistrarVehiculo.UseVisualStyleBackColor = true;
            this.btnRegistrarVehiculo.Click += new System.EventHandler(this.btnRegistrarVehiculo_Click);
            // 
            // txtMarcaVehiculo
            // 
            this.txtMarcaVehiculo.Location = new System.Drawing.Point(186, 132);
            this.txtMarcaVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarcaVehiculo.Name = "txtMarcaVehiculo";
            this.txtMarcaVehiculo.Size = new System.Drawing.Size(132, 22);
            this.txtMarcaVehiculo.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Marca";
            // 
            // txtIDVehiculo
            // 
            this.txtIDVehiculo.Location = new System.Drawing.Point(186, 88);
            this.txtIDVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDVehiculo.Name = "txtIDVehiculo";
            this.txtIDVehiculo.Size = new System.Drawing.Size(132, 22);
            this.txtIDVehiculo.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id Vehiculo";
            // 
            // txtMatriculaVehiculo
            // 
            this.txtMatriculaVehiculo.Location = new System.Drawing.Point(186, 221);
            this.txtMatriculaVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatriculaVehiculo.Name = "txtMatriculaVehiculo";
            this.txtMatriculaVehiculo.Size = new System.Drawing.Size(132, 22);
            this.txtMatriculaVehiculo.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Matricula";
            // 
            // txtModeloVehiculo
            // 
            this.txtModeloVehiculo.Location = new System.Drawing.Point(186, 177);
            this.txtModeloVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModeloVehiculo.Name = "txtModeloVehiculo";
            this.txtModeloVehiculo.Size = new System.Drawing.Size(132, 22);
            this.txtModeloVehiculo.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Modelo";
            // 
            // txtTipoVehiculo
            // 
            this.txtTipoVehiculo.Location = new System.Drawing.Point(186, 313);
            this.txtTipoVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoVehiculo.Name = "txtTipoVehiculo";
            this.txtTipoVehiculo.Size = new System.Drawing.Size(132, 22);
            this.txtTipoVehiculo.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 317);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Id Tipo Vehiculo";
            // 
            // txtAnioVehiculo
            // 
            this.txtAnioVehiculo.Location = new System.Drawing.Point(186, 269);
            this.txtAnioVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnioVehiculo.Name = "txtAnioVehiculo";
            this.txtAnioVehiculo.Size = new System.Drawing.Size(132, 22);
            this.txtAnioVehiculo.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Anio";
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.txtTipoVehiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAnioVehiculo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMatriculaVehiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModeloVehiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarVehiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificarVehiculo);
            this.Controls.Add(this.dataGridViewVehiculo);
            this.Controls.Add(this.btnConsultarVehiculo);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnRegistrarVehiculo);
            this.Controls.Add(this.txtMarcaVehiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDVehiculo);
            this.Controls.Add(this.label1);
            this.Name = "FormVehiculo";
            this.Text = "Vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificarVehiculo;
        private System.Windows.Forms.DataGridView dataGridViewVehiculo;
        private System.Windows.Forms.Button btnConsultarVehiculo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnRegistrarVehiculo;
        private System.Windows.Forms.TextBox txtMarcaVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatriculaVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModeloVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipoVehiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnioVehiculo;
        private System.Windows.Forms.Label label7;
    }
}