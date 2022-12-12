using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace proyectoSQL
{
    public partial class Autor : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Autor()
        {
            
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
            //conexion.Open();
        }
        private void MostrarDatos()
        {
            dgvActividad.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Autor ORDER BY idAutor");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string aPaterno = txtApaterno.Text;
            string aMaterno = txtAmaterno.Text;
            string calle = txtCalle.Text;
            string colonia = txtColonia.Text;
            string numero = txtNumero.Text;
            string cuidad = txtCuidad.Text;
            string estado = txtEstado.Text;
            string pais = txtPais.Text;
            string telefono = txtTelefono.Text;
            consulta = "INSERT INTO Autor (nombre,apellidoPaterno,apellidoMaterno,calle,colonia,numeroExterior,cuidad,estado,pais,telefono) values ('" + nombre + "','" + aPaterno + "','" + aMaterno + "'+'" + calle + "','" + colonia + "','" + numero + "'+'" + cuidad + "','" + estado + "','" + pais +"','"+telefono+"')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAmaterno.Clear();
            txtApaterno.Clear();
            txtPais.Clear();
            txtEstado.Clear();
            txtCuidad.Clear();
            txtTelefono.Clear();
            txtNumero.Clear();
            txtColonia.Clear();
            txtCalle.Clear();
        }

        private void Autor_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string aPaterno = txtApaterno.Text;
            string aMaterno = txtAmaterno.Text;
            string calle = txtCalle.Text;
            string colonia = txtColonia.Text;
            string numero = txtNumero.Text;
            string cuidad = txtCuidad.Text;
            string estado = txtEstado.Text;
            string pais = txtPais.Text;
            string telefono = txtTelefono.Text;
            int idAutor = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Autor SET nombre ='" + nombre + "',apellidoPaterno = '" + aPaterno + "',apellidoMaterno = '" + aMaterno + "', calle = '" + calle + "',colonia = '" + colonia + "',numeroExterior = '" + numero + "', cuidad = '" + cuidad + "',estado = '" + estado + "',pais = '" + pais + "',telefono = '" + telefono + "'WHERE idAutor = " + idAutor.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAmaterno.Clear();
            txtApaterno.Clear();
            txtPais.Clear();
            txtEstado.Clear();
            txtCuidad.Clear();
            txtTelefono.Clear();
            txtNumero.Clear();
            txtColonia.Clear();
            txtCalle.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idAutor = (int)dgvActividad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Autor SET ESTATUS = 0 WHERE idAutor =" + idAutor.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
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
