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
    public partial class frmPedidoVenda : Form
    {
        public frmPedidoVenda()
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
            if (MessageBox.Show("Deseja realmente excluir este pedido ?", "VetiPDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Pedido excluído com sucesso !", "Veti PDV");
            }
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            frmDevolucaoPedido _formDevPedido = new frmDevolucaoPedido();
            _formDevPedido.ShowDialog();            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmInserirPedidoVenda _formInserirPedido = new frmInserirPedidoVenda();
            _formInserirPedido.ShowDialog();
        }

        private void btnNotaFiscal_Click(object sender, EventArgs e)
        {
            frmNotaFiscal _formNotaFiscal = new frmNotaFiscal();
            _formNotaFiscal.ShowDialog();
        }
    }
}
