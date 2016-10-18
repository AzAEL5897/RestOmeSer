using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestOmegSerWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            timerFechaHora.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Jesus")
            {
                if(txtContraseña.Text == "12345678")
                {
                    MessageBox.Show("Bienvenido al Restaurante Orinoco's");
                    frmMenu Menu = new frmMenu();
                    Menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
          
        }

        private void btlCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
