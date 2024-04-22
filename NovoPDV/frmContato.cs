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
    public partial class frmContato : Form
    {
        public frmContato()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem enviada com sucesso ! Em breve entraremos em contato.", "Veti PDV 2.0", MessageBoxButtons.OK);
            txtRazaoNome.Clear();
            txtFantasia.Clear();
            msktxtCNPJCPF.Clear();
            txtEmail.Clear();
            msktxtTelefone.Clear();
            msktxtCelular.Clear();
            txtMensagem.Clear();
            rbPessoaFisica.Checked = false;
            rbPessoaJuridica.Checked = false;
            txtRazaoNome.Focus();
        }

        private void FormContato_Load(object sender, EventArgs e)
        {
            txtRazaoNome.Enabled = false;
            txtFantasia.Enabled = false;
            msktxtCNPJCPF.Enabled = false;
            txtEmail.Enabled = false;
            msktxtTelefone.Enabled = false;
            msktxtCelular.Enabled = false;
            txtMensagem.Enabled = false;
            btnEnviar.Enabled = false;
            btnLimpar.Enabled = false;
            txtRazaoNome.Focus();
        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPessoaFisica.Checked == true)
            {
                txtRazaoNome.Enabled = true;
                txtFantasia.Enabled = true;
                msktxtCNPJCPF.Enabled = true;
                txtEmail.Enabled = true;
                msktxtTelefone.Enabled = true;
                msktxtCelular.Enabled = true;
                txtMensagem.Enabled = true;
                btnEnviar.Enabled = true;
                btnLimpar.Enabled = true; ;
                lblRazaoNome.Visible = false;
                txtRazaoNome.Visible = false;
                lblFantasia.Text = "Nome Completo";
                lblCNPJCPF.Text = "CPF";
                msktxtCNPJCPF.Mask = "000.000.000-00";
                txtFantasia.Focus();
            }
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            txtRazaoNome.Enabled = true;
            txtFantasia.Enabled = true;
            msktxtCNPJCPF.Enabled = true;
            txtEmail.Enabled = true;
            msktxtTelefone.Enabled = true;
            msktxtCelular.Enabled = true;
            txtMensagem.Enabled = true;
            btnEnviar.Enabled = true;
            btnLimpar.Enabled = true; ;
            lblRazaoNome.Visible = true;
            txtRazaoNome.Visible = true;
            lblFantasia.Text = "Nome Fantasia";
            lblCNPJCPF.Text = "CNPJ";
            msktxtCNPJCPF.Mask = "00.000.000/0000-00";
            txtRazaoNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRazaoNome.Clear();
            txtFantasia.Clear();
            msktxtCNPJCPF.Clear();
            txtEmail.Clear();
            msktxtTelefone.Clear();
            msktxtCelular.Clear();
            txtMensagem.Clear();
            rbPessoaFisica.Checked = false;
            rbPessoaJuridica.Checked = false;
            txtRazaoNome.Focus();
        }
    }
}
