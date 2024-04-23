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
    public partial class frmPosicaoCaixaSintetico : Form
    {
        public frmPosicaoCaixaSintetico()
        {
            InitializeComponent();
        }

        private StringReader meuLeitor;

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDialog1.Document = pd1;
            string strTexto = "";

            foreach (object x in listBox1.Items)
            {
                strTexto = strTexto + x.ToString() + "\n";
            }

            meuLeitor = new StringReader(strTexto);

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pd1.Print();
            }
        }
    }
}
