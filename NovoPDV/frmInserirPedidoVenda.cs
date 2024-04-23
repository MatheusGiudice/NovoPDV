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
    public partial class frmInserirPedidoVenda : Form
    {
        public frmInserirPedidoVenda()
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
            if (MessageBox.Show("Deseja realmente excluir este item ?", "VetiPDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Item excluído com sucesso !", "Veti PDV");
            }
        }

        private void btnImprimirPedido_Click(object sender, EventArgs e)
        {
            frmImprimirPedido _formImprimirPedido = new frmImprimirPedido();
            _formImprimirPedido.ShowDialog();
        }

        private void FormInserirPedido_Load(object sender, EventArgs e)
        {
            txtNumPedido.Enabled = false;
            msktxtDataPedido.Enabled = false;
            txtQtdeItens.Enabled = false;
            txtQtdeProdutos.Enabled = false;
            msktxtValorTotal.Enabled = false;
            txtCodCliente.Focus();
        }

        private void btnBaixarPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente baixar este pedido ?", "VetiPDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Pedido baixado com sucesso !", "Veti PDV");
            }
        }

        private void btnNotaFiscal_Click(object sender, EventArgs e)
        {
            frmNotaFiscal _formNotaFiscal = new frmNotaFiscal();
            _formNotaFiscal.ShowDialog();
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            frmDescontoPedido _formDescontoPedido = new frmDescontoPedido();
            _formDescontoPedido.ShowDialog();
        }
    }
}
