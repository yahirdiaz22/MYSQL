using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class AreaMuseo : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public AreaMuseo()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM AreaMuseo ORDER BY idAreaMuseo");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcio.Text;
            string idBiblioteca = txtIdBiblioteca.Text;
            consulta = "INSERT INTO AreaMuseo (nombre,descripcion,idBiblioteca) values ('" + nombre + "','" + descripcion + "','" + idBiblioteca + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtDescripcio.Clear();
            txtIdBiblioteca.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcio.Text;
            string idBiblioteca = txtIdBiblioteca.Text;
            int idAreaMuseo = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE AreaMuseo SET nombre ='" + nombre + "','" + descripcion        + "','" + idBiblioteca + "'WHERE idAreaMuseo = " + idAreaMuseo.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtIdBiblioteca.Clear();
        }

        private void AreaMuseo_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idAreaMuseo = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE AreaMuseo SET ESTATUS = 0 WHERE idAreaMuseo =" + idAreaMuseo.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            Menu regresar = new Menu();
            regresar.Show();
        }
    }
}
