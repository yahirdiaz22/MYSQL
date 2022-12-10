using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace proyectoSQL
{
    public partial class Estanteria : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Estanteria()
        {
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
            InitializeComponent();
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Estanteria ORDER BY idEstanteria");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string numero = txtNumero.Text;
            string descripcion = txtDescripcion.Text;
            string idClasificacion = txtIDClasificacion.Text;

            consulta = "INSERT INTO Estanteria (numeroEstanteria,descripcion,idClasificacion) " +
                "values('" + numero + "', '" + descripcion + "','" + idClasificacion + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();


            txtNumero.Clear();
            txtDescripcion.Clear();
            txtIDClasificacion.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idEstanteria = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string numero = txtNumero.Text;
            string descripcion = txtDescripcion.Text;
            string idClasificacion = txtIDClasificacion.Text;
            consulta = consulta = "UPDATE Estanteria SET numeroEstanteria = " + numero + "', '" + descripcion + "','" + idClasificacion + "' WHERE idEstanteria = " + idEstanteria.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNumero.Clear();
            txtDescripcion.Clear();
            txtIDClasificacion.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idEstanteria = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Estanteria SET ESTATUS = 0 WHERE idEstanteria =" + idEstanteria.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void Estanteria_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
