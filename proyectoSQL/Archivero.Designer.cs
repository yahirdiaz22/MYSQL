namespace proyectoSQL
{
    partial class Archivero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, 0.</param>
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
            this.txtRecortes = new System.Windows.Forms.TextBox();
            this.dgvActividad = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtIlustraciones = new System.Windows.Forms.TextBox();
            this.txtFolletos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAvisos = new System.Windows.Forms.TextBox();
            this.txtidbiblio = new System.Windows.Forms.TextBox();
            this.txtVolantes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecortes
            // 
            this.txtRecortes.Location = new System.Drawing.Point(261, 66);
            this.txtRecortes.Name = "txtRecortes";
            this.txtRecortes.Size = new System.Drawing.Size(175, 22);
            this.txtRecortes.TabIndex = 36;
            // 
            // dgvActividad
            // 
            this.dgvActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividad.Location = new System.Drawing.Point(12, 336);
            this.dgvActividad.Name = "dgvActividad";
            this.dgvActividad.RowHeadersWidth = 51;
            this.dgvActividad.RowTemplate.Height = 24;
            this.dgvActividad.Size = new System.Drawing.Size(989, 248);
            this.dgvActividad.TabIndex = 35;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(605, 108);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(101, 40);
            this.btnBorrar.TabIndex = 34;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(605, 59);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 40);
            this.btnModificar.TabIndex = 33;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(605, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 40);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtIlustraciones
            // 
            this.txtIlustraciones.Location = new System.Drawing.Point(261, 121);
            this.txtIlustraciones.Name = "txtIlustraciones";
            this.txtIlustraciones.Size = new System.Drawing.Size(175, 22);
            this.txtIlustraciones.TabIndex = 31;
            // 
            // txtFolletos
            // 
            this.txtFolletos.Location = new System.Drawing.Point(261, 18);
            this.txtFolletos.Name = "txtFolletos";
            this.txtFolletos.Size = new System.Drawing.Size(175, 22);
            this.txtFolletos.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "ingrese el nombre de las ilustraciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "ingrese el nombre de los recortes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "ingrese el nombre de los folletos";
            // 
            // txtAvisos
            // 
            this.txtAvisos.Location = new System.Drawing.Point(261, 218);
            this.txtAvisos.Name = "txtAvisos";
            this.txtAvisos.Size = new System.Drawing.Size(175, 22);
            this.txtAvisos.TabIndex = 42;
            // 
            // txtidbiblio
            // 
            this.txtidbiblio.Location = new System.Drawing.Point(261, 273);
            this.txtidbiblio.Name = "txtidbiblio";
            this.txtidbiblio.Size = new System.Drawing.Size(175, 22);
            this.txtidbiblio.TabIndex = 41;
            // 
            // txtVolantes
            // 
            this.txtVolantes.Location = new System.Drawing.Point(261, 170);
            this.txtVolantes.Name = "txtVolantes";
            this.txtVolantes.Size = new System.Drawing.Size(175, 22);
            this.txtVolantes.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "ingrese el id de la Biblioteca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "ingrese el nombre de los avisos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "ingrese el nombre de los volantes";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(748, 59);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 40);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Archivero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 678);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtAvisos);
            this.Controls.Add(this.txtidbiblio);
            this.Controls.Add(this.txtVolantes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRecortes);
            this.Controls.Add(this.dgvActividad);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIlustraciones);
            this.Controls.Add(this.txtFolletos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Archivero";
            this.Text = "Archivero";
            this.Load += new System.EventHandler(this.Archivero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecortes;
        private System.Windows.Forms.DataGridView dgvActividad;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtIlustraciones;
        private System.Windows.Forms.TextBox txtFolletos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAvisos;
        private System.Windows.Forms.TextBox txtidbiblio;
        private System.Windows.Forms.TextBox txtVolantes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
    }
}