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
    public partial class frmCadastroCaixa : Form
    {
        public frmCadastroCaixa()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este cadastro ?", "VetiPDV 2.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro excluído com sucesso !", "Veti PDV");
                btnCancelar.Visible = false;
                btnAlterar.Enabled = true;
                btnNovo.Enabled = true;
                txtCodigo.Enabled = false;
                txtDescricao.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro salvo com sucesso !", "Veti PDV");
            btnCancelar.Visible = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
        }

        private void FormCadastroCaixa_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Visible = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            txtCodigo.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Visible = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            txtCodigo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtCodigo.Enabled = false;
            txtDescricao.Text = "";
            txtDescricao.Enabled = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnNovo.Focus();
        }
    }
}
