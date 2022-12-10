namespace proyectoSQL
{
    partial class Documento
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
            this.txtMapa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCds = new System.Windows.Forms.TextBox();
            this.txtDvd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvActividadPrograma = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlano = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDBil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividadPrograma)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMapa
            // 
            this.txtMapa.Location = new System.Drawing.Point(289, 201);
            this.txtMapa.Name = "txtMapa";
            this.txtMapa.Size = new System.Drawing.Size(175, 22);
            this.txtMapa.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "ingrese el nombre el mapa";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(646, 201);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 40);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCds
            // 
            this.txtCds.Location = new System.Drawing.Point(289, 72);
            this.txtCds.Name = "txtCds";
            this.txtCds.Size = new System.Drawing.Size(175, 22);
            this.txtCds.TabIndex = 50;
            // 
            // txtDvd
            // 
            this.txtDvd.Location = new System.Drawing.Point(289, 132);
            this.txtDvd.Name = "txtDvd";
            this.txtDvd.Size = new System.Drawing.Size(175, 22);
            this.txtDvd.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "ingrese el nombre del dvd";
            // 
            // dgvActividadPrograma
            // 
            this.dgvActividadPrograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividadPrograma.Location = new System.Drawing.Point(1, 375);
            this.dgvActividadPrograma.Name = "dgvActividadPrograma";
            this.dgvActividadPrograma.RowHeadersWidth = 51;
            this.dgvActividadPrograma.RowTemplate.Height = 24;
            this.dgvActividadPrograma.Size = new System.Drawing.Size(1019, 339);
            this.dgvActividadPrograma.TabIndex = 47;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(646, 132);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(101, 40);
            this.btnBorrar.TabIndex = 46;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(646, 72);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 40);
            this.btnModificar.TabIndex = 45;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(646, 20);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 40);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtVideo
            // 
            this.txtVideo.Location = new System.Drawing.Point(289, 21);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(175, 22);
            this.txtVideo.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "ingrese el nombre del cds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "ingrese el nombre del video";
            // 
            // txtPlano
            // 
            this.txtPlano.Location = new System.Drawing.Point(289, 256);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.Size = new System.Drawing.Size(175, 22);
            this.txtPlano.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "ingrese el nombre de los planos";
            // 
            // txtIDBil
            // 
            this.txtIDBil.Location = new System.Drawing.Point(289, 320);
            this.txtIDBil.Name = "txtIDBil";
            this.txtIDBil.Size = new System.Drawing.Size(175, 22);
            this.txtIDBil.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "ingrese el id de la biblioteca";
            // 
            // Documento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 683);
            this.Controls.Add(this.txtIDBil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPlano);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMapa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCds);
            this.Controls.Add(this.txtDvd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvActividadPrograma);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Documento";
            this.Text = "Documento";
            this.Load += new System.EventHandler(this.Documento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividadPrograma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMapa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtCds;
        private System.Windows.Forms.TextBox txtDvd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvActividadPrograma;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDBil;
        private System.Windows.Forms.Label label6;
    }
}