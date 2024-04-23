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
    public partial class frmFiscalProdutos : Form
    {
        public frmFiscalProdutos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnICMSSubstituicao_Click(object sender, EventArgs e)
        {
            frmICMSSubstituicao _formICMSSubstituicao = new frmICMSSubstituicao();
            _formICMSSubstituicao.ShowDialog();
        }

        private void FormFiscalProdutos_Load(object sender, EventArgs e)
        {
            cbNCM.Enabled = false;
            txtSituacaoTributaria.Enabled = false;
            cbRegraICMS.Enabled = false;
            cbEtiquetaPeso.Enabled = false;
            txtCSTIPIEntrada.Enabled = false;
            txtCSTIPISaida.Enabled = false;
            msktxtPorcentIPI.Enabled = false;
            txtCEST.Enabled = false;
            rbNormal.Enabled = false;
            msktxtPorcentVenda.Enabled = false;
            rbIsento.Enabled = false;
            rbNaoIncidencia.Enabled = false;
            rbSubstituicao.Enabled = false;
            rbDiferenciado.Enabled = false;
            msktxtPorcentDifer.Enabled = false;
            rbReduzido.Enabled = false;
            msktxtPorcentReduz.Enabled = false;
            txtBaseReducao.Enabled = false;
            cbServico.Enabled = false;
            msktxtPorcentISS.Enabled = false;
            cbProdutoAtivo.Enabled = false;
            cbFabricacaoPropria.Enabled = false;
            rbVendaFracSim.Enabled = false;
            rbVendaFraNao.Enabled = false;
            cbCFOPEntradaDentroEstado.Enabled = false;
            cbCFOPEntradaForaEst.Enabled = false;
            cbCFOPSaidaConsFinal.Enabled = false;
            cbCFOPSaidaDentroEst.Enabled = false;
            cbCFOPSaidaForaEstcomSub.Enabled = false;
            cbCFOPSaidaForaEstsemSub.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            cbNCM.Enabled = true;
            txtSituacaoTributaria.Enabled = true;
            cbRegraICMS.Enabled = true;
            cbEtiquetaPeso.Enabled = true;
            txtCSTIPIEntrada.Enabled = true;
            txtCSTIPISaida.Enabled = true;
            msktxtPorcentIPI.Enabled = true;
            txtCEST.Enabled = true;
            rbNormal.Enabled = true;
            rbIsento.Enabled = true;
            rbNaoIncidencia.Enabled = true;
            rbSubstituicao.Enabled = true;
            rbDiferenciado.Enabled = true;
            rbReduzido.Enabled = true;
            txtBaseReducao.Enabled = true;
            cbServico.Enabled = true;
            cbProdutoAtivo.Enabled = true;
            cbFabricacaoPropria.Enabled = true;
            rbVendaFracSim.Enabled = true;
            rbVendaFraNao.Enabled = true;
            cbCFOPEntradaDentroEstado.Enabled = true;
            cbCFOPEntradaForaEst.Enabled = true;
            cbCFOPSaidaConsFinal.Enabled = true;
            cbCFOPSaidaDentroEst.Enabled = true;
            cbCFOPSaidaForaEstcomSub.Enabled = true;
            cbCFOPSaidaForaEstsemSub.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            cbNCM.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro salvo com sucesso !", "Veti PDV");
            btnCancelar.Visible = false;
            btnAlterar.Enabled = true;
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked == true)
            {
                msktxtPorcentVenda.Enabled = true;
                msktxtPorcentDifer.Clear();
                msktxtPorcentDifer.Enabled = false;
                msktxtPorcentReduz.Clear();
                msktxtPorcentReduz.Enabled = false;
            }
        }

        private void rbDiferenciado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDiferenciado.Checked == true)
            {
                msktxtPorcentDifer.Enabled = true;
                msktxtPorcentVenda.Clear();
                msktxtPorcentVenda.Enabled = false;
                msktxtPorcentReduz.Clear();
                msktxtPorcentReduz.Enabled = false;
            }
        }

        private void rbReduzido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReduzido.Checked == true)
            {
                msktxtPorcentReduz.Enabled = true;
                msktxtPorcentVenda.Clear();
                msktxtPorcentVenda.Enabled = false;
                msktxtPorcentDifer.Clear();
                msktxtPorcentDifer.Enabled = false;
            }
        }

        private void cbServico_CheckedChanged(object sender, EventArgs e)
        {
            if (cbServico.Checked == true)
            {
                msktxtPorcentISS.Enabled = true;
            }
            else
                msktxtPorcentISS.Enabled = false;
            msktxtPorcentISS.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbNCM.Text = "";
            cbNCM.Enabled = false;
            txtSituacaoTributaria.Text = "";
            txtSituacaoTributaria.Enabled = false;
            cbRegraICMS.Text = "";
            cbRegraICMS.Enabled = false;
            cbEtiquetaPeso.Text = "";
            cbEtiquetaPeso.Enabled = false;
            txtCSTIPIEntrada.Text = "";
            txtCSTIPIEntrada.Enabled = false;
            txtCSTIPISaida.Text = "";
            txtCSTIPISaida.Enabled = false;
            msktxtPorcentIPI.Text = "";
            msktxtPorcentIPI.Enabled = false;
            txtCEST.Text = "";
            txtCEST.Enabled = false;
            rbNormal.Checked = false;
            rbNormal.Enabled = false;
            msktxtPorcentVenda.Text = "";
            msktxtPorcentVenda.Enabled = false;
            rbIsento.Checked = false;
            rbIsento.Enabled = false;
            rbNaoIncidencia.Checked = false;
            rbNaoIncidencia.Enabled = false;
            rbSubstituicao.Checked = false;
            rbSubstituicao.Enabled = false;
            rbDiferenciado.Checked = false;
            rbDiferenciado.Enabled = false;
            msktxtPorcentDifer.Text = "";
            msktxtPorcentDifer.Enabled = false;
            rbReduzido.Checked = false;
            rbReduzido.Enabled = false;
            msktxtPorcentReduz.Text = "";
            msktxtPorcentReduz.Enabled = false;
            txtBaseReducao.Text = "";
            txtBaseReducao.Enabled = false;
            cbServico.Text = "";
            cbServico.Enabled = false;
            msktxtPorcentISS.Text = "";
            msktxtPorcentISS.Enabled = false;
            cbProdutoAtivo.Text = "";
            cbProdutoAtivo.Enabled = false;
            cbFabricacaoPropria.Text = "";
            cbFabricacaoPropria.Enabled = false;
            rbVendaFracSim.Checked = false;
            rbVendaFracSim.Enabled = false;
            rbVendaFraNao.Checked = false;
            rbVendaFraNao.Enabled = false;
            cbCFOPEntradaDentroEstado.Text = "";
            cbCFOPEntradaDentroEstado.Enabled = false;
            cbCFOPEntradaForaEst.Text = "";
            cbCFOPEntradaForaEst.Enabled = false;
            cbCFOPSaidaConsFinal.Text = "";
            cbCFOPSaidaConsFinal.Enabled = false;
            cbCFOPSaidaDentroEst.Text = "";
            cbCFOPSaidaDentroEst.Enabled = false;
            cbCFOPSaidaForaEstcomSub.Text = "";
            cbCFOPSaidaForaEstcomSub.Enabled = false;
            cbCFOPSaidaForaEstsemSub.Text = "";
            cbCFOPSaidaForaEstsemSub.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Visible = false;
            btnAlterar.Enabled = true;
        }
    }
}
