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
    public partial class frmAgregarP : Form
    {
        public frmAgregarP()
        {
            InitializeComponent();
        }

        private void frmAgregarP_Load(object sender, EventArgs e)
        {
            dao d = new dao();
            cboArea.DataSource = d.obtener("Areas");
            cboArea.DisplayMember = "nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string N = txtNombre.Text;
            string D = txtDescripcion.Text;
            string S = txtSerie.Text;
            string C = txtColor.Text;
            string F = dateTimePicker1.Text;
            string T = txtTipo.Text;
            string O = txtObservaciones.Text;
            int A = cboArea.SelectedIndex + 1;

            //MessageBox.Show(F);

            dao d = new dao();
            if (d.insertar(N, D, S, C, F, T, O, A))
            {
                MessageBox.Show("Producto Agregado Exitosamente");
            }
            else
            {
                MessageBox.Show("Error", "No Se Pudo Agregar :c", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult = DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
           
        }
    }
}
