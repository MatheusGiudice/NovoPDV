using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NovoPDV
{

    
    public partial class frmNotasFiscaisEmitidas : Form
    {
        public frmNotasFiscaisEmitidas()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private StringReader meuLeitor;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDialog1.Document = pd1;
            string strTexto = "";

            foreach (object x in dataGridView1.Rows)
            {
                strTexto = strTexto + x.ToString() + "\n";
            }

            meuLeitor = new StringReader(strTexto);

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pd1.Print();
            }
        }

        private void btnCancelarNF_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar a Nota Fiscal ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Nota cancelada com sucesso !", "Veti PDV");
            }
            
        }

        private void btnCartaCorrecao_Click(object sender, EventArgs e)
        {
            frmCartaCorrecao _formCartaCorrecao = new frmCartaCorrecao();
            _formCartaCorrecao.ShowDialog();
        }

        private void rbFiltroCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFiltroCliente.Checked == true)
            {
                txtFiltroCliente.Focus();
            }
        }

        private void rbFiltroNumNota_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFiltroNumNota.Checked == true)
            {
                txtFiltroNumNota.Focus();
            }
        }

        private void rbFiltroNumPedido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFiltroNumPedido.Checked == true)
            {
                txtFiltroNumPedido.Focus();
            }
        }

        private void rbFiltroPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFiltroPeriodo.Checked == true)
            {
                dtInicio.Focus();
            }
        }
    }
}
