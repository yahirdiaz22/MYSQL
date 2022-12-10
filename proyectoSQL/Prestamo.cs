using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Prestamo : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Prestamo()
        {
            InitializeComponent(); string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Prestamo ORDER BY idPrestamo");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = txtPrestamo.Text;
            string fechaEntrega = txtFechaEntrega.Text;
            string credencial = txtIDCredencial.Text;

            consulta = "INSERT INTO Prestamo (fecha,fechaEntrega,idCredencial) " +
                "values('" + fecha + "', '" + fechaEntrega + "','" + credencial + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();

            txtIDCredencial.Clear();
            txtPrestamo.Clear();
            txtFechaEntrega.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idPrestamo = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string fecha = txtPrestamo.Text;
            string fechaEntrega = txtFechaEntrega.Text;
            string credencial = txtIDCredencial.Text;
            consulta = consulta = "UPDATE Prestamo SET fecha = '" + fecha + "', '" + fechaEntrega + "','" + credencial + "' WHERE idPrestamo = " + idPrestamo.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDCredencial.Clear();
            txtPrestamo.Clear();
            txtFechaEntrega.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idPrestamo = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Prestamo SET ESTATUS = 0 WHERE idPrestamo =" + idPrestamo.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
