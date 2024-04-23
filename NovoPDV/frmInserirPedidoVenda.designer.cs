
namespace NovoPDV
{
    partial class frmInserirPedidoVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirPedidoVenda));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkVendaPresencial = new System.Windows.Forms.CheckBox();
            this.cbPrecos = new System.Windows.Forms.ComboBox();
            this.lblPreços = new System.Windows.Forms.Label();
            this.cbCondPgto = new System.Windows.Forms.ComboBox();
            this.lblCondPgto = new System.Windows.Forms.Label();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.msktxtCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFCNPJ = new System.Windows.Forms.Label();
            this.txtRazaoCliente = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblRepresentante = new System.Windows.Forms.Label();
            this.msktxtFrete = new System.Windows.Forms.MaskedTextBox();
            this.lblFrete = new System.Windows.Forms.Label();
            this.cbTipoPgto = new System.Windows.Forms.ComboBox();
            this.lblTipoPgto = new System.Windows.Forms.Label();
            this.txtRazaoTransportadora = new System.Windows.Forms.TextBox();
            this.txtCodTransportadora = new System.Windows.Forms.TextBox();
            this.lblTransportadora = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.msktxtValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.msktxtDataPedido = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtQtdeItens = new System.Windows.Forms.TextBox();
            this.lblQtdeItens = new System.Windows.Forms.Label();
            this.txtQtdeProdutos = new System.Windows.Forms.TextBox();
            this.lblQtdeProdutos = new System.Windows.Forms.Label();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreçoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreçoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterarItens = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msktxtPrecoUnitario = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.lblQtde = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnBaixarPedido = new System.Windows.Forms.Button();
            this.btnNotaFiscal = new System.Windows.Forms.Button();
            this.btnImprimirPedido = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(286, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 140);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkVendaPresencial);
            this.tabPage1.Controls.Add(this.cbPrecos);
            this.tabPage1.Controls.Add(this.lblPreços);
            this.tabPage1.Controls.Add(this.cbCondPgto);
            this.tabPage1.Controls.Add(this.lblCondPgto);
            this.tabPage1.Controls.Add(this.cbVendedor);
            this.tabPage1.Controls.Add(this.lblVendedor);
            this.tabPage1.Controls.Add(this.msktxtCPFCNPJ);
            this.tabPage1.Controls.Add(this.lblCPFCNPJ);
            this.tabPage1.Controls.Add(this.txtRazaoCliente);
            this.tabPage1.Controls.Add(this.txtCodCliente);
            this.tabPage1.Controls.Add(this.lblCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 114);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pedido";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkVendaPresencial
            // 
            this.chkVendaPresencial.AutoSize = true;
            this.chkVendaPresencial.Location = new System.Drawing.Point(18, 81);
            this.chkVendaPresencial.Name = "chkVendaPresencial";
            this.chkVendaPresencial.Size = new System.Drawing.Size(109, 17);
            this.chkVendaPresencial.TabIndex = 7;
            this.chkVendaPresencial.Text = "Venda Presencial";
            this.chkVendaPresencial.UseVisualStyleBackColor = true;
            // 
            // cbPrecos
            // 
            this.cbPrecos.FormattingEnabled = true;
            this.cbPrecos.Items.AddRange(new object[] {
            "Preço de Venda",
            "Preço 1",
            "Preço 2",
            "Preço 3"});
            this.cbPrecos.Location = new System.Drawing.Point(554, 46);
            this.cbPrecos.Name = "cbPrecos";
            this.cbPrecos.Size = new System.Drawing.Size(123, 21);
            this.cbPrecos.TabIndex = 6;
            // 
            // lblPreços
            // 
            this.lblPreços.AutoSize = true;
            this.lblPreços.Location = new System.Drawing.Point(508, 49);
            this.lblPreços.Name = "lblPreços";
            this.lblPreços.Size = new System.Drawing.Size(40, 13);
            this.lblPreços.TabIndex = 198198493;
            this.lblPreços.Text = "Preços";
            // 
            // cbCondPgto
            // 
            this.cbCondPgto.FormattingEnabled = true;
            this.cbCondPgto.Location = new System.Drawing.Point(327, 46);
            this.cbCondPgto.Name = "cbCondPgto";
            this.cbCondPgto.Size = new System.Drawing.Size(163, 21);
            this.cbCondPgto.TabIndex = 5;
            // 
            // lblCondPgto
            // 
            this.lblCondPgto.AutoSize = true;
            this.lblCondPgto.Location = new System.Drawing.Point(261, 49);
            this.lblCondPgto.Name = "lblCondPgto";
            this.lblCondPgto.Size = new System.Drawing.Size(60, 13);
            this.lblCondPgto.TabIndex = 198198492;
            this.lblCondPgto.Text = "Cond. Pgto";
            // 
            // cbVendedor
            // 
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(75, 46);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(163, 21);
            this.cbVendedor.TabIndex = 4;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(16, 49);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 198198490;
            this.lblVendedor.Text = "Vendedor";
            // 
            // msktxtCPFCNPJ
            // 
            this.msktxtCPFCNPJ.Location = new System.Drawing.Point(544, 14);
            this.msktxtCPFCNPJ.Mask = "00.000.000/0000-00";
            this.msktxtCPFCNPJ.Name = "msktxtCPFCNPJ";
            this.msktxtCPFCNPJ.Size = new System.Drawing.Size(133, 20);
            this.msktxtCPFCNPJ.TabIndex = 3;
            this.msktxtCPFCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCPFCNPJ
            // 
            this.lblCPFCNPJ.AutoSize = true;
            this.lblCPFCNPJ.Location = new System.Drawing.Point(473, 17);
            this.lblCPFCNPJ.Name = "lblCPFCNPJ";
            this.lblCPFCNPJ.Size = new System.Drawing.Size(65, 13);
            this.lblCPFCNPJ.TabIndex = 198198489;
            this.lblCPFCNPJ.Text = "CPF / CNPJ";
            // 
            // txtRazaoCliente
            // 
            this.txtRazaoCliente.Location = new System.Drawing.Point(122, 14);
            this.txtRazaoCliente.Name = "txtRazaoCliente";
            this.txtRazaoCliente.Size = new System.Drawing.Size(268, 20);
            this.txtRazaoCliente.TabIndex = 2;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(61, 14);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(55, 20);
            this.txtCodCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(16, 17);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.lblRepresentante);
            this.tabPage2.Controls.Add(this.msktxtFrete);
            this.tabPage2.Controls.Add(this.lblFrete);
            this.tabPage2.Controls.Add(this.cbTipoPgto);
            this.tabPage2.Controls.Add(this.lblTipoPgto);
            this.tabPage2.Controls.Add(this.txtRazaoTransportadora);
            this.tabPage2.Controls.Add(this.txtCodTransportadora);
            this.tabPage2.Controls.Add(this.lblTransportadora);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 114);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados Adicionais";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(425, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 984984168;
            // 
            // lblRepresentante
            // 
            this.lblRepresentante.AutoSize = true;
            this.lblRepresentante.Location = new System.Drawing.Point(332, 64);
            this.lblRepresentante.Name = "lblRepresentante";
            this.lblRepresentante.Size = new System.Drawing.Size(77, 13);
            this.lblRepresentante.TabIndex = 984984169;
            this.lblRepresentante.Text = "Representante";
            // 
            // msktxtFrete
            // 
            this.msktxtFrete.Location = new System.Drawing.Point(152, 61);
            this.msktxtFrete.Mask = "$ 000,00";
            this.msktxtFrete.Name = "msktxtFrete";
            this.msktxtFrete.Size = new System.Drawing.Size(79, 20);
            this.msktxtFrete.TabIndex = 4;
            this.msktxtFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Location = new System.Drawing.Point(115, 64);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(31, 13);
            this.lblFrete.TabIndex = 984984167;
            this.lblFrete.Text = "Frete";
            // 
            // cbTipoPgto
            // 
            this.cbTipoPgto.FormattingEnabled = true;
            this.cbTipoPgto.Location = new System.Drawing.Point(486, 26);
            this.cbTipoPgto.Name = "cbTipoPgto";
            this.cbTipoPgto.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPgto.TabIndex = 3;
            // 
            // lblTipoPgto
            // 
            this.lblTipoPgto.AutoSize = true;
            this.lblTipoPgto.Location = new System.Drawing.Point(380, 29);
            this.lblTipoPgto.Name = "lblTipoPgto";
            this.lblTipoPgto.Size = new System.Drawing.Size(100, 13);
            this.lblTipoPgto.TabIndex = 984984166;
            this.lblTipoPgto.Text = "Tipo de Pagamento";
            // 
            // txtRazaoTransportadora
            // 
            this.txtRazaoTransportadora.Enabled = false;
            this.txtRazaoTransportadora.Location = new System.Drawing.Point(166, 26);
            this.txtRazaoTransportadora.Name = "txtRazaoTransportadora";
            this.txtRazaoTransportadora.Size = new System.Drawing.Size(195, 20);
            this.txtRazaoTransportadora.TabIndex = 2;
            // 
            // txtCodTransportadora
            // 
            this.txtCodTransportadora.Location = new System.Drawing.Point(92, 26);
            this.txtCodTransportadora.Name = "txtCodTransportadora";
            this.txtCodTransportadora.Size = new System.Drawing.Size(59, 20);
            this.txtCodTransportadora.TabIndex = 1;
            // 
            // lblTransportadora
            // 
            this.lblTransportadora.AutoSize = true;
            this.lblTransportadora.Location = new System.Drawing.Point(7, 29);
            this.lblTransportadora.Name = "lblTransportadora";
            this.lblTransportadora.Size = new System.Drawing.Size(79, 13);
            this.lblTransportadora.TabIndex = 984984165;
            this.lblTransportadora.Text = "Transportadora";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtObservacoes);
            this.tabPage3.Controls.Add(this.lblObservacoes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(714, 114);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Observações";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(98, 21);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(582, 72);
            this.txtObservacoes.TabIndex = 1;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(22, 51);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(70, 13);
            this.lblObservacoes.TabIndex = 0;
            this.lblObservacoes.Text = "Observações";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDesconto);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.msktxtValorTotal);
            this.groupBox1.Controls.Add(this.lblValorTotal);
            this.groupBox1.Controls.Add(this.msktxtDataPedido);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.txtQtdeItens);
            this.groupBox1.Controls.Add(this.lblQtdeItens);
            this.groupBox1.Controls.Add(this.txtQtdeProdutos);
            this.groupBox1.Controls.Add(this.lblQtdeProdutos);
            this.groupBox1.Controls.Add(this.txtNumPedido);
            this.groupBox1.Controls.Add(this.lblNumPedido);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnAlterarItens);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.msktxtPrecoUnitario);
            this.groupBox1.Controls.Add(this.lblPrecoUnitario);
            this.groupBox1.Controls.Add(this.txtQtde);
            this.groupBox1.Controls.Add(this.lblQtde);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.lblProduto);
            this.groupBox1.Location = new System.Drawing.Point(286, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 380);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnDesconto
            // 
            this.btnDesconto.BackColor = System.Drawing.SystemColors.Control;
            this.btnDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDesconto.Image = ((System.Drawing.Image)(resources.GetObject("btnDesconto.Image")));
            this.btnDesconto.Location = new System.Drawing.Point(393, 54);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(85, 79);
            this.btnDesconto.TabIndex = 198198514;
            this.btnDesconto.Text = "Desconto";
            this.btnDesconto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesconto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDesconto.UseVisualStyleBackColor = false;
            this.btnDesconto.Click += new System.EventHandler(this.btnDesconto_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(92, 54);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 79);
            this.btnExcluir.TabIndex = 198198507;
            this.btnExcluir.Text = "Excluir Itens";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // msktxtValorTotal
            // 
            this.msktxtValorTotal.Location = new System.Drawing.Point(550, 346);
            this.msktxtValorTotal.Mask = "$ 000,00";
            this.msktxtValorTotal.Name = "msktxtValorTotal";
            this.msktxtValorTotal.Size = new System.Drawing.Size(96, 20);
            this.msktxtValorTotal.TabIndex = 198198513;
            this.msktxtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(568, 320);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(58, 13);
            this.lblValorTotal.TabIndex = 198198506;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // msktxtDataPedido
            // 
            this.msktxtDataPedido.Location = new System.Drawing.Point(147, 346);
            this.msktxtDataPedido.Mask = "00/00/0000";
            this.msktxtDataPedido.Name = "msktxtDataPedido";
            this.msktxtDataPedido.Size = new System.Drawing.Size(96, 20);
            this.msktxtDataPedido.TabIndex = 198198511;
            this.msktxtDataPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msktxtDataPedido.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(97, 349);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 198198505;
            this.lblData.Text = "Data";
            // 
            // txtQtdeItens
            // 
            this.txtQtdeItens.Location = new System.Drawing.Point(392, 346);
            this.txtQtdeItens.Name = "txtQtdeItens";
            this.txtQtdeItens.Size = new System.Drawing.Size(96, 20);
            this.txtQtdeItens.TabIndex = 198198512;
            // 
            // lblQtdeItens
            // 
            this.lblQtdeItens.AutoSize = true;
            this.lblQtdeItens.Location = new System.Drawing.Point(305, 349);
            this.lblQtdeItens.Name = "lblQtdeItens";
            this.lblQtdeItens.Size = new System.Drawing.Size(56, 13);
            this.lblQtdeItens.TabIndex = 198198504;
            this.lblQtdeItens.Text = "Qtde Itens";
            // 
            // txtQtdeProdutos
            // 
            this.txtQtdeProdutos.Location = new System.Drawing.Point(392, 317);
            this.txtQtdeProdutos.Name = "txtQtdeProdutos";
            this.txtQtdeProdutos.Size = new System.Drawing.Size(96, 20);
            this.txtQtdeProdutos.TabIndex = 198198510;
            // 
            // lblQtdeProdutos
            // 
            this.lblQtdeProdutos.AutoSize = true;
            this.lblQtdeProdutos.Location = new System.Drawing.Point(305, 320);
            this.lblQtdeProdutos.Name = "lblQtdeProdutos";
            this.lblQtdeProdutos.Size = new System.Drawing.Size(75, 13);
            this.lblQtdeProdutos.TabIndex = 198198502;
            this.lblQtdeProdutos.Text = "Qtde Produtos";
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Location = new System.Drawing.Point(147, 317);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(96, 20);
            this.txtNumPedido.TabIndex = 198198509;
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Location = new System.Drawing.Point(97, 320);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(40, 13);
            this.lblNumPedido.TabIndex = 198198500;
            this.lblNumPedido.Text = "Pedido";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProduto,
            this.DescProduto,
            this.Quantidade,
            this.PreçoUnit,
            this.Desconto,
            this.PreçoTotal});
            this.dataGridView1.Location = new System.Drawing.Point(92, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 167);
            this.dataGridView1.TabIndex = 198198498;
            // 
            // CodProduto
            // 
            this.CodProduto.HeaderText = "Produto";
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.Width = 80;
            // 
            // DescProduto
            // 
            this.DescProduto.HeaderText = "Descrição";
            this.DescProduto.Name = "DescProduto";
            this.DescProduto.Width = 150;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Qtde";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 50;
            // 
            // PreçoUnit
            // 
            this.PreçoUnit.HeaderText = "Preço Unitário";
            this.PreçoUnit.Name = "PreçoUnit";
            this.PreçoUnit.Width = 80;
            // 
            // Desconto
            // 
            this.Desconto.HeaderText = "Desconto %";
            this.Desconto.Name = "Desconto";
            this.Desconto.Width = 70;
            // 
            // PreçoTotal
            // 
            this.PreçoTotal.HeaderText = "Preço Total";
            this.PreçoTotal.Name = "PreçoTotal";
            this.PreçoTotal.Width = 80;
            // 
            // btnAlterarItens
            // 
            this.btnAlterarItens.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterarItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterarItens.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarItens.Image")));
            this.btnAlterarItens.Location = new System.Drawing.Point(240, 54);
            this.btnAlterarItens.Name = "btnAlterarItens";
            this.btnAlterarItens.Size = new System.Drawing.Size(85, 79);
            this.btnAlterarItens.TabIndex = 198198508;
            this.btnAlterarItens.Text = "Alterar Itens";
            this.btnAlterarItens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterarItens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarItens.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(556, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 99);
            this.pictureBox1.TabIndex = 198198497;
            this.pictureBox1.TabStop = false;
            // 
            // msktxtPrecoUnitario
            // 
            this.msktxtPrecoUnitario.Location = new System.Drawing.Point(458, 19);
            this.msktxtPrecoUnitario.Mask = "$ 000,00";
            this.msktxtPrecoUnitario.Name = "msktxtPrecoUnitario";
            this.msktxtPrecoUnitario.Size = new System.Drawing.Size(82, 20);
            this.msktxtPrecoUnitario.TabIndex = 10;
            this.msktxtPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(392, 22);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(60, 13);
            this.lblPrecoUnitario.TabIndex = 198198496;
            this.lblPrecoUnitario.Text = "Preço Unit.";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(278, 19);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(96, 20);
            this.txtQtde.TabIndex = 9;
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(239, 22);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(30, 13);
            this.lblQtde.TabIndex = 198198495;
            this.lblQtde.Text = "Qtde";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(123, 19);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(96, 20);
            this.txtProduto.TabIndex = 8;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(73, 22);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 198198494;
            this.lblProduto.Text = "Produto";
            // 
            // btnBaixarPedido
            // 
            this.btnBaixarPedido.BackColor = System.Drawing.SystemColors.Control;
            this.btnBaixarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBaixarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnBaixarPedido.Image")));
            this.btnBaixarPedido.Location = new System.Drawing.Point(358, 17);
            this.btnBaixarPedido.Name = "btnBaixarPedido";
            this.btnBaixarPedido.Size = new System.Drawing.Size(85, 79);
            this.btnBaixarPedido.TabIndex = 11;
            this.btnBaixarPedido.Text = "Baixar";
            this.btnBaixarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaixarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBaixarPedido.UseVisualStyleBackColor = false;
            this.btnBaixarPedido.Click += new System.EventHandler(this.btnBaixarPedido_Click);
            // 
            // btnNotaFiscal
            // 
            this.btnNotaFiscal.BackColor = System.Drawing.SystemColors.Control;
            this.btnNotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNotaFiscal.Image = ((System.Drawing.Image)(resources.GetObject("btnNotaFiscal.Image")));
            this.btnNotaFiscal.Location = new System.Drawing.Point(595, 17);
            this.btnNotaFiscal.Name = "btnNotaFiscal";
            this.btnNotaFiscal.Size = new System.Drawing.Size(85, 79);
            this.btnNotaFiscal.TabIndex = 12;
            this.btnNotaFiscal.Text = "Nota Fiscal";
            this.btnNotaFiscal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNotaFiscal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNotaFiscal.UseVisualStyleBackColor = false;
            this.btnNotaFiscal.Click += new System.EventHandler(this.btnNotaFiscal_Click);
            // 
            // btnImprimirPedido
            // 
            this.btnImprimirPedido.BackColor = System.Drawing.SystemColors.Control;
            this.btnImprimirPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnImprimirPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirPedido.Image")));
            this.btnImprimirPedido.Location = new System.Drawing.Point(847, 17);
            this.btnImprimirPedido.Name = "btnImprimirPedido";
            this.btnImprimirPedido.Size = new System.Drawing.Size(85, 79);
            this.btnImprimirPedido.TabIndex = 13;
            this.btnImprimirPedido.Text = "Imprimir Pedido";
            this.btnImprimirPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimirPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimirPedido.UseVisualStyleBackColor = false;
            this.btnImprimirPedido.Click += new System.EventHandler(this.btnImprimirPedido_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 634);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 51);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormInserirPedidoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1393, 711);
            this.Controls.Add(this.btnBaixarPedido);
            this.Controls.Add(this.btnNotaFiscal);
            this.Controls.Add(this.btnImprimirPedido);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInserirPedidoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido de Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInserirPedido_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkVendaPresencial;
        private System.Windows.Forms.ComboBox cbPrecos;
        private System.Windows.Forms.Label lblPreços;
        private System.Windows.Forms.ComboBox cbCondPgto;
        private System.Windows.Forms.Label lblCondPgto;
        private System.Windows.Forms.ComboBox cbVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.MaskedTextBox msktxtCPFCNPJ;
        private System.Windows.Forms.Label lblCPFCNPJ;
        private System.Windows.Forms.TextBox txtRazaoCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblRepresentante;
        private System.Windows.Forms.MaskedTextBox msktxtFrete;
        private System.Windows.Forms.Label lblFrete;
        private System.Windows.Forms.ComboBox cbTipoPgto;
        private System.Windows.Forms.Label lblTipoPgto;
        private System.Windows.Forms.TextBox txtRazaoTransportadora;
        private System.Windows.Forms.TextBox txtCodTransportadora;
        private System.Windows.Forms.Label lblTransportadora;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox msktxtPrecoUnitario;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnAlterarItens;
        private System.Windows.Forms.MaskedTextBox msktxtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.MaskedTextBox msktxtDataPedido;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtQtdeItens;
        private System.Windows.Forms.Label lblQtdeItens;
        private System.Windows.Forms.TextBox txtQtdeProdutos;
        private System.Windows.Forms.Label lblQtdeProdutos;
        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnImprimirPedido;
        private System.Windows.Forms.Button btnNotaFiscal;
        private System.Windows.Forms.Button btnBaixarPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreçoUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreçoTotal;
        private System.Windows.Forms.Button btnDesconto;
    }
}