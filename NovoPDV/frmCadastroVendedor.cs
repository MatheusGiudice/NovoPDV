﻿using System;
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
    public partial class frmCadastroVendedor : Form
    {
        public frmCadastroVendedor()
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblRazaoNome.Visible = true;
            txtRazaoNome.Visible = true;
            lblFantasia.Text = "Nome Fantasia";
            lblCNPJCPF.Text = "CNPJ";
            msktxtCNPJCPF.Mask = "00.000.000/0000-00";
            lblIERG.Text = "IE";
            txtRazaoNome.Focus();
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
            rbPF.Enabled = true;
            rbPJ.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            rbAtivoVendedor.Enabled = true;
            rbInativoVendedor.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            btnAlterar.Enabled = false;
            txtRazaoNome.Focus();
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
            txtContato.Enabled = true;
            msktxtTelefone.Enabled = true;
            msktxtCelular.Enabled = true;
            rbPF.Enabled = true;
            rbPJ.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            rbAtivoVendedor.Enabled = true;
            rbInativoVendedor.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            btnAlterar.Enabled = false;
            txtRazaoNome.Focus();
        }

        private void CadastroVendedor_Load(object sender, EventArgs e)
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
            rbPF.Enabled = false;
            rbPJ.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            rbAtivoVendedor.Enabled = false;
            rbInativoVendedor.Enabled = false;
            txtPesquisar.Focus();
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
            msktxtTelefone.Text = "";
            msktxtTelefone.Enabled = false;
            msktxtCelular.Text = "";
            msktxtCelular.Enabled = false;
            txtContato.Text = "";
            txtContato.Enabled = false;
            rbPF.Checked = false;
            rbPF.Enabled = false;
            rbPJ.Checked = false;
            rbPJ.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            rbAtivoVendedor.Checked = false;
            rbAtivoVendedor.Enabled = false;
            rbInativoVendedor.Checked = false;
            rbInativoVendedor.Enabled = false;
            btnCancelar.Visible = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            txtPesquisar.Focus();

        }
    }
}
