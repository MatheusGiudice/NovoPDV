﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoPDV
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginUsuario _loginUsuario = new frmLoginUsuario();
            _loginUsuario.ShowDialog();
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuporte _suporteForm = new frmSuporte();
            _suporteForm.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSobre _formSobre = new FormSobre();
            _formSobre.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeClientes _formCadastroClientes = new CadastroDeClientes();
            _formCadastroClientes.ShowDialog();
        }
    }
}
