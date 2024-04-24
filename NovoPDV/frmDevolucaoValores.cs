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
    public partial class frmDevolucaoValores : Form
    {
        public frmDevolucaoValores()
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

        private void btnBaixarPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a Devolução ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Devolução baixada com sucesso !", "Veti PDV");
            }
        }
    }
}
