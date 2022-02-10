using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InverntarioUbuntu
{
    public partial class frmPrincipal : Form
    {
        frmAreas newAreas;
        frmProductos newProductos;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            newAreas = new frmAreas();
            abrirForm(newAreas);
            newProductos = new frmProductos();
            abrirForm(newProductos);

        }

        private void areasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newAreas.WindowState = FormWindowState.Maximized;
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newProductos.WindowState = FormWindowState.Maximized;
        }
        private void abrirForm( Form f )
        {
            f.MdiParent = this;
            f.ControlBox= false;
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }
    }
}
