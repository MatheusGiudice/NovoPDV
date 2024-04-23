
namespace NovoPDV
{
    partial class frmInserirPedidoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirPedidoCompra));
            this.btnBaixarPedido = new System.Windows.Forms.Button();
            this.btnNotaFiscal = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.msktxtValorDolar = new System.Windows.Forms.MaskedTextBox();
            this.txtNumNotaFiscal = new System.Windows.Forms.TextBox();
            this.cbCondPgto = new System.Windows.Forms.ComboBox();
            this.cbFrete = new System.Windows.Forms.ComboBox();
            this.txtRazaoFornecedor = new System.Windows.Forms.TextBox();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.dtDataReceb = new System.Windows.Forms.DateTimePicker();
            this.dtDataPedido = new System.Windows.Forms.DateTimePicker();
            this.txtSerieNumPedido = new System.Windows.Forms.TextBox();
            this.lblValorDolar = new System.Windows.Forms.Label();
            this.lblNumNotaFiscal = new System.Windows.Forms.Label();
            this.lblCondPgto = new System.Windows.Forms.Label();
            this.lblFrete = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblDataReceb = new System.Windows.Forms.Label();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.msktxtPorcentICMS = new System.Windows.Forms.MaskedTextBox();
            this.lblPorcentICMS = new System.Windows.Forms.Label();
            this.msktxtPorcentIPI = new System.Windows.Forms.MaskedTextBox();
            this.lblPorcentIPI = new System.Windows.Forms.Label();
            this.msktxtPrecoVenda = new System.Windows.Forms.MaskedTextBox();
            this.msktxtPrecoCompra = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.lblPrecoCompra = new System.Windows.Forms.Label();
            this.msktxtQtdeAt = new System.Windows.Forms.MaskedTextBox();
            this.msktxtQtdePed = new System.Windows.Forms.MaskedTextBox();
            this.lblQtdeAtual = new System.Windows.Forms.Label();
            this.lblQtdePedido = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtDescProduto = new System.Windows.Forms.TextBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdePed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreçoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreçoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalIPI = new System.Windows.Forms.Label();
            this.lblTotalICMS = new System.Windows.Forms.Label();
            this.lblICMSSub = new System.Windows.Forms.Label();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.lblTotalAtendido = new System.Windows.Forms.Label();
            this.msktxtTotalIPI = new System.Windows.Forms.MaskedTextBox();
            this.msktxtICMSSub = new System.Windows.Forms.MaskedTextBox();
            this.txtQtdeTotalAtendido = new System.Windows.Forms.TextBox();
            this.txtQtdeTotalPedido = new System.Windows.Forms.TextBox();
            this.msktxtValorTotalPedido = new System.Windows.Forms.MaskedTextBox();
            this.msktxtValorTotalAtendido = new System.Windows.Forms.MaskedTextBox();
            this.msktxtTotalICMS = new System.Windows.Forms.MaskedTextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.msktxtDesconto = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaixarPedido
            // 
            this.btnBaixarPedido.BackColor = System.Drawing.SystemColors.Control;
            this.btnBaixarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBaixarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnBaixarPedido.Image")));
            this.btnBaixarPedido.Location = new System.Drawing.Point(173, 22);
            this.btnBaixarPedido.Name = "btnBaixarPedido";
            this.btnBaixarPedido.Size = new System.Drawing.Size(85, 79);
            this.btnBaixarPedido.TabIndex = 9006;
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
            this.btnNotaFiscal.Location = new System.Drawing.Point(431, 22);
            this.btnNotaFiscal.Name = "btnNotaFiscal";
            this.btnNotaFiscal.Size = new System.Drawing.Size(85, 79);
            this.btnNotaFiscal.TabIndex = 9007;
            this.btnNotaFiscal.Text = "Nota";
            this.btnNotaFiscal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNotaFiscal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNotaFiscal.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(675, 22);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 79);
            this.btnSair.TabIndex = 9008;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumPedido);
            this.groupBox1.Controls.Add(this.msktxtValorDolar);
            this.groupBox1.Controls.Add(this.txtNumNotaFiscal);
            this.groupBox1.Controls.Add(this.cbCondPgto);
            this.groupBox1.Controls.Add(this.cbFrete);
            this.groupBox1.Controls.Add(this.txtRazaoFornecedor);
            this.groupBox1.Controls.Add(this.txtCodFornecedor);
            this.groupBox1.Controls.Add(this.dtDataReceb);
            this.groupBox1.Controls.Add(this.dtDataPedido);
            this.groupBox1.Controls.Add(this.txtSerieNumPedido);
            this.groupBox1.Controls.Add(this.lblValorDolar);
            this.groupBox1.Controls.Add(this.lblNumNotaFiscal);
            this.groupBox1.Controls.Add(this.lblCondPgto);
            this.groupBox1.Controls.Add(this.lblFrete);
            this.groupBox1.Controls.Add(this.lblFornecedor);
            this.groupBox1.Controls.Add(this.lblDataReceb);
            this.groupBox1.Controls.Add(this.lblDataPedido);
            this.groupBox1.Controls.Add(this.lblNumPedido);
            this.groupBox1.Location = new System.Drawing.Point(173, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 100);
            this.groupBox1.TabIndex = 9009;
            this.groupBox1.TabStop = false;
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Location = new System.Drawing.Point(74, 17);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(89, 20);
            this.txtNumPedido.TabIndex = 1;
            // 
            // msktxtValorDolar
            // 
            this.msktxtValorDolar.Location = new System.Drawing.Point(491, 71);
            this.msktxtValorDolar.Mask = "$ 000,00";
            this.msktxtValorDolar.Name = "msktxtValorDolar";
            this.msktxtValorDolar.Size = new System.Drawing.Size(82, 20);
            this.msktxtValorDolar.TabIndex = 10;
            this.msktxtValorDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumNotaFiscal
            // 
            this.txtNumNotaFiscal.Location = new System.Drawing.Point(336, 71);
            this.txtNumNotaFiscal.Name = "txtNumNotaFiscal";
            this.txtNumNotaFiscal.Size = new System.Drawing.Size(89, 20);
            this.txtNumNotaFiscal.TabIndex = 9;
            // 
            // cbCondPgto
            // 
            this.cbCondPgto.FormattingEnabled = true;
            this.cbCondPgto.Items.AddRange(new object[] {
            "",
            "CIF",
            "FOB"});
            this.cbCondPgto.Location = new System.Drawing.Point(74, 71);
            this.cbCondPgto.Name = "cbCondPgto";
            this.cbCondPgto.Size = new System.Drawing.Size(157, 21);
            this.cbCondPgto.TabIndex = 8;
            // 
            // cbFrete
            // 
            this.cbFrete.FormattingEnabled = true;
            this.cbFrete.Items.AddRange(new object[] {
            "",
            "CIF",
            "FOB"});
            this.cbFrete.Location = new System.Drawing.Point(491, 42);
            this.cbFrete.Name = "cbFrete";
            this.cbFrete.Size = new System.Drawing.Size(82, 21);
            this.cbFrete.TabIndex = 7;
            // 
            // txtRazaoFornecedor
            // 
            this.txtRazaoFornecedor.Location = new System.Drawing.Point(129, 42);
            this.txtRazaoFornecedor.Name = "txtRazaoFornecedor";
            this.txtRazaoFornecedor.Size = new System.Drawing.Size(248, 20);
            this.txtRazaoFornecedor.TabIndex = 6;
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Location = new System.Drawing.Point(74, 42);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(49, 20);
            this.txtCodFornecedor.TabIndex = 5;
            // 
            // dtDataReceb
            // 
            this.dtDataReceb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataReceb.Location = new System.Drawing.Point(491, 17);
            this.dtDataReceb.Name = "dtDataReceb";
            this.dtDataReceb.Size = new System.Drawing.Size(82, 20);
            this.dtDataReceb.TabIndex = 4;
            // 
            // dtDataPedido
            // 
            this.dtDataPedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataPedido.Location = new System.Drawing.Point(295, 17);
            this.dtDataPedido.Name = "dtDataPedido";
            this.dtDataPedido.Size = new System.Drawing.Size(82, 20);
            this.dtDataPedido.TabIndex = 3;
            // 
            // txtSerieNumPedido
            // 
            this.txtSerieNumPedido.Location = new System.Drawing.Point(169, 16);
            this.txtSerieNumPedido.Name = "txtSerieNumPedido";
            this.txtSerieNumPedido.Size = new System.Drawing.Size(46, 20);
            this.txtSerieNumPedido.TabIndex = 2;
            // 
            // lblValorDolar
            // 
            this.lblValorDolar.AutoSize = true;
            this.lblValorDolar.Location = new System.Drawing.Point(459, 74);
            this.lblValorDolar.Name = "lblValorDolar";
            this.lblValorDolar.Size = new System.Drawing.Size(28, 13);
            this.lblValorDolar.TabIndex = 9017;
            this.lblValorDolar.Text = "US$";
            // 
            // lblNumNotaFiscal
            // 
            this.lblNumNotaFiscal.AutoSize = true;
            this.lblNumNotaFiscal.Location = new System.Drawing.Point(255, 74);
            this.lblNumNotaFiscal.Name = "lblNumNotaFiscal";
            this.lblNumNotaFiscal.Size = new System.Drawing.Size(75, 13);
            this.lblNumNotaFiscal.TabIndex = 9016;
            this.lblNumNotaFiscal.Text = "Nº Nota Fiscal";
            // 
            // lblCondPgto
            // 
            this.lblCondPgto.AutoSize = true;
            this.lblCondPgto.Location = new System.Drawing.Point(7, 74);
            this.lblCondPgto.Name = "lblCondPgto";
            this.lblCondPgto.Size = new System.Drawing.Size(60, 13);
            this.lblCondPgto.TabIndex = 9015;
            this.lblCondPgto.Text = "Cond. Pgto";
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Location = new System.Drawing.Point(417, 45);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(31, 13);
            this.lblFrete.TabIndex = 9014;
            this.lblFrete.Text = "Frete";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(7, 45);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 9013;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblDataReceb
            // 
            this.lblDataReceb.AutoSize = true;
            this.lblDataReceb.Location = new System.Drawing.Point(417, 20);
            this.lblDataReceb.Name = "lblDataReceb";
            this.lblDataReceb.Size = new System.Drawing.Size(68, 13);
            this.lblDataReceb.TabIndex = 9012;
            this.lblDataReceb.Text = "Data Receb.";
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Location = new System.Drawing.Point(223, 20);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(66, 13);
            this.lblDataPedido.TabIndex = 9011;
            this.lblDataPedido.Text = "Data Pedido";
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Location = new System.Drawing.Point(7, 20);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(55, 13);
            this.lblNumPedido.TabIndex = 9010;
            this.lblNumPedido.Text = "Nº Pedido";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.msktxtPorcentICMS);
            this.groupBox2.Controls.Add(this.lblPorcentICMS);
            this.groupBox2.Controls.Add(this.msktxtPorcentIPI);
            this.groupBox2.Controls.Add(this.lblPorcentIPI);
            this.groupBox2.Controls.Add(this.msktxtPrecoVenda);
            this.groupBox2.Controls.Add(this.msktxtPrecoCompra);
            this.groupBox2.Controls.Add(this.lblPrecoVenda);
            this.groupBox2.Controls.Add(this.lblPrecoCompra);
            this.groupBox2.Controls.Add(this.msktxtQtdeAt);
            this.groupBox2.Controls.Add(this.msktxtQtdePed);
            this.groupBox2.Controls.Add(this.lblQtdeAtual);
            this.groupBox2.Controls.Add(this.lblQtdePedido);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnInserir);
            this.groupBox2.Controls.Add(this.txtDescProduto);
            this.groupBox2.Controls.Add(this.txtCodProduto);
            this.groupBox2.Controls.Add(this.lblProduto);
            this.groupBox2.Location = new System.Drawing.Point(173, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 110);
            this.groupBox2.TabIndex = 9010;
            this.groupBox2.TabStop = false;
            // 
            // msktxtPorcentICMS
            // 
            this.msktxtPorcentICMS.Location = new System.Drawing.Point(379, 73);
            this.msktxtPorcentICMS.Mask = "000,00 %";
            this.msktxtPorcentICMS.Name = "msktxtPorcentICMS";
            this.msktxtPorcentICMS.Size = new System.Drawing.Size(59, 20);
            this.msktxtPorcentICMS.TabIndex = 18;
            this.msktxtPorcentICMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPorcentICMS
            // 
            this.lblPorcentICMS.AutoSize = true;
            this.lblPorcentICMS.Location = new System.Drawing.Point(329, 76);
            this.lblPorcentICMS.Name = "lblPorcentICMS";
            this.lblPorcentICMS.Size = new System.Drawing.Size(44, 13);
            this.lblPorcentICMS.TabIndex = 9025;
            this.lblPorcentICMS.Text = "% ICMS";
            // 
            // msktxtPorcentIPI
            // 
            this.msktxtPorcentIPI.Location = new System.Drawing.Point(379, 45);
            this.msktxtPorcentIPI.Mask = "000,00 %";
            this.msktxtPorcentIPI.Name = "msktxtPorcentIPI";
            this.msktxtPorcentIPI.Size = new System.Drawing.Size(59, 20);
            this.msktxtPorcentIPI.TabIndex = 17;
            this.msktxtPorcentIPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPorcentIPI
            // 
            this.lblPorcentIPI.AutoSize = true;
            this.lblPorcentIPI.Location = new System.Drawing.Point(329, 48);
            this.lblPorcentIPI.Name = "lblPorcentIPI";
            this.lblPorcentIPI.Size = new System.Drawing.Size(31, 13);
            this.lblPorcentIPI.TabIndex = 9024;
            this.lblPorcentIPI.Text = "% IPI";
            // 
            // msktxtPrecoVenda
            // 
            this.msktxtPrecoVenda.Location = new System.Drawing.Point(238, 73);
            this.msktxtPrecoVenda.Mask = "$ 000,00";
            this.msktxtPrecoVenda.Name = "msktxtPrecoVenda";
            this.msktxtPrecoVenda.Size = new System.Drawing.Size(74, 20);
            this.msktxtPrecoVenda.TabIndex = 16;
            this.msktxtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msktxtPrecoCompra
            // 
            this.msktxtPrecoCompra.Location = new System.Drawing.Point(238, 45);
            this.msktxtPrecoCompra.Mask = "$ 000,00";
            this.msktxtPrecoCompra.Name = "msktxtPrecoCompra";
            this.msktxtPrecoCompra.Size = new System.Drawing.Size(74, 20);
            this.msktxtPrecoCompra.TabIndex = 15;
            this.msktxtPrecoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(143, 76);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(84, 13);
            this.lblPrecoVenda.TabIndex = 9023;
            this.lblPrecoVenda.Text = "Preço de Venda";
            // 
            // lblPrecoCompra
            // 
            this.lblPrecoCompra.AutoSize = true;
            this.lblPrecoCompra.Location = new System.Drawing.Point(143, 48);
            this.lblPrecoCompra.Name = "lblPrecoCompra";
            this.lblPrecoCompra.Size = new System.Drawing.Size(89, 13);
            this.lblPrecoCompra.TabIndex = 9022;
            this.lblPrecoCompra.Text = "Preço de Compra";
            // 
            // msktxtQtdeAt
            // 
            this.msktxtQtdeAt.Location = new System.Drawing.Point(68, 73);
            this.msktxtQtdeAt.Mask = "000,00";
            this.msktxtQtdeAt.Name = "msktxtQtdeAt";
            this.msktxtQtdeAt.Size = new System.Drawing.Size(55, 20);
            this.msktxtQtdeAt.TabIndex = 14;
            this.msktxtQtdeAt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msktxtQtdePed
            // 
            this.msktxtQtdePed.Location = new System.Drawing.Point(68, 45);
            this.msktxtQtdePed.Mask = "000,00";
            this.msktxtQtdePed.Name = "msktxtQtdePed";
            this.msktxtQtdePed.Size = new System.Drawing.Size(55, 20);
            this.msktxtQtdePed.TabIndex = 13;
            this.msktxtQtdePed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQtdeAtual
            // 
            this.lblQtdeAtual.AutoSize = true;
            this.lblQtdeAtual.Location = new System.Drawing.Point(7, 76);
            this.lblQtdeAtual.Name = "lblQtdeAtual";
            this.lblQtdeAtual.Size = new System.Drawing.Size(46, 13);
            this.lblQtdeAtual.TabIndex = 9021;
            this.lblQtdeAtual.Text = "Qtde At.";
            // 
            // lblQtdePedido
            // 
            this.lblQtdePedido.AutoSize = true;
            this.lblQtdePedido.Location = new System.Drawing.Point(7, 48);
            this.lblQtdePedido.Name = "lblQtdePedido";
            this.lblQtdePedido.Size = new System.Drawing.Size(55, 13);
            this.lblQtdePedido.TabIndex = 9020;
            this.lblQtdePedido.Text = "Qtde Ped.";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(517, 24);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(64, 67);
            this.btnExcluir.TabIndex = 9011;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.Location = new System.Drawing.Point(447, 24);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(64, 67);
            this.btnInserir.TabIndex = 9019;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInserir.UseVisualStyleBackColor = false;
            // 
            // txtDescProduto
            // 
            this.txtDescProduto.Location = new System.Drawing.Point(119, 13);
            this.txtDescProduto.Name = "txtDescProduto";
            this.txtDescProduto.Size = new System.Drawing.Size(258, 20);
            this.txtDescProduto.TabIndex = 12;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(57, 13);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(56, 20);
            this.txtCodProduto.TabIndex = 11;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(7, 16);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 9018;
            this.lblProduto.Text = "Produto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProduto,
            this.DescricaoProduto,
            this.QtdePed,
            this.QtdeAt,
            this.PreçoCompra,
            this.ICMS,
            this.IPI,
            this.PreçoVenda});
            this.dataGridView1.Location = new System.Drawing.Point(173, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 162);
            this.dataGridView1.TabIndex = 9011;
            // 
            // CodProduto
            // 
            this.CodProduto.HeaderText = "Código";
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.Width = 80;
            // 
            // DescricaoProduto
            // 
            this.DescricaoProduto.HeaderText = "Descrição do Produto";
            this.DescricaoProduto.Name = "DescricaoProduto";
            this.DescricaoProduto.Width = 180;
            // 
            // QtdePed
            // 
            this.QtdePed.HeaderText = "Qtde Ped.";
            this.QtdePed.Name = "QtdePed";
            this.QtdePed.Width = 60;
            // 
            // QtdeAt
            // 
            this.QtdeAt.HeaderText = "Qtde At.";
            this.QtdeAt.Name = "QtdeAt";
            this.QtdeAt.Width = 60;
            // 
            // PreçoCompra
            // 
            this.PreçoCompra.HeaderText = "Preço Compra";
            this.PreçoCompra.Name = "PreçoCompra";
            this.PreçoCompra.Width = 80;
            // 
            // ICMS
            // 
            this.ICMS.HeaderText = "ICMS";
            this.ICMS.Name = "ICMS";
            this.ICMS.Width = 60;
            // 
            // IPI
            // 
            this.IPI.HeaderText = "IPI";
            this.IPI.Name = "IPI";
            this.IPI.Width = 60;
            // 
            // PreçoVenda
            // 
            this.PreçoVenda.HeaderText = "Preço Venda";
            this.PreçoVenda.Name = "PreçoVenda";
            this.PreçoVenda.Width = 80;
            // 
            // lblTotalIPI
            // 
            this.lblTotalIPI.AutoSize = true;
            this.lblTotalIPI.Location = new System.Drawing.Point(180, 543);
            this.lblTotalIPI.Name = "lblTotalIPI";
            this.lblTotalIPI.Size = new System.Drawing.Size(47, 13);
            this.lblTotalIPI.TabIndex = 9026;
            this.lblTotalIPI.Text = "Total IPI";
            // 
            // lblTotalICMS
            // 
            this.lblTotalICMS.AutoSize = true;
            this.lblTotalICMS.Location = new System.Drawing.Point(181, 571);
            this.lblTotalICMS.Name = "lblTotalICMS";
            this.lblTotalICMS.Size = new System.Drawing.Size(60, 13);
            this.lblTotalICMS.TabIndex = 9000032;
            this.lblTotalICMS.Text = "Total ICMS";
            // 
            // lblICMSSub
            // 
            this.lblICMSSub.AutoSize = true;
            this.lblICMSSub.Location = new System.Drawing.Point(339, 571);
            this.lblICMSSub.Name = "lblICMSSub";
            this.lblICMSSub.Size = new System.Drawing.Size(55, 13);
            this.lblICMSSub.TabIndex = 9000033;
            this.lblICMSSub.Text = "ICMS Sub";
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.AutoSize = true;
            this.lblTotalPedido.Location = new System.Drawing.Point(488, 543);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(67, 13);
            this.lblTotalPedido.TabIndex = 9000034;
            this.lblTotalPedido.Text = "Total Pedido";
            // 
            // lblTotalAtendido
            // 
            this.lblTotalAtendido.AutoSize = true;
            this.lblTotalAtendido.Location = new System.Drawing.Point(488, 571);
            this.lblTotalAtendido.Name = "lblTotalAtendido";
            this.lblTotalAtendido.Size = new System.Drawing.Size(76, 13);
            this.lblTotalAtendido.TabIndex = 9000035;
            this.lblTotalAtendido.Text = "Total Atendido";
            // 
            // msktxtTotalIPI
            // 
            this.msktxtTotalIPI.Location = new System.Drawing.Point(247, 540);
            this.msktxtTotalIPI.Mask = "$ 000,00";
            this.msktxtTotalIPI.Name = "msktxtTotalIPI";
            this.msktxtTotalIPI.Size = new System.Drawing.Size(74, 20);
            this.msktxtTotalIPI.TabIndex = 19;
            this.msktxtTotalIPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msktxtICMSSub
            // 
            this.msktxtICMSSub.Location = new System.Drawing.Point(400, 568);
            this.msktxtICMSSub.Mask = "$ 000,00";
            this.msktxtICMSSub.Name = "msktxtICMSSub";
            this.msktxtICMSSub.Size = new System.Drawing.Size(74, 20);
            this.msktxtICMSSub.TabIndex = 21;
            this.msktxtICMSSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtdeTotalAtendido
            // 
            this.txtQtdeTotalAtendido.Location = new System.Drawing.Point(570, 568);
            this.txtQtdeTotalAtendido.Name = "txtQtdeTotalAtendido";
            this.txtQtdeTotalAtendido.Size = new System.Drawing.Size(46, 20);
            this.txtQtdeTotalAtendido.TabIndex = 23;
            // 
            // txtQtdeTotalPedido
            // 
            this.txtQtdeTotalPedido.Location = new System.Drawing.Point(570, 540);
            this.txtQtdeTotalPedido.Name = "txtQtdeTotalPedido";
            this.txtQtdeTotalPedido.Size = new System.Drawing.Size(46, 20);
            this.txtQtdeTotalPedido.TabIndex = 22;
            // 
            // msktxtValorTotalPedido
            // 
            this.msktxtValorTotalPedido.Location = new System.Drawing.Point(620, 540);
            this.msktxtValorTotalPedido.Mask = "$ 000,00";
            this.msktxtValorTotalPedido.Name = "msktxtValorTotalPedido";
            this.msktxtValorTotalPedido.Size = new System.Drawing.Size(74, 20);
            this.msktxtValorTotalPedido.TabIndex = 24;
            this.msktxtValorTotalPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msktxtValorTotalAtendido
            // 
            this.msktxtValorTotalAtendido.Location = new System.Drawing.Point(620, 568);
            this.msktxtValorTotalAtendido.Mask = "$ 000,00";
            this.msktxtValorTotalAtendido.Name = "msktxtValorTotalAtendido";
            this.msktxtValorTotalAtendido.Size = new System.Drawing.Size(74, 20);
            this.msktxtValorTotalAtendido.TabIndex = 25;
            this.msktxtValorTotalAtendido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msktxtTotalICMS
            // 
            this.msktxtTotalICMS.Location = new System.Drawing.Point(247, 568);
            this.msktxtTotalICMS.Mask = "$ 000,00";
            this.msktxtTotalICMS.Name = "msktxtTotalICMS";
            this.msktxtTotalICMS.Size = new System.Drawing.Size(74, 20);
            this.msktxtTotalICMS.TabIndex = 20;
            this.msktxtTotalICMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(339, 543);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(53, 13);
            this.lblDesconto.TabIndex = 9000036;
            this.lblDesconto.Text = "Desconto";
            // 
            // msktxtDesconto
            // 
            this.msktxtDesconto.Location = new System.Drawing.Point(400, 540);
            this.msktxtDesconto.Mask = "$ 000,00";
            this.msktxtDesconto.Name = "msktxtDesconto";
            this.msktxtDesconto.Size = new System.Drawing.Size(74, 20);
            this.msktxtDesconto.TabIndex = 9000037;
            this.msktxtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmInserirPedidoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(934, 684);
            this.Controls.Add(this.msktxtDesconto);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.msktxtTotalICMS);
            this.Controls.Add(this.msktxtValorTotalAtendido);
            this.Controls.Add(this.msktxtValorTotalPedido);
            this.Controls.Add(this.txtQtdeTotalPedido);
            this.Controls.Add(this.txtQtdeTotalAtendido);
            this.Controls.Add(this.msktxtICMSSub);
            this.Controls.Add(this.msktxtTotalIPI);
            this.Controls.Add(this.lblTotalAtendido);
            this.Controls.Add(this.lblTotalPedido);
            this.Controls.Add(this.lblICMSSub);
            this.Controls.Add(this.lblTotalICMS);
            this.Controls.Add(this.lblTotalIPI);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNotaFiscal);
            this.Controls.Add(this.btnBaixarPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInserirPedidoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido de Compra";
            this.Load += new System.EventHandler(this.FormInserirPedidoCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaixarPedido;
        private System.Windows.Forms.Button btnNotaFiscal;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox msktxtValorDolar;
        private System.Windows.Forms.TextBox txtNumNotaFiscal;
        private System.Windows.Forms.ComboBox cbCondPgto;
        private System.Windows.Forms.ComboBox cbFrete;
        private System.Windows.Forms.TextBox txtRazaoFornecedor;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.DateTimePicker dtDataReceb;
        private System.Windows.Forms.DateTimePicker dtDataPedido;
        private System.Windows.Forms.TextBox txtSerieNumPedido;
        private System.Windows.Forms.Label lblValorDolar;
        private System.Windows.Forms.Label lblNumNotaFiscal;
        private System.Windows.Forms.Label lblCondPgto;
        private System.Windows.Forms.Label lblFrete;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblDataReceb;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.MaskedTextBox msktxtPorcentICMS;
        private System.Windows.Forms.Label lblPorcentICMS;
        private System.Windows.Forms.MaskedTextBox msktxtPorcentIPI;
        private System.Windows.Forms.Label lblPorcentIPI;
        private System.Windows.Forms.MaskedTextBox msktxtPrecoVenda;
        private System.Windows.Forms.MaskedTextBox msktxtPrecoCompra;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.Label lblPrecoCompra;
        private System.Windows.Forms.MaskedTextBox msktxtQtdeAt;
        private System.Windows.Forms.MaskedTextBox msktxtQtdePed;
        private System.Windows.Forms.Label lblQtdeAtual;
        private System.Windows.Forms.Label lblQtdePedido;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdePed;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreçoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreçoVenda;
        private System.Windows.Forms.Label lblTotalIPI;
        private System.Windows.Forms.Label lblTotalICMS;
        private System.Windows.Forms.Label lblICMSSub;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.Label lblTotalAtendido;
        private System.Windows.Forms.MaskedTextBox msktxtTotalIPI;
        private System.Windows.Forms.MaskedTextBox msktxtICMSSub;
        private System.Windows.Forms.TextBox txtQtdeTotalAtendido;
        private System.Windows.Forms.TextBox txtQtdeTotalPedido;
        private System.Windows.Forms.MaskedTextBox msktxtValorTotalPedido;
        private System.Windows.Forms.MaskedTextBox msktxtValorTotalAtendido;
        private System.Windows.Forms.MaskedTextBox msktxtTotalICMS;
        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.MaskedTextBox msktxtDesconto;
    }
}