
namespace NovoPDV
{
    partial class frmInutilizacaoFaixaNF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInutilizacaoFaixaNF));
            this.btnInutilizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMotivoInutilizacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFim = new System.Windows.Forms.TextBox();
            this.lblFim = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Série = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Início = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Justificativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caminho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInutilizar
            // 
            this.btnInutilizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnInutilizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInutilizar.Image = ((System.Drawing.Image)(resources.GetObject("btnInutilizar.Image")));
            this.btnInutilizar.Location = new System.Drawing.Point(183, 12);
            this.btnInutilizar.Name = "btnInutilizar";
            this.btnInutilizar.Size = new System.Drawing.Size(85, 79);
            this.btnInutilizar.TabIndex = 21;
            this.btnInutilizar.Text = "Inutilizar";
            this.btnInutilizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInutilizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInutilizar.UseVisualStyleBackColor = false;
            this.btnInutilizar.Click += new System.EventHandler(this.btnInutilizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(563, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 79);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotivoInutilizacao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFim);
            this.groupBox1.Controls.Add(this.lblFim);
            this.groupBox1.Controls.Add(this.txtInicio);
            this.groupBox1.Controls.Add(this.lblInicio);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.lblSerie);
            this.groupBox1.Location = new System.Drawing.Point(134, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 64);
            this.groupBox1.TabIndex = 9000030;
            this.groupBox1.TabStop = false;
            // 
            // txtMotivoInutilizacao
            // 
            this.txtMotivoInutilizacao.Location = new System.Drawing.Point(375, 38);
            this.txtMotivoInutilizacao.Name = "txtMotivoInutilizacao";
            this.txtMotivoInutilizacao.Size = new System.Drawing.Size(190, 20);
            this.txtMotivoInutilizacao.TabIndex = 9005;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 9004;
            this.label1.Text = "Motivo (no mínimo 15 dígitos):";
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(255, 38);
            this.txtFim.Name = "txtFim";
            this.txtFim.Size = new System.Drawing.Size(93, 20);
            this.txtFim.TabIndex = 3;
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Location = new System.Drawing.Point(287, 15);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(26, 13);
            this.lblFim.TabIndex = 9003;
            this.lblFim.Text = "Fim:";
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(130, 38);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(93, 20);
            this.txtInicio.TabIndex = 2;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(158, 15);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(37, 13);
            this.lblInicio.TabIndex = 9001;
            this.lblInicio.Text = "Início:";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(6, 38);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(93, 20);
            this.txtSerie.TabIndex = 1;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(34, 15);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(34, 13);
            this.lblSerie.TabIndex = 9000;
            this.lblSerie.Text = "Série:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(134, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 74);
            this.groupBox2.TabIndex = 9000031;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(555, 51);
            this.textBox1.TabIndex = 9004;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Série,
            this.Início,
            this.Fim,
            this.Data,
            this.Justificativa,
            this.Caminho});
            this.dataGridView1.Location = new System.Drawing.Point(134, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 150);
            this.dataGridView1.TabIndex = 9000032;
            // 
            // Série
            // 
            this.Série.HeaderText = "Série";
            this.Série.Name = "Série";
            this.Série.Width = 70;
            // 
            // Início
            // 
            this.Início.HeaderText = "Início";
            this.Início.Name = "Início";
            this.Início.Width = 80;
            // 
            // Fim
            // 
            this.Fim.HeaderText = "Fim";
            this.Fim.Name = "Fim";
            this.Fim.Width = 80;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 80;
            // 
            // Justificativa
            // 
            this.Justificativa.HeaderText = "Justificativa";
            this.Justificativa.Name = "Justificativa";
            this.Justificativa.Width = 170;
            // 
            // Caminho
            // 
            this.Caminho.HeaderText = "Caminho";
            this.Caminho.Name = "Caminho";
            this.Caminho.Width = 200;
            // 
            // frmInutilizacaoFaixaNF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(832, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInutilizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInutilizacaoFaixaNF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inutilização de Faixa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInutilizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFim;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Série;
        private System.Windows.Forms.DataGridViewTextBoxColumn Início;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Justificativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caminho;
        private System.Windows.Forms.TextBox txtMotivoInutilizacao;
        private System.Windows.Forms.Label label1;
    }
}