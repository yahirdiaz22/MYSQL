using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyectoSQL
{
    public partial class Empleado : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Empleado()
        {
            InitializeComponent(); string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dgvActividadPrograma.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Empleado ORDER BY idEmpleado");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string aPaterno = txtApaterno.Text;
            string aMaterno = txtAmaterno.Text;
            string rfc = txtRFC.Text;
            string calle = txtCalle.Text;
            string numero = txtNumero.Text;
            string cuidad = txtCuidad.Text;
            string estado = txtEstado.Text;
            string pais = txtPais.Text;
            string telefono = txtTelefono.Text;
            string biblioteca = txtIDBIblitoeca.Text;
            consulta = "INSERT INTO Empleado (nombre,apellidoPaterno,apellidoMaterno,rfc,calle,numeroExterior,cuidad,estado,pais,teledono,idBiblioteca) values ('" + nombre + "','" + aPaterno + "','" + aMaterno + "','" + rfc+  "','" + calle + "','" + numero + "'+'" + cuidad + "','" + estado + "','" + pais + "','" + telefono + "', '" +biblioteca + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();

            txtNombre.Clear();
            txtAmaterno.Clear();
            txtApaterno.Clear();
            txtPais.Clear();
            txtEstado.Clear();
            txtCuidad.Clear();
            txtRFC.Clear();
            txtNumero.Clear();
            txtTelefono.Clear();
            txtCalle.Clear();
            txtIDBIblitoeca.Clear();
            txtRFC.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idEmpeldao = (int)dgvActividadPrograma.SelectedRows[0].Cells[0].Value;
            string nombre = txtNombre.Text;
            string aPaterno = txtApaterno.Text;
            string aMaterno = txtAmaterno.Text;
            string rfc = txtRFC.Text;
            string calle = txtCalle.Text;
            string numero = txtNumero.Text;
            string cuidad = txtCuidad.Text;
            string estado = txtEstado.Text;
            string pais = txtPais.Text;
            string telefono = txtTelefono.Text;
            string biblioteca = txtIDBIblitoeca.Text;
            consulta = "UPDATE Empleado SET nombre = '" + nombre + "',apellidoPaterno = '" + aPaterno + "',apellidoMaterno = '" + aMaterno + "',rfc = '" + rfc + "',calle = '" + calle + "', numero = '" + numero + "', cuidad = '" + cuidad + "', estado = '" + estado + "',pais = '" + pais + "',telefono = '" + telefono + "', idBiblioteca = '" + biblioteca + "' WHERE idEmpeldao = " + idEmpeldao.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAmaterno.Clear();
            txtApaterno.Clear();
            txtPais.Clear();
            txtEstado.Clear();
            txtCuidad.Clear();
            txtRFC.Clear();
            txtNumero.Clear();
            txtTelefono.Clear();
            txtCalle.Clear();
            txtIDBIblitoeca.Clear();
            txtRFC.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idEmpeldao = (int)dgvActividadPrograma.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Empeldao SET ESTATUS = 0 WHERE idEmpeldao =" + idEmpeldao.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
