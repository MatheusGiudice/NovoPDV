
namespace NovoPDV
{
    partial class frmPosicaoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosicaoCaixa));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorFechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsolidado = new System.Windows.Forms.Button();
            this.btnSintetico = new System.Windows.Forms.Button();
            this.btnAnalítico = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataAbertura,
            this.HoraAbertura,
            this.ValorAbertura,
            this.DataFechamento,
            this.HoraFechamento,
            this.ValorFechamento,
            this.Usuario,
            this.Caixa});
            this.dataGridView1.Location = new System.Drawing.Point(79, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 309);
            this.dataGridView1.TabIndex = 9000044;
            // 
            // DataAbertura
            // 
            this.DataAbertura.HeaderText = "Aberto Em";
            this.DataAbertura.Name = "DataAbertura";
            // 
            // HoraAbertura
            // 
            this.HoraAbertura.HeaderText = "Horário Abertura";
            this.HoraAbertura.Name = "HoraAbertura";
            // 
            // ValorAbertura
            // 
            this.ValorAbertura.HeaderText = "Valor Abertura";
            this.ValorAbertura.Name = "ValorAbertura";
            // 
            // DataFechamento
            // 
            this.DataFechamento.HeaderText = "Fechado Em";
            this.DataFechamento.Name = "DataFechamento";
            // 
            // HoraFechamento
            // 
            this.HoraFechamento.HeaderText = "Horário Fechamento";
            this.HoraFechamento.Name = "HoraFechamento";
            // 
            // ValorFechamento
            // 
            this.ValorFechamento.HeaderText = "Valor Fechamento";
            this.ValorFechamento.Name = "ValorFechamento";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.Name = "Usuario";
            // 
            // Caixa
            // 
            this.Caixa.HeaderText = "Caixa";
            this.Caixa.Name = "Caixa";
            // 
            // btnConsolidado
            // 
            this.btnConsolidado.Image = ((System.Drawing.Image)(resources.GetObject("btnConsolidado.Image")));
            this.btnConsolidado.Location = new System.Drawing.Point(703, 51);
            this.btnConsolidado.Name = "btnConsolidado";
            this.btnConsolidado.Size = new System.Drawing.Size(85, 79);
            this.btnConsolidado.TabIndex = 3;
            this.btnConsolidado.Text = "Consolidado";
            this.btnConsolidado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsolidado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsolidado.UseVisualStyleBackColor = true;
            this.btnConsolidado.Click += new System.EventHandler(this.btnConsolidado_Click);
            // 
            // btnSintetico
            // 
            this.btnSintetico.Image = ((System.Drawing.Image)(resources.GetObject("btnSintetico.Image")));
            this.btnSintetico.Location = new System.Drawing.Point(451, 51);
            this.btnSintetico.Name = "btnSintetico";
            this.btnSintetico.Size = new System.Drawing.Size(85, 79);
            this.btnSintetico.TabIndex = 2;
            this.btnSintetico.Text = "Sintético";
            this.btnSintetico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSintetico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSintetico.UseVisualStyleBackColor = true;
            this.btnSintetico.Click += new System.EventHandler(this.btnSintetico_Click);
            // 
            // btnAnalítico
            // 
            this.btnAnalítico.Image = ((System.Drawing.Image)(resources.GetObject("btnAnalítico.Image")));
            this.btnAnalítico.Location = new System.Drawing.Point(200, 51);
            this.btnAnalítico.Name = "btnAnalítico";
            this.btnAnalítico.Size = new System.Drawing.Size(85, 79);
            this.btnAnalítico.TabIndex = 1;
            this.btnAnalítico.Text = "Analítico";
            this.btnAnalítico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnalítico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnalítico.UseVisualStyleBackColor = true;
            this.btnAnalítico.Click += new System.EventHandler(this.btnAnalítico_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 575);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 51);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPosicaoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1003, 638);
            this.Controls.Add(this.btnConsolidado);
            this.Controls.Add(this.btnSintetico);
            this.Controls.Add(this.btnAnalítico);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPosicaoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posição de Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorFechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caixa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAnalítico;
        private System.Windows.Forms.Button btnSintetico;
        private System.Windows.Forms.Button btnConsolidado;
    }
}