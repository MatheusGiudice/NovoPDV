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
    public partial class frmICMSSubstituicao : Form
    {
        public frmICMSSubstituicao()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este cadastro ?", "VetiPDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro excluído com sucesso !", "Veti PDV");
                btnAlterar.Enabled = true;
                btnNovo.Enabled = true;
                btnCancelar.Visible = false;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro salvo com sucesso !", "Veti PDV");
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnCancelar.Visible = false;
        }

        private void FormICMSSubstituicao_Load(object sender, EventArgs e)
        {
            cbUF.Enabled = false;
            cbRegraICMSSubstituicao.Enabled = false;
            msktxtIVAST.Enabled = false;
            txtCSTSubstituicao.Enabled = false;
            msktxtICMSInterDestino.Enabled = false;
            msktxtICMSInterestadual.Enabled = false;
            msktxtFCPDestino.Enabled = false;
            msktxtFCPOrigem.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cbUF.Enabled = true;
            cbRegraICMSSubstituicao.Enabled = true;
            msktxtIVAST.Enabled = true;
            txtCSTSubstituicao.Enabled = true;
            msktxtICMSInterDestino.Enabled = true;
            msktxtICMSInterestadual.Enabled = true;
            msktxtFCPDestino.Enabled = true;
            msktxtFCPOrigem.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            cbUF.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            cbUF.Enabled = true;
            cbRegraICMSSubstituicao.Enabled = true;
            msktxtIVAST.Enabled = true;
            txtCSTSubstituicao.Enabled = true;
            msktxtICMSInterDestino.Enabled = true;
            msktxtICMSInterestadual.Enabled = true;
            msktxtFCPDestino.Enabled = true;
            msktxtFCPOrigem.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true; 
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            cbUF.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbUF.Text = "";
            cbUF.Enabled = false;
            cbRegraICMSSubstituicao.Text = "";
            cbRegraICMSSubstituicao.Enabled = false;
            msktxtIVAST.Text = "";
            msktxtIVAST.Enabled = false;
            txtCSTSubstituicao.Text = "";
            txtCSTSubstituicao.Enabled = false;
            msktxtICMSInterDestino.Text = "";
            msktxtICMSInterDestino.Enabled = false;
            msktxtICMSInterestadual.Text = "";
            msktxtICMSInterestadual.Enabled = false;
            msktxtFCPDestino.Text = "";
            msktxtFCPDestino.Enabled = false;
            msktxtFCPOrigem.Text = "";
            msktxtFCPOrigem.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
        }
    }
}
