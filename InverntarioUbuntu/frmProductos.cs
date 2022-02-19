using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InverntarioUbuntu.BACKEND;
using InverntarioUbuntu.POJOS;

namespace InverntarioUbuntu
{
    public partial class frmProductos : Form
    {
        dao d;
        public frmProductos()
        {
            InitializeComponent();
            d = new dao();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void frmProductos_Load(object sender, EventArgs e)
        {
            actualizarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgregarP nuevo = new frmAgregarP();
            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                actualizarDatos();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Seleccionadas = dataGridView1.SelectedRows.Count;
            if (Seleccionadas == 0 || Seleccionadas > 1)
                return;

            int index =int.Parse( dataGridView1.SelectedRows[0].Cells[0].Value.ToString() );

            MessageBox.Show(index+"");
            dao d = new dao();
            d.eliminar("Inventario", index);
            actualizarDatos();
        }
        public void actualizarDatos()
        {
            dataGridView1.DataSource = d.obtener("Inventario");
        }
    }
}
