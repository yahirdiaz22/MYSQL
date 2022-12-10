using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class EquipoComputo : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public EquipoComputo()
        {
            InitializeComponent(); string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            consulta = "SELECT * FROM EquipoComputo";
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "EquipoComputo");
            conexion.Close();
            dgvActividadPrograma.DataSource = ds.Tables["EquipoComputo"];
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string numero = txtNumero.Text;
            string fechainicio = txtFechaInicio.Text;
            string fechafinal = txtFechaFiinal.Text;
            string idBiblioteca = txtIDBil.Text;
            consulta = "INSERT INTO EquipoComputo (marca,numeroEquipo,fechaInicio,fechaFinal,idBiblioteac) " +
                "values('" + marca + "', '" + numero + "','" + fechainicio + "', '" + fechafinal + "','" + idBiblioteca +"')";
            conexion.Open();
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close(); MostrarDatos();
            txtMarca.Clear();
            txtNumero.Clear();
            txtFechaInicio.Clear();
            txtFechaFiinal.Clear();
            txtIDBil.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idEquipoComputo = (int)dgvActividadPrograma.SelectedRows[0].Cells[0].Value;
            string marca = txtMarca.Text;
            string numero = txtNumero.Text;
            string fechainicio = txtFechaInicio.Text;
            string fechafinal = txtFechaFiinal.Text;
            string idBiblioteca = txtIDBil.Text;
            consulta = consulta = "UPDATE Clasificacion SET marca = '" + marca + "', '" + numero + "','" + fechainicio + "', '" + fechafinal + "','" + idBiblioteca + "' WHERE idEquipoComputo = " + idEquipoComputo.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtMarca.Clear();
            txtNumero.Clear();
            txtFechaInicio.Clear();
            txtFechaFiinal.Clear();
            txtIDBil.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idEquipoComputo = (int)dgvActividadPrograma.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE EquipoComputo SET ESTATUS = 0 WHERE idEquipoComputo =" + idEquipoComputo.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void EquipoComputo_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
