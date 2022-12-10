using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace proyectoSQL
{
    public partial class Imprenta : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Imprenta()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Imprenta ORDER BY idImprenta");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string numero = txtNumero.Text;
            string descripcion = txtDescripcion.Text;
            string cantidad = txtCantidad.Text;
            string editorial = txtEditorial.Text;
            consulta = "INSERT INTO Editorial (nombre,numeroImprenta,descripcion,cantidadTotal,idEditorial) " +
                "values('" + nombre + "', '" + numero + "','" + descripcion + "','" + cantidad + "','" + editorial + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();

            txtCantidad.Clear();
            txtDescripcion.Clear();
            txtEditorial.Clear();
            txtNombre.Clear();
            txtNumero.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idImprenta = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string nombre = txtNombre.Text;
            string numero = txtNumero.Text;
            string descripcion = txtDescripcion.Text;
            string cantidad = txtCantidad.Text;
            string editorial = txtEditorial.Text;
            consulta = consulta = "UPDATE Imprenta SET nombre = '" + nombre + "', '" + numero + "','" + descripcion + "','" + cantidad + "','" + editorial + "' WHERE idImprenta = " + idImprenta.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtCantidad.Clear();
            txtDescripcion.Clear();
            txtEditorial.Clear();
            txtNombre.Clear();
            txtNumero.Clear();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idImprenta = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Imprenta SET ESTATUS = false WHERE idImprenta =" + idImprenta.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void Imprenta_Load(object sender, EventArgs e)
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
