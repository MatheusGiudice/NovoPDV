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
    public partial class frmInserirPedidoCompra : Form
    {
        public frmInserirPedidoCompra()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o produto ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Item removido com sucesso !", "Veti PDV");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBaixarPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("Confirma a baixa do Pedido de Compra ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Pedido baixado com sucesso !", "Veti PDV");
            }
        }

        private void FormInserirPedidoCompra_Load(object sender, EventArgs e)
        {
            btnBaixarPedido.Focus();
        }
    }
}
