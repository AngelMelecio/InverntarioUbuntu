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

            int I =int.Parse( dataGridView1.SelectedRows[0].Cells[0].Value.ToString() );

            dao d = new dao();
            if (d.eliminar("Inventario", I))
            {
                MessageBox.Show("Producto con el Id: " + I + " eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Error", "No Se Pudo Eliminar :c",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            actualizarDatos();
        }
        public void actualizarDatos()
        {
            dataGridView1.DataSource = d.obtener("Inventario");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Seleccionadas = dataGridView1.SelectedRows.Count;
            if (Seleccionadas == 0 || Seleccionadas > 1)
                return;

            DataGridViewRow fila = dataGridView1.SelectedRows[0];
            int I = int.Parse(fila.Cells[0].Value.ToString());
            string N = fila.Cells[1].Value.ToString();
            string D = fila.Cells[2].Value.ToString();
            string S = fila.Cells[3].Value.ToString();
            string C = fila.Cells[4].Value.ToString();
            string F = fila.Cells[5].Value.ToString();
            string T = fila.Cells[6].Value.ToString();
            string O = fila.Cells[7].Value.ToString();

            frmAgregarP nuevo = new frmAgregarP(false, I, N, D, S, C, F, T, O) ;
            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                actualizarDatos();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
