
namespace NovoPDV
{
    partial class frmICMSSubstituicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmICMSSubstituicao));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.cbRegraICMSSubstituicao = new System.Windows.Forms.ComboBox();
            this.lblRegra = new System.Windows.Forms.Label();
            this.lblIVAST = new System.Windows.Forms.Label();
            this.msktxtIVAST = new System.Windows.Forms.MaskedTextBox();
            this.txtCSTSubstituicao = new System.Windows.Forms.TextBox();
            this.lblCSTSubstituicao = new System.Windows.Forms.Label();
            this.msktxtICMSInterDestino = new System.Windows.Forms.MaskedTextBox();
            this.lblICMSInternoDestino = new System.Windows.Forms.Label();
            this.msktxtICMSInterestadual = new System.Windows.Forms.MaskedTextBox();
            this.lblICMSInterestadual = new System.Windows.Forms.Label();
            this.gbICMSSubstituicao = new System.Windows.Forms.GroupBox();
            this.lblFCPDestino = new System.Windows.Forms.Label();
            this.msktxtFCPDestino = new System.Windows.Forms.MaskedTextBox();
            this.msktxtFCPOrigem = new System.Windows.Forms.MaskedTextBox();
            this.lblFCPOrigem = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentICMSDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentICMSInter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FCPOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FCPDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbICMSSubstituicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(302, 41);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 79);
            this.btnAlterar.TabIndex = 18;
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
            this.btnSalvar.Location = new System.Drawing.Point(701, 41);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 79);
            this.btnSalvar.TabIndex = 20;
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
            this.btnExcluir.Location = new System.Drawing.Point(499, 41);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 79);
            this.btnExcluir.TabIndex = 19;
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
            this.btnNovo.Location = new System.Drawing.Point(106, 41);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 79);
            this.btnNovo.TabIndex = 17;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cbUF
            // 
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(60, 19);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(58, 21);
            this.cbUF.TabIndex = 1;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUF.Location = new System.Drawing.Point(28, 20);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(26, 17);
            this.lblUF.TabIndex = 900011;
            this.lblUF.Text = "UF";
            // 
            // cbRegraICMSSubstituicao
            // 
            this.cbRegraICMSSubstituicao.FormattingEnabled = true;
            this.cbRegraICMSSubstituicao.Items.AddRange(new object[] {
            "CFOP Nota",
            "Substituto",
            "Substituído"});
            this.cbRegraICMSSubstituicao.Location = new System.Drawing.Point(274, 19);
            this.cbRegraICMSSubstituicao.Name = "cbRegraICMSSubstituicao";
            this.cbRegraICMSSubstituicao.Size = new System.Drawing.Size(91, 21);
            this.cbRegraICMSSubstituicao.TabIndex = 2;
            // 
            // lblRegra
            // 
            this.lblRegra.AutoSize = true;
            this.lblRegra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRegra.Location = new System.Drawing.Point(221, 20);
            this.lblRegra.Name = "lblRegra";
            this.lblRegra.Size = new System.Drawing.Size(47, 17);
            this.lblRegra.TabIndex = 900013;
            this.lblRegra.Text = "Regra";
            // 
            // lblIVAST
            // 
            this.lblIVAST.AutoSize = true;
            this.lblIVAST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIVAST.Location = new System.Drawing.Point(28, 59);
            this.lblIVAST.Name = "lblIVAST";
            this.lblIVAST.Size = new System.Drawing.Size(52, 17);
            this.lblIVAST.TabIndex = 900014;
            this.lblIVAST.Text = "IVA-ST";
            // 
            // msktxtIVAST
            // 
            this.msktxtIVAST.Location = new System.Drawing.Point(86, 58);
            this.msktxtIVAST.Mask = "000,00 %";
            this.msktxtIVAST.Name = "msktxtIVAST";
            this.msktxtIVAST.Size = new System.Drawing.Size(67, 20);
            this.msktxtIVAST.TabIndex = 3;
            this.msktxtIVAST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCSTSubstituicao
            // 
            this.txtCSTSubstituicao.Location = new System.Drawing.Point(319, 58);
            this.txtCSTSubstituicao.Name = "txtCSTSubstituicao";
            this.txtCSTSubstituicao.Size = new System.Drawing.Size(46, 20);
            this.txtCSTSubstituicao.TabIndex = 4;
            // 
            // lblCSTSubstituicao
            // 
            this.lblCSTSubstituicao.AutoSize = true;
            this.lblCSTSubstituicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCSTSubstituicao.Location = new System.Drawing.Point(278, 59);
            this.lblCSTSubstituicao.Name = "lblCSTSubstituicao";
            this.lblCSTSubstituicao.Size = new System.Drawing.Size(35, 17);
            this.lblCSTSubstituicao.TabIndex = 900015;
            this.lblCSTSubstituicao.Text = "CST";
            // 
            // msktxtICMSInterDestino
            // 
            this.msktxtICMSInterDestino.Location = new System.Drawing.Point(119, 95);
            this.msktxtICMSInterDestino.Mask = "000,00 %";
            this.msktxtICMSInterDestino.Name = "msktxtICMSInterDestino";
            this.msktxtICMSInterDestino.Size = new System.Drawing.Size(67, 20);
            this.msktxtICMSInterDestino.TabIndex = 5;
            this.msktxtICMSInterDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblICMSInternoDestino
            // 
            this.lblICMSInternoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblICMSInternoDestino.Location = new System.Drawing.Point(28, 87);
            this.lblICMSInternoDestino.Name = "lblICMSInternoDestino";
            this.lblICMSInternoDestino.Size = new System.Drawing.Size(93, 35);
            this.lblICMSInternoDestino.TabIndex = 900017;
            this.lblICMSInternoDestino.Text = "ICMS Interno Destino";
            // 
            // msktxtICMSInterestadual
            // 
            this.msktxtICMSInterestadual.Location = new System.Drawing.Point(119, 137);
            this.msktxtICMSInterestadual.Mask = "000,00 %";
            this.msktxtICMSInterestadual.Name = "msktxtICMSInterestadual";
            this.msktxtICMSInterestadual.Size = new System.Drawing.Size(67, 20);
            this.msktxtICMSInterestadual.TabIndex = 6;
            this.msktxtICMSInterestadual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblICMSInterestadual
            // 
            this.lblICMSInterestadual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblICMSInterestadual.Location = new System.Drawing.Point(28, 127);
            this.lblICMSInterestadual.Name = "lblICMSInterestadual";
            this.lblICMSInterestadual.Size = new System.Drawing.Size(90, 36);
            this.lblICMSInterestadual.TabIndex = 900019;
            this.lblICMSInterestadual.Text = "ICMS Interstadual";
            // 
            // gbICMSSubstituicao
            // 
            this.gbICMSSubstituicao.Controls.Add(this.lblFCPDestino);
            this.gbICMSSubstituicao.Controls.Add(this.msktxtFCPDestino);
            this.gbICMSSubstituicao.Controls.Add(this.msktxtIVAST);
            this.gbICMSSubstituicao.Controls.Add(this.txtCSTSubstituicao);
            this.gbICMSSubstituicao.Controls.Add(this.lblCSTSubstituicao);
            this.gbICMSSubstituicao.Controls.Add(this.msktxtFCPOrigem);
            this.gbICMSSubstituicao.Controls.Add(this.cbUF);
            this.gbICMSSubstituicao.Controls.Add(this.lblFCPOrigem);
            this.gbICMSSubstituicao.Controls.Add(this.lblIVAST);
            this.gbICMSSubstituicao.Controls.Add(this.lblUF);
            this.gbICMSSubstituicao.Controls.Add(this.msktxtICMSInterestadual);
            this.gbICMSSubstituicao.Controls.Add(this.cbRegraICMSSubstituicao);
            this.gbICMSSubstituicao.Controls.Add(this.lblICMSInterestadual);
            this.gbICMSSubstituicao.Controls.Add(this.lblRegra);
            this.gbICMSSubstituicao.Controls.Add(this.msktxtICMSInterDestino);
            this.gbICMSSubstituicao.Controls.Add(this.lblICMSInternoDestino);
            this.gbICMSSubstituicao.Location = new System.Drawing.Point(572, 225);
            this.gbICMSSubstituicao.Name = "gbICMSSubstituicao";
            this.gbICMSSubstituicao.Size = new System.Drawing.Size(397, 178);
            this.gbICMSSubstituicao.TabIndex = 900020;
            this.gbICMSSubstituicao.TabStop = false;
            // 
            // lblFCPDestino
            // 
            this.lblFCPDestino.AutoSize = true;
            this.lblFCPDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFCPDestino.Location = new System.Drawing.Point(206, 138);
            this.lblFCPDestino.Name = "lblFCPDestino";
            this.lblFCPDestino.Size = new System.Drawing.Size(86, 17);
            this.lblFCPDestino.TabIndex = 900025;
            this.lblFCPDestino.Text = "FCP Destino";
            // 
            // msktxtFCPDestino
            // 
            this.msktxtFCPDestino.Location = new System.Drawing.Point(298, 137);
            this.msktxtFCPDestino.Mask = "000,00 %";
            this.msktxtFCPDestino.Name = "msktxtFCPDestino";
            this.msktxtFCPDestino.Size = new System.Drawing.Size(67, 20);
            this.msktxtFCPDestino.TabIndex = 8;
            this.msktxtFCPDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msktxtFCPOrigem
            // 
            this.msktxtFCPOrigem.Location = new System.Drawing.Point(298, 95);
            this.msktxtFCPOrigem.Mask = "000,00 %";
            this.msktxtFCPOrigem.Name = "msktxtFCPOrigem";
            this.msktxtFCPOrigem.Size = new System.Drawing.Size(67, 20);
            this.msktxtFCPOrigem.TabIndex = 7;
            this.msktxtFCPOrigem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFCPOrigem
            // 
            this.lblFCPOrigem.AutoSize = true;
            this.lblFCPOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFCPOrigem.Location = new System.Drawing.Point(210, 96);
            this.lblFCPOrigem.Name = "lblFCPOrigem";
            this.lblFCPOrigem.Size = new System.Drawing.Size(84, 17);
            this.lblFCPOrigem.TabIndex = 900023;
            this.lblFCPOrigem.Text = "FCP Origem";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 551);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 51);
            this.btnSair.TabIndex = 9000023;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UF,
            this.IVA,
            this.PorcentICMSDestino,
            this.PorcentICMSInter,
            this.CST,
            this.Regra,
            this.FCPOrigem,
            this.FCPDestino});
            this.dataGridView1.Location = new System.Drawing.Point(26, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 239);
            this.dataGridView1.TabIndex = 9000025;
            // 
            // UF
            // 
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.Width = 60;
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.Width = 80;
            // 
            // PorcentICMSDestino
            // 
            this.PorcentICMSDestino.HeaderText = "% ICMS Destino";
            this.PorcentICMSDestino.Name = "PorcentICMSDestino";
            this.PorcentICMSDestino.Width = 80;
            // 
            // PorcentICMSInter
            // 
            this.PorcentICMSInter.HeaderText = "% ICMS Inter";
            this.PorcentICMSInter.Name = "PorcentICMSInter";
            this.PorcentICMSInter.Width = 80;
            // 
            // CST
            // 
            this.CST.HeaderText = "CST";
            this.CST.Name = "CST";
            this.CST.Width = 80;
            // 
            // Regra
            // 
            this.Regra.HeaderText = "Regra";
            this.Regra.Name = "Regra";
            // 
            // FCPOrigem
            // 
            this.FCPOrigem.HeaderText = "FCP Origem";
            this.FCPOrigem.Name = "FCPOrigem";
            this.FCPOrigem.Width = 80;
            // 
            // FCPDestino
            // 
            this.FCPDestino.HeaderText = "FCP Destino";
            this.FCPDestino.Name = "FCPDestino";
            this.FCPDestino.Width = 80;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(884, 41);
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
            // FormICMSSubstituicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(981, 614);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gbICMSSubstituicao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormICMSSubstituicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICMS de Substituição";
            this.Load += new System.EventHandler(this.FormICMSSubstituicao_Load);
            this.gbICMSSubstituicao.ResumeLayout(false);
            this.gbICMSSubstituicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.ComboBox cbRegraICMSSubstituicao;
        private System.Windows.Forms.Label lblRegra;
        private System.Windows.Forms.Label lblIVAST;
        private System.Windows.Forms.MaskedTextBox msktxtIVAST;
        private System.Windows.Forms.TextBox txtCSTSubstituicao;
        private System.Windows.Forms.Label lblCSTSubstituicao;
        private System.Windows.Forms.MaskedTextBox msktxtICMSInterDestino;
        private System.Windows.Forms.Label lblICMSInternoDestino;
        private System.Windows.Forms.MaskedTextBox msktxtICMSInterestadual;
        private System.Windows.Forms.Label lblICMSInterestadual;
        private System.Windows.Forms.GroupBox gbICMSSubstituicao;
        private System.Windows.Forms.Label lblFCPDestino;
        private System.Windows.Forms.Label lblFCPOrigem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox msktxtFCPDestino;
        private System.Windows.Forms.MaskedTextBox msktxtFCPOrigem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentICMSDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentICMSInter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CST;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regra;
        private System.Windows.Forms.DataGridViewTextBoxColumn FCPOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FCPDestino;
        private System.Windows.Forms.Button btnCancelar;
    }
}