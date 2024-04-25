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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterarUsuario _alterarUsuario = new frmAlterarUsuario();
            _alterarUsuario.ShowDialog();
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuporte _suporteForm = new frmSuporte();
            _suporteForm.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre _formSobre = new frmSobre();
            _formSobre.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroClientes _formCadastroClientes = new frmCadastroClientes();
            _formCadastroClientes.ShowDialog();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEmpresa _cadastroEmpresa = new frmCadastroEmpresa();
            _cadastroEmpresa.ShowDialog();
        }

        private void caixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroCaixa _cadastroCaixa = new frmCadastroCaixa();
            _cadastroCaixa.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor _cadastroFornecedor = new frmCadastroFornecedor();
            _cadastroFornecedor.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario _cadastroFuncionario = new frmCadastroFuncionario();
            _cadastroFuncionario.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroVendedor _cadastroVendedor = new frmCadastroVendedor();
            _cadastroVendedor.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProdutos _cadastroProdutos = new frmCadastroProdutos();
            _cadastroProdutos.ShowDialog();
        }

        private void transportadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTransportadora _cadastroTransportadora = new frmCadastroTransportadora();
            _cadastroTransportadora.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario _cadastroUsuario = new frmCadastroUsuario();
            _cadastroUsuario.ShowDialog();
        }

        private void estadosParaICMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadoICMS _estadoICMS = new frmEstadoICMS();
            _estadoICMS.ShowDialog();
        }

        private void naturezaDaOperaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNatOperacao _natOperacao = new frmNatOperacao();
            _natOperacao.ShowDialog();
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCondPagto _condPagto = new frmCondPagto();
            _condPagto.ShowDialog();
        }

        private void nCMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNCM _formNCM = new frmNCM();
            _formNCM.ShowDialog();
        }

        private void pedidosDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidoVenda _pedidoDeVenda = new frmPedidoVenda();
            _pedidoDeVenda.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevolucaoPedido _DevolucaoPedido = new frmDevolucaoPedido();
            _DevolucaoPedido.ShowDialog();
        }

        private void inutilizaçãoDeFaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInutilizacaoFaixaNF _inutilizacaoFaixaNF = new frmInutilizacaoFaixaNF();
            _inutilizacaoFaixaNF.ShowDialog();
        }

        private void complementarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotaFiscalComplementar _notaFiscalComplementar = new frmNotaFiscalComplementar();
            _notaFiscalComplementar.ShowDialog();
        }

        private void pedidosBaixadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidoBaixado _pedidoBaixado = new frmPedidoBaixado();
            _pedidoBaixado.ShowDialog();
        }

        private void emitidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotasFiscaisEmitidas _notasFiscaisEmitidas = new frmNotasFiscaisEmitidas();
            _notasFiscaisEmitidas.ShowDialog();
        }

        private void cartaDeCorreçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCartaCorrecao _cartaDeCorrecao = new frmCartaCorrecao();
            _cartaDeCorrecao.ShowDialog();
        }

        private void posiçãoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginPosicaoCaixa _loginPosicaoCaixa = new frmLoginPosicaoCaixa();
            _loginPosicaoCaixa.ShowDialog();
        }

        private void pedidosAbertosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPedidoCompra _pedidoCompra = new frmPedidoCompra();
            _pedidoCompra.ShowDialog();
        }

        private void valoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevolucaoValores _devolucaoValores = new frmDevolucaoValores();
            _devolucaoValores.ShowDialog();
        }

        private void canceladasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotasFiscaisCanceladas _notasFiscaisCanceladas = new frmNotasFiscaisCanceladas();
            _notasFiscaisCanceladas.ShowDialog();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrcamento _orcamento = new frmOrcamento();
            _orcamento.ShowDialog();
        }
    }
}
