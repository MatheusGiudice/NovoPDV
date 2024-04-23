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
    public partial class frmNotaFiscal : Form
    {
        public frmNotaFiscal()
        {
            InitializeComponent();
        }

        private void FormNotaFiscal_Load(object sender, EventArgs e)
        {
            cbNaturezaOperacao.Focus();
            btnEnviaNF.Enabled = false;
            btnSituacaoNF.Enabled = false;
            btnDanfe.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E-mail enviado com sucesso !", "Veti PDV");
        }

        private void btnGeraNFe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nota gerada com sucesso !", "Veti PDV");
            btnEnviaNF.Enabled = true;
        }

        private void btnEnviaNF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lote recebido com sucesso !", "Veti PDV");
            btnSituacaoNF.Enabled = true;
        }

        private void btnSituacaoNF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NFe emitida com sucesso !", "Veti PDV");
            btnDanfe.Enabled = true;
        }

        private void chkNaoInfDataHoraDanfe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNaoInfDataHoraDanfe.Checked == true)
            {
                msktxtHorarioSaida.Enabled = false;
                dateTimePicker1.Enabled = false;
                
            }
            else
                dateTimePicker1.Enabled = true;
                msktxtHorarioSaida.Enabled = true;
        }

        private void btnReferenciarNFe_Click(object sender, EventArgs e)
        {
            frmNotaReferenciada _formNotaReferenciada = new frmNotaReferenciada();
            _formNotaReferenciada.Show();
        }
    }
}
