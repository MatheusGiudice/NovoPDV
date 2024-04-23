
namespace NovoPDV
{
    partial class frmDevolucaoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucaoPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCarregarItens = new System.Windows.Forms.Button();
            this.txtCodDevolucao = new System.Windows.Forms.TextBox();
            this.lblCodDevolucao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipoPedido = new System.Windows.Forms.ComboBox();
            this.lblTipoPedido = new System.Windows.Forms.Label();
            this.btnIncluirItem = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Código_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unitário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msktxtPrecoUnitario = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.msktxtCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFCNPJ = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtMotivoDev = new System.Windows.Forms.TextBox();
            this.lblMotivoDev = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Devolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Location = new System.Drawing.Point(79, 34);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(70, 20);
            this.txtNumPedido.TabIndex = 1;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(33, 37);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(40, 13);
            this.lblPedido.TabIndex = 9000035;
            this.lblPedido.Text = "Pedido";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(520, 17);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 79);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(956, 17);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 79);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCarregarItens
            // 
            this.btnCarregarItens.BackColor = System.Drawing.SystemColors.Control;
            this.btnCarregarItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCarregarItens.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregarItens.Image")));
            this.btnCarregarItens.Location = new System.Drawing.Point(737, 17);
            this.btnCarregarItens.Name = "btnCarregarItens";
            this.btnCarregarItens.Size = new System.Drawing.Size(85, 79);
            this.btnCarregarItens.TabIndex = 14;
            this.btnCarregarItens.Text = "Carregar Itens";
            this.btnCarregarItens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarregarItens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCarregarItens.UseVisualStyleBackColor = false;
            this.btnCarregarItens.Click += new System.EventHandler(this.btnCarregarItens_Click);
            // 
            // txtCodDevolucao
            // 
            this.txtCodDevolucao.Enabled = false;
            this.txtCodDevolucao.Location = new System.Drawing.Point(270, 150);
            this.txtCodDevolucao.Name = "txtCodDevolucao";
            this.txtCodDevolucao.Size = new System.Drawing.Size(80, 20);
            this.txtCodDevolucao.TabIndex = 9000039;
            // 
            // lblCodDevolucao
            // 
            this.lblCodDevolucao.AutoSize = true;
            this.lblCodDevolucao.Location = new System.Drawing.Point(224, 153);
            this.lblCodDevolucao.Name = "lblCodDevolucao";
            this.lblCodDevolucao.Size = new System.Drawing.Size(40, 13);
            this.lblCodDevolucao.TabIndex = 9000040;
            this.lblCodDevolucao.Text = "Código";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipoPedido);
            this.groupBox1.Controls.Add(this.lblTipoPedido);
            this.groupBox1.Controls.Add(this.btnIncluirItem);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.msktxtPrecoUnitario);
            this.groupBox1.Controls.Add(this.lblPrecoUnitario);
            this.groupBox1.Controls.Add(this.txtQtde);
            this.groupBox1.Controls.Add(this.lblQuantidade);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.lblProduto);
            this.groupBox1.Controls.Add(this.msktxtCPFCNPJ);
            this.groupBox1.Controls.Add(this.lblCPFCNPJ);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.txtMotivoDev);
            this.groupBox1.Controls.Add(this.lblMotivoDev);
            this.groupBox1.Controls.Add(this.txtNumPedido);
            this.groupBox1.Controls.Add(this.lblPedido);
            this.groupBox1.Location = new System.Drawing.Point(620, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 378);
            this.groupBox1.TabIndex = 9000041;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Pedido";
            // 
            // cbTipoPedido
            // 
            this.cbTipoPedido.FormattingEnabled = true;
            this.cbTipoPedido.Items.AddRange(new object[] {
            "Compra",
            "Venda"});
            this.cbTipoPedido.Location = new System.Drawing.Point(204, 32);
            this.cbTipoPedido.Name = "cbTipoPedido";
            this.cbTipoPedido.Size = new System.Drawing.Size(78, 21);
            this.cbTipoPedido.TabIndex = 2;
            // 
            // lblTipoPedido
            // 
            this.lblTipoPedido.AutoSize = true;
            this.lblTipoPedido.Location = new System.Drawing.Point(170, 37);
            this.lblTipoPedido.Name = "lblTipoPedido";
            this.lblTipoPedido.Size = new System.Drawing.Size(28, 13);
            this.lblTipoPedido.TabIndex = 9000048;
            this.lblTipoPedido.Text = "Tipo";
            // 
            // btnIncluirItem
            // 
            this.btnIncluirItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnIncluirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnIncluirItem.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirItem.Image")));
            this.btnIncluirItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirItem.Location = new System.Drawing.Point(221, 153);
            this.btnIncluirItem.Name = "btnIncluirItem";
            this.btnIncluirItem.Size = new System.Drawing.Size(125, 51);
            this.btnIncluirItem.TabIndex = 16;
            this.btnIncluirItem.Text = "Incluir Item";
            this.btnIncluirItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluirItem.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código_Produto,
            this.Descrição,
            this.Quantidade,
            this.Valor_Unitário,
            this.Valor_Total_Item});
            this.dataGridView2.Location = new System.Drawing.Point(26, 220);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(520, 133);
            this.dataGridView2.TabIndex = 9000047;
            // 
            // Código_Produto
            // 
            this.Código_Produto.HeaderText = "Cód. Produto";
            this.Código_Produto.Name = "Código_Produto";
            this.Código_Produto.ReadOnly = true;
            this.Código_Produto.Width = 70;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Width = 180;
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 87;
            // 
            // Valor_Unitário
            // 
            this.Valor_Unitário.HeaderText = "Valor Unitário";
            this.Valor_Unitário.Name = "Valor_Unitário";
            this.Valor_Unitário.ReadOnly = true;
            this.Valor_Unitário.Width = 70;
            // 
            // Valor_Total_Item
            // 
            this.Valor_Total_Item.HeaderText = "Valor Total";
            this.Valor_Total_Item.Name = "Valor_Total_Item";
            this.Valor_Total_Item.ReadOnly = true;
            this.Valor_Total_Item.Width = 70;
            // 
            // msktxtPrecoUnitario
            // 
            this.msktxtPrecoUnitario.Location = new System.Drawing.Point(452, 106);
            this.msktxtPrecoUnitario.Mask = "$ ___,___";
            this.msktxtPrecoUnitario.Name = "msktxtPrecoUnitario";
            this.msktxtPrecoUnitario.Size = new System.Drawing.Size(73, 20);
            this.msktxtPrecoUnitario.TabIndex = 8;
            this.msktxtPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(381, 109);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(60, 13);
            this.lblPrecoUnitario.TabIndex = 9000046;
            this.lblPrecoUnitario.Text = "Preço Unit.";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(254, 106);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 7;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(218, 109);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(30, 13);
            this.lblQuantidade.TabIndex = 9000044;
            this.lblQuantidade.Text = "Qtde";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(79, 106);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 6;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(33, 109);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 9000042;
            this.lblProduto.Text = "Produto";
            // 
            // msktxtCPFCNPJ
            // 
            this.msktxtCPFCNPJ.Location = new System.Drawing.Point(385, 71);
            this.msktxtCPFCNPJ.Name = "msktxtCPFCNPJ";
            this.msktxtCPFCNPJ.Size = new System.Drawing.Size(140, 20);
            this.msktxtCPFCNPJ.TabIndex = 5;
            // 
            // lblCPFCNPJ
            // 
            this.lblCPFCNPJ.AutoSize = true;
            this.lblCPFCNPJ.Location = new System.Drawing.Point(314, 74);
            this.lblCPFCNPJ.Name = "lblCPFCNPJ";
            this.lblCPFCNPJ.Size = new System.Drawing.Size(65, 13);
            this.lblCPFCNPJ.TabIndex = 9000040;
            this.lblCPFCNPJ.Text = "CPF / CNPJ";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(79, 71);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(203, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(33, 74);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 9000039;
            this.lblCliente.Text = "Cliente";
            // 
            // txtMotivoDev
            // 
            this.txtMotivoDev.Location = new System.Drawing.Point(336, 34);
            this.txtMotivoDev.Name = "txtMotivoDev";
            this.txtMotivoDev.Size = new System.Drawing.Size(189, 20);
            this.txtMotivoDev.TabIndex = 3;
            // 
            // lblMotivoDev
            // 
            this.lblMotivoDev.AutoSize = true;
            this.lblMotivoDev.Location = new System.Drawing.Point(291, 37);
            this.lblMotivoDev.Name = "lblMotivoDev";
            this.lblMotivoDev.Size = new System.Drawing.Size(39, 13);
            this.lblMotivoDev.TabIndex = 9000037;
            this.lblMotivoDev.Text = "Motivo";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(312, 17);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 79);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.NumPedido,
            this.Cliente,
            this.TipoPedido,
            this.Data_Pedido,
            this.Data_Devolucao,
            this.CPF_CNPJ,
            this.Vendedor,
            this.Quantidade_Produtos,
            this.Valor_Total});
            this.dataGridView1.Location = new System.Drawing.Point(47, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 171);
            this.dataGridView1.TabIndex = 9000043;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 631);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 51);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(326, 233);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(176, 51);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(117, 249);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(184, 20);
            this.txtPesquisar.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(312, 17);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 79);
            this.btnCancelar.TabIndex = 9000100;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 70;
            // 
            // NumPedido
            // 
            this.NumPedido.HeaderText = "Nº Pedido";
            this.NumPedido.Name = "NumPedido";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 180;
            // 
            // TipoPedido
            // 
            this.TipoPedido.HeaderText = "Tipo Pedido";
            this.TipoPedido.Name = "TipoPedido";
            // 
            // Data_Pedido
            // 
            this.Data_Pedido.HeaderText = "Data Pedido";
            this.Data_Pedido.Name = "Data_Pedido";
            // 
            // Data_Devolucao
            // 
            this.Data_Devolucao.HeaderText = "Data Devolução";
            this.Data_Devolucao.Name = "Data_Devolucao";
            // 
            // CPF_CNPJ
            // 
            this.CPF_CNPJ.HeaderText = "CPF / CNPJ";
            this.CPF_CNPJ.Name = "CPF_CNPJ";
            this.CPF_CNPJ.Width = 150;
            // 
            // Vendedor
            // 
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Width = 130;
            // 
            // Quantidade_Produtos
            // 
            this.Quantidade_Produtos.HeaderText = "Qtde Produtos";
            this.Quantidade_Produtos.Name = "Quantidade_Produtos";
            this.Quantidade_Produtos.Width = 70;
            // 
            // Valor_Total
            // 
            dataGridViewCellStyle1.Format = "C4";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor_Total.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor_Total.HeaderText = "Valor Total";
            this.Valor_Total.Name = "Valor_Total";
            // 
            // frmDevolucaoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1305, 694);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtCodDevolucao);
            this.Controls.Add(this.lblCodDevolucao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCarregarItens);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDevolucaoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluções";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDevPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregarItens;
        private System.Windows.Forms.TextBox txtCodDevolucao;
        private System.Windows.Forms.Label lblCodDevolucao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unitário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total_Item;
        private System.Windows.Forms.MaskedTextBox msktxtPrecoUnitario;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.MaskedTextBox msktxtCPFCNPJ;
        private System.Windows.Forms.Label lblCPFCNPJ;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtMotivoDev;
        private System.Windows.Forms.Label lblMotivoDev;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnIncluirItem;
        private System.Windows.Forms.ComboBox cbTipoPedido;
        private System.Windows.Forms.Label lblTipoPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Devolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade_Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
    }
}