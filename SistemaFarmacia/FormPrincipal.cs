﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaFarmacia.MODULOS
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios next = new FormUsuarios();
            next.MdiParent = this.MdiParent;
            next.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MODULOS.Caja.FormCaja nuevo = new Caja.FormCaja();
            nuevo.MdiParent = this;
            nuevo.Show();
        }
    }
}
