using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Multa : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Multa()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Multa ORDER BY idMulta");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            string precio = txtPrecio.Text;
            string usuario = txtIDUsuario.Text;
            consulta = "INSERT INTO Multa (descripcion,precio,idUsuario) " +
                "values('" + descripcion + "', '" + precio + "','" + usuario + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();

            txtIDUsuario.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idMulta = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string descripcion = txtDescripcion.Text;
            string precio = txtPrecio.Text;
            string usuario = txtIDUsuario.Text;
            consulta = consulta = "UPDATE Multa SET descripcion = '" + descripcion + "', '" + precio + "','" + usuario + "' WHERE idMulta = " + idMulta.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDUsuario.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idMulta = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Multa SET ESTATUS = 0 WHERE idMulta =" + idMulta.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void Multa_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
