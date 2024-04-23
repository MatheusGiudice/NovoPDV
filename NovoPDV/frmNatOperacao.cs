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
    public partial class frmNatOperacao : Form
    {
        public frmNatOperacao()
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro salvo com sucesso !", "Veti PDV");
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
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

        private void FormNatOperacao_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            cbTipoNatureza.Enabled = false;
            txtDescricao.Enabled = false;
            cbLayout.Enabled = false;
            cbFinalidadeEmissao.Enabled = false;
            chkDevolRetorno.Enabled = false;
            chkComplementar.Enabled = false;
            chkEntrada.Enabled = false;
            chkBaseCalcICMScomIPI.Enabled = false;
            chkCalculaICMS.Enabled = false;
            chkNaoAddICMSSubTotalNota.Enabled = false;
            chkBaseCalcICMScomIPIConsFinal.Enabled = false;
            chkCalcEmpSimpNac.Enabled = false;
            chkSobCFOPConfigItensNota.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            txtPesquisar.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            cbTipoNatureza.Enabled = true;
            txtDescricao.Enabled = true;
            cbLayout.Enabled = true;
            cbFinalidadeEmissao.Enabled = true;
            chkDevolRetorno.Enabled = true;
            chkComplementar.Enabled = true;
            chkEntrada.Enabled = true;
            chkBaseCalcICMScomIPI.Enabled = true;
            chkCalculaICMS.Enabled = true;
            chkNaoAddICMSSubTotalNota.Enabled = true;
            chkBaseCalcICMScomIPIConsFinal.Enabled = true;
            chkCalcEmpSimpNac.Enabled = true;
            chkSobCFOPConfigItensNota.Enabled = true;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            txtCodigo.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            cbTipoNatureza.Enabled = true;
            txtDescricao.Enabled = true;
            cbLayout.Enabled = true;
            cbFinalidadeEmissao.Enabled = true;
            chkDevolRetorno.Enabled = true;
            chkComplementar.Enabled = true;
            chkEntrada.Enabled = true;
            chkBaseCalcICMScomIPI.Enabled = true;
            chkCalculaICMS.Enabled = true;
            chkNaoAddICMSSubTotalNota.Enabled = true;
            chkBaseCalcICMScomIPIConsFinal.Enabled = true;
            chkCalcEmpSimpNac.Enabled = true;
            chkSobCFOPConfigItensNota.Enabled = true;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            txtCodigo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtCodigo.Enabled = false;
            cbTipoNatureza.Text = "";
            cbTipoNatureza.Enabled = false;
            txtDescricao.Text = "";
            txtDescricao.Enabled = false;
            cbLayout.Text = "";
            cbLayout.Enabled = false;
            cbFinalidadeEmissao.Text = "";
            cbFinalidadeEmissao.Enabled = false;
            chkDevolRetorno.Checked = false;
            chkDevolRetorno.Enabled = false;
            chkComplementar.Checked = false;
            chkComplementar.Enabled = false;
            chkEntrada.Checked = false; 
            chkEntrada.Enabled = false;
            chkBaseCalcICMScomIPI.Checked = false;
            chkBaseCalcICMScomIPI.Enabled = false;
            chkCalculaICMS.Checked = false;
            chkCalculaICMS.Enabled = false;
            chkNaoAddICMSSubTotalNota.Checked = false;
            chkNaoAddICMSSubTotalNota.Enabled = false;
            chkBaseCalcICMScomIPIConsFinal.Checked = false;
            chkBaseCalcICMScomIPIConsFinal.Enabled = false;
            chkCalcEmpSimpNac.Checked = false;
            chkCalcEmpSimpNac.Enabled = false;
            chkSobCFOPConfigItensNota.Checked = false;
            chkSobCFOPConfigItensNota.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            txtPesquisar.Focus();
        }
    }
}
