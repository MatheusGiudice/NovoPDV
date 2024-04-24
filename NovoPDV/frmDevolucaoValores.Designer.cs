
namespace NovoPDV
{
    partial class frmDevolucaoValores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucaoValores));
            this.lblData = new System.Windows.Forms.Label();
            this.lblFormaPgto = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbFormaPgto = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Devolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBaixarPedido = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(17, 26);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 984651;
            this.lblData.Text = "Data";
            // 
            // lblFormaPgto
            // 
            this.lblFormaPgto.AutoSize = true;
            this.lblFormaPgto.Location = new System.Drawing.Point(293, 26);
            this.lblFormaPgto.Name = "lblFormaPgto";
            this.lblFormaPgto.Size = new System.Drawing.Size(108, 13);
            this.lblFormaPgto.TabIndex = 984652;
            this.lblFormaPgto.Text = "Forma de Pagamento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 984653;
            // 
            // cbFormaPgto
            // 
            this.cbFormaPgto.FormattingEnabled = true;
            this.cbFormaPgto.Location = new System.Drawing.Point(407, 23);
            this.cbFormaPgto.Name = "cbFormaPgto";
            this.cbFormaPgto.Size = new System.Drawing.Size(136, 21);
            this.cbFormaPgto.TabIndex = 984654;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Devolucao,
            this.Data,
            this.Cliente,
            this.Valor});
            this.dataGridView1.Location = new System.Drawing.Point(20, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 150);
            this.dataGridView1.TabIndex = 984655;
            // 
            // Devolucao
            // 
            this.Devolucao.HeaderText = "Devolução";
            this.Devolucao.Name = "Devolucao";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 180;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFormaPgto);
            this.groupBox1.Controls.Add(this.lblFormaPgto);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Location = new System.Drawing.Point(48, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 61);
            this.groupBox1.TabIndex = 984656;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(48, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 186);
            this.groupBox2.TabIndex = 984657;
            this.groupBox2.TabStop = false;
            // 
            // btnBaixarPedido
            // 
            this.btnBaixarPedido.BackColor = System.Drawing.SystemColors.Control;
            this.btnBaixarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBaixarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnBaixarPedido.Image")));
            this.btnBaixarPedido.Location = new System.Drawing.Point(116, 12);
            this.btnBaixarPedido.Name = "btnBaixarPedido";
            this.btnBaixarPedido.Size = new System.Drawing.Size(85, 79);
            this.btnBaixarPedido.TabIndex = 984656;
            this.btnBaixarPedido.Text = "Baixar";
            this.btnBaixarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaixarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBaixarPedido.UseVisualStyleBackColor = false;
            this.btnBaixarPedido.Click += new System.EventHandler(this.btnBaixarPedido_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(483, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 79);
            this.btnSair.TabIndex = 984658;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmDevolucaoValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(653, 403);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnBaixarPedido);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDevolucaoValores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolução de Valores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblFormaPgto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbFormaPgto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBaixarPedido;
        private System.Windows.Forms.Button btnSair;
    }
}