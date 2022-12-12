using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Documento : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Documento()
        {
            InitializeComponent(); string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividadPrograma.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Documento ORDER BY idDocumento");
        }

        private void Documento_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string video = txtVideo.Text;
            string cds = txtCds.Text;
            string dvd = txtDvd.Text;
            string mapas = txtMapa.Text;
            string planos = txtPlano.Text;
            string idBiblioteca = txtIDBil.Text;
            consulta = "INSERT INTO Documento (videos,cds,dvd,mapas,planos,idBiblioteca) " +
                "values('" + video + "', '" + cds + "', '" + dvd + "', '" + mapas + "','" + planos + "','" + idBiblioteca + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();


            txtVideo.Clear();
            txtCds.Clear();
            txtDvd.Clear();
            txtMapa.Clear();
            txtPlano.Clear();
            txtIDBil.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idDocumento = (int)dgvActividadPrograma.SelectedRows[0].Cells[0].Value;
            string video = txtVideo.Text;
            string cds = txtCds.Text;
            string dvd = txtDvd.Text;
            string mapas = txtMapa.Text;
            string planos = txtPlano.Text;

            string idBiblioteca = txtIDBil.Text;
            consulta = "UPDATE Documento SET videos = '" + video + "', cds =  '" + cds + "', dvd = '" + dvd + "', mapas = '" + mapas + "',planos = '" + planos + "',idBiblioteca = '" + idBiblioteca + "' WHERE idDocumento = " + idDocumento.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtVideo.Clear();
            txtCds.Clear();
            txtDvd.Clear();
            txtMapa.Clear();
            txtPlano.Clear();
            txtIDBil.Clear();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idDocumento = (int)dgvActividadPrograma.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Documento SET ESTATUS = 0 WHERE idDocumento =" + idDocumento.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
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
