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
using InverntarioUbuntu.POJOS;

namespace InverntarioUbuntu
{
    public partial class frmAreas : Form
    {
        public frmAreas()
        {
            InitializeComponent();
        }

        private void frmAreas_Load(object sender, EventArgs e)
        {
            dao d = new dao();
            dataGridView1.DataSource = d.obtener( "Areas" );
        }
    }
}
