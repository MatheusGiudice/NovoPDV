
namespace NovoPDV
{
    partial class frmNCM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNCM));
            this.txtNCM = new System.Windows.Forms.TextBox();
            this.lblNCM = new System.Windows.Forms.Label();
            this.msktxtPorcentCombPobreza = new System.Windows.Forms.MaskedTextBox();
            this.lblPorcentAliqDif = new System.Windows.Forms.Label();
            this.msktxtPorcentIPI = new System.Windows.Forms.MaskedTextBox();
            this.lblPorcentIPI = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNaturezaReceita = new System.Windows.Forms.TextBox();
            this.lblNaturezaReceita = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaturezaReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentCombPobreza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNCM
            // 
            this.txtNCM.Location = new System.Drawing.Point(57, 55);
            this.txtNCM.Name = "txtNCM";
            this.txtNCM.Size = new System.Drawing.Size(122, 20);
            this.txtNCM.TabIndex = 3;
            // 
            // lblNCM
            // 
            this.lblNCM.AutoSize = true;
            this.lblNCM.Location = new System.Drawing.Point(16, 58);
            this.lblNCM.Name = "lblNCM";
            this.lblNCM.Size = new System.Drawing.Size(31, 13);
            this.lblNCM.TabIndex = 44;
            this.lblNCM.Text = "NCM";
            // 
            // msktxtPorcentCombPobreza
            // 
            this.msktxtPorcentCombPobreza.Location = new System.Drawing.Point(132, 90);
            this.msktxtPorcentCombPobreza.Mask = "000,00 %";
            this.msktxtPorcentCombPobreza.Name = "msktxtPorcentCombPobreza";
            this.msktxtPorcentCombPobreza.Size = new System.Drawing.Size(58, 20);
            this.msktxtPorcentCombPobreza.TabIndex = 5;
            this.msktxtPorcentCombPobreza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPorcentAliqDif
            // 
            this.lblPorcentAliqDif.AutoSize = true;
            this.lblPorcentAliqDif.Location = new System.Drawing.Point(16, 93);
            this.lblPorcentAliqDif.Name = "lblPorcentAliqDif";
            this.lblPorcentAliqDif.Size = new System.Drawing.Size(111, 13);
            this.lblPorcentAliqDif.TabIndex = 43;
            this.lblPorcentAliqDif.Text = "Combate à Pobreza %";
            // 
            // msktxtPorcentIPI
            // 
            this.msktxtPorcentIPI.Location = new System.Drawing.Point(301, 55);
            this.msktxtPorcentIPI.Mask = "000,00 %";
            this.msktxtPorcentIPI.Name = "msktxtPorcentIPI";
            this.msktxtPorcentIPI.Size = new System.Drawing.Size(58, 20);
            this.msktxtPorcentIPI.TabIndex = 4;
            this.msktxtPorcentIPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPorcentIPI
            // 
            this.lblPorcentIPI.AutoSize = true;
            this.lblPorcentIPI.Location = new System.Drawing.Point(255, 58);
            this.lblPorcentIPI.Name = "lblPorcentIPI";
            this.lblPorcentIPI.Size = new System.Drawing.Size(31, 13);
            this.lblPorcentIPI.TabIndex = 42;
            this.lblPorcentIPI.Text = "IPI %";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 35;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(62, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(58, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNaturezaReceita
            // 
            this.txtNaturezaReceita.Location = new System.Drawing.Point(237, 22);
            this.txtNaturezaReceita.Name = "txtNaturezaReceita";
            this.txtNaturezaReceita.Size = new System.Drawing.Size(122, 20);
            this.txtNaturezaReceita.TabIndex = 2;
            // 
            // lblNaturezaReceita
            // 
            this.lblNaturezaReceita.AutoSize = true;
            this.lblNaturezaReceita.Location = new System.Drawing.Point(129, 25);
            this.lblNaturezaReceita.Name = "lblNaturezaReceita";
            this.lblNaturezaReceita.Size = new System.Drawing.Size(105, 13);
            this.lblNaturezaReceita.TabIndex = 46;
            this.lblNaturezaReceita.Text = "Natureza da Receita";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NCM,
            this.PorcentIPI,
            this.NaturezaReceita,
            this.Mensagem,
            this.PorcentCombPobreza});
            this.dataGridView1.Location = new System.Drawing.Point(22, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 192);
            this.dataGridView1.TabIndex = 47;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 60;
            // 
            // NCM
            // 
            this.NCM.HeaderText = "NCM";
            this.NCM.Name = "NCM";
            this.NCM.Width = 130;
            // 
            // PorcentIPI
            // 
            this.PorcentIPI.HeaderText = "IPI %";
            this.PorcentIPI.Name = "PorcentIPI";
            this.PorcentIPI.Width = 60;
            // 
            // NaturezaReceita
            // 
            this.NaturezaReceita.HeaderText = "Natureza da Receita";
            this.NaturezaReceita.Name = "NaturezaReceita";
            this.NaturezaReceita.Width = 140;
            // 
            // Mensagem
            // 
            this.Mensagem.HeaderText = "Mensagem";
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Width = 200;
            // 
            // PorcentCombPobreza
            // 
            this.PorcentCombPobreza.HeaderText = "Combate à Pobreza %";
            this.PorcentCombPobreza.Name = "PorcentCombPobreza";
            this.PorcentCombPobreza.Width = 60;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 489);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 51);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(270, 32);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 79);
            this.btnAlterar.TabIndex = 9;
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
            this.btnSalvar.Location = new System.Drawing.Point(635, 32);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 79);
            this.btnSalvar.TabIndex = 7;
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
            this.btnExcluir.Location = new System.Drawing.Point(454, 32);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 79);
            this.btnExcluir.TabIndex = 8;
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
            this.btnNovo.Location = new System.Drawing.Point(86, 32);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 79);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(256, 155);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(176, 51);
            this.btnPesquisar.TabIndex = 9000047;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(49, 171);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(201, 20);
            this.txtPesquisar.TabIndex = 9000046;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMensagem);
            this.groupBox1.Controls.Add(this.lblMensagem);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblPorcentIPI);
            this.groupBox1.Controls.Add(this.msktxtPorcentIPI);
            this.groupBox1.Controls.Add(this.lblPorcentAliqDif);
            this.groupBox1.Controls.Add(this.msktxtPorcentCombPobreza);
            this.groupBox1.Controls.Add(this.lblNCM);
            this.groupBox1.Controls.Add(this.txtNaturezaReceita);
            this.groupBox1.Controls.Add(this.txtNCM);
            this.groupBox1.Controls.Add(this.lblNaturezaReceita);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(503, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 155);
            this.groupBox1.TabIndex = 9000048;
            this.groupBox1.TabStop = false;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(81, 123);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(278, 20);
            this.txtMensagem.TabIndex = 6;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(16, 126);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(59, 13);
            this.lblMensagem.TabIndex = 47;
            this.lblMensagem.Text = "Mensagem";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(804, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 79);
            this.btnCancelar.TabIndex = 9000101;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormNCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(912, 552);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(124, 167);
            this.Name = "FormNCM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCM";
            this.Load += new System.EventHandler(this.FormNCM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtNCM;
        private System.Windows.Forms.Label lblNCM;
        private System.Windows.Forms.MaskedTextBox msktxtPorcentCombPobreza;
        private System.Windows.Forms.Label lblPorcentAliqDif;
        private System.Windows.Forms.MaskedTextBox msktxtPorcentIPI;
        private System.Windows.Forms.Label lblPorcentIPI;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNaturezaReceita;
        private System.Windows.Forms.Label lblNaturezaReceita;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentIPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaturezaReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentCombPobreza;
        private System.Windows.Forms.Button btnCancelar;
    }
}