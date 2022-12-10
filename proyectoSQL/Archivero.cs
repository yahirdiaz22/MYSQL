using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Archivero : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Archivero()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string folletos = txtFolletos.Text;
            string recortes = txtRecortes.Text;
            string ilustraciones = txtIlustraciones.Text;
            string volantes = txtVolantes.Text;
            string avisos = txtAvisos.Text;
            string idBiblioteca = txtidbiblio.Text;
            consulta = "INSERT INTO Archivero (folletos,recortes,ilustracions,volantes,avisos,idBiblioteca) values ('" + folletos + "','" + recortes + "','" + ilustraciones + "','" + volantes + "','" + avisos + "','" + idBiblioteca + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFolletos.Clear();
            txtRecortes.Clear();
            txtIlustraciones.Clear();
            txtVolantes.Clear();
            txtAvisos.Clear();
            txtidbiblio.Clear();
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Archivero ORDER BY idArchivero");
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string folletos = txtFolletos.Text;
            string recortes = txtRecortes.Text;
            string ilustraciones = txtIlustraciones.Text;
            string volantes = txtVolantes.Text;
            string avisos = txtAvisos.Text;
            string idBiblioteca = txtidbiblio.Text;
            int idArchivero = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Archivero SET folletos ='" + folletos + "','" + recortes + "','" + ilustraciones + "','" + volantes + "','" + avisos + "','" + idBiblioteca + "' WHERE idArchivero = " + idArchivero.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFolletos.Clear();
            txtRecortes.Clear();
            txtIlustraciones.Clear();
            txtVolantes.Clear();
            txtAvisos.Clear();
            txtidbiblio.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idActividad = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Actividad SET ESTATUS = 0 WHERE idActividad =" + idActividad.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void Archivero_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            Menu regresar = new Menu();
            regresar.Show();
        }
    }
}
