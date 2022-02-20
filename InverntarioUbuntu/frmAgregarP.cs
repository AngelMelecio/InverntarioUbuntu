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
        dao d = new dao();
        bool agre = true;
        public frmAgregarP()
        {
            InitializeComponent();
        }
        public frmAgregarP( bool Ac, int I, string N,string D,string S,string C,string F,string T ,string O )
        {
            InitializeComponent();
            agre = Ac;
            txtId.Text = I + "";
            txtNombre.Text = N;
            txtDescripcion.Text = D;
            txtSerie.Text = S;
            txtColor.Text = C;
            dateTimePicker1.Text = F;
            txtTipo.Text = T;
            txtObservaciones.Text = O;

        }
        private void frmAgregarP_Load(object sender, EventArgs e)
        {
            cboArea.DataSource = d.obtener("AREAS");
            cboArea.DisplayMember = "Nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int I = 0;
            if( !agre )
                I = int.Parse(txtId.Text);
            string N = txtNombre.Text;
            string D = txtDescripcion.Text;
            string S = txtSerie.Text;
            string C = txtColor.Text;
            string F = dateTimePicker1.Text;
            string T = txtTipo.Text;
            string O = txtObservaciones.Text;
            cboArea.DisplayMember = "Id";
            int A = int.Parse(cboArea.Text.ToString());
            cboArea.DisplayMember = "Nombre";
            // Es agregar
            if (agre)
            {
                if (d.insertar(N, D, S, C, F, T, O, A))
                {
                    MessageBox.Show("Producto Agregado Exitosamente");
                }
                else
                {
                    MessageBox.Show("Error", "No Se Pudo Agregar :c",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }// Es Editar
           else
            {
                if (d.editar( I,N, D, S, C, F, T, O, A))
                {
                    MessageBox.Show("Producto Editado Exitosamente");
                }
                else
                {
                    MessageBox.Show("Error", "No Se Pudo Editar :c",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DialogResult = DialogResult.OK;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
           
        }
    }
}
