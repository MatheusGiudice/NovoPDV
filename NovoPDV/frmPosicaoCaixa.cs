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
    public partial class frmPosicaoCaixa : Form
    {
        public frmPosicaoCaixa()
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

        private void btnAnalítico_Click(object sender, EventArgs e)
        {
            
            frmPosicaoCaixaAnalitico _formPosicaoCaixaAnalitico = new frmPosicaoCaixaAnalitico();
            _formPosicaoCaixaAnalitico.ShowDialog();
        }

        private void btnSintetico_Click(object sender, EventArgs e)
        {
            frmPosicaoCaixaSintetico _formPosicaoCaixaSintetico = new frmPosicaoCaixaSintetico();
            _formPosicaoCaixaSintetico.ShowDialog();
        }

        private void btnConsolidado_Click(object sender, EventArgs e)
        {
            frmPosicaoCaixaConsolidado _formPosicaoCaixaConsolidado = new frmPosicaoCaixaConsolidado();
            _formPosicaoCaixaConsolidado.ShowDialog();
        }
    }
}
