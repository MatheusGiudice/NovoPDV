
namespace NovoPDV
{
    partial class frmEstadoICMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadoICMS));
            this.lblUF = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.lblPorcentAliq = new System.Windows.Forms.Label();
            this.msktxtPorcentAliq = new System.Windows.Forms.MaskedTextBox();
            this.lblPorcentSubst = new System.Windows.Forms.Label();
            this.msktxtPorcentSubst = new System.Windows.Forms.MaskedTextBox();
            this.msktxtPorcentAliqDif = new System.Windows.Forms.MaskedTextBox();
            this.lblPorcentAliqDif = new System.Windows.Forms.Label();
            this.lblNomeEstado = new System.Windows.Forms.Label();
            this.txtNomeEstado = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentAliq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentSubstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentAliqDif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(124, 197);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 0;
            this.lblUF.Text = "UF";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(232, 32);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 79);
            this.btnAlterar.TabIndex = 7;
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
            this.btnSalvar.Location = new System.Drawing.Point(600, 32);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 79);
            this.btnSalvar.TabIndex = 9;
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
            this.btnExcluir.Location = new System.Drawing.Point(416, 32);
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
            this.btnNovo.Location = new System.Drawing.Point(58, 32);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 79);
            this.btnNovo.TabIndex = 6;
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
            this.cbUF.Location = new System.Drawing.Point(151, 194);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(58, 21);
            this.cbUF.TabIndex = 1;
            // 
            // lblPorcentAliq
            // 
            this.lblPorcentAliq.AutoSize = true;
            this.lblPorcentAliq.Location = new System.Drawing.Point(229, 197);
            this.lblPorcentAliq.Name = "lblPorcentAliq";
            this.lblPorcentAliq.Size = new System.Drawing.Size(58, 13);
            this.lblPorcentAliq.TabIndex = 29;
            this.lblPorcentAliq.Text = "Alíquota %";
            // 
            // msktxtPorcentAliq
            // 
            this.msktxtPorcentAliq.Location = new System.Drawing.Point(293, 194);
            this.msktxtPorcentAliq.Mask = "000,00 %";
            this.msktxtPorcentAliq.Name = "msktxtPorcentAliq";
            this.msktxtPorcentAliq.Size = new System.Drawing.Size(76, 20);
            this.msktxtPorcentAliq.TabIndex = 2;
            this.msktxtPorcentAliq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPorcentSubst
            // 
            this.lblPorcentSubst.AutoSize = true;
            this.lblPorcentSubst.Location = new System.Drawing.Point(94, 233);
            this.lblPorcentSubst.Name = "lblPorcentSubst";
            this.lblPorcentSubst.Size = new System.Drawing.Size(48, 13);
            this.lblPorcentSubst.TabIndex = 31;
            this.lblPorcentSubst.Text = "Subst. %";
            // 
            // msktxtPorcentSubst
            // 
            this.msktxtPorcentSubst.Location = new System.Drawing.Point(147, 230);
            this.msktxtPorcentSubst.Mask = "000,00 %";
            this.msktxtPorcentSubst.Name = "msktxtPorcentSubst";
            this.msktxtPorcentSubst.Size = new System.Drawing.Size(76, 20);
            this.msktxtPorcentSubst.TabIndex = 3;
            this.msktxtPorcentSubst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msktxtPorcentAliqDif
            // 
            this.msktxtPorcentAliqDif.Location = new System.Drawing.Point(293, 230);
            this.msktxtPorcentAliqDif.Mask = "000,00 %";
            this.msktxtPorcentAliqDif.Name = "msktxtPorcentAliqDif";
            this.msktxtPorcentAliqDif.Size = new System.Drawing.Size(76, 20);
            this.msktxtPorcentAliqDif.TabIndex = 4;
            this.msktxtPorcentAliqDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPorcentAliqDif
            // 
            this.lblPorcentAliqDif.AutoSize = true;
            this.lblPorcentAliqDif.Location = new System.Drawing.Point(231, 233);
            this.lblPorcentAliqDif.Name = "lblPorcentAliqDif";
            this.lblPorcentAliqDif.Size = new System.Drawing.Size(56, 13);
            this.lblPorcentAliqDif.TabIndex = 33;
            this.lblPorcentAliqDif.Text = "Alíq. Dif %";
            // 
            // lblNomeEstado
            // 
            this.lblNomeEstado.AutoSize = true;
            this.lblNomeEstado.Location = new System.Drawing.Point(108, 265);
            this.lblNomeEstado.Name = "lblNomeEstado";
            this.lblNomeEstado.Size = new System.Drawing.Size(35, 13);
            this.lblNomeEstado.TabIndex = 34;
            this.lblNomeEstado.Text = "Nome";
            // 
            // txtNomeEstado
            // 
            this.txtNomeEstado.Location = new System.Drawing.Point(149, 262);
            this.txtNomeEstado.Name = "txtNomeEstado";
            this.txtNomeEstado.Size = new System.Drawing.Size(217, 20);
            this.txtNomeEstado.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UF,
            this.NomeEstado,
            this.PorcentAliq,
            this.PorcentSubstituicao,
            this.PorcentAliqDif});
            this.dataGridView1.Location = new System.Drawing.Point(450, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 155);
            this.dataGridView1.TabIndex = 35;
            // 
            // UF
            // 
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.Width = 50;
            // 
            // NomeEstado
            // 
            this.NomeEstado.HeaderText = "Nome Estado";
            this.NomeEstado.Name = "NomeEstado";
            this.NomeEstado.Width = 150;
            // 
            // PorcentAliq
            // 
            this.PorcentAliq.HeaderText = "Alíquota %";
            this.PorcentAliq.Name = "PorcentAliq";
            // 
            // PorcentSubstituicao
            // 
            this.PorcentSubstituicao.HeaderText = "Substituição %";
            this.PorcentSubstituicao.Name = "PorcentSubstituicao";
            // 
            // PorcentAliqDif
            // 
            this.PorcentAliqDif.HeaderText = "Alíq. Diferenc. %";
            this.PorcentAliqDif.Name = "PorcentAliqDif";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 461);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 51);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(788, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 79);
            this.btnCancelar.TabIndex = 9000098;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormICMSEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(912, 524);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNomeEstado);
            this.Controls.Add(this.lblNomeEstado);
            this.Controls.Add(this.msktxtPorcentAliqDif);
            this.Controls.Add(this.lblPorcentAliqDif);
            this.Controls.Add(this.msktxtPorcentSubst);
            this.Controls.Add(this.lblPorcentSubst);
            this.Controls.Add(this.msktxtPorcentAliq);
            this.Controls.Add(this.lblPorcentAliq);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblUF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormICMSEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alíquotas de ICMS por Estado";
            this.Load += new System.EventHandler(this.FormICMSEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label lblPorcentAliq;
        private System.Windows.Forms.MaskedTextBox msktxtPorcentAliq;
        private System.Windows.Forms.Label lblPorcentSubst;
        private System.Windows.Forms.MaskedTextBox msktxtPorcentSubst;
        private System.Windows.Forms.MaskedTextBox msktxtPorcentAliqDif;
        private System.Windows.Forms.Label lblPorcentAliqDif;
        private System.Windows.Forms.Label lblNomeEstado;
        private System.Windows.Forms.TextBox txtNomeEstado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentAliq;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentSubstituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentAliqDif;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
    }
}