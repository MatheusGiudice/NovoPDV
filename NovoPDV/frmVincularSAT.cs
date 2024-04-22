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
    public partial class frmVincularSAT : Form
    {
        public frmVincularSAT()
        {
            InitializeComponent();
        }

        private void FormVincularSAT_Load(object sender, EventArgs e)
        {
            txtFabricanteSAT.Enabled = false;
            txtModeloSAT.Enabled = false;
            txtNumSerieSAT.Enabled = false;
            txtSerieSAT.Enabled = false;
            txtCodAtivacaoSAT.Enabled = false;
            txtAutCertifSAT.Enabled = false;
            rbAtivoSAT.Enabled = false;
            rbInativoSAT.Enabled = false;
            btnSalvar.Enabled = false;
            txtPesquisar.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtFabricanteSAT.Enabled = true;
            txtModeloSAT.Enabled = true;
            txtNumSerieSAT.Enabled = true;
            txtCodAtivacaoSAT.Enabled = true;
            txtSerieSAT.Enabled = true;
            txtAutCertifSAT.Enabled = true;
            rbAtivoSAT.Enabled = true;
            rbInativoSAT.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            txtFabricanteSAT.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtFabricanteSAT.Enabled = true;
            txtModeloSAT.Enabled = true;
            txtNumSerieSAT.Enabled = true;
            txtCodAtivacaoSAT.Enabled = true;
            txtAutCertifSAT.Enabled = true;
            txtSerieSAT.Enabled = true;
            rbAtivoSAT.Enabled = true;
            rbInativoSAT.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            txtFabricanteSAT.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro salvo com sucesso !", "Veti PDV 2.0");
            txtFabricanteSAT.Enabled = false;
            txtModeloSAT.Enabled = false;
            txtNumSerieSAT.Enabled = false;
            txtSerieSAT.Enabled = false;
            txtCodAtivacaoSAT.Enabled = false;
            txtAutCertifSAT.Enabled = false;
            rbAtivoSAT.Enabled = false;
            rbInativoSAT.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            txtPesquisar.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtFabricanteSAT.Text = "";
            txtFabricanteSAT.Enabled = false;
            txtModeloSAT.Text = "";
            txtModeloSAT.Enabled = false;
            txtNumSerieSAT.Text = "";
            txtNumSerieSAT.Enabled = false;
            txtSerieSAT.Text = "";
            txtSerieSAT.Enabled = false;
            txtCodAtivacaoSAT.Text = "";
            txtCodAtivacaoSAT.Enabled = false;
            txtAutCertifSAT.Text = "";
            txtAutCertifSAT.Enabled = false;
            rbAtivoSAT.Enabled = false;
            rbInativoSAT.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            txtPesquisar.Focus();
        }
    }
}
