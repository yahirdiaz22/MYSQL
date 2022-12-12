using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class DevolucionPrestamo : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public DevolucionPrestamo()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM DevolucionPrestamo ORDER BY idDevolucionPrestamo");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string devolucion = txtIDDevolucion.Text;
            string prestamo = txtIDPRestamo.Text;
            consulta = "INSERT INTO DevolucionPrestamo (idDevolucion, idPrestamo) " +
                "values('" + devolucion + "', '" + prestamo +  "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();


            txtIDDevolucion.Clear();
            txtIDPRestamo.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idDevolucionPresatmo = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string devolucion = txtIDDevolucion.Text;
            string prestamo = txtIDPRestamo.Text;
            consulta = "UPDATE DevolucionPrestamo SET idDevolucion = '" + devolucion + "', idPrestamo =  '" + prestamo + "' WHERE idDevolucionPrestamo = " + idDevolucionPresatmo.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDDevolucion.Clear();
            txtIDPRestamo.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idDevolucionPresatmo = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE DevolucionPresatmo SET ESTATUS = 0 WHERE idDevolucionPresatmo =" + idDevolucionPresatmo.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void DevolucionPrestamo_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }
    }
}
