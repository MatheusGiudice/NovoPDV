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
    public partial class frmNCM : Form
    {
        public frmNCM()
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtNCM.Enabled = true;
            msktxtPorcentIPI.Enabled = true;
            msktxtPorcentCombPobreza.Enabled = true;
            txtNaturezaReceita.Enabled = true;
            txtMensagem.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            txtCodigo.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtNCM.Enabled = true;
            msktxtPorcentIPI.Enabled = true;
            msktxtPorcentCombPobreza.Enabled = true;
            txtNaturezaReceita.Enabled = true;
            txtMensagem.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            txtCodigo.Focus();
        }

        private void FormNCM_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtNCM.Enabled = false;
            msktxtPorcentIPI.Enabled = false;
            msktxtPorcentCombPobreza.Enabled = false;
            txtNaturezaReceita.Enabled = false;
            txtMensagem.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            txtPesquisar.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtCodigo.Enabled = false;
            txtNCM.Text = "";
            txtNCM.Enabled = false;
            msktxtPorcentIPI.Text = "";
            msktxtPorcentIPI.Enabled = false;
            msktxtPorcentCombPobreza.Text = "";
            msktxtPorcentCombPobreza.Enabled = false;
            txtNaturezaReceita.Text = "";
            txtNaturezaReceita.Enabled = false;
            txtMensagem.Text = "";
            txtMensagem.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            txtPesquisar.Focus();
        }
    }
}
