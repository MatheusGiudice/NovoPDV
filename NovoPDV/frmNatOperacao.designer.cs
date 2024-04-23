
namespace NovoPDV
{
    partial class frmNatOperacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNatOperacao));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTipoNatureza = new System.Windows.Forms.Label();
            this.cbTipoNatureza = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cbLayout = new System.Windows.Forms.ComboBox();
            this.lblLayout = new System.Windows.Forms.Label();
            this.cbFinalidadeEmissao = new System.Windows.Forms.ComboBox();
            this.lblFinalidadeEmissao = new System.Windows.Forms.Label();
            this.chkDevolRetorno = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSobCFOPConfigItensNota = new System.Windows.Forms.CheckBox();
            this.chkCalcEmpSimpNac = new System.Windows.Forms.CheckBox();
            this.chkBaseCalcICMScomIPIConsFinal = new System.Windows.Forms.CheckBox();
            this.chkNaoAddICMSSubTotalNota = new System.Windows.Forms.CheckBox();
            this.chkCalculaICMS = new System.Windows.Forms.CheckBox();
            this.chkBaseCalcICMScomIPI = new System.Windows.Forms.CheckBox();
            this.chkEntrada = new System.Windows.Forms.CheckBox();
            this.chkComplementar = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoNatureza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Layout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalidadeEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(289, 32);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 79);
            this.btnAlterar.TabIndex = 11;
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
            this.btnSalvar.Location = new System.Drawing.Point(631, 32);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 79);
            this.btnSalvar.TabIndex = 13;
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
            this.btnExcluir.Location = new System.Drawing.Point(457, 32);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 79);
            this.btnExcluir.TabIndex = 12;
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
            this.btnNovo.Location = new System.Drawing.Point(115, 32);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 79);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 539);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 51);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(506, 154);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(58, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(460, 157);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 37;
            this.lblCodigo.Text = "Código";
            // 
            // lblTipoNatureza
            // 
            this.lblTipoNatureza.AutoSize = true;
            this.lblTipoNatureza.Location = new System.Drawing.Point(617, 157);
            this.lblTipoNatureza.Name = "lblTipoNatureza";
            this.lblTipoNatureza.Size = new System.Drawing.Size(89, 13);
            this.lblTipoNatureza.TabIndex = 38;
            this.lblTipoNatureza.Text = "Tipo da Natureza";
            // 
            // cbTipoNatureza
            // 
            this.cbTipoNatureza.FormattingEnabled = true;
            this.cbTipoNatureza.Items.AddRange(new object[] {
            "Dentro do Estado",
            "Fora do Estado",
            "Sem Inscrição Estadual"});
            this.cbTipoNatureza.Location = new System.Drawing.Point(712, 154);
            this.cbTipoNatureza.Name = "cbTipoNatureza";
            this.cbTipoNatureza.Size = new System.Drawing.Size(131, 21);
            this.cbTipoNatureza.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(521, 180);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(322, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(460, 183);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 40;
            this.lblDescricao.Text = "Descrição";
            // 
            // cbLayout
            // 
            this.cbLayout.FormattingEnabled = true;
            this.cbLayout.Items.AddRange(new object[] {
            "Nota Fiscal de Entrada",
            "Nota Fiscal"});
            this.cbLayout.Location = new System.Drawing.Point(521, 206);
            this.cbLayout.Name = "cbLayout";
            this.cbLayout.Size = new System.Drawing.Size(175, 21);
            this.cbLayout.TabIndex = 4;
            // 
            // lblLayout
            // 
            this.lblLayout.AutoSize = true;
            this.lblLayout.Location = new System.Drawing.Point(460, 209);
            this.lblLayout.Name = "lblLayout";
            this.lblLayout.Size = new System.Drawing.Size(39, 13);
            this.lblLayout.TabIndex = 42;
            this.lblLayout.Text = "Layout";
            // 
            // cbFinalidadeEmissao
            // 
            this.cbFinalidadeEmissao.FormattingEnabled = true;
            this.cbFinalidadeEmissao.Items.AddRange(new object[] {
            "1 - NF-e Normal",
            "2 - NF-e Complementar",
            "3 - NF-e de Ajuste",
            "4 - Devolução de Mercadoria"});
            this.cbFinalidadeEmissao.Location = new System.Drawing.Point(578, 233);
            this.cbFinalidadeEmissao.Name = "cbFinalidadeEmissao";
            this.cbFinalidadeEmissao.Size = new System.Drawing.Size(265, 21);
            this.cbFinalidadeEmissao.TabIndex = 5;
            // 
            // lblFinalidadeEmissao
            // 
            this.lblFinalidadeEmissao.AutoSize = true;
            this.lblFinalidadeEmissao.Location = new System.Drawing.Point(460, 236);
            this.lblFinalidadeEmissao.Name = "lblFinalidadeEmissao";
            this.lblFinalidadeEmissao.Size = new System.Drawing.Size(112, 13);
            this.lblFinalidadeEmissao.TabIndex = 44;
            this.lblFinalidadeEmissao.Text = "Finalidade de Emissão";
            // 
            // chkDevolRetorno
            // 
            this.chkDevolRetorno.AutoSize = true;
            this.chkDevolRetorno.Location = new System.Drawing.Point(6, 19);
            this.chkDevolRetorno.Name = "chkDevolRetorno";
            this.chkDevolRetorno.Size = new System.Drawing.Size(127, 17);
            this.chkDevolRetorno.TabIndex = 6;
            this.chkDevolRetorno.Text = "Devolução / Retorno";
            this.chkDevolRetorno.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(431, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 315);
            this.groupBox1.TabIndex = 909091;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSobCFOPConfigItensNota);
            this.groupBox3.Controls.Add(this.chkCalcEmpSimpNac);
            this.groupBox3.Controls.Add(this.chkBaseCalcICMScomIPIConsFinal);
            this.groupBox3.Controls.Add(this.chkNaoAddICMSSubTotalNota);
            this.groupBox3.Controls.Add(this.chkCalculaICMS);
            this.groupBox3.Controls.Add(this.chkBaseCalcICMScomIPI);
            this.groupBox3.Controls.Add(this.chkEntrada);
            this.groupBox3.Controls.Add(this.chkComplementar);
            this.groupBox3.Controls.Add(this.chkDevolRetorno);
            this.groupBox3.Location = new System.Drawing.Point(12, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 160);
            this.groupBox3.TabIndex = 909091;
            this.groupBox3.TabStop = false;
            // 
            // chkSobCFOPConfigItensNota
            // 
            this.chkSobCFOPConfigItensNota.AutoSize = true;
            this.chkSobCFOPConfigItensNota.Location = new System.Drawing.Point(6, 134);
            this.chkSobCFOPConfigItensNota.Name = "chkSobCFOPConfigItensNota";
            this.chkSobCFOPConfigItensNota.Size = new System.Drawing.Size(267, 17);
            this.chkSobCFOPConfigItensNota.TabIndex = 14;
            this.chkSobCFOPConfigItensNota.Text = "Sobrescrever CFOP Configurado nos Itens da Nota";
            this.chkSobCFOPConfigItensNota.UseVisualStyleBackColor = true;
            // 
            // chkCalcEmpSimpNac
            // 
            this.chkCalcEmpSimpNac.AutoSize = true;
            this.chkCalcEmpSimpNac.Location = new System.Drawing.Point(6, 111);
            this.chkCalcEmpSimpNac.Name = "chkCalcEmpSimpNac";
            this.chkCalcEmpSimpNac.Size = new System.Drawing.Size(299, 17);
            this.chkCalcEmpSimpNac.TabIndex = 13;
            this.chkCalcEmpSimpNac.Text = "Cálculo para Empresa Cadastrada como Simples Nacional";
            this.chkCalcEmpSimpNac.UseVisualStyleBackColor = true;
            // 
            // chkBaseCalcICMScomIPIConsFinal
            // 
            this.chkBaseCalcICMScomIPIConsFinal.AutoSize = true;
            this.chkBaseCalcICMScomIPIConsFinal.Location = new System.Drawing.Point(6, 88);
            this.chkBaseCalcICMScomIPIConsFinal.Name = "chkBaseCalcICMScomIPIConsFinal";
            this.chkBaseCalcICMScomIPIConsFinal.Size = new System.Drawing.Size(293, 17);
            this.chkBaseCalcICMScomIPIConsFinal.TabIndex = 12;
            this.chkBaseCalcICMScomIPIConsFinal.Text = "Base de Cálculo do ICMS com IPI para Consumidor Final";
            this.chkBaseCalcICMScomIPIConsFinal.UseVisualStyleBackColor = true;
            // 
            // chkNaoAddICMSSubTotalNota
            // 
            this.chkNaoAddICMSSubTotalNota.AutoSize = true;
            this.chkNaoAddICMSSubTotalNota.Location = new System.Drawing.Point(212, 65);
            this.chkNaoAddICMSSubTotalNota.Name = "chkNaoAddICMSSubTotalNota";
            this.chkNaoAddICMSSubTotalNota.Size = new System.Drawing.Size(227, 17);
            this.chkNaoAddICMSSubTotalNota.TabIndex = 11;
            this.chkNaoAddICMSSubTotalNota.Text = "Não Adiciona ICMS Sub. no Total da Nota";
            this.chkNaoAddICMSSubTotalNota.UseVisualStyleBackColor = true;
            // 
            // chkCalculaICMS
            // 
            this.chkCalculaICMS.AutoSize = true;
            this.chkCalculaICMS.Location = new System.Drawing.Point(212, 42);
            this.chkCalculaICMS.Name = "chkCalculaICMS";
            this.chkCalculaICMS.Size = new System.Drawing.Size(90, 17);
            this.chkCalculaICMS.TabIndex = 10;
            this.chkCalculaICMS.Text = "Calcula ICMS";
            this.chkCalculaICMS.UseVisualStyleBackColor = true;
            // 
            // chkBaseCalcICMScomIPI
            // 
            this.chkBaseCalcICMScomIPI.AutoSize = true;
            this.chkBaseCalcICMScomIPI.Location = new System.Drawing.Point(212, 19);
            this.chkBaseCalcICMScomIPI.Name = "chkBaseCalcICMScomIPI";
            this.chkBaseCalcICMScomIPI.Size = new System.Drawing.Size(186, 17);
            this.chkBaseCalcICMScomIPI.TabIndex = 9;
            this.chkBaseCalcICMScomIPI.Text = "Base de Cálculo do ICMS com IPI";
            this.chkBaseCalcICMScomIPI.UseVisualStyleBackColor = true;
            // 
            // chkEntrada
            // 
            this.chkEntrada.AutoSize = true;
            this.chkEntrada.Location = new System.Drawing.Point(6, 65);
            this.chkEntrada.Name = "chkEntrada";
            this.chkEntrada.Size = new System.Drawing.Size(63, 17);
            this.chkEntrada.TabIndex = 8;
            this.chkEntrada.Text = "Entrada";
            this.chkEntrada.UseVisualStyleBackColor = true;
            // 
            // chkComplementar
            // 
            this.chkComplementar.AutoSize = true;
            this.chkComplementar.Location = new System.Drawing.Point(6, 42);
            this.chkComplementar.Name = "chkComplementar";
            this.chkComplementar.Size = new System.Drawing.Size(93, 17);
            this.chkComplementar.TabIndex = 7;
            this.chkComplementar.Text = "Complementar";
            this.chkComplementar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descrição,
            this.TipoNatureza,
            this.Layout,
            this.FinalidadeEmissao});
            this.dataGridView1.Location = new System.Drawing.Point(11, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 224);
            this.dataGridView1.TabIndex = 909092;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 60;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.Width = 250;
            // 
            // TipoNatureza
            // 
            this.TipoNatureza.HeaderText = "Tipo da Natureza";
            this.TipoNatureza.Name = "TipoNatureza";
            this.TipoNatureza.Width = 180;
            // 
            // Layout
            // 
            this.Layout.HeaderText = "Layout";
            this.Layout.Name = "Layout";
            this.Layout.Width = 180;
            // 
            // FinalidadeEmissao
            // 
            this.FinalidadeEmissao.HeaderText = "Finalidade de Emissão";
            this.FinalidadeEmissao.Name = "FinalidadeEmissao";
            this.FinalidadeEmissao.Width = 180;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(223, 143);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(151, 51);
            this.btnPesquisar.TabIndex = 9000047;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(43, 162);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(159, 20);
            this.txtPesquisar.TabIndex = 9000046;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(797, 32);
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
            // FormNatOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(912, 602);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbFinalidadeEmissao);
            this.Controls.Add(this.lblFinalidadeEmissao);
            this.Controls.Add(this.cbLayout);
            this.Controls.Add(this.lblLayout);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.cbTipoNatureza);
            this.Controls.Add(this.lblTipoNatureza);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNatOperacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Natureza da Operação";
            this.Load += new System.EventHandler(this.FormNatOperacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipoNatureza;
        private System.Windows.Forms.ComboBox cbTipoNatureza;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cbLayout;
        private System.Windows.Forms.Label lblLayout;
        private System.Windows.Forms.ComboBox cbFinalidadeEmissao;
        private System.Windows.Forms.Label lblFinalidadeEmissao;
        private System.Windows.Forms.CheckBox chkDevolRetorno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkSobCFOPConfigItensNota;
        private System.Windows.Forms.CheckBox chkCalcEmpSimpNac;
        private System.Windows.Forms.CheckBox chkBaseCalcICMScomIPIConsFinal;
        private System.Windows.Forms.CheckBox chkNaoAddICMSSubTotalNota;
        private System.Windows.Forms.CheckBox chkCalculaICMS;
        private System.Windows.Forms.CheckBox chkBaseCalcICMScomIPI;
        private System.Windows.Forms.CheckBox chkEntrada;
        private System.Windows.Forms.CheckBox chkComplementar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoNatureza;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Layout;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalidadeEmissao;
        private System.Windows.Forms.Button btnCancelar;
    }
}