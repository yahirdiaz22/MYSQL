using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class ColeccionLibro : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public ColeccionLibro()
        {
            InitializeComponent(); string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);

        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM ColeccionLibro ORDER BY idColeccionLibro");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idLibro = txtIDLibro.Text;
            string idColeccion = txtIDColeccion.Text;
            consulta = "INSERT INTO ColeccionLibro (idColeccion,idLibro) " +
                "values('" + idColeccion + "', '" + idLibro +"')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDColeccion.Clear();
            txtIDLibro.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idColeccionLibro = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string idColeccion = txtIDColeccion.Text;
            string idLibro = txtIDLibro.Text;
            consulta = "UPDATE ColeccionLibro SET idColeccion = '" + idColeccion + "', idLibro = '" + idLibro + "' WHERE idColeccionLibro = " + idColeccionLibro.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDColeccion.Clear();
            txtIDLibro.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idColeccionLibro = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE ColeccionLibro SET ESTATUS = 0 WHERE idColeccionLibro =" + idColeccionLibro.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void ColeccionLibro_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
