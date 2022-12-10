using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Credencial : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Credencial()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            consulta = "SELECT * FROM Credencial";
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "Credencial");
            conexion.Close();
            dgvActividadPrograma.DataSource = ds.Tables["Credencial"];
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string aPaterno = txtApaterno.Text;
            string aMaterno = txtAmaterno.Text;
            string calle = txtCalle.Text;
            string numero = txtNumero.Text;
            string cuidad = txtCuidad.Text;
            string estado = txtEstado.Text;
            string clave = txtClave.Text;
            string curp = txtClave.Text;
            string pais = txtPais.Text;
            string fecha = txtPais.Text;
            string vigencia = txtPais.Text;
            string sexo = txtSexo.Text;
            string idUsuario = txtIDUsuario.Text;
            consulta = "INSERT INTO Autor (nombre,apellidoPaterno,apellidoMaterno,calle,numeroExterior,cuidad,estado,pais,claveElector,CURP,fechaNacimiento,vigencia,sexo,idUsuario) values ('" + nombre + "','" + aPaterno + "','" + aMaterno + "'+'" + calle  + "','" + numero + "'+'" + cuidad + "','" + estado + "','" + pais + "','" + clave + "', '"+ clave + "',"+ curp +"','" +fecha+"','"+ vigencia+"','"+sexo+"','"+idUsuario+ "')";
            conexion.Open();
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MostrarDatos();

            txtNombre.Clear();
            txtAmaterno.Clear();
            txtApaterno.Clear();
            txtPais.Clear();
            txtEstado.Clear();
            txtCuidad.Clear();
            txtCurp.Clear();
            txtNumero.Clear();
            txtFecha.Clear();
            txtCalle.Clear();
            txtVigencia.Clear();
            txtSexo.Clear();
            txtIDUsuario.Clear();
            txtClave.Clear();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idCredencial = (int)dgvActividadPrograma.SelectedRows[0].Cells[0].Value;
            string nombre = txtNombre.Text;
            string aPaterno = txtApaterno.Text;
            string aMaterno = txtAmaterno.Text;
            string calle = txtCalle.Text;
            string numero = txtNumero.Text;
            string cuidad = txtCuidad.Text;
            string estado = txtEstado.Text;
            string clave = txtClave.Text;
            string curp = txtClave.Text;
            string pais = txtPais.Text;
            string fecha = txtPais.Text;
            string vigencia = txtPais.Text;
            string sexo = txtSexo.Text;
            string idUsuario = txtIDUsuario.Text;
            consulta = consulta = "UPDATE Credencial SET nombre = '" + nombre + "','" + aPaterno + "','" + aMaterno + "'+'" + calle + "','" + numero + "'+'" + cuidad + "','" + estado + "','" + pais + "','" + clave + "', '" + clave + "'," + curp + "','" + fecha + "','" + vigencia + "','" + sexo + "','" + idUsuario + "' WHERE idCredencial = " + idCredencial.ToString();
            conexion.Open();
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MostrarDatos();
            txtNombre.Clear();
            txtAmaterno.Clear();
            txtApaterno.Clear();
            txtPais.Clear();
            txtEstado.Clear();
            txtCuidad.Clear();
            txtCurp.Clear();
            txtNumero.Clear();
            txtFecha.Clear();
            txtCalle.Clear();
            txtVigencia.Clear();
            txtSexo.Clear();
            txtIDUsuario.Clear();
            txtClave.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idCredencial = (int)dgvActividadPrograma.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Credencial SET ESTATUS = 0 WHERE idCredencial =" + idCredencial.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void Credencial_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
