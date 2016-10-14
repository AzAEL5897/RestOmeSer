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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaUsuario alt = new frmAltaUsuario();
            alt.Show();
            this.Hide();
        }

        private void agregarClienteFrecuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteFrecuente clie = new frmClienteFrecuente();
            clie.Show();
            this.Hide();
        }

        private void distribuccionDeLasMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMesas mes = new frmMesas();
            mes.Show();
            this.Hide();
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenar ord = new frmOrdenar();
            ord.Show();
            this.Hide();
        }
    }
}
