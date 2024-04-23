
namespace NovoPDV
{
    partial class frmDescontoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescontoPedido));
            this.lblDescontoPorcent = new System.Windows.Forms.Label();
            this.lblDescontoReais = new System.Windows.Forms.Label();
            this.msktxtDescontoPorcent = new System.Windows.Forms.MaskedTextBox();
            this.msktxtDesconto = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msktxtArredondamento = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescontoPorcent
            // 
            this.lblDescontoPorcent.AutoSize = true;
            this.lblDescontoPorcent.Location = new System.Drawing.Point(84, 42);
            this.lblDescontoPorcent.Name = "lblDescontoPorcent";
            this.lblDescontoPorcent.Size = new System.Drawing.Size(64, 13);
            this.lblDescontoPorcent.TabIndex = 900050;
            this.lblDescontoPorcent.Text = "Desconto %";
            // 
            // lblDescontoReais
            // 
            this.lblDescontoReais.AutoSize = true;
            this.lblDescontoReais.Location = new System.Drawing.Point(84, 70);
            this.lblDescontoReais.Name = "lblDescontoReais";
            this.lblDescontoReais.Size = new System.Drawing.Size(70, 13);
            this.lblDescontoReais.TabIndex = 900051;
            this.lblDescontoReais.Text = "Desconto R$";
            // 
            // msktxtDescontoPorcent
            // 
            this.msktxtDescontoPorcent.Location = new System.Drawing.Point(175, 39);
            this.msktxtDescontoPorcent.Mask = "000,00 %";
            this.msktxtDescontoPorcent.Name = "msktxtDescontoPorcent";
            this.msktxtDescontoPorcent.Size = new System.Drawing.Size(66, 20);
            this.msktxtDescontoPorcent.TabIndex = 1;
            this.msktxtDescontoPorcent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msktxtDesconto
            // 
            this.msktxtDesconto.Location = new System.Drawing.Point(175, 67);
            this.msktxtDesconto.Mask = "$ 000,00 ";
            this.msktxtDesconto.Name = "msktxtDesconto";
            this.msktxtDesconto.Size = new System.Drawing.Size(66, 20);
            this.msktxtDesconto.TabIndex = 2;
            this.msktxtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 900052;
            this.label1.Text = "Arredondamento";
            // 
            // msktxtArredondamento
            // 
            this.msktxtArredondamento.Location = new System.Drawing.Point(175, 93);
            this.msktxtArredondamento.Mask = "$ 000,00 ";
            this.msktxtArredondamento.Name = "msktxtArredondamento";
            this.msktxtArredondamento.Size = new System.Drawing.Size(66, 20);
            this.msktxtArredondamento.TabIndex = 3;
            this.msktxtArredondamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(249, 140);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(72, 68);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAplicar.Image = ((System.Drawing.Image)(resources.GetObject("btnAplicar.Image")));
            this.btnAplicar.Location = new System.Drawing.Point(12, 140);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(72, 68);
            this.btnAplicar.TabIndex = 4;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAplicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // frmDescontoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(333, 220);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.msktxtArredondamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msktxtDesconto);
            this.Controls.Add(this.msktxtDescontoPorcent);
            this.Controls.Add(this.lblDescontoReais);
            this.Controls.Add(this.lblDescontoPorcent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDescontoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desconto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescontoPorcent;
        private System.Windows.Forms.Label lblDescontoReais;
        private System.Windows.Forms.MaskedTextBox msktxtDescontoPorcent;
        private System.Windows.Forms.MaskedTextBox msktxtDesconto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktxtArredondamento;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAplicar;
    }
}