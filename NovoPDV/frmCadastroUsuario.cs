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
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
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
            if (MessageBox.Show("Deseja realmente excluir este cadastro ?", "VetiPDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro excluído com sucesso !", "Veti PDV");
                btnCancelar.Visible = false;
                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro salvo com sucesso !", "Veti PDV");
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            chklstboxFuncoes.Enabled = false;
            chklstboxModulos.Enabled = false;
            chkSupervisor.Enabled = false;
            txtCodigoUsuario.Enabled = false;
            txtNomeUsuario.Enabled = false;
            btnNovo.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            chklstboxFuncoes.Enabled = true;
            chklstboxModulos.Enabled = true;
            chkSupervisor.Enabled = true;
            txtNomeUsuario.Enabled = true;
            txtSenhaUsuario.Enabled = true;
            txtCodigoUsuario.Enabled = false;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            btnAlterar.Enabled = false;
            txtNomeUsuario.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            chklstboxFuncoes.Enabled = true;
            chklstboxModulos.Enabled = true;
            chkSupervisor.Enabled = true;
            txtNomeUsuario.Enabled = true;
            txtSenhaUsuario.Enabled = true;
            txtCodigoUsuario.Enabled = false;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            btnAlterar.Enabled = false;
            txtNomeUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            chklstboxFuncoes.Enabled = false;
            chklstboxModulos.Enabled = false;
            chkSupervisor.Checked = false;
            chkSupervisor.Enabled = false;
            txtCodigoUsuario.Text = "";
            txtCodigoUsuario.Enabled = false;
            txtNomeUsuario.Text = "";
            txtNomeUsuario.Enabled = false;
            txtSenhaUsuario.Text = "";
            txtSenhaUsuario.Enabled = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
        }
    }
}
