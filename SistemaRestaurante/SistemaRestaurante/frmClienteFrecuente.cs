using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurante
{
    public partial class frmClienteFrecuente : Form
    {
        public frmClienteFrecuente()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu();
            Menu.Show();
            this.Hide();
        }
    }
}
