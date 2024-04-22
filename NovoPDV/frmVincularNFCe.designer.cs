
namespace NovoPDV
{
    partial class frmVincularNFCe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVincularNFCe));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblDataValidadeCertificado = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtSerieCertificado = new System.Windows.Forms.TextBox();
            this.lblSerieCertificado = new System.Windows.Forms.Label();
            this.msktxtDataValidadeCertificado = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(272, 34);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 79);
            this.btnAlterar.TabIndex = 6;
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
            this.btnSalvar.Location = new System.Drawing.Point(452, 34);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 79);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(101, 34);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 79);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblDataValidadeCertificado
            // 
            this.lblDataValidadeCertificado.AutoSize = true;
            this.lblDataValidadeCertificado.Location = new System.Drawing.Point(248, 214);
            this.lblDataValidadeCertificado.Name = "lblDataValidadeCertificado";
            this.lblDataValidadeCertificado.Size = new System.Drawing.Size(89, 13);
            this.lblDataValidadeCertificado.TabIndex = 9000091;
            this.lblDataValidadeCertificado.Text = "Data de Validade";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 301);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 51);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtSerieCertificado
            // 
            this.txtSerieCertificado.Location = new System.Drawing.Point(356, 176);
            this.txtSerieCertificado.Name = "txtSerieCertificado";
            this.txtSerieCertificado.Size = new System.Drawing.Size(104, 20);
            this.txtSerieCertificado.TabIndex = 1;
            // 
            // lblSerieCertificado
            // 
            this.lblSerieCertificado.AutoSize = true;
            this.lblSerieCertificado.Location = new System.Drawing.Point(291, 179);
            this.lblSerieCertificado.Name = "lblSerieCertificado";
            this.lblSerieCertificado.Size = new System.Drawing.Size(46, 13);
            this.lblSerieCertificado.TabIndex = 9000088;
            this.lblSerieCertificado.Text = "Nº Série";
            // 
            // msktxtDataValidadeCertificado
            // 
            this.msktxtDataValidadeCertificado.Location = new System.Drawing.Point(356, 211);
            this.msktxtDataValidadeCertificado.Mask = "00/00/0000";
            this.msktxtDataValidadeCertificado.Name = "msktxtDataValidadeCertificado";
            this.msktxtDataValidadeCertificado.Size = new System.Drawing.Size(104, 20);
            this.msktxtDataValidadeCertificado.TabIndex = 2;
            this.msktxtDataValidadeCertificado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msktxtDataValidadeCertificado.ValidatingType = typeof(System.DateTime);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(634, 34);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 79);
            this.btnCancelar.TabIndex = 9000096;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmVincularNFCe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(756, 364);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.msktxtDataValidadeCertificado);
            this.Controls.Add(this.lblDataValidadeCertificado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtSerieCertificado);
            this.Controls.Add(this.lblSerieCertificado);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVincularNFCe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NFC-e";
            this.Load += new System.EventHandler(this.FormVincularNFCe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblDataValidadeCertificado;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtSerieCertificado;
        private System.Windows.Forms.Label lblSerieCertificado;
        private System.Windows.Forms.MaskedTextBox msktxtDataValidadeCertificado;
        private System.Windows.Forms.Button btnCancelar;
    }
}