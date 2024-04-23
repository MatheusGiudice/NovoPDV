
namespace NovoPDV
{
    partial class frmCadastroProdutos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProdutos));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriçãoFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CódigoEAN13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreçoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreçoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueMínimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueMáximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtDescricaoFiscal = new System.Windows.Forms.TextBox();
            this.lblDescricaoFiscal = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtEAN13 = new System.Windows.Forms.TextBox();
            this.lblEAN13 = new System.Windows.Forms.Label();
            this.gbSituacaoAtivoInativo = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.pbFotoProduto = new System.Windows.Forms.PictureBox();
            this.btnAdicionarFoto = new System.Windows.Forms.Button();
            this.lblGrupoProduto = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.lblUndMedida = new System.Windows.Forms.Label();
            this.cbUndMedida = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFiscal = new System.Windows.Forms.Button();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.msktxtPrecoVenda = new System.Windows.Forms.MaskedTextBox();
            this.msktxtPrecoCusto = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnEtiquetaProduto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstoqueMaximo = new System.Windows.Forms.TextBox();
            this.lblEstoqueMaximo = new System.Windows.Forms.Label();
            this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.lblEstoqueMinimo = new System.Windows.Forms.Label();
            this.txtEstoqueAtual = new System.Windows.Forms.TextBox();
            this.lblEstoqueAtual = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.msktxtPreco2 = new System.Windows.Forms.MaskedTextBox();
            this.lblPreco2 = new System.Windows.Forms.Label();
            this.msktxtPreco1 = new System.Windows.Forms.MaskedTextBox();
            this.lblPreco1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbAtivoNao = new System.Windows.Forms.RadioButton();
            this.rbAtivoSim = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbSituacaoAtivoInativo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(412, 56);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 79);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(801, 56);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 79);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(598, 56);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 79);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(230, 56);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 79);
            this.btnNovo.TabIndex = 20;
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
            this.Situação,
            this.Descrição,
            this.DescriçãoFiscal,
            this.CódigoEAN13,
            this.Marca,
            this.Grupo,
            this.Modelo,
            this.UnidadeMedida,
            this.PreçoVenda,
            this.PreçoCusto,
            this.EstoqueAtual,
            this.EstoqueMínimo,
            this.EstoqueMáximo});
            this.dataGridView1.Location = new System.Drawing.Point(13, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 213);
            this.dataGridView1.TabIndex = 9000005;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 70;
            // 
            // Situação
            // 
            this.Situação.HeaderText = "Situação";
            this.Situação.Name = "Situação";
            this.Situação.Width = 70;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.Width = 180;
            // 
            // DescriçãoFiscal
            // 
            this.DescriçãoFiscal.HeaderText = "Descrição Fiscal";
            this.DescriçãoFiscal.Name = "DescriçãoFiscal";
            this.DescriçãoFiscal.Width = 180;
            // 
            // CódigoEAN13
            // 
            this.CódigoEAN13.HeaderText = "Código EAN 13";
            this.CódigoEAN13.Name = "CódigoEAN13";
            this.CódigoEAN13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CódigoEAN13.Width = 120;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // UnidadeMedida
            // 
            this.UnidadeMedida.HeaderText = "Und de Medida";
            this.UnidadeMedida.Name = "UnidadeMedida";
            this.UnidadeMedida.Width = 60;
            // 
            // PreçoVenda
            // 
            this.PreçoVenda.HeaderText = "Preço de Venda";
            this.PreçoVenda.Name = "PreçoVenda";
            this.PreçoVenda.Width = 80;
            // 
            // PreçoCusto
            // 
            this.PreçoCusto.HeaderText = "Preço de Custo";
            this.PreçoCusto.Name = "PreçoCusto";
            this.PreçoCusto.Width = 80;
            // 
            // EstoqueAtual
            // 
            this.EstoqueAtual.HeaderText = "Estoque Atual";
            this.EstoqueAtual.Name = "EstoqueAtual";
            this.EstoqueAtual.Width = 70;
            // 
            // EstoqueMínimo
            // 
            this.EstoqueMínimo.HeaderText = "Estoque Mínimo";
            this.EstoqueMínimo.Name = "EstoqueMínimo";
            this.EstoqueMínimo.Width = 70;
            // 
            // EstoqueMáximo
            // 
            this.EstoqueMáximo.HeaderText = "Estoque Máximo";
            this.EstoqueMáximo.Name = "EstoqueMáximo";
            this.EstoqueMáximo.Width = 70;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(276, 99);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(176, 51);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(69, 115);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(201, 20);
            this.txtPesquisar.TabIndex = 9000003;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(92, 86);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(75, 20);
            this.txtCodigo.TabIndex = 9000007;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodigo.Location = new System.Drawing.Point(16, 87);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 9000006;
            this.lblCodigo.Text = "Código";
            // 
            // txtDescricaoFiscal
            // 
            this.txtDescricaoFiscal.Location = new System.Drawing.Point(132, 139);
            this.txtDescricaoFiscal.Name = "txtDescricaoFiscal";
            this.txtDescricaoFiscal.Size = new System.Drawing.Size(257, 20);
            this.txtDescricaoFiscal.TabIndex = 2;
            // 
            // lblDescricaoFiscal
            // 
            this.lblDescricaoFiscal.AutoSize = true;
            this.lblDescricaoFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescricaoFiscal.Location = new System.Drawing.Point(15, 140);
            this.lblDescricaoFiscal.Name = "lblDescricaoFiscal";
            this.lblDescricaoFiscal.Size = new System.Drawing.Size(111, 17);
            this.lblDescricaoFiscal.TabIndex = 9000011;
            this.lblDescricaoFiscal.Text = "Descrição Fiscal";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(92, 113);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(297, 20);
            this.txtDescricaoProduto.TabIndex = 1;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNomeProduto.Location = new System.Drawing.Point(15, 114);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(71, 17);
            this.lblNomeProduto.TabIndex = 9000010;
            this.lblNomeProduto.Text = "Descrição";
            // 
            // txtEAN13
            // 
            this.txtEAN13.Location = new System.Drawing.Point(132, 165);
            this.txtEAN13.Name = "txtEAN13";
            this.txtEAN13.Size = new System.Drawing.Size(144, 20);
            this.txtEAN13.TabIndex = 3;
            // 
            // lblEAN13
            // 
            this.lblEAN13.AutoSize = true;
            this.lblEAN13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEAN13.Location = new System.Drawing.Point(15, 166);
            this.lblEAN13.Name = "lblEAN13";
            this.lblEAN13.Size = new System.Drawing.Size(104, 17);
            this.lblEAN13.TabIndex = 9000012;
            this.lblEAN13.Text = "Código EAN 13";
            // 
            // gbSituacaoAtivoInativo
            // 
            this.gbSituacaoAtivoInativo.Controls.Add(this.rbInativo);
            this.gbSituacaoAtivoInativo.Controls.Add(this.rbAtivo);
            this.gbSituacaoAtivoInativo.Location = new System.Drawing.Point(312, 23);
            this.gbSituacaoAtivoInativo.Name = "gbSituacaoAtivoInativo";
            this.gbSituacaoAtivoInativo.Size = new System.Drawing.Size(97, 72);
            this.gbSituacaoAtivoInativo.TabIndex = 9000013;
            this.gbSituacaoAtivoInativo.TabStop = false;
            this.gbSituacaoAtivoInativo.Text = "Situação";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(22, 42);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 9000014;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(22, 19);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 9000013;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // pbFotoProduto
            // 
            this.pbFotoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFotoProduto.Location = new System.Drawing.Point(446, 76);
            this.pbFotoProduto.Name = "pbFotoProduto";
            this.pbFotoProduto.Size = new System.Drawing.Size(141, 148);
            this.pbFotoProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoProduto.TabIndex = 9000015;
            this.pbFotoProduto.TabStop = false;
            // 
            // btnAdicionarFoto
            // 
            this.btnAdicionarFoto.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdicionarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdicionarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarFoto.Image")));
            this.btnAdicionarFoto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionarFoto.Location = new System.Drawing.Point(609, 104);
            this.btnAdicionarFoto.Name = "btnAdicionarFoto";
            this.btnAdicionarFoto.Size = new System.Drawing.Size(74, 79);
            this.btnAdicionarFoto.TabIndex = 16;
            this.btnAdicionarFoto.Text = "Adicionar Foto";
            this.btnAdicionarFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionarFoto.UseVisualStyleBackColor = false;
            this.btnAdicionarFoto.Click += new System.EventHandler(this.btnAdicionarFoto_Click);
            // 
            // lblGrupoProduto
            // 
            this.lblGrupoProduto.AutoSize = true;
            this.lblGrupoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGrupoProduto.Location = new System.Drawing.Point(16, 272);
            this.lblGrupoProduto.Name = "lblGrupoProduto";
            this.lblGrupoProduto.Size = new System.Drawing.Size(48, 17);
            this.lblGrupoProduto.TabIndex = 9000017;
            this.lblGrupoProduto.Text = "Grupo";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(132, 271);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(144, 20);
            this.txtGrupo.TabIndex = 7;
            // 
            // lblUndMedida
            // 
            this.lblUndMedida.AutoSize = true;
            this.lblUndMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUndMedida.Location = new System.Drawing.Point(16, 298);
            this.lblUndMedida.Name = "lblUndMedida";
            this.lblUndMedida.Size = new System.Drawing.Size(80, 17);
            this.lblUndMedida.TabIndex = 9000018;
            this.lblUndMedida.Text = "Un. Medida";
            // 
            // cbUndMedida
            // 
            this.cbUndMedida.FormattingEnabled = true;
            this.cbUndMedida.Items.AddRange(new object[] {
            "GR",
            "KG",
            "MG",
            "ML",
            "MT",
            "PÇ",
            "UN"});
            this.cbUndMedida.Location = new System.Drawing.Point(132, 297);
            this.cbUndMedida.Name = "cbUndMedida";
            this.cbUndMedida.Size = new System.Drawing.Size(85, 21);
            this.cbUndMedida.TabIndex = 8;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMarca.Location = new System.Drawing.Point(15, 192);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 9000019;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(132, 191);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(144, 20);
            this.txtMarca.TabIndex = 4;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblModelo.Location = new System.Drawing.Point(16, 218);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 17);
            this.lblModelo.TabIndex = 9000020;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(132, 217);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(144, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(23, 633);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 51);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFiscal
            // 
            this.btnFiscal.BackColor = System.Drawing.SystemColors.Control;
            this.btnFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFiscal.Image = ((System.Drawing.Image)(resources.GetObject("btnFiscal.Image")));
            this.btnFiscal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiscal.Location = new System.Drawing.Point(554, 568);
            this.btnFiscal.Name = "btnFiscal";
            this.btnFiscal.Size = new System.Drawing.Size(120, 51);
            this.btnFiscal.TabIndex = 17;
            this.btnFiscal.Text = "Fiscal";
            this.btnFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiscal.UseVisualStyleBackColor = false;
            this.btnFiscal.Click += new System.EventHandler(this.btnFiscal_Click);
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrecoVenda.Location = new System.Drawing.Point(16, 325);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(110, 17);
            this.lblPrecoVenda.TabIndex = 9000022;
            this.lblPrecoVenda.Text = "Preço de Venda";
            // 
            // msktxtPrecoVenda
            // 
            this.msktxtPrecoVenda.Location = new System.Drawing.Point(132, 324);
            this.msktxtPrecoVenda.Mask = "$ 000,00";
            this.msktxtPrecoVenda.Name = "msktxtPrecoVenda";
            this.msktxtPrecoVenda.Size = new System.Drawing.Size(85, 20);
            this.msktxtPrecoVenda.TabIndex = 9;
            this.msktxtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msktxtPrecoCusto
            // 
            this.msktxtPrecoCusto.Location = new System.Drawing.Point(349, 324);
            this.msktxtPrecoCusto.Mask = "$ 000,00";
            this.msktxtPrecoCusto.Name = "msktxtPrecoCusto";
            this.msktxtPrecoCusto.Size = new System.Drawing.Size(85, 20);
            this.msktxtPrecoCusto.TabIndex = 10;
            this.msktxtPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrecoCusto.Location = new System.Drawing.Point(233, 325);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(105, 17);
            this.lblPrecoCusto.TabIndex = 9000024;
            this.lblPrecoCusto.Text = "Preço de Custo";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFornecedor.Location = new System.Drawing.Point(16, 244);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(81, 17);
            this.lblFornecedor.TabIndex = 9000026;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(132, 244);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(257, 21);
            this.cbFornecedor.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1034, 543);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9000027;
            this.pictureBox1.TabStop = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1305, 25);
            this.bindingNavigator1.TabIndex = 9000028;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.SystemColors.Control;
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
            this.btnImportar.Location = new System.Drawing.Point(48, 53);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(85, 79);
            this.btnImportar.TabIndex = 19;
            this.btnImportar.Text = "Importar Cadastros";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImportar.UseVisualStyleBackColor = false;
            // 
            // btnEtiquetaProduto
            // 
            this.btnEtiquetaProduto.BackColor = System.Drawing.SystemColors.Control;
            this.btnEtiquetaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEtiquetaProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnEtiquetaProduto.Image")));
            this.btnEtiquetaProduto.Location = new System.Drawing.Point(1000, 56);
            this.btnEtiquetaProduto.Name = "btnEtiquetaProduto";
            this.btnEtiquetaProduto.Size = new System.Drawing.Size(85, 79);
            this.btnEtiquetaProduto.TabIndex = 24;
            this.btnEtiquetaProduto.Text = "Etiqueta";
            this.btnEtiquetaProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEtiquetaProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEtiquetaProduto.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstoqueMaximo);
            this.groupBox1.Controls.Add(this.lblEstoqueMaximo);
            this.groupBox1.Controls.Add(this.txtEstoqueMinimo);
            this.groupBox1.Controls.Add(this.lblEstoqueMinimo);
            this.groupBox1.Controls.Add(this.txtEstoqueAtual);
            this.groupBox1.Controls.Add(this.lblEstoqueAtual);
            this.groupBox1.Location = new System.Drawing.Point(446, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 121);
            this.groupBox1.TabIndex = 9000029;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estoque";
            // 
            // txtEstoqueMaximo
            // 
            this.txtEstoqueMaximo.Location = new System.Drawing.Point(138, 80);
            this.txtEstoqueMaximo.Name = "txtEstoqueMaximo";
            this.txtEstoqueMaximo.Size = new System.Drawing.Size(95, 20);
            this.txtEstoqueMaximo.TabIndex = 15;
            // 
            // lblEstoqueMaximo
            // 
            this.lblEstoqueMaximo.AutoSize = true;
            this.lblEstoqueMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEstoqueMaximo.Location = new System.Drawing.Point(11, 81);
            this.lblEstoqueMaximo.Name = "lblEstoqueMaximo";
            this.lblEstoqueMaximo.Size = new System.Drawing.Size(111, 17);
            this.lblEstoqueMaximo.TabIndex = 9000034;
            this.lblEstoqueMaximo.Text = "Estoque Máximo";
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(138, 54);
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(95, 20);
            this.txtEstoqueMinimo.TabIndex = 14;
            // 
            // lblEstoqueMinimo
            // 
            this.lblEstoqueMinimo.AutoSize = true;
            this.lblEstoqueMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEstoqueMinimo.Location = new System.Drawing.Point(11, 55);
            this.lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            this.lblEstoqueMinimo.Size = new System.Drawing.Size(108, 17);
            this.lblEstoqueMinimo.TabIndex = 9000032;
            this.lblEstoqueMinimo.Text = "Estoque Mínimo";
            // 
            // txtEstoqueAtual
            // 
            this.txtEstoqueAtual.Location = new System.Drawing.Point(138, 28);
            this.txtEstoqueAtual.Name = "txtEstoqueAtual";
            this.txtEstoqueAtual.Size = new System.Drawing.Size(95, 20);
            this.txtEstoqueAtual.TabIndex = 13;
            // 
            // lblEstoqueAtual
            // 
            this.lblEstoqueAtual.AutoSize = true;
            this.lblEstoqueAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEstoqueAtual.Location = new System.Drawing.Point(11, 29);
            this.lblEstoqueAtual.Name = "lblEstoqueAtual";
            this.lblEstoqueAtual.Size = new System.Drawing.Size(96, 17);
            this.lblEstoqueAtual.TabIndex = 9000030;
            this.lblEstoqueAtual.Text = "Estoque Atual";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.msktxtPreco2);
            this.groupBox2.Controls.Add(this.lblPreco2);
            this.groupBox2.Controls.Add(this.msktxtPreco1);
            this.groupBox2.Controls.Add(this.lblPreco1);
            this.groupBox2.Controls.Add(this.lblNomeProduto);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtDescricaoProduto);
            this.groupBox2.Controls.Add(this.lblDescricaoFiscal);
            this.groupBox2.Controls.Add(this.txtDescricaoFiscal);
            this.groupBox2.Controls.Add(this.txtEAN13);
            this.groupBox2.Controls.Add(this.lblEAN13);
            this.groupBox2.Controls.Add(this.btnAdicionarFoto);
            this.groupBox2.Controls.Add(this.gbSituacaoAtivoInativo);
            this.groupBox2.Controls.Add(this.cbFornecedor);
            this.groupBox2.Controls.Add(this.pbFotoProduto);
            this.groupBox2.Controls.Add(this.lblGrupoProduto);
            this.groupBox2.Controls.Add(this.lblFornecedor);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.lblCodigo);
            this.groupBox2.Controls.Add(this.txtGrupo);
            this.groupBox2.Controls.Add(this.msktxtPrecoCusto);
            this.groupBox2.Controls.Add(this.lblUndMedida);
            this.groupBox2.Controls.Add(this.lblPrecoCusto);
            this.groupBox2.Controls.Add(this.cbUndMedida);
            this.groupBox2.Controls.Add(this.msktxtPrecoVenda);
            this.groupBox2.Controls.Add(this.lblMarca);
            this.groupBox2.Controls.Add(this.lblPrecoVenda);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(this.lblModelo);
            this.groupBox2.Controls.Add(this.txtModelo);
            this.groupBox2.Location = new System.Drawing.Point(610, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 387);
            this.groupBox2.TabIndex = 9000030;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Produtos";
            // 
            // msktxtPreco2
            // 
            this.msktxtPreco2.Location = new System.Drawing.Point(349, 350);
            this.msktxtPreco2.Mask = "$ 000,00";
            this.msktxtPreco2.Name = "msktxtPreco2";
            this.msktxtPreco2.Size = new System.Drawing.Size(85, 20);
            this.msktxtPreco2.TabIndex = 12;
            this.msktxtPreco2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPreco2
            // 
            this.lblPreco2.AutoSize = true;
            this.lblPreco2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPreco2.Location = new System.Drawing.Point(233, 351);
            this.lblPreco2.Name = "lblPreco2";
            this.lblPreco2.Size = new System.Drawing.Size(57, 17);
            this.lblPreco2.TabIndex = 9000033;
            this.lblPreco2.Text = "Preço 2";
            // 
            // msktxtPreco1
            // 
            this.msktxtPreco1.Location = new System.Drawing.Point(132, 350);
            this.msktxtPreco1.Mask = "$ 000,00";
            this.msktxtPreco1.Name = "msktxtPreco1";
            this.msktxtPreco1.Size = new System.Drawing.Size(85, 20);
            this.msktxtPreco1.TabIndex = 11;
            this.msktxtPreco1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPreco1
            // 
            this.lblPreco1.AutoSize = true;
            this.lblPreco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPreco1.Location = new System.Drawing.Point(16, 351);
            this.lblPreco1.Name = "lblPreco1";
            this.lblPreco1.Size = new System.Drawing.Size(57, 17);
            this.lblPreco1.TabIndex = 9000031;
            this.lblPreco1.Text = "Preço 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDescricao);
            this.groupBox3.Controls.Add(this.rbCodigo);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.txtPesquisar);
            this.groupBox3.Controls.Add(this.btnPesquisar);
            this.groupBox3.Location = new System.Drawing.Point(45, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 387);
            this.groupBox3.TabIndex = 9000031;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar";
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Location = new System.Drawing.Point(276, 65);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(73, 17);
            this.rbDescricao.TabIndex = 9000037;
            this.rbDescricao.TabStop = true;
            this.rbDescricao.Text = "Descrição";
            this.rbDescricao.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(171, 65);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbCodigo.TabIndex = 9000036;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbAtivoNao);
            this.groupBox4.Controls.Add(this.rbAtivoSim);
            this.groupBox4.Location = new System.Drawing.Point(13, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(103, 49);
            this.groupBox4.TabIndex = 9000035;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ativo";
            // 
            // rbAtivoNao
            // 
            this.rbAtivoNao.AutoSize = true;
            this.rbAtivoNao.Location = new System.Drawing.Point(54, 19);
            this.rbAtivoNao.Name = "rbAtivoNao";
            this.rbAtivoNao.Size = new System.Drawing.Size(45, 17);
            this.rbAtivoNao.TabIndex = 9000035;
            this.rbAtivoNao.TabStop = true;
            this.rbAtivoNao.Text = "Não";
            this.rbAtivoNao.UseVisualStyleBackColor = true;
            // 
            // rbAtivoSim
            // 
            this.rbAtivoSim.AutoSize = true;
            this.rbAtivoSim.Location = new System.Drawing.Point(6, 19);
            this.rbAtivoSim.Name = "rbAtivoSim";
            this.rbAtivoSim.Size = new System.Drawing.Size(42, 17);
            this.rbAtivoSim.TabIndex = 9000034;
            this.rbAtivoSim.TabStop = true;
            this.rbAtivoSim.Text = "Sim";
            this.rbAtivoSim.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(1204, 56);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 79);
            this.btnCancelar.TabIndex = 9000099;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1305, 694);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEtiquetaProduto);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFiscal);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastroProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbSituacaoAtivoInativo.ResumeLayout(false);
            this.gbSituacaoAtivoInativo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescricaoFiscal;
        private System.Windows.Forms.Label lblDescricaoFiscal;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtEAN13;
        private System.Windows.Forms.Label lblEAN13;
        private System.Windows.Forms.GroupBox gbSituacaoAtivoInativo;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.PictureBox pbFotoProduto;
        private System.Windows.Forms.Button btnAdicionarFoto;
        private System.Windows.Forms.Label lblGrupoProduto;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label lblUndMedida;
        private System.Windows.Forms.ComboBox cbUndMedida;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFiscal;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.MaskedTextBox msktxtPrecoVenda;
        private System.Windows.Forms.MaskedTextBox msktxtPrecoCusto;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnEtiquetaProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEstoqueMaximo;
        private System.Windows.Forms.Label lblEstoqueMaximo;
        private System.Windows.Forms.TextBox txtEstoqueMinimo;
        private System.Windows.Forms.Label lblEstoqueMinimo;
        private System.Windows.Forms.TextBox txtEstoqueAtual;
        private System.Windows.Forms.Label lblEstoqueAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriçãoFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódigoEAN13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreçoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreçoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueMínimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueMáximo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox msktxtPreco2;
        private System.Windows.Forms.Label lblPreco2;
        private System.Windows.Forms.MaskedTextBox msktxtPreco1;
        private System.Windows.Forms.Label lblPreco1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbAtivoNao;
        private System.Windows.Forms.RadioButton rbAtivoSim;
        private System.Windows.Forms.Button btnCancelar;
    }
}