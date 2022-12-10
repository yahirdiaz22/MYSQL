namespace proyectoSQL
{
    partial class Libro
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvActividad = new System.Windows.Forms.DataGridView();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDPresatmo = new System.Windows.Forms.TextBox();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.txtIDPasta = new System.Windows.Forms.TextBox();
            this.txtIDAutor = new System.Windows.Forms.TextBox();
            this.txtIDMaterial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDEstanteria = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDBiblioteca = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDAdquisicion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(450, 195);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(175, 22);
            this.txtCantidad.TabIndex = 197;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 16);
            this.label6.TabIndex = 196;
            this.label6.Text = "ingrese la cantidad de paginas del libro";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1176, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 40);
            this.btnSalir.TabIndex = 195;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(1176, 130);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(101, 40);
            this.btnBorrar.TabIndex = 194;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(1176, 81);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 40);
            this.btnModificar.TabIndex = 193;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1176, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 40);
            this.btnAgregar.TabIndex = 192;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(450, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 22);
            this.txtNombre.TabIndex = 191;
            // 
            // dgvActividad
            // 
            this.dgvActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividad.Location = new System.Drawing.Point(12, 553);
            this.dgvActividad.Name = "dgvActividad";
            this.dgvActividad.RowHeadersWidth = 51;
            this.dgvActividad.RowTemplate.Height = 24;
            this.dgvActividad.Size = new System.Drawing.Size(992, 189);
            this.dgvActividad.TabIndex = 190;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(450, 114);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(175, 22);
            this.txtPais.TabIndex = 189;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 188;
            this.label2.Text = "ingrese el pais del libro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 187;
            this.label1.Text = "ingrese el nombre del libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 198;
            this.label3.Text = "ingrese el id del tema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 199;
            this.label4.Text = "ingrese el id de la pasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 200;
            this.label5.Text = "ingrese el id del prestamo";
            // 
            // txtIDPresatmo
            // 
            this.txtIDPresatmo.Location = new System.Drawing.Point(450, 422);
            this.txtIDPresatmo.Name = "txtIDPresatmo";
            this.txtIDPresatmo.Size = new System.Drawing.Size(175, 22);
            this.txtIDPresatmo.TabIndex = 203;
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(450, 275);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(175, 22);
            this.txtTema.TabIndex = 202;
            // 
            // txtIDPasta
            // 
            this.txtIDPasta.Location = new System.Drawing.Point(450, 341);
            this.txtIDPasta.Name = "txtIDPasta";
            this.txtIDPasta.Size = new System.Drawing.Size(175, 22);
            this.txtIDPasta.TabIndex = 201;
            // 
            // txtIDAutor
            // 
            this.txtIDAutor.Location = new System.Drawing.Point(882, 42);
            this.txtIDAutor.Name = "txtIDAutor";
            this.txtIDAutor.Size = new System.Drawing.Size(175, 22);
            this.txtIDAutor.TabIndex = 207;
            // 
            // txtIDMaterial
            // 
            this.txtIDMaterial.Location = new System.Drawing.Point(882, 114);
            this.txtIDMaterial.Name = "txtIDMaterial";
            this.txtIDMaterial.Size = new System.Drawing.Size(175, 22);
            this.txtIDMaterial.TabIndex = 206;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(647, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 16);
            this.label7.TabIndex = 205;
            this.label7.Text = "ingrese el id del material";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(647, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 16);
            this.label8.TabIndex = 204;
            this.label8.Text = "iingrese el id del autor";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(882, 198);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(175, 22);
            this.txtIDUsuario.TabIndex = 209;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(647, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 16);
            this.label9.TabIndex = 208;
            this.label9.Text = "ingrese el id del usuario";
            // 
            // txtIDEstanteria
            // 
            this.txtIDEstanteria.Location = new System.Drawing.Point(882, 281);
            this.txtIDEstanteria.Name = "txtIDEstanteria";
            this.txtIDEstanteria.Size = new System.Drawing.Size(175, 22);
            this.txtIDEstanteria.TabIndex = 211;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(647, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 16);
            this.label10.TabIndex = 210;
            this.label10.Text = "ingrese el id de la estanteria";
            // 
            // txtIDBiblioteca
            // 
            this.txtIDBiblioteca.Location = new System.Drawing.Point(882, 356);
            this.txtIDBiblioteca.Name = "txtIDBiblioteca";
            this.txtIDBiblioteca.Size = new System.Drawing.Size(175, 22);
            this.txtIDBiblioteca.TabIndex = 213;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(647, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 16);
            this.label11.TabIndex = 212;
            this.label11.Text = "ingrese el id de la biblioteca";
            // 
            // txtIDAdquisicion
            // 
            this.txtIDAdquisicion.Location = new System.Drawing.Point(882, 425);
            this.txtIDAdquisicion.Name = "txtIDAdquisicion";
            this.txtIDAdquisicion.Size = new System.Drawing.Size(175, 22);
            this.txtIDAdquisicion.TabIndex = 215;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(647, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 16);
            this.label12.TabIndex = 214;
            this.label12.Text = "ingrese el id de la adquisicion";
            // 
            // Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 754);
            this.Controls.Add(this.txtIDAdquisicion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIDBiblioteca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIDEstanteria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIDAutor);
            this.Controls.Add(this.txtIDMaterial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIDPresatmo);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.txtIDPasta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvActividad);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Libro";
            this.Text = "Libro";
            this.Load += new System.EventHandler(this.Libro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvActividad;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDPresatmo;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.TextBox txtIDPasta;
        private System.Windows.Forms.TextBox txtIDAutor;
        private System.Windows.Forms.TextBox txtIDMaterial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDEstanteria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDBiblioteca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIDAdquisicion;
        private System.Windows.Forms.Label label12;
    }
}