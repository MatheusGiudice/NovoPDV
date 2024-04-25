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
    public partial class frmInserirOrcamento : Form
    {
        public frmInserirOrcamento()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmImprimirPedido _formImprimirPedido = new frmImprimirPedido();
            _formImprimirPedido.ShowDialog();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja gravar o orçamento ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Orçamento salvo com sucesso !", "Veti PDV");
            }
        }

        private void frmInserirOrcamento_Load(object sender, EventArgs e)
        {
            txtCodCliente.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o item ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 MessageBox.Show("Item excluído com sucesso !", "Veti PDV");
             }
        }

        

    }
}
