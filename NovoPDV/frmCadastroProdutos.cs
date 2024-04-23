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
    public partial class frmCadastroProdutos : Form
    {
        public frmCadastroProdutos()
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
                btnAlterar.Enabled = true;
                btnNovo.Enabled = true;
                btnImportar.Enabled = true;
                btnCancelar.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro salvo com sucesso !", "Veti PDV");
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnImportar.Enabled = true;
            btnCancelar.Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            rbAtivo.Enabled = true;
            rbAtivo.Checked = true;
            rbAtivoSim.Checked = true;
            rbInativo.Enabled = true;
            txtDescricaoProduto.Enabled = true;
            txtDescricaoFiscal.Enabled = true;
            txtEAN13.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            cbFornecedor.Enabled = true;
            txtGrupo.Enabled = true;
            cbUndMedida.Enabled = true;
            msktxtPrecoVenda.Enabled = true;
            msktxtPrecoCusto.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            btnAdicionarFoto.Enabled = true;
            pbFotoProduto.Enabled = true;
            btnEtiquetaProduto.Enabled = true;
            txtEstoqueAtual.Enabled = true;
            txtEstoqueMinimo.Enabled = true;
            txtEstoqueMaximo.Enabled = true;
            msktxtPreco1.Enabled = true;
            msktxtPreco2.Enabled = true;
            btnNovo.Enabled = false;
            btnImportar.Enabled = false;
            btnCancelar.Visible = true;
            btnAlterar.Enabled = false;
            txtDescricaoProduto.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            rbAtivo.Enabled = true;
            rbAtivo.Checked = true;
            rbAtivoSim.Checked = true;
            rbInativo.Enabled = true;
            txtDescricaoProduto.Enabled = true;
            txtDescricaoFiscal.Enabled = true;
            txtEAN13.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            cbFornecedor.Enabled = true;
            txtGrupo.Enabled = true;
            cbUndMedida.Enabled = true;
            msktxtPrecoCusto.Enabled = true;
            msktxtPrecoVenda.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            btnAdicionarFoto.Enabled = true;
            pbFotoProduto.Enabled = true;
            btnEtiquetaProduto.Enabled = true;
            txtEstoqueAtual.Enabled = true;
            txtEstoqueMinimo.Enabled = true;
            txtEstoqueMaximo.Enabled = true;
            btnNovo.Enabled = false;
            btnImportar.Enabled = false;
            btnCancelar.Visible = true;
            msktxtPreco1.Enabled = true;
            msktxtPreco2.Enabled = true;
            btnAlterar.Enabled = false;
            txtDescricaoProduto.Focus();
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            rbAtivo.Enabled = false;
            rbAtivo.Checked = true;
            rbAtivoSim.Checked = true;
            rbInativo.Enabled = false;
            txtDescricaoProduto.Enabled = false;
            txtDescricaoFiscal.Enabled = false;
            txtEAN13.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            cbFornecedor.Enabled = false;
            txtGrupo.Enabled = false;
            cbUndMedida.Enabled = false;
            msktxtPrecoVenda.Enabled = false;
            msktxtPrecoCusto.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnAdicionarFoto.Enabled = false;
            pbFotoProduto.Enabled = false;
            btnEtiquetaProduto.Enabled = true;
            txtEstoqueAtual.Enabled = false;
            txtEstoqueMinimo.Enabled = false;
            txtEstoqueMaximo.Enabled = false;
            msktxtPreco1.Enabled = false;
            msktxtPreco2.Enabled = false;
            txtPesquisar.Focus();
        }

        private void btnAdicionarFoto_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog _openFileDialog1 = new OpenFileDialog();
                _openFileDialog1.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (_openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = _openFileDialog1.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível localizar o item", "Veti PDV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiscal_Click(object sender, EventArgs e)
        {
            frmFiscalProdutos _formFiscalProdutos = new frmFiscalProdutos();
            _formFiscalProdutos.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            rbAtivo.Checked = true; ;
            rbAtivo.Enabled = false;
            rbAtivoSim.Checked = true;
            rbInativo.Checked = false;
            rbInativo.Enabled = false;
            txtDescricaoProduto.Text = "";
            txtDescricaoProduto.Enabled = false;
            txtDescricaoFiscal.Text = "";
            txtDescricaoFiscal.Enabled = false;
            txtEAN13.Text = "";
            txtEAN13.Enabled = false;
            txtMarca.Text = "";
            txtMarca.Enabled = false;
            txtModelo.Text = "";
            txtModelo.Enabled = false;
            cbFornecedor.Text = "";
            cbFornecedor.Enabled = false;
            txtGrupo.Text = "";
            txtGrupo.Enabled = false;
            cbUndMedida.Text = "";
            cbUndMedida.Enabled = false;
            msktxtPrecoVenda.Text = "";
            msktxtPrecoVenda.Enabled = false;
            msktxtPrecoCusto.Text = "";
            msktxtPrecoCusto.Enabled = false;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            btnAdicionarFoto.Enabled = false;
            pbFotoProduto.Enabled = false;
            btnEtiquetaProduto.Enabled = false;
            txtEstoqueAtual.Text = "";
            txtEstoqueAtual.Enabled = false;
            txtEstoqueMinimo.Text = "";
            txtEstoqueMinimo.Enabled = false;
            txtEstoqueMaximo.Text = "";
            txtEstoqueMaximo.Enabled = false;
            msktxtPreco1.Text = "";
            msktxtPreco1.Enabled = false;
            msktxtPreco2.Text = "";
            msktxtPreco2.Enabled = false;
            btnImportar.Enabled = true;
            btnNovo.Enabled = true;
            btnCancelar.Visible = false;
            btnAlterar.Enabled = true;
            btnEtiquetaProduto.Enabled = true;
            txtPesquisar.Focus();
        }
    }
}
