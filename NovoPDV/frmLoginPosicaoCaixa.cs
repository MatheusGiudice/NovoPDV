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
    public partial class frmLoginPosicaoCaixa : Form
    {
        public frmLoginPosicaoCaixa()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            frmPosicaoCaixa _formPosicaoCaixa = new frmPosicaoCaixa();
            _formPosicaoCaixa.ShowDialog();
        }
    }
}
