using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class ProveedorLibro : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public ProveedorLibro()
        {
            InitializeComponent(); string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM ProveedorLibro ORDER BY idProveedorLibro");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idProveedor = txtIDProveedor.Text;
            string idLibro = txtIDLibro.Text;
            consulta = "INSERT INTO ProveedorLibro (idProveedor,idLibro) " +
                "values('" + idProveedor + "', '" + idLibro + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDProveedor.Clear();
            txtIDLibro.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idProveedorLibro = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string idProveedor = txtIDProveedor.Text;
            string idLibro = txtIDLibro.Text;
            consulta = consulta = "UPDATE ProveedorLibro SET idProveedor = '" + idProveedor + idLibro + "' WHERE idProveedorLibro = " + idProveedorLibro.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDProveedor.Clear();
            txtIDLibro.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idProveedorLibro = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE ProveedorLibro SET ESTATUS = 0 WHERE idProveedorLibro =" + idProveedorLibro.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void ProveedorLibro_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
