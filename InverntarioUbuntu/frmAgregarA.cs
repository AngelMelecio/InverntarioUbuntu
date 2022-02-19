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
        public frmAgregarA()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string N = txtNombre.Text;
            string U = txtUbicacion.Text;

            daoAA d = new daoAA();
            if (d.insertar(N, U))
            {
                MessageBox.Show("Area Agregada Exitosamente");
            }
            else
            {
                MessageBox.Show("Error", "No Se Pudo Agregar :c",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult = DialogResult.OK;
        }

        private void frmAgregarA_Load(object sender, EventArgs e)
        {
            daoAA d = new daoAA();

            
        }
    }
}
