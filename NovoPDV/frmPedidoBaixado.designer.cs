
namespace NovoPDV
{
    partial class frmPedidoBaixado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoBaixado));
            this.btnCancelarCupomFiscal = new System.Windows.Forms.Button();
            this.btnReimpCupomFiscal = new System.Windows.Forms.Button();
            this.btnImprimirPedido = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataBaixaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeItens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkExcluidos = new System.Windows.Forms.CheckBox();
            this.chkCancelado = new System.Windows.Forms.CheckBox();
            this.chkBaixados = new System.Windows.Forms.CheckBox();
            this.btnNotaFiscal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarCupomFiscal
            // 
            this.btnCancelarCupomFiscal.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelarCupomFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelarCupomFiscal.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCupomFiscal.Image")));
            this.btnCancelarCupomFiscal.Location = new System.Drawing.Point(300, 24);
            this.btnCancelarCupomFiscal.Name = "btnCancelarCupomFiscal";
            this.btnCancelarCupomFiscal.Size = new System.Drawing.Size(102, 97);
            this.btnCancelarCupomFiscal.TabIndex = 20;
            this.btnCancelarCupomFiscal.Text = "Cancelar Cupom Fiscal";
            this.btnCancelarCupomFiscal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarCupomFiscal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelarCupomFiscal.UseVisualStyleBackColor = false;
            this.btnCancelarCupomFiscal.Click += new System.EventHandler(this.btnCancelarCupomFiscal_Click);
            // 
            // btnReimpCupomFiscal
            // 
            this.btnReimpCupomFiscal.BackColor = System.Drawing.SystemColors.Control;
            this.btnReimpCupomFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReimpCupomFiscal.Image = ((System.Drawing.Image)(resources.GetObject("btnReimpCupomFiscal.Image")));
            this.btnReimpCupomFiscal.Location = new System.Drawing.Point(97, 24);
            this.btnReimpCupomFiscal.Name = "btnReimpCupomFiscal";
            this.btnReimpCupomFiscal.Size = new System.Drawing.Size(102, 97);
            this.btnReimpCupomFiscal.TabIndex = 19;
            this.btnReimpCupomFiscal.Text = "Reimp. Cupom Fiscal";
            this.btnReimpCupomFiscal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReimpCupomFiscal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReimpCupomFiscal.UseVisualStyleBackColor = false;
            this.btnReimpCupomFiscal.Click += new System.EventHandler(this.btnReimpCupomFiscal_Click);
            // 
            // btnImprimirPedido
            // 
            this.btnImprimirPedido.BackColor = System.Drawing.SystemColors.Control;
            this.btnImprimirPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnImprimirPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirPedido.Image")));
            this.btnImprimirPedido.Location = new System.Drawing.Point(511, 24);
            this.btnImprimirPedido.Name = "btnImprimirPedido";
            this.btnImprimirPedido.Size = new System.Drawing.Size(102, 97);
            this.btnImprimirPedido.TabIndex = 9000033;
            this.btnImprimirPedido.Text = "Imprimir Pedido";
            this.btnImprimirPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimirPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimirPedido.UseVisualStyleBackColor = false;
            this.btnImprimirPedido.Click += new System.EventHandler(this.btnImprimirPedido_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumPedido,
            this.Cliente,
            this.DataPedido,
            this.DataBaixaPedido,
            this.QtdeItens,
            this.ValorPedido,
            this.Vendedor});
            this.dataGridView1.Location = new System.Drawing.Point(233, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 211);
            this.dataGridView1.TabIndex = 9000036;
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
            this.Cliente.Width = 200;
            // 
            // DataPedido
            // 
            this.DataPedido.HeaderText = "Data Pedido";
            this.DataPedido.Name = "DataPedido";
            // 
            // DataBaixaPedido
            // 
            this.DataBaixaPedido.HeaderText = "Data Baixa Pedido";
            this.DataBaixaPedido.Name = "DataBaixaPedido";
            // 
            // QtdeItens
            // 
            this.QtdeItens.HeaderText = "Qtde Itens";
            this.QtdeItens.Name = "QtdeItens";
            // 
            // ValorPedido
            // 
            this.ValorPedido.HeaderText = "Valor do Pedido";
            this.ValorPedido.Name = "ValorPedido";
            // 
            // Vendedor
            // 
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Width = 200;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(553, 147);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(176, 51);
            this.btnPesquisar.TabIndex = 9000035;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(278, 163);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(237, 20);
            this.txtPesquisar.TabIndex = 9000034;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 537);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 51);
            this.btnSair.TabIndex = 9000038;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkExcluidos);
            this.groupBox1.Controls.Add(this.chkCancelado);
            this.groupBox1.Controls.Add(this.chkBaixados);
            this.groupBox1.Location = new System.Drawing.Point(87, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 91);
            this.groupBox1.TabIndex = 9000040;
            this.groupBox1.TabStop = false;
            // 
            // chkExcluidos
            // 
            this.chkExcluidos.AutoSize = true;
            this.chkExcluidos.Location = new System.Drawing.Point(17, 64);
            this.chkExcluidos.Name = "chkExcluidos";
            this.chkExcluidos.Size = new System.Drawing.Size(73, 17);
            this.chkExcluidos.TabIndex = 2;
            this.chkExcluidos.Text = "Excluídos";
            this.chkExcluidos.UseVisualStyleBackColor = true;
            // 
            // chkCancelado
            // 
            this.chkCancelado.AutoSize = true;
            this.chkCancelado.Location = new System.Drawing.Point(17, 41);
            this.chkCancelado.Name = "chkCancelado";
            this.chkCancelado.Size = new System.Drawing.Size(82, 17);
            this.chkCancelado.TabIndex = 1;
            this.chkCancelado.Text = "Cancelados";
            this.chkCancelado.UseVisualStyleBackColor = true;
            // 
            // chkBaixados
            // 
            this.chkBaixados.AutoSize = true;
            this.chkBaixados.Location = new System.Drawing.Point(17, 18);
            this.chkBaixados.Name = "chkBaixados";
            this.chkBaixados.Size = new System.Drawing.Size(69, 17);
            this.chkBaixados.TabIndex = 0;
            this.chkBaixados.Text = "Baixados";
            this.chkBaixados.UseVisualStyleBackColor = true;
            // 
            // btnNotaFiscal
            // 
            this.btnNotaFiscal.BackColor = System.Drawing.SystemColors.Control;
            this.btnNotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNotaFiscal.Image = ((System.Drawing.Image)(resources.GetObject("btnNotaFiscal.Image")));
            this.btnNotaFiscal.Location = new System.Drawing.Point(731, 24);
            this.btnNotaFiscal.Name = "btnNotaFiscal";
            this.btnNotaFiscal.Size = new System.Drawing.Size(102, 97);
            this.btnNotaFiscal.TabIndex = 9000041;
            this.btnNotaFiscal.Text = "Nota Fiscal";
            this.btnNotaFiscal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNotaFiscal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNotaFiscal.UseVisualStyleBackColor = false;
            this.btnNotaFiscal.Click += new System.EventHandler(this.btnNotaFiscal_Click);
            // 
            // FormPedidoBaixado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(928, 600);
            this.Controls.Add(this.btnNotaFiscal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimirPedido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnCancelarCupomFiscal);
            this.Controls.Add(this.btnReimpCupomFiscal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPedidoBaixado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos Baixados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarCupomFiscal;
        private System.Windows.Forms.Button btnReimpCupomFiscal;
        private System.Windows.Forms.Button btnImprimirPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkExcluidos;
        private System.Windows.Forms.CheckBox chkCancelado;
        private System.Windows.Forms.CheckBox chkBaixados;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataBaixaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.Button btnNotaFiscal;
    }
}