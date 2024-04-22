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
    public partial class frmCadastroEmpresa : Form
    {
        public frmCadastroEmpresa()
        {
            InitializeComponent();
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {
            txtRazaoSocial.Enabled = false;
            txtFantasia.Enabled = false;
            msktxtCNPJ.Enabled = false;
            txtInscEstadual.Enabled = false;
            txtInscMunicipal.Enabled = false;
            cbCRT.Enabled = false;
            txtCNAE.Enabled = false;
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
            btnSalvar.Enabled = false;
            txtPesquisar.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtRazaoSocial.Enabled = true;
            txtFantasia.Enabled = true;
            msktxtCNPJ.Enabled = true;
            txtInscEstadual.Enabled = true;
            txtInscMunicipal.Enabled = true;
            cbCRT.Enabled = true;
            txtCNAE.Enabled = true;
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
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            btnAlterar.Enabled = false;
            txtRazaoSocial.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtRazaoSocial.Enabled = true;
            txtFantasia.Enabled = true;
            msktxtCNPJ.Enabled = true;
            txtInscEstadual.Enabled = true;
            txtInscMunicipal.Enabled = true;
            cbCRT.Enabled = true;
            txtCNAE.Enabled = true;
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
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            btnAlterar.Enabled = false;
            txtRazaoSocial.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro salvo com sucesso !", "Veti PDV 2.0");
            txtRazaoSocial.Enabled = false;
            txtFantasia.Enabled = false;
            msktxtCNPJ.Enabled = false;
            txtInscEstadual.Enabled = false;
            txtInscMunicipal.Enabled = false;
            cbCRT.Enabled = false;
            txtCNAE.Enabled = false;
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
            btnSalvar.Enabled = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            txtPesquisar.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnVincularSat_Click(object sender, EventArgs e)
        {
            frmVincularSAT _formVincularSAT = new frmVincularSAT();
            _formVincularSAT.ShowDialog();
        }

        private void btnVincularNFCe_Click_1(object sender, EventArgs e)
        {
            frmVincularNFCe _formVincularNFCe = new frmVincularNFCe();
            _formVincularNFCe.ShowDialog();
        }

        private void btnSelecionarLogo_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog _openFileDiagog1 = new OpenFileDialog();
                _openFileDiagog1.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (_openFileDiagog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = _openFileDiagog1.FileName;

                    // image1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível localizar o item", "Veti PDV", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtRazaoSocial.Text = "";
            txtRazaoSocial.Enabled = false;
            txtFantasia.Text = "";
            txtFantasia.Enabled = false;
            msktxtCNPJ.Text = "";
            msktxtCNPJ.Enabled = false;
            txtInscEstadual.Text = ""; 
            txtInscEstadual.Enabled = false;
            txtInscMunicipal.Text = "";
            txtInscMunicipal.Enabled = false;
            cbCRT.Text = "";
            cbCRT.Enabled = false;
            txtCNAE.Text = "";
            txtCNAE.Enabled = false;
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
            msktxtTelefone.Text = "";
            msktxtTelefone.Enabled = false;
            msktxtCelular.Text = "";
            msktxtCelular.Enabled = false;
            txtContato.Text = "";
            txtContato.Enabled = false;
            btnCancelar.Visible = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            txtPesquisar.Focus();

        }
    }
}
