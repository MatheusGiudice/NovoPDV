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
    public partial class frmInutilizacaoFaixaNF : Form
    {
        public frmInutilizacaoFaixaNF()
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

        private void btnInutilizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a Inutilização de Faixa ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Inutilização de Faixa realizada com sucesso !", "Veti PDV");
                txtSerie.Clear();
                txtInicio.Clear();
                txtFim.Clear();
                txtMotivoInutilizacao.Clear();
            }
        }
    }
}
