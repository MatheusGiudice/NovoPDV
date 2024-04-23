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
    public partial class frmPosicaoCaixaConsolidado : Form
    {
        public frmPosicaoCaixaConsolidado()
        {
            InitializeComponent();
        }

        private StringReader meuLeitor;

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

        private void pd1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //define as variáveis para controlar as linhas, o posicionamento e a caneta e cor usada
            float linhasPorPagina = 0;
            float yPosicao = 0;
            int contador = 0;
            float MargemEsquerda = e.MarginBounds.Left;
            float MargemTopo = e.MarginBounds.Top;
            string linha = null;

            //define a fonte e a pena e sua cor
            Font FonteImpressao = this.listBox1.Font;
            SolidBrush minhaPena = new SolidBrush(Color.Black);

            //define o número de linhas por página usando MarginBounds
            linhasPorPagina = e.MarginBounds.Height / FonteImpressao.GetHeight(e.Graphics);

            //percorre a string usando o StringReader e imprime cada linha
            while (contador < linhasPorPagina && ((linha = meuLeitor.ReadLine()) != null))
            {
                //calcula a posição da próxima linha com base na
                //altura da fonte de acordo com o dispositivo de impressão
                yPosicao = MargemTopo + (contador * FonteImpressao.GetHeight(e.Graphics));
                //desenha a próxima alinha no controle
                e.Graphics.DrawString(linha, FonteImpressao, minhaPena, MargemEsquerda, yPosicao, new StringFormat());
                contador++;
            }

            //se existe mais linhas imprime outra página
            if (linha != null)
            {
                e.HasMorePages = true;
            }
            else
                e.HasMorePages = false;
            minhaPena.Dispose();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
