using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaRestaurante.modelo;
using SistemaRestaurante.controlador;
using System.Data.SqlClient;



namespace SistemaRestaurante
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //DATAACCESSLAYER EN LA CAPA
            SqlConnection conexion = new SqlConnection("Data Source =.; Initial Catalog = SistemaRestaurante; Integrated Security = True");
            conexion.Open();

            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            string cadena = "select * from Usuarios where (Usuario='" + Usuario + "') and (Contraseña='" + Contraseña + "')";

            SqlCommand comnando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comnando.ExecuteReader();
            if(registro.Read())
            {
                conexion.Close();
                conexion.Open();
                MessageBox.Show("BIENVENIDO AL RESTAURANTE ORINOCO'S");
                btnAceptar.Enabled = true;

                frmMenu me = new frmMenu();
                me.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("ERROR, VERIFIQUE SU DATOS");
            }
            conexion.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
