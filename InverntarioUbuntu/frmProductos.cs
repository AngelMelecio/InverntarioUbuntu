﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InverntarioUbuntu.BACKEND;

namespace InverntarioUbuntu
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void frmProductos_Load(object sender, EventArgs e)
        {
            dao d = new dao();
            dataGridView1.DataSource = d.obtenerInventario();
        }
    }
}
