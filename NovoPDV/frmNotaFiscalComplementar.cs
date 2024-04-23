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
    public partial class frmNotaFiscalComplementar : Form
    {
        public frmNotaFiscalComplementar()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?","Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormNotaFiscalComplementar_Load(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnSituacaoNF.Enabled = false;
            btnEnviaNF.Enabled = false;
            btnGeraNFe.Enabled = false;
            txtNumNota.Enabled = false;
            cbNatOperacao.Enabled = false;
            dtDataEmissao.Enabled = false;
            dtDataSaida.Enabled = false;
            dtHorario.Enabled = false;
            txtCliente.Enabled = false;
            chkNaoInformaDataHoraSaida.Enabled = false;
            msktxtBaseICMS.Enabled = false;
            msktxtValorICMS.Enabled = false;
            msktxtTotalProdutos.Enabled = false;
            msktxtTotalNota.Enabled = false;
            msktxtBaseICMSSub.Enabled = false;
            msktxtValorICMSSub.Enabled = false;
            msktxtTotalServicos.Enabled = false;
            msktxtValorISS.Enabled = false;
            msktxtValorIPI.Enabled = false;
            msktxtValorSeguro.Enabled = false;
            msktxtValorDespesas.Enabled = false;
            msktxtValorFrete.Enabled = false;
            txtNotaComplementada.Enabled = false;
            txtChaveAcesso.Enabled = false;
            cbMensagem1.Enabled = false;
            cbMensagem2.Enabled = false;
            cbMensagem3.Enabled = false;
            cbMensagem4.Enabled = false;
            txtCodProduto.Enabled = false;
            msktxtValorUnitario.Enabled = false;
            txtQuantidade.Enabled = false;
            txtNCM.Enabled = false;
            msktxtValorIPI2.Enabled = false;
            txtUnidade.Enabled = false;
            txtSitTributaria.Enabled = false;
            txtCFOP.Enabled = false;
            msktxtTotal.Enabled = false;
            txtAliqICMS.Enabled = false;
            txtAliqISS.Enabled = false;
            txtAliqIPI.Enabled = false;
            txtPesquisar.Focus();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            btnGeraNFe.Enabled = true;
            txtNumNota.Enabled = true;
            cbNatOperacao.Enabled = true;
            dtDataEmissao.Enabled = true;
            dtDataSaida.Enabled = true;
            dtHorario.Enabled = true;
            txtCliente.Enabled = true;
            chkNaoInformaDataHoraSaida.Enabled = true;
            msktxtBaseICMS.Enabled = true;
            msktxtValorICMS.Enabled = true;
            msktxtTotalProdutos.Enabled = true;
            msktxtTotalNota.Enabled = true;
            msktxtBaseICMSSub.Enabled = true;
            msktxtValorICMSSub.Enabled = true;
            msktxtTotalServicos.Enabled = true;
            msktxtValorISS.Enabled = true;
            msktxtValorIPI.Enabled = true;
            msktxtValorSeguro.Enabled = true;
            msktxtValorDespesas.Enabled = true;
            msktxtValorFrete.Enabled = true;
            txtNotaComplementada.Enabled = true;
            txtChaveAcesso.Enabled = true;
            cbMensagem1.Enabled = true;
            cbMensagem2.Enabled = true;
            cbMensagem3.Enabled = true;
            cbMensagem4.Enabled = true;
            txtCodProduto.Enabled = true;
            msktxtValorUnitario.Enabled = true;
            txtQuantidade.Enabled = true;
            txtNCM.Enabled = true;
            msktxtValorIPI2.Enabled = true;
            txtUnidade.Enabled = true;
            txtSitTributaria.Enabled = true;
            txtCFOP.Enabled = true;
            msktxtTotal.Enabled = true;
            txtAliqICMS.Enabled = true;
            txtAliqISS.Enabled = true;
            txtAliqIPI.Enabled = true;
            btnIncluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = true;
            txtNumNota.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnGeraNFe.Enabled = true;
            txtNumNota.Enabled = true;
            cbNatOperacao.Enabled = true;
            dtDataEmissao.Enabled = true;
            dtDataSaida.Enabled = true;
            dtHorario.Enabled = true;
            txtCliente.Enabled = true;
            chkNaoInformaDataHoraSaida.Enabled = true;
            msktxtBaseICMS.Enabled = true;
            msktxtValorICMS.Enabled = true;
            msktxtTotalProdutos.Enabled = true;
            msktxtTotalNota.Enabled = true;
            msktxtBaseICMSSub.Enabled = true;
            msktxtValorICMSSub.Enabled = true;
            msktxtTotalServicos.Enabled = true;
            msktxtValorISS.Enabled = true;
            msktxtValorIPI.Enabled = true;
            msktxtValorSeguro.Enabled = true;
            msktxtValorDespesas.Enabled = true;
            msktxtValorFrete.Enabled = true;
            txtNotaComplementada.Enabled = true;
            txtChaveAcesso.Enabled = true;
            cbMensagem1.Enabled = true;
            cbMensagem2.Enabled = true;
            cbMensagem3.Enabled = true;
            cbMensagem4.Enabled = true;
            txtCodProduto.Enabled = true;
            msktxtValorUnitario.Enabled = true;
            txtQuantidade.Enabled = true;
            txtNCM.Enabled = true;
            msktxtValorIPI2.Enabled = true;
            txtUnidade.Enabled = true;
            txtSitTributaria.Enabled = true;
            txtCFOP.Enabled = true;
            msktxtTotal.Enabled = true;
            txtAliqICMS.Enabled = true;
            txtAliqISS.Enabled = true;
            txtAliqIPI.Enabled = true;
            btnIncluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = true;
            txtNumNota.Focus();
        }

        private void btnGeraNFe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nota gerada com sucesso !", "Veti PDV 2.0");
            btnEnviaNF.Enabled = true;
        }

        private void btnEnviaNF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lote recebido com sucesso !", "Veti PDV 2.0");
            btnSituacaoNF.Enabled = true;
        }

        private void btnSituacaoNF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nota Fiscal Complementar emitida com sucesso !", "Veti PDV 2.0");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnSituacaoNF.Enabled = false;
            btnEnviaNF.Enabled = false;
            btnGeraNFe.Enabled = false;
            txtNumNota.Text = "";
            txtNumNota.Enabled = false;
            cbNatOperacao.Text = "";
            cbNatOperacao.Enabled = false;
            dtDataEmissao.Enabled = false;
            dtDataSaida.Enabled = false;
            dtHorario.Enabled = false;
            txtCliente.Text = "";
            txtCliente.Enabled = false;
            chkNaoInformaDataHoraSaida.Checked = false;
            chkNaoInformaDataHoraSaida.Enabled = false;
            msktxtBaseICMS.Text = "";
            msktxtBaseICMS.Enabled = false;
            msktxtValorICMS.Text = "";
            msktxtValorICMS.Enabled = false;
            msktxtTotalProdutos.Text = "";
            msktxtTotalProdutos.Enabled = false;
            msktxtTotalNota.Text = "";
            msktxtTotalNota.Enabled = false;
            msktxtBaseICMSSub.Text = "";
            msktxtBaseICMSSub.Enabled = false;
            msktxtValorICMSSub.Text = "";
            msktxtValorICMSSub.Enabled = false;
            msktxtTotalServicos.Text = "";
            msktxtTotalServicos.Enabled = false;
            msktxtValorISS.Text = "";
            msktxtValorISS.Enabled = false;
            msktxtValorIPI.Text = "";
            msktxtValorIPI.Enabled = false;
            msktxtValorSeguro.Text = "";
            msktxtValorSeguro.Enabled = false;
            msktxtValorDespesas.Text = "";
            msktxtValorDespesas.Enabled = false;
            msktxtValorFrete.Text = "";
            msktxtValorFrete.Enabled = false;
            txtNotaComplementada.Text = "";
            txtNotaComplementada.Enabled = false;
            txtChaveAcesso.Text = "";
            txtChaveAcesso.Enabled = false;
            cbMensagem1.Text = "";
            cbMensagem1.Enabled = false;
            cbMensagem2.Text = "";
            cbMensagem2.Enabled = false;
            cbMensagem3.Text = "";
            cbMensagem3.Enabled = false;
            cbMensagem4.Text = "";
            cbMensagem4.Enabled = false;
            txtCodProduto.Text = "";
            txtCodProduto.Enabled = false;
            msktxtValorUnitario.Text = "";
            msktxtValorUnitario.Enabled = false;
            txtQuantidade.Text = "";
            txtQuantidade.Enabled = false;
            txtNCM.Text = "";
            txtNCM.Enabled = false;
            msktxtValorIPI2.Text = "";
            msktxtValorIPI2.Enabled = false;
            txtUnidade.Text = "";
            txtUnidade.Enabled = false;
            txtSitTributaria.Text = "";
            txtSitTributaria.Enabled = false;
            txtCFOP.Text = "";
            txtCFOP.Enabled = false;
            msktxtTotal.Text = "";
            msktxtTotal.Enabled = false;
            txtAliqICMS.Text = "";
            txtAliqICMS.Enabled = false;
            txtAliqISS.Text = "";
            txtAliqISS.Enabled = false;
            txtAliqIPI.Text = "";
            txtAliqIPI.Enabled = false;
            btnIncluir.Enabled = true;
            btnAlterar.Enabled = true;
            btnIncluir.Visible = true;
            txtPesquisar.Focus();
        }
    }
}
