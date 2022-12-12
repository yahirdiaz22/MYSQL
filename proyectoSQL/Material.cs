using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Material : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Material()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Material ORDER BY idMaterial");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipoMaterial = txtMaterial.Text;
            string Cantidad = txtCantidad.Text;
            consulta = "INSERT INTO Material (tipoMaterial,cantidadMaterial) " +
                "values('" + txtCantidad + "', '" + Cantidad + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();


            txtMaterial.Clear();
            txtCantidad.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idMaterial = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            string tipoMaterial = txtMaterial.Text;
            string Cantidad = txtCantidad.Text;
            consulta = "UPDATE Material  SET tipoMaterial = '" + tipoMaterial + "', cantidadMaterial = '" + Cantidad + "' WHERE idMaterial = " + idMaterial.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtMaterial.Clear();
            txtCantidad.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idMaterial = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Material SET ESTATUS = 0 WHERE idMaterial =" + idMaterial.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void Material_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
