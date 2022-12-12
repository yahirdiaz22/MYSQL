using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Mobiliario : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Mobiliario()
        {
            InitializeComponent();  string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Mobiliario ORDER BY idMobiliario");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string sillas = txtSillas.Text;
            string mesas = txtCantidad.Text;
            string boveda = txtIDBiblioteca.Text;

            consulta = "INSERT INTO Mobiliario (sillas,mesas,idBoveda) " +
                "values('" + sillas + "', '" + mesas + "','" + boveda + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();

            txtIDBiblioteca.Clear();
            txtSillas.Clear();
            txtCantidad.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idMobiliario = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string sillas = txtSillas.Text;
            string mesas = txtCantidad.Text;
            string boveda = txtIDBiblioteca.Text;
            consulta = "UPDATE Mobiliario SET sillas ='" + sillas + "', mesas = '" + mesas + "',idBoveda = '" + boveda + "' WHERE idMobiliario = " + idMobiliario.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDBiblioteca.Clear();
            txtSillas.Clear();
            txtCantidad.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idMobiliario = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Mobiliario SET ESTATUS = 0 WHERE idMobiliario =" + idMobiliario.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void Mobiliario_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
