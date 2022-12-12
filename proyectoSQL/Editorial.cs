using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Editorial : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Editorial()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Editorial ORDER BY idEditorial");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string calle = txtCalle.Text;
            string colonia = txtColonia.Text;
            string numeroExterior = txtNumeroExterior.Text;
            string telefono = txtTelefono.Text;
            string cuidad = txtCuida.Text;
            string estado = txtEstado.Text;
            string pais = txtPais.Text;
            string libro = txtLibrp.Text;
            string revista = txtRevista.Text;
            consulta = "INSERT INTO Editorial (nombre,calle,colonia,numeroExterior,cuidad,estado,pais,telefono,idLibro,idRevista) values ('" + nombre + "','" + calle + "','" + colonia + "','" + numeroExterior + "','" + cuidad + "','" + estado + "','" + pais + "','" + telefono + "','" + libro + "','" + revista + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtPais.Clear();
            txtEstado.Clear();
            txtRevista.Clear();
            txtLibrp.Clear();
            txtCuida.Clear();
            txtTelefono.Clear();
            txtNumeroExterior.Clear();
            txtColonia.Clear();
            txtCalle.Clear();
            txtNombre.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string calle = txtCalle.Text;
            string colonia = txtColonia.Text;
            string numeroExterior = txtNumeroExterior.Text;
            string telefono = txtTelefono.Text;
            string cuidad = txtCuida.Text;
            string estado = txtEstado.Text;
            string pais = txtPais.Text;
            string libro = txtLibrp.Text;
            string revista = txtRevista.Text;
            int idEditorial = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Editorial SET nombre = '" + nombre + "',calle = '" + calle + "',colonia = '" + colonia + "',numeroExterior = '" + numeroExterior + "',cuidad = '" + cuidad + "',estado = '" + estado + "', pais = '" + pais + "', telefono = '" + telefono + "',idLibro = '" + libro + "',idRevista = '" + revista + "' WHERE idEditorial = " + idEditorial.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtPais.Clear();
            txtEstado.Clear();
            txtRevista.Clear();
            txtLibrp.Clear();
            txtCuida.Clear();
            txtTelefono.Clear();
            txtNumeroExterior.Clear();
            txtColonia.Clear();
            txtCalle.Clear();
            txtNombre.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idEditorial = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Editorial SET ESTATUS = 0 WHERE idEditorial =" + idEditorial.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }
    

        private void Editorial_Load(object sender, EventArgs e)
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
