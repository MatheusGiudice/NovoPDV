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
    public partial class frmNotasFiscaisCanceladas : Form
    {
        public frmNotasFiscaisCanceladas()
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
    }
}
