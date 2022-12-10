namespace proyectoSQL
{
    partial class Adquisicion
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
            this.txtDonacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuscripcion = new System.Windows.Forms.TextBox();
            this.dgvAdquisicion = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtIntercambio = new System.Windows.Forms.TextBox();
            this.txtCompar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdquisicion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDonacion
            // 
            this.txtDonacion.Location = new System.Drawing.Point(433, 157);
            this.txtDonacion.Name = "txtDonacion";
            this.txtDonacion.Size = new System.Drawing.Size(175, 22);
            this.txtDonacion.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "ingresa cantidad de donacion de la adquisicion";
            // 
            // txtSuscripcion
            // 
            this.txtSuscripcion.Location = new System.Drawing.Point(433, 59);
            this.txtSuscripcion.Name = "txtSuscripcion";
            this.txtSuscripcion.Size = new System.Drawing.Size(175, 22);
            this.txtSuscripcion.TabIndex = 56;
            // 
            // dgvAdquisicion
            // 
            this.dgvAdquisicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdquisicion.Location = new System.Drawing.Point(55, 227);
            this.dgvAdquisicion.Name = "dgvAdquisicion";
            this.dgvAdquisicion.RowHeadersWidth = 51;
            this.dgvAdquisicion.RowTemplate.Height = 24;
            this.dgvAdquisicion.Size = new System.Drawing.Size(1157, 257);
            this.dgvAdquisicion.TabIndex = 55;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(729, 132);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(101, 40);
            this.btnBorrar.TabIndex = 54;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(729, 83);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 40);
            this.btnModificar.TabIndex = 53;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(729, 38);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 40);
            this.btnAgregar.TabIndex = 52;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtIntercambio
            // 
            this.txtIntercambio.Location = new System.Drawing.Point(433, 101);
            this.txtIntercambio.Name = "txtIntercambio";
            this.txtIntercambio.Size = new System.Drawing.Size(175, 22);
            this.txtIntercambio.TabIndex = 51;
            // 
            // txtCompar
            // 
            this.txtCompar.Location = new System.Drawing.Point(433, 11);
            this.txtCompar.Name = "txtCompar";
            this.txtCompar.Size = new System.Drawing.Size(175, 22);
            this.txtCompar.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "ingresa el interacmbio de la suscripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "ingresa la suscripcion de la adquisicion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "ingresa la compra de la adquisicion";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(963, 62);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 40);
            this.btnSalir.TabIndex = 59;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Adquisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 753);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtDonacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSuscripcion);
            this.Controls.Add(this.dgvAdquisicion);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIntercambio);
            this.Controls.Add(this.txtCompar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Adquisicion";
            this.Text = "Adquisicion";
            this.Load += new System.EventHandler(this.Adquisicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdquisicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDonacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuscripcion;
        private System.Windows.Forms.DataGridView dgvAdquisicion;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtIntercambio;
        private System.Windows.Forms.TextBox txtCompar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}