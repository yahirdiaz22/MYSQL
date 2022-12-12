using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Clasificacion : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Clasificacion()
        {
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
            InitializeComponent();
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Clasificacion ORDER BY idClasificacion");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            string idBiblioteca = txtIdBiblio.Text;
            consulta = "INSERT INTO Clasificacion (nombre, tematica, calidad) " +
                "values('" + descripcion + "', '" + idBiblioteca + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtDescripcion.Clear();
            txtIdBiblio.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idClasificacion = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string descripcion = txtDescripcion.Text;
            string idBiblioteca = txtIdBiblio.Text;
            consulta = "UPDATE Clasificacion SET descripcion = '" + descripcion + "', idBiblioteca = '" + idBiblioteca + "' WHERE idClasificacion = " + idClasificacion.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtDescripcion.Clear();
            txtIdBiblio.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idClasificacion = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Clasificacion SET ESTATUS = 0 WHERE idClasificaion =" + idClasificacion.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void Clasificacion_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
