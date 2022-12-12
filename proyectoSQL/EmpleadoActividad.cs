using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class EmpleadoActividad : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public EmpleadoActividad()
        {
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
            InitializeComponent();
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM EmpleadoActividad ORDER BY idEmpleadoActividad");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string actividad = txtActividad.Text;
            string empeldao = txtEmpleado.Text;
            consulta = "INSERT INTO EmpleadoActividad (idEmpleado,idActividad) " +
                "values('" + empeldao + "', '" + actividad + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();


            txtActividad.Clear();
            txtEmpleado.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idEmpledoActividad = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string actividad = txtActividad.Text;
            string empeldao = txtEmpleado.Text;
            consulta = "UPDATE EmpleadoActividad SET idEmpleado = '" + empeldao + "', idActividad = '" + actividad + "' WHERE idEmpleadoActividad = " + idEmpledoActividad.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtActividad.Clear();
            txtEmpleado.Clear();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idEmpledoActividad = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE EmpledoActividad SET ESTATUS = 0 WHERE idEmpledoActividad =" + idEmpledoActividad.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void EmpleadoActividad_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
