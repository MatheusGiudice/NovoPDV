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
    public partial class frmCondPagto : Form
    {
        public frmCondPagto()
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

        private void FormCondPagto_Load(object sender, EventArgs e)
        {
            txtDescricao.Enabled = false;
            cbPermParcel.Enabled = false;
            cbNumParcelas.Enabled = false;
            txtDias1.Enabled = false;
            msktxtDias1.Enabled = false;
            txtDias2.Enabled = false;
            msktxtDias2.Enabled = false;
            txtDias3.Enabled = false;
            msktxtDias3.Enabled = false;
            txtDias4.Enabled = false;
            msktxtDias4.Enabled = false;
            txtDias5.Enabled = false;
            msktxtDias5.Enabled = false;
            txtDias6.Enabled = false;
            msktxtDias6.Enabled = false;
            txtDias7.Enabled = false;
            msktxtDias7.Enabled = false;
            txtDias8.Enabled = false;
            msktxtDias8.Enabled = false;
            txtDias9.Enabled = false;
            msktxtDias9.Enabled = false;
            txtDias10.Enabled = false;
            msktxtDias10.Enabled = false;
            txtDias11.Enabled = false;
            msktxtDias11.Enabled = false;
            txtDias12.Enabled = false;
            msktxtDias12.Enabled = false;
            chkPIXSim.Enabled = false;
            chkPIXNao.Enabled = false;
            cbChavePix.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnImprimirQRCode.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            cbPermParcel.Enabled = true;
            cbNumParcelas.Enabled = true;
            txtDias1.Enabled = true;
            msktxtDias1.Enabled = true;
            txtDias2.Enabled = true;
            msktxtDias2.Enabled = true;
            txtDias3.Enabled = true;
            msktxtDias3.Enabled = true;
            txtDias4.Enabled = true;
            msktxtDias4.Enabled = true;
            txtDias5.Enabled = true;
            msktxtDias5.Enabled = true;
            txtDias6.Enabled = true;
            msktxtDias6.Enabled = true;
            txtDias7.Enabled = true;
            msktxtDias7.Enabled = true;
            txtDias8.Enabled = true;
            msktxtDias8.Enabled = true;
            txtDias9.Enabled = true;
            msktxtDias9.Enabled = true;
            txtDias10.Enabled = true;
            msktxtDias10.Enabled = true;
            txtDias11.Enabled = true;
            msktxtDias11.Enabled = true;
            txtDias12.Enabled = true;
            msktxtDias12.Enabled = true;
            chkPIXSim.Enabled = true;
            chkPIXNao.Enabled = true;
            cbChavePix.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            btnImprimirQRCode.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            btnAlterar.Enabled = false;
            txtDescricao.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            cbPermParcel.Enabled = true;
            cbNumParcelas.Enabled = true;
            txtDias1.Enabled = true;
            msktxtDias1.Enabled = true;
            txtDias2.Enabled = true;
            msktxtDias2.Enabled = true;
            txtDias3.Enabled = true;
            msktxtDias3.Enabled = true;
            txtDias4.Enabled = true;
            msktxtDias4.Enabled = true;
            txtDias5.Enabled = true;
            msktxtDias5.Enabled = true;
            txtDias6.Enabled = true;
            msktxtDias6.Enabled = true;
            txtDias7.Enabled = true;
            msktxtDias7.Enabled = true;
            txtDias8.Enabled = true;
            msktxtDias8.Enabled = true;
            txtDias9.Enabled = true;
            msktxtDias9.Enabled = true;
            txtDias10.Enabled = true;
            msktxtDias10.Enabled = true;
            txtDias11.Enabled = true;
            msktxtDias11.Enabled = true;
            txtDias12.Enabled = true;
            msktxtDias12.Enabled = true;
            chkPIXSim.Enabled = true;
            chkPIXNao.Enabled = true;
            cbChavePix.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            btnImprimirQRCode.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            btnAlterar.Enabled = false;
            txtDescricao.Focus();
        }

        private void btnImprimirQRCode_Click(object sender, EventArgs e)
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
            txtDescricao.Enabled = false;
            cbPermParcel.Enabled = false;
            cbNumParcelas.Enabled = false;
            txtDias1.Enabled = false;
            msktxtDias1.Enabled = false;
            txtDias2.Enabled = false;
            msktxtDias2.Enabled = false;
            txtDias3.Enabled = false;
            msktxtDias3.Enabled = false;
            txtDias4.Enabled = false;
            msktxtDias4.Enabled = false;
            txtDias5.Enabled = false;
            msktxtDias5.Enabled = false;
            txtDias6.Enabled = false;
            msktxtDias6.Enabled = false;
            txtDias7.Enabled = false;
            msktxtDias7.Enabled = false;
            txtDias8.Enabled = false;
            msktxtDias8.Enabled = false;
            txtDias9.Enabled = false;
            msktxtDias9.Enabled = false;
            txtDias10.Enabled = false;
            msktxtDias10.Enabled = false;
            txtDias11.Enabled = false;
            msktxtDias11.Enabled = false;
            txtDias12.Enabled = false;
            msktxtDias12.Enabled = false;
            chkPIXSim.Enabled = false;
            chkPIXNao.Enabled = false;
            cbChavePix.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnImprimirQRCode.Enabled = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
        }
    }
}
