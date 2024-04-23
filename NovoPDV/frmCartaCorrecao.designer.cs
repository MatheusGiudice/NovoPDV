
namespace NovoPDV
{
    partial class frmCartaCorrecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCartaCorrecao));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumNotaFiscal = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtNumCartaCorrecao = new System.Windows.Forms.TextBox();
            this.lblCartaCorrecao = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDadosCorrecao = new System.Windows.Forms.TextBox();
            this.lblInformacoesCartaCorrecao = new System.Windows.Forms.Label();
            this.lblInformacoesCartaCorrecao1 = new System.Windows.Forms.Label();
            this.lblInformacoesCartaCorrecao2 = new System.Windows.Forms.Label();
            this.lblInformacoesCartaCorrecao3 = new System.Windows.Forms.Label();
            this.lblInformacoesCartaCorrecao4 = new System.Windows.Forms.Label();
            this.lblInformacoesCartaCorrecao5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(330, 31);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(85, 79);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(566, 31);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 79);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumNotaFiscal);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.txtNumCartaCorrecao);
            this.groupBox1.Controls.Add(this.lblCartaCorrecao);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.lblNotaFiscal);
            this.groupBox1.Location = new System.Drawing.Point(435, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 108);
            this.groupBox1.TabIndex = 9000032;
            this.groupBox1.TabStop = false;
            // 
            // txtNumNotaFiscal
            // 
            this.txtNumNotaFiscal.Enabled = false;
            this.txtNumNotaFiscal.Location = new System.Drawing.Point(177, 45);
            this.txtNumNotaFiscal.Name = "txtNumNotaFiscal";
            this.txtNumNotaFiscal.Size = new System.Drawing.Size(53, 20);
            this.txtNumNotaFiscal.TabIndex = 9007;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(64, 73);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(236, 20);
            this.txtCliente.TabIndex = 9009;
            // 
            // txtNumCartaCorrecao
            // 
            this.txtNumCartaCorrecao.Enabled = false;
            this.txtNumCartaCorrecao.Location = new System.Drawing.Point(184, 16);
            this.txtNumCartaCorrecao.Name = "txtNumCartaCorrecao";
            this.txtNumCartaCorrecao.Size = new System.Drawing.Size(66, 20);
            this.txtNumCartaCorrecao.TabIndex = 9005;
            // 
            // lblCartaCorrecao
            // 
            this.lblCartaCorrecao.AutoSize = true;
            this.lblCartaCorrecao.Location = new System.Drawing.Point(79, 19);
            this.lblCartaCorrecao.Name = "lblCartaCorrecao";
            this.lblCartaCorrecao.Size = new System.Drawing.Size(99, 13);
            this.lblCartaCorrecao.TabIndex = 9004;
            this.lblCartaCorrecao.Text = "Carta de Correção: ";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(16, 76);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 9008;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.AutoSize = true;
            this.lblNotaFiscal.Location = new System.Drawing.Point(105, 48);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(66, 13);
            this.lblNotaFiscal.TabIndex = 9006;
            this.lblNotaFiscal.Text = "Nota Fiscal: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDadosCorrecao);
            this.groupBox2.Location = new System.Drawing.Point(55, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 209);
            this.groupBox2.TabIndex = 9000033;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações de Correção";
            // 
            // txtDadosCorrecao
            // 
            this.txtDadosCorrecao.Location = new System.Drawing.Point(6, 20);
            this.txtDadosCorrecao.Multiline = true;
            this.txtDadosCorrecao.Name = "txtDadosCorrecao";
            this.txtDadosCorrecao.Size = new System.Drawing.Size(307, 178);
            this.txtDadosCorrecao.TabIndex = 1;
            // 
            // lblInformacoesCartaCorrecao
            // 
            this.lblInformacoesCartaCorrecao.AutoSize = true;
            this.lblInformacoesCartaCorrecao.Location = new System.Drawing.Point(26, 348);
            this.lblInformacoesCartaCorrecao.Name = "lblInformacoesCartaCorrecao";
            this.lblInformacoesCartaCorrecao.Size = new System.Drawing.Size(383, 13);
            this.lblInformacoesCartaCorrecao.TabIndex = 6;
            this.lblInformacoesCartaCorrecao.Text = "\"A Carta de Correção é disciplinada pelo § 1º-A do art. 7º do Convênio S/N, de ";
            // 
            // lblInformacoesCartaCorrecao1
            // 
            this.lblInformacoesCartaCorrecao1.AutoSize = true;
            this.lblInformacoesCartaCorrecao1.Location = new System.Drawing.Point(23, 367);
            this.lblInformacoesCartaCorrecao1.Name = "lblInformacoesCartaCorrecao1";
            this.lblInformacoesCartaCorrecao1.Size = new System.Drawing.Size(386, 13);
            this.lblInformacoesCartaCorrecao1.TabIndex = 9000034;
            this.lblInformacoesCartaCorrecao1.Text = "15 de dezembro de 1970 e pode ser utilizada para regularização de erro ocorrido";
            // 
            // lblInformacoesCartaCorrecao2
            // 
            this.lblInformacoesCartaCorrecao2.AutoSize = true;
            this.lblInformacoesCartaCorrecao2.Location = new System.Drawing.Point(29, 384);
            this.lblInformacoesCartaCorrecao2.Name = "lblInformacoesCartaCorrecao2";
            this.lblInformacoesCartaCorrecao2.Size = new System.Drawing.Size(380, 13);
            this.lblInformacoesCartaCorrecao2.TabIndex = 9000035;
            this.lblInformacoesCartaCorrecao2.Text = "na emissão de documento fiscal, desde que o erro não esteja relacionado com:";
            // 
            // lblInformacoesCartaCorrecao3
            // 
            this.lblInformacoesCartaCorrecao3.AutoSize = true;
            this.lblInformacoesCartaCorrecao3.Location = new System.Drawing.Point(9, 403);
            this.lblInformacoesCartaCorrecao3.Name = "lblInformacoesCartaCorrecao3";
            this.lblInformacoesCartaCorrecao3.Size = new System.Drawing.Size(433, 13);
            this.lblInformacoesCartaCorrecao3.TabIndex = 9000036;
            this.lblInformacoesCartaCorrecao3.Text = "I - As variáveis que determinam o valor dos impostos tais como: Base de Cálculo, " +
    "Alíquota,";
            // 
            // lblInformacoesCartaCorrecao4
            // 
            this.lblInformacoesCartaCorrecao4.AutoSize = true;
            this.lblInformacoesCartaCorrecao4.Location = new System.Drawing.Point(56, 421);
            this.lblInformacoesCartaCorrecao4.Name = "lblInformacoesCartaCorrecao4";
            this.lblInformacoesCartaCorrecao4.Size = new System.Drawing.Size(339, 13);
            this.lblInformacoesCartaCorrecao4.TabIndex = 9000037;
            this.lblInformacoesCartaCorrecao4.Text = "Diferença de Preço, Quantidade, Valor da Operação ou da Prestação;";
            // 
            // lblInformacoesCartaCorrecao5
            // 
            this.lblInformacoesCartaCorrecao5.AutoSize = true;
            this.lblInformacoesCartaCorrecao5.Location = new System.Drawing.Point(9, 439);
            this.lblInformacoesCartaCorrecao5.Name = "lblInformacoesCartaCorrecao5";
            this.lblInformacoesCartaCorrecao5.Size = new System.Drawing.Size(443, 13);
            this.lblInformacoesCartaCorrecao5.TabIndex = 9000038;
            this.lblInformacoesCartaCorrecao5.Text = "II - A correção de dados cadastrais que implique mudança do Remetente ou do Desti" +
    "natário;";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 9000039;
            this.label1.Text = "III - a data da Emissão ou de Saída";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.Location = new System.Drawing.Point(88, 31);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(85, 79);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FormCartaCorrecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInformacoesCartaCorrecao5);
            this.Controls.Add(this.lblInformacoesCartaCorrecao4);
            this.Controls.Add(this.lblInformacoesCartaCorrecao3);
            this.Controls.Add(this.lblInformacoesCartaCorrecao2);
            this.Controls.Add(this.lblInformacoesCartaCorrecao1);
            this.Controls.Add(this.lblInformacoesCartaCorrecao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCartaCorrecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carta de Correção";
            this.Load += new System.EventHandler(this.FormCartaCorrecao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumNotaFiscal;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtNumCartaCorrecao;
        private System.Windows.Forms.Label lblCartaCorrecao;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDadosCorrecao;
        private System.Windows.Forms.Label lblInformacoesCartaCorrecao;
        private System.Windows.Forms.Label lblInformacoesCartaCorrecao1;
        private System.Windows.Forms.Label lblInformacoesCartaCorrecao2;
        private System.Windows.Forms.Label lblInformacoesCartaCorrecao3;
        private System.Windows.Forms.Label lblInformacoesCartaCorrecao4;
        private System.Windows.Forms.Label lblInformacoesCartaCorrecao5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
    }
}