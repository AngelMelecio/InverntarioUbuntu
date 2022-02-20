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
    public partial class frmAreas : Form
    {
        dao d = new dao();
        public frmAreas()
        {
            InitializeComponent();
            
        }

        private void frmAreas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = d.obtener( "AREAS" );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgregarA nuevo = new frmAgregarA();
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

            int I = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            //MessageBox.Show(index+"");
            dao d = new dao();
            if (d.eliminar("AREAS", I))
            {
                MessageBox.Show("Area con el Id: " + I + " eliminada exitosamente");
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
            dataGridView1.DataSource = d.obtener("AREAS");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Seleccionadas = dataGridView1.SelectedRows.Count;
            if (Seleccionadas == 0 || Seleccionadas > 1)
                return;
            DataGridViewRow fila = dataGridView1.SelectedRows[0];
            int I = int.Parse(fila.Cells[0].Value.ToString());
            string N = fila.Cells[1].Value.ToString() ;
            string U = fila.Cells[2].Value.ToString();

            frmAgregarA nueva = new frmAgregarA(false,I, N, U);
            if (nueva.ShowDialog() == DialogResult.OK)
            {
                actualizarDatos();
            }

        }
    }
}
