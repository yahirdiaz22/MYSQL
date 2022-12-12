using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class UsuarioPrestamo : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public UsuarioPrestamo()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM UsuarioPrestamo ORDER BY idUsuarioPrestamo");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string usuario = txtIDUsuario.Text;
            string prestamo = txtIDPrestamo.Text;
            consulta = "INSERT INTO UsuarioPrestamo (idUsuario,idPrestamo) " +
                "values('" + usuario + "', '" + prestamo + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();


            txtIDUsuario.Clear();
            txtIDPrestamo.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idUsuarioPrestamo = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string usuario = txtIDUsuario.Text;
            string prestamo = txtIDPrestamo.Text;
            consulta = "UPDATE UsuarioPrestamo  SET idUsuario = '" + usuario + "', idPrestamo = '" + prestamo + "' WHERE idUsuarioPrestamo = " + idUsuarioPrestamo.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDUsuario.Clear();
            txtIDPrestamo.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idUsuarioPrestamo = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE UsuarioPrestamo SET ESTATUS = 0 WHERE idUsuarioPrestamo =" + idUsuarioPrestamo.ToString();
            conexion.Open();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void UsuarioPrestamo_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
