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
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
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

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPessoaFisica.Checked == true)
            {
                lblRazaoNome.Visible = false;
                txtRazaoNome.Visible = false;
                lblFantasia.Text = "Nome Completo";
                lblCNPJCPF.Text = "CPF";
                msktxtCNPJCPF.Mask = "000.000.000-00";
                lblIERG.Text = "RG";
                txtFantasia.Focus();
            }
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblRazaoNome.Visible = true;
            txtRazaoNome.Visible = true;
            lblFantasia.Text = "Nome Fantasia";
            lblCNPJCPF.Text = "CNPJ";
            msktxtCNPJCPF.Mask = "00.000.000/0000-00";
            lblIERG.Text = "IE";
            txtRazaoNome.Focus();
        }

        private void CadastroDeClientes_Load(object sender, EventArgs e)
        {
            txtRazaoNome.Enabled = false;
            txtFantasia.Enabled = false;
            msktxtCNPJCPF.Enabled = false;
            txtIERG.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            cbUF.Enabled = false;
            txtCidade.Enabled = false;
            msktxtCEP.Enabled = false;
            txtEmail.Enabled = false;
            msktxtTelefone.Enabled = false;
            msktxtCelular.Enabled = false;
            txtContato.Enabled = false;
            rbPessoaFisica.Enabled = false;
            rbPessoaJuridica.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            chkSimplesNacional.Enabled = false;
            chkPermCredICMS.Enabled = false;
            rbZonaFrancaSim.Enabled = false;
            rbZonaFrancaNao.Enabled = false;
            txtSuframa.Enabled = false;
            txtObservacao.Enabled = false;
            txtPesquisar.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtRazaoNome.Enabled = true;
            txtFantasia.Enabled = true;
            msktxtCNPJCPF.Enabled = true;
            txtIERG.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            cbUF.Enabled = true;
            txtCidade.Enabled = true;
            msktxtCEP.Enabled = true;
            txtEmail.Enabled = true;
            msktxtTelefone.Enabled = true;
            msktxtCelular.Enabled = true;
            txtContato.Enabled = true;
            rbPessoaFisica.Enabled = true;
            rbPessoaJuridica.Enabled = true;
            chkSimplesNacional.Enabled = true;
            chkPermCredICMS.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            rbZonaFrancaSim.Enabled = true;
            rbZonaFrancaNao.Enabled = true;
            txtSuframa.Enabled = true;
            txtObservacao.Enabled = true;
            btnNovo.Enabled = false;
            btnImportar.Enabled = false;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
            btnAlterar.Enabled = false;
            txtRazaoNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este cadastro ?", "VetiPDV 2.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro excluído com sucesso !", "Veti PDV 2.0");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Cadastro salvo com sucesso !", "Veti PDV 2.0");
            txtRazaoNome.Enabled = false;
            txtFantasia.Enabled = false;
            msktxtCNPJCPF.Enabled = false;
            txtIERG.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            cbUF.Enabled = false;
            txtCidade.Enabled = false;
            msktxtCEP.Enabled = false;
            txtEmail.Enabled = false;
            msktxtTelefone.Enabled = false;
            msktxtCelular.Enabled = false;
            txtContato.Enabled = false;
            rbPessoaFisica.Enabled = false;
            rbPessoaJuridica.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            chkSimplesNacional.Enabled = false;
            chkPermCredICMS.Enabled = false;
            rbZonaFrancaSim.Enabled = false;
            rbZonaFrancaNao.Enabled = false;
            txtSuframa.Enabled = false;
            txtObservacao.Enabled = false;
            txtPesquisar.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtRazaoNome.Enabled = true;
            txtFantasia.Enabled = true;
            msktxtCNPJCPF.Enabled = true;
            txtIERG.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            cbUF.Enabled = true;
            txtCidade.Enabled = true;
            msktxtCEP.Enabled = true;
            txtEmail.Enabled = true;
            msktxtTelefone.Enabled = true;
            msktxtCelular.Enabled = true;
            txtContato.Enabled = true;
            rbPessoaFisica.Enabled = true;
            rbPessoaJuridica.Enabled = true;
            chkSimplesNacional.Enabled = true;
            chkPermCredICMS.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            rbZonaFrancaSim.Enabled = true;
            rbZonaFrancaNao.Enabled = true;
            txtSuframa.Enabled = true;
            txtObservacao.Enabled = true;
            btnNovo.Enabled = false;
            btnImportar.Enabled = false;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
            btnAlterar.Enabled = false;
            txtRazaoNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtRazaoNome.Text = "";
            txtRazaoNome.Enabled = false;
            txtFantasia.Text = "";
            txtFantasia.Enabled = false;
            msktxtCNPJCPF.Text = "";
            msktxtCNPJCPF.Enabled = false;
            txtIERG.Text = "";
            txtIERG.Enabled = false;
            txtEndereco.Text = "";
            txtEndereco.Enabled = false;
            txtNumero.Text = "";
            txtNumero.Enabled = false;
            txtComplemento.Text = "";
            txtComplemento.Enabled = false;
            txtBairro.Text = "";
            txtBairro.Enabled = false;
            cbUF.Text = "";
            cbUF.Enabled = false;
            txtCidade.Text = "";
            txtCidade.Enabled = false;
            msktxtCEP.Text = "";
            msktxtCEP.Enabled = false;
            txtEmail.Text = "";
            txtEmail.Enabled = false;
            txtContato.Text = "";
            txtContato.Enabled = false;
            msktxtTelefone.Text = "";
            msktxtTelefone.Enabled = false;
            msktxtCelular.Text = "";
            msktxtCelular.Enabled = false;
            rbPessoaFisica.Checked = false;
            rbPessoaFisica.Enabled = false;
            rbPessoaJuridica.Checked = false;
            rbPessoaJuridica.Enabled = false;
            chkSimplesNacional.Checked = false;
            chkSimplesNacional.Enabled = false;
            chkPermCredICMS.Checked = false;
            chkPermCredICMS.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            rbZonaFrancaSim.Checked = false;
            rbZonaFrancaSim.Enabled = false;
            rbZonaFrancaNao.Checked = false;
            rbZonaFrancaNao.Enabled = false;
            txtSuframa.Text = "";
            txtSuframa.Enabled = false;
            txtObservacao.Text = "";
            txtObservacao.Enabled = false;
            btnCancelar.Visible = false;
            btnImportar.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            txtPesquisar.Focus();
        }
    }
}
