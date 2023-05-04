﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using negocio;


namespace Catalogo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            NegocioArticulo negocio = new NegocioArticulo();
            dataGridView1.DataSource = negocio.listar();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArt alta = new frmAgregarArt();
            alta.ShowDialog();
            //Refresh datagridview
            Form1_Load(sender, e);
            

        }

      
    }
}