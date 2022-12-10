using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace proyectoSQL
{
    public partial class Actividad : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;

        public Actividad()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
            //conexion.Open();

        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Actividad ORDER BY idActividad");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string fecha = txtFecha.Text;
            string descripcion = txtDescripcion.Text;
            string idEmpleado = txtidEmpleado.Text;
            consulta = "INSERT INTO Actividad (nombreActividad,fecha,descripcion,idEmpleado) values ('" + nombre + "','" + fecha + "','" + descripcion + "','"+idEmpleado+"')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtidEmpleado.Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string fecha = txtFecha.Text;
            string descripcion = txtDescripcion.Text;
            string idEmpelado = txtidEmpleado.Text;
            int idActividad = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Actividad SET nombreActividad ='" + nombre + "','" + fecha + "','" + descripcion + "','"+idEmpelado+"'WHERE idActividad = "+idActividad.ToString();
            conexion.Open();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();

            txtNombre.Clear();
            txtDescripcion.Clear();
            txtidEmpleado.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idActividad = (int) dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Actividad SET ESTATUS = 0 WHERE idActividad =" + idActividad.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtidEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvActividad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFecha_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            Menu regresar = new Menu();
            regresar.Show();
        }
    }
}
