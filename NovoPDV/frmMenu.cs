using System;
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
            frmSobre _formSobre = new frmSobre();
            _formSobre.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroClientes _formCadastroClientes = new frmCadastroClientes();
            _formCadastroClientes.ShowDialog();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEmpresa _cadastroEmpresa = new frmCadastroEmpresa();
            _cadastroEmpresa.ShowDialog();
        }

        private void caixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroCaixa _cadastroCaixa = new frmCadastroCaixa();
            _cadastroCaixa.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor _cadastroFornecedor = new frmCadastroFornecedor();
            _cadastroFornecedor.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario _cadastroFuncionario = new frmCadastroFuncionario();
            _cadastroFuncionario.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroVendedor _cadastroVendedor = new frmCadastroVendedor();
            _cadastroVendedor.ShowDialog();
        }
    }
}
