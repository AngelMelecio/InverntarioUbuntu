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
    public partial class frmAgregarA : Form
    {
        bool agre = true;
        dao d = new dao();
        public frmAgregarA()
        {
            InitializeComponent();
        }
        public frmAgregarA(bool Ac, int I, string N, string U)
        {
            InitializeComponent();
            agre = Ac;
            txtId.Text = I+"";
            txtNombre.Text = N;
            txtUbicacion.Text = U;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int I = 0; 
            if( !agre )
                I = int.Parse( txtId.Text );
            string N = txtNombre.Text;
            string U = txtUbicacion.Text;

            if (agre)
            {
                if (d.insertar(N, U))
                {
                    MessageBox.Show("Area Agregada Exitosamente");
                }
                else
                {
                    MessageBox.Show("Error", "No Se Pudo Agregar :c",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if ( d.editar(I,N,U) )
                {
                    MessageBox.Show("Area Editada Exitosamente");
                }
                else
                {
                    MessageBox.Show("Error", "No Se Pudo Editar :c",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            DialogResult = DialogResult.OK;
        }

        private void frmAgregarA_Load(object sender, EventArgs e)
        {
    

            
        }
    }
}
