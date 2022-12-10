using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Ejemplares : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Ejemplares()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Ejemplares ORDER BY idEjemplares");
        }
        private void Ejemplares_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string desrcipcion = txtEjemplare.Text;
            string numero = txtDescripcion.Text;
            consulta = "INSERT INTO Ejemplares (totalEjemplares,descripcion) " +
                "values('" + desrcipcion + "', '" + numero + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();

            txtDescripcion.Clear();
            txtEjemplare.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idEjemplares = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string Total = txtEjemplare.Text;
            string descripcion = txtDescripcion.Text;

            consulta = consulta = "UPDATE Ejemplares SET totalEjemplares = '" + Total + "', '" + descripcion + "' WHERE idEjemplares = " + idEjemplares.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtDescripcion.Clear();
            txtEjemplare.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idEjemplares = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Ejemplares SET ESTATUS = 0 WHERE idEditorialRevista =" + idEjemplares.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtEjemplare.Clear();
            txtDescripcion.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }
    }
}
