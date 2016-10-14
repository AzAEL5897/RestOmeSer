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


namespace SistemaRestaurante
{
    public partial class frmMesas : Form
    {
        public frmMesas()
        {
            InitializeComponent();
        }

        private void Mesas_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenu Me = new frmMenu();
            Me.Show();
            this.Hide();
            

        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
           
            Mesa mesa = new Mesa();
            ClienteFrecuente clientFre = new ClienteFrecuente();
            
        }
    }
}
