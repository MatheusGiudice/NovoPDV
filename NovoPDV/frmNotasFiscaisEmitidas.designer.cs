
namespace NovoPDV
{
    partial class frmNotasFiscaisEmitidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotasFiscaisEmitidas));
            this.gbTipoFiltro = new System.Windows.Forms.GroupBox();
            this.txtFiltroNumPedido = new System.Windows.Forms.TextBox();
            this.txtFiltroNumNota = new System.Windows.Forms.TextBox();
            this.txtFiltroCliente = new System.Windows.Forms.TextBox();
            this.lblFiltroAte = new System.Windows.Forms.Label();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.rbFiltroNumPedido = new System.Windows.Forms.RadioButton();
            this.rbFiltroNumNota = new System.Windows.Forms.RadioButton();
            this.rbFiltroCliente = new System.Windows.Forms.RadioButton();
            this.rbFiltroPeriodo = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataEmissão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCartaCorrecao = new System.Windows.Forms.Button();
            this.btnCancelarNF = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pd1 = new System.Drawing.Printing.PrintDocument();
            this.gbTipoFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTipoFiltro
            // 
            this.gbTipoFiltro.Controls.Add(this.txtFiltroNumPedido);
            this.gbTipoFiltro.Controls.Add(this.txtFiltroNumNota);
            this.gbTipoFiltro.Controls.Add(this.txtFiltroCliente);
            this.gbTipoFiltro.Controls.Add(this.lblFiltroAte);
            this.gbTipoFiltro.Controls.Add(this.dtFinal);
            this.gbTipoFiltro.Controls.Add(this.dtInicio);
            this.gbTipoFiltro.Controls.Add(this.rbFiltroNumPedido);
            this.gbTipoFiltro.Controls.Add(this.rbFiltroNumNota);
            this.gbTipoFiltro.Controls.Add(this.rbFiltroCliente);
            this.gbTipoFiltro.Controls.Add(this.rbFiltroPeriodo);
            this.gbTipoFiltro.Location = new System.Drawing.Point(560, 121);
            this.gbTipoFiltro.Name = "gbTipoFiltro";
            this.gbTipoFiltro.Size = new System.Drawing.Size(349, 174);
            this.gbTipoFiltro.TabIndex = 984984;
            this.gbTipoFiltro.TabStop = false;
            this.gbTipoFiltro.Text = "Filtro";
            // 
            // txtFiltroNumPedido
            // 
            this.txtFiltroNumPedido.Location = new System.Drawing.Point(96, 123);
            this.txtFiltroNumPedido.Name = "txtFiltroNumPedido";
            this.txtFiltroNumPedido.Size = new System.Drawing.Size(220, 20);
            this.txtFiltroNumPedido.TabIndex = 9;
            // 
            // txtFiltroNumNota
            // 
            this.txtFiltroNumNota.Location = new System.Drawing.Point(96, 92);
            this.txtFiltroNumNota.Name = "txtFiltroNumNota";
            this.txtFiltroNumNota.Size = new System.Drawing.Size(220, 20);
            this.txtFiltroNumNota.TabIndex = 7;
            // 
            // txtFiltroCliente
            // 
            this.txtFiltroCliente.Location = new System.Drawing.Point(96, 59);
            this.txtFiltroCliente.Name = "txtFiltroCliente";
            this.txtFiltroCliente.Size = new System.Drawing.Size(220, 20);
            this.txtFiltroCliente.TabIndex = 5;
            // 
            // lblFiltroAte
            // 
            this.lblFiltroAte.AutoSize = true;
            this.lblFiltroAte.Location = new System.Drawing.Point(196, 30);
            this.lblFiltroAte.Name = "lblFiltroAte";
            this.lblFiltroAte.Size = new System.Drawing.Size(22, 13);
            this.lblFiltroAte.TabIndex = 9006;
            this.lblFiltroAte.Text = "até";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFinal.Location = new System.Drawing.Point(232, 26);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(84, 20);
            this.dtFinal.TabIndex = 3;
            this.dtFinal.Value = new System.DateTime(2024, 1, 2, 0, 0, 0, 0);
            // 
            // dtInicio
            // 
            this.dtInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(96, 26);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtInicio.Size = new System.Drawing.Size(84, 20);
            this.dtInicio.TabIndex = 2;
            this.dtInicio.Value = new System.DateTime(2024, 1, 2, 0, 0, 0, 0);
            // 
            // rbFiltroNumPedido
            // 
            this.rbFiltroNumPedido.AutoSize = true;
            this.rbFiltroNumPedido.Location = new System.Drawing.Point(21, 124);
            this.rbFiltroNumPedido.Name = "rbFiltroNumPedido";
            this.rbFiltroNumPedido.Size = new System.Drawing.Size(73, 17);
            this.rbFiltroNumPedido.TabIndex = 8;
            this.rbFiltroNumPedido.TabStop = true;
            this.rbFiltroNumPedido.Text = "Nº Pedido";
            this.rbFiltroNumPedido.UseVisualStyleBackColor = true;
            this.rbFiltroNumPedido.CheckedChanged += new System.EventHandler(this.rbFiltroNumPedido_CheckedChanged);
            // 
            // rbFiltroNumNota
            // 
            this.rbFiltroNumNota.AutoSize = true;
            this.rbFiltroNumNota.Location = new System.Drawing.Point(21, 93);
            this.rbFiltroNumNota.Name = "rbFiltroNumNota";
            this.rbFiltroNumNota.Size = new System.Drawing.Size(63, 17);
            this.rbFiltroNumNota.TabIndex = 6;
            this.rbFiltroNumNota.TabStop = true;
            this.rbFiltroNumNota.Text = "Nº Nota";
            this.rbFiltroNumNota.UseVisualStyleBackColor = true;
            this.rbFiltroNumNota.CheckedChanged += new System.EventHandler(this.rbFiltroNumNota_CheckedChanged);
            // 
            // rbFiltroCliente
            // 
            this.rbFiltroCliente.AutoSize = true;
            this.rbFiltroCliente.Location = new System.Drawing.Point(21, 60);
            this.rbFiltroCliente.Name = "rbFiltroCliente";
            this.rbFiltroCliente.Size = new System.Drawing.Size(57, 17);
            this.rbFiltroCliente.TabIndex = 4;
            this.rbFiltroCliente.TabStop = true;
            this.rbFiltroCliente.Text = "Cliente";
            this.rbFiltroCliente.UseVisualStyleBackColor = true;
            this.rbFiltroCliente.CheckedChanged += new System.EventHandler(this.rbFiltroCliente_CheckedChanged);
            // 
            // rbFiltroPeriodo
            // 
            this.rbFiltroPeriodo.AutoSize = true;
            this.rbFiltroPeriodo.Location = new System.Drawing.Point(21, 28);
            this.rbFiltroPeriodo.Name = "rbFiltroPeriodo";
            this.rbFiltroPeriodo.Size = new System.Drawing.Size(63, 17);
            this.rbFiltroPeriodo.TabIndex = 1;
            this.rbFiltroPeriodo.TabStop = true;
            this.rbFiltroPeriodo.Text = "Período";
            this.rbFiltroPeriodo.UseVisualStyleBackColor = true;
            this.rbFiltroPeriodo.CheckedChanged += new System.EventHandler(this.rbFiltroPeriodo_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataEmissão,
            this.NumNota,
            this.NumPedido,
            this.Cliente,
            this.Valor,
            this.DataPedido});
            this.dataGridView1.Location = new System.Drawing.Point(31, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 267);
            this.dataGridView1.TabIndex = 984990;
            // 
            // DataEmissão
            // 
            this.DataEmissão.HeaderText = "Data de Emissão";
            this.DataEmissão.Name = "DataEmissão";
            this.DataEmissão.Width = 80;
            // 
            // NumNota
            // 
            this.NumNota.HeaderText = "Nº Nota";
            this.NumNota.Name = "NumNota";
            this.NumNota.Width = 70;
            // 
            // NumPedido
            // 
            this.NumPedido.HeaderText = "Nº Pedido";
            this.NumPedido.Name = "NumPedido";
            this.NumPedido.Width = 80;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 200;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor NF";
            this.Valor.Name = "Valor";
            this.Valor.Width = 80;
            // 
            // DataPedido
            // 
            this.DataPedido.HeaderText = "Data Pedido";
            this.DataPedido.Name = "DataPedido";
            this.DataPedido.Width = 80;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(549, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(85, 79);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(752, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 79);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCartaCorrecao
            // 
            this.btnCartaCorrecao.BackColor = System.Drawing.SystemColors.Control;
            this.btnCartaCorrecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCartaCorrecao.Image = ((System.Drawing.Image)(resources.GetObject("btnCartaCorrecao.Image")));
            this.btnCartaCorrecao.Location = new System.Drawing.Point(337, 12);
            this.btnCartaCorrecao.Name = "btnCartaCorrecao";
            this.btnCartaCorrecao.Size = new System.Drawing.Size(85, 79);
            this.btnCartaCorrecao.TabIndex = 10;
            this.btnCartaCorrecao.Text = "Carta de Correção";
            this.btnCartaCorrecao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCartaCorrecao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCartaCorrecao.UseVisualStyleBackColor = false;
            this.btnCartaCorrecao.Click += new System.EventHandler(this.btnCartaCorrecao_Click);
            // 
            // btnCancelarNF
            // 
            this.btnCancelarNF.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelarNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelarNF.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarNF.Image")));
            this.btnCancelarNF.Location = new System.Drawing.Point(125, 12);
            this.btnCancelarNF.Name = "btnCancelarNF";
            this.btnCancelarNF.Size = new System.Drawing.Size(85, 79);
            this.btnCancelarNF.TabIndex = 0;
            this.btnCancelarNF.Text = "Cancelar";
            this.btnCancelarNF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarNF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelarNF.UseVisualStyleBackColor = false;
            this.btnCancelarNF.Click += new System.EventHandler(this.btnCancelarNF_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FormNotasFiscaisEmitidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(964, 476);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCartaCorrecao);
            this.Controls.Add(this.btnCancelarNF);
            this.Controls.Add(this.gbTipoFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNotasFiscaisEmitidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas Fiscais Emitidas";
            this.gbTipoFiltro.ResumeLayout(false);
            this.gbTipoFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTipoFiltro;
        private System.Windows.Forms.Button btnCartaCorrecao;
        private System.Windows.Forms.Button btnCancelarNF;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.RadioButton rbFiltroNumPedido;
        private System.Windows.Forms.RadioButton rbFiltroNumNota;
        private System.Windows.Forms.RadioButton rbFiltroCliente;
        private System.Windows.Forms.RadioButton rbFiltroPeriodo;
        private System.Windows.Forms.Label lblFiltroAte;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.TextBox txtFiltroNumPedido;
        private System.Windows.Forms.TextBox txtFiltroNumNota;
        private System.Windows.Forms.TextBox txtFiltroCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmissão;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPedido;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument pd1;
    }
}