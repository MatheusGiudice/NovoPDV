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
    public partial class frmEstadoICMS : Form
    {
        public frmEstadoICMS()
        {
            InitializeComponent();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormICMSEstado_Load(object sender, EventArgs e)
        {
            cbUF.Enabled = false;
            msktxtPorcentAliq.Enabled = false;
            msktxtPorcentSubst.Enabled = false;
            msktxtPorcentAliqDif.Enabled = false;
            txtNomeEstado.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            cbUF.Enabled = true;
            msktxtPorcentAliq.Enabled = true;
            msktxtPorcentSubst.Enabled = true;
            msktxtPorcentAliqDif.Enabled = true;
            txtNomeEstado.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            cbUF.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cbUF.Enabled = true;
            msktxtPorcentAliq.Enabled = true;
            msktxtPorcentSubst.Enabled = true;
            msktxtPorcentAliqDif.Enabled = true;
            txtNomeEstado.Enabled = true;
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
            msktxtPorcentAliq.Text = "";
            msktxtPorcentAliq.Enabled = false;
            msktxtPorcentSubst.Text = "";
            msktxtPorcentSubst.Enabled = false;
            msktxtPorcentAliqDif.Text = "";
            msktxtPorcentAliqDif.Enabled = false;
            txtNomeEstado.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
        }
    }
}
