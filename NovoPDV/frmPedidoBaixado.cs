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
    public partial class frmPedidoBaixado : Form
    {
        public frmPedidoBaixado()
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

        private void btnImprimirPedido_Click(object sender, EventArgs e)
        {
            frmImprimirPedido _formImprimirPedido = new frmImprimirPedido();
            _formImprimirPedido.Show();
        }

        private void btnNotaFiscal_Click(object sender, EventArgs e)
        {
            frmNotaFiscal _formNotaFiscal = new frmNotaFiscal();
            _formNotaFiscal.Show();
        }

        private void btnReimpCupomFiscal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja reimprimir o cupom fiscal ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Cupom reimpresso com sucesso !", "Veti PDV");
            }
        }

        private void btnCancelarCupomFiscal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o cupom fiscal ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Cupom cancelado com sucesso !", "Veti PDV");
            }
        }
    }
}
