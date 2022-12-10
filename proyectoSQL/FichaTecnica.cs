using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class FichaTecnica : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public FichaTecnica()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM FichaTecnica ORDER BY idFichaTecnica");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string año = txtFecha.Text;
            string sinopsis = txtSinopsis.Text;
            string idioma = txtIdioma.Text;
            string titulo = txtTitulo.Text;
            string ilustrador = txtIlustrador.Text;
            string libro = txtIDLibro.Text;
            consulta = "INSERT INTO FichaTecnica (año,sinopsis,idiomaOriginal,titulo,ilustradorOriginal,idLibro) " +
                "values('" + año + "', '" + sinopsis + "','" + idioma + "', '" + titulo + "','" + idioma + "', '" + libro +"')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtTitulo.Clear();
            txtFecha.Clear();
            txtSinopsis.Clear();
            txtIdioma.Clear();
            txtIlustrador.Clear();
            txtIDLibro.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idFichaTecnica = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string año = txtFecha.Text;
            string sinopsis = txtSinopsis.Text;
            string idioma = txtIdioma.Text;
            string titulo = txtTitulo.Text;
            string ilustrador = txtIlustrador.Text;
            string libro = txtIDLibro.Text;
            consulta = consulta = "UPDATE FichaTecnica SET año = '" + año + "', '" + sinopsis + "','" + idioma + "', '" + titulo + "','" + idioma + "', '" + libro + "' WHERE idFichaTecnica = " + idFichaTecnica.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtTitulo.Clear();
            txtFecha.Clear();
            txtSinopsis.Clear();
            txtIdioma.Clear();
            txtIlustrador.Clear();
            txtIDLibro.Clear();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idFichaTecnica = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE iichaTecnica SET ESTATUS = 0 WHERE idFichaTecnica =" + idFichaTecnica.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void FichaTecnica_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
