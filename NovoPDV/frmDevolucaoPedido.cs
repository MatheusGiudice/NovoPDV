using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace NovoPDV
{
    public partial class frmDevolucaoPedido : Form
    {

        List<Produtos> _tabelaProdutos = new List<Produtos>();
        
        public frmDevolucaoPedido()
        {
            InitializeComponent();

            _tabelaProdutos.Add(new Produtos(1, "Sabão em Pó", 25.83M));
            _tabelaProdutos.Add(new Produtos(2, "Sabão em Pedra", 5.32M));
            _tabelaProdutos.Add(new Produtos(3, "Palha de Açó", 2.14M));
            _tabelaProdutos.Add(new Produtos(4, "Detergente Neutro", 5.4M));
            _tabelaProdutos.Add(new Produtos(5, "Água Sanitária", 11.64M));

            dataGridView1.DataSource = _tabelaProdutos; 
        
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro salvo com sucesso !", "Veti PDV");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esta devolução ?", "VetiPDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Devolução excluída com sucesso !", "Veti PDV");
            }
        }

        private void FormDevPedido_Load(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            btnCarregarItens.Enabled = false;
            btnSalvar.Enabled = false;
            btnIncluirItem.Enabled = false;
            txtNumPedido.Enabled = false;
            cbTipoPedido.Enabled = false;
            txtMotivoDev.Enabled = false;
            txtCliente.Enabled = false;
            msktxtCPFCNPJ.Enabled = false;
            txtProduto.Enabled = false;
            txtQtde.Enabled = false;
            msktxtPrecoUnitario.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = true;
            btnCarregarItens.Enabled = true;
            btnSalvar.Enabled = true;
            btnIncluirItem.Enabled = true;
            txtNumPedido.Enabled = true;
            cbTipoPedido.Enabled = true;
            txtMotivoDev.Enabled = true;
            txtCliente.Enabled = true;
            msktxtCPFCNPJ.Enabled = true;
            txtProduto.Enabled = true;
            txtQtde.Enabled = true;
            msktxtPrecoUnitario.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            txtNumPedido.Focus();
        }

        private void btnCarregarItens_Click(object sender, EventArgs e)
        {
            SalvarExcel();
            MessageBox.Show("Salvo !");
        }

        public void SalvarExcel()
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook pasta = app.Workbooks.Add();
            Excel.Worksheet plan;
            plan = pasta.Worksheets.Add();
            plan.Name = "Devoluções 2023";

            plan.Range["A1"].Value = "Código";
            plan.Range["B1"].Value = "Data Devolução";
            plan.Range["C1"].Value = "Nº Pedido";
            plan.Range["D1"].Value = "Total Pedido";
            plan.Range["E1"].Value = "Data Pedido";
            plan.Range["F1"].Value = "Cliente";
            plan.Range["G1"].Value = "CPF/CNPJ";
            plan.Range["H1"].Value = "Vendedor";
            plan.Range["I1"].Value = "Qtde Produtos";
            plan.Range["J1"].Value = "Valor Total";

            plan.Range["K1"].Value = "ID";
            plan.Range["L1"].Value = "Nome";
            plan.Range["M1"].Value = "Unitário";

            int l = 2;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                plan.Range["K" + l].Value = r.Cells["Id"].Value;
                plan.Range["L" + l].Value = r.Cells["Nome"].Value;
                plan.Range["M" + l++].Value = r.Cells["Unitario"].Value;

            }

            

            pasta.SaveAs(@"C:\Users\matheus\Desktop\teste.xlsx");
            pasta.Close();
            app.Quit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            btnCarregarItens.Enabled = false;
            btnSalvar.Enabled = false;
            btnIncluirItem.Enabled = false;
            txtNumPedido.Text = "";
            txtNumPedido.Enabled = false;
            cbTipoPedido.Text = "";
            cbTipoPedido.Enabled = false;
            txtMotivoDev.Text = "";
            txtMotivoDev.Enabled = false;
            txtCliente.Text = "";
            txtCliente.Enabled = false;
            msktxtCPFCNPJ.Text = "";
            msktxtCPFCNPJ.Enabled = false;
            txtProduto.Text = "";
            txtProduto.Enabled = false;
            txtQtde.Text = "";
            txtQtde.Enabled = false;
            msktxtPrecoUnitario.Text = "";
            msktxtPrecoUnitario.Enabled = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
        }
    }
}
