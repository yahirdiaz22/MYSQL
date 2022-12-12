using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Pasta : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Pasta()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Pasta ORDER BY idPasta");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string color = txtColor.Text;
            string pasta = txtTipo.Text;
            consulta = "INSERT INTO Pasta (color,tipoPasta) " +
                "values('" + color + "', '" + txtTipo + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtTipo.Clear();
            txtColor.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idPasta = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string color = txtColor.Text;
            string pasta = txtTipo.Text;
            consulta = "UPDATE Pasta  SET color = '" + color + "', tipoPasta = '" + pasta + "' WHERE idPasta = " + idPasta.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtTipo.Clear();
            txtColor.Clear();
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

        private void Pasta_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
