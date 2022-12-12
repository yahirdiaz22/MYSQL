using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace proyectoSQL
{
    public partial class Inventario : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Inventario()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Inventario ORDER BY idInventario");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            string fecha = txtFecha.Text;
            string empleado = txtIDEmpleado.Text;

            consulta = "INSERT INTO Inventario (descripcion,fecha,idEmpleado) " +
                "values('" + descripcion + "', '" + fecha + "','" + empleado + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();

            txtIDEmpleado.Clear();
            txtDescripcion.Clear();
            txtFecha.Clear();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idInventario = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string descripcion = txtDescripcion.Text;
            string fecha = txtFecha.Text;
            string empleado = txtIDEmpleado.Text;
            consulta = "UPDATE Inventario SET descripcion = '" + descripcion + "',fecha = '" + fecha + "',idEmpleado ='" + empleado + "' WHERE idInventario = " + idInventario.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDEmpleado.Clear();
            txtDescripcion.Clear();
            txtFecha.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idInventario = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Inventario SET ESTATUS = 0 WHERE idInventario =" + idInventario.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void Inventario_Load(object sender, EventArgs e)
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
