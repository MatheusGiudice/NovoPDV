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
    public partial class frmVincularNFCe : Form
    {
        public frmVincularNFCe()
        {
            InitializeComponent();
        }

        private void FormVincularNFCe_Load(object sender, EventArgs e)
        {
            txtSerieCertificado.Enabled = false;
            msktxtDataValidadeCertificado.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtSerieCertificado.Enabled = true;
            msktxtDataValidadeCertificado.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            txtSerieCertificado.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtSerieCertificado.Enabled = true;
            msktxtDataValidadeCertificado.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            txtSerieCertificado.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro salvo com sucesso !", "Veti PDV 2.0");
            txtSerieCertificado.Enabled = false;
            msktxtDataValidadeCertificado.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtSerieCertificado.Text = "";
            txtSerieCertificado.Enabled = false;
            msktxtDataValidadeCertificado.Text = "";
            msktxtDataValidadeCertificado.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
        }
    }
}
