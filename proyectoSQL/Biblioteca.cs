using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Biblioteca : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Biblioteca()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }

        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Biblioteca ORDER BY idBiblioteca");
        }
        private void Biblioteca_Load(object sender, EventArgs e)
        {
           MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            Menu regresar = new Menu();
            regresar.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string calle = txtCalle.Text;
            string colonia = txtColonia.Text;
            string numeroExterior = txtNumeroExterior.Text;
            string telefono = txtTelefono.Text;
            string cuidad = txtCuidad.Text;
            string estado = txtEstado.Text;
            string pais = txtPais.Text;
            consulta = "INSERT INTO Biblioteca (nombre,calle,colonia,numeroExterior,telefono,cuidad,estado,pais) values ('" + nombre + "','" + calle + "','" + colonia + "','" + numeroExterior + "','" + telefono + "','" + cuidad + "','" + estado + "','" + pais + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtPais.Clear();
            txtEstado.Clear();
            txtCuidad.Clear();
            txtTelefono.Clear();
            txtNumeroExterior.Clear();
            txtColonia.Clear();
            txtCalle.Clear();
            txtNombre.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string calle = txtCalle.Text;
            string colonia = txtColonia.Text;
            string numeroExterior = txtNumeroExterior.Text;
            string telefono = txtTelefono.Text;
            string cuidad = txtCuidad.Text;
            string estado = txtEstado.Text;
            string pais = txtPais.Text;
            int idBiblioteca = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Biblioteca SET nombre ='" + nombre + "',calle = '" + calle + "',colonia = '" + colonia + "',numeroExterior = '" + numeroExterior + "',telefono = '" + telefono + "',cuidad = '" + cuidad + "',estado = '" + estado + "',pais = '" + pais + "'WHERE idBiblioteca  = " + idBiblioteca.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtPais.Clear();
            txtEstado.Clear();
            txtCuidad.Clear();
            txtTelefono.Clear();
            txtNumeroExterior.Clear();
            txtColonia.Clear();
            txtCalle.Clear();
            txtNombre.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idBiblioteca = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Biblioteca SET ESTATUS = 0 WHERE idBiblioteca =" + idBiblioteca.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }
    }
}
