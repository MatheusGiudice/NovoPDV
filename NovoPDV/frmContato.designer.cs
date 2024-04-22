
namespace NovoPDV
{
    partial class frmContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContato));
            this.gbTipoCliente = new System.Windows.Forms.GroupBox();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.msktxtCNPJCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJCPF = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.lblFantasia = new System.Windows.Forms.Label();
            this.txtRazaoNome = new System.Windows.Forms.TextBox();
            this.lblRazaoNome = new System.Windows.Forms.Label();
            this.msktxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.msktxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbTipoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTipoCliente
            // 
            this.gbTipoCliente.Controls.Add(this.rbPessoaJuridica);
            this.gbTipoCliente.Controls.Add(this.rbPessoaFisica);
            this.gbTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbTipoCliente.Location = new System.Drawing.Point(24, 119);
            this.gbTipoCliente.Name = "gbTipoCliente";
            this.gbTipoCliente.Size = new System.Drawing.Size(147, 68);
            this.gbTipoCliente.TabIndex = 900004;
            this.gbTipoCliente.TabStop = false;
            this.gbTipoCliente.Text = "Tipo Cliente";
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbPessoaJuridica.Location = new System.Drawing.Point(6, 43);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(126, 21);
            this.rbPessoaJuridica.TabIndex = 900005;
            this.rbPessoaJuridica.TabStop = true;
            this.rbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbPessoaJuridica_CheckedChanged);
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbPessoaFisica.Location = new System.Drawing.Point(7, 20);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(113, 21);
            this.rbPessoaFisica.TabIndex = 900004;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Pessoa Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.rbPessoaFisica_CheckedChanged);
            // 
            // msktxtCNPJCPF
            // 
            this.msktxtCNPJCPF.Location = new System.Drawing.Point(360, 121);
            this.msktxtCNPJCPF.Mask = "00.000.000/0000-00";
            this.msktxtCNPJCPF.Name = "msktxtCNPJCPF";
            this.msktxtCNPJCPF.Size = new System.Drawing.Size(121, 20);
            this.msktxtCNPJCPF.TabIndex = 3;
            // 
            // lblCNPJCPF
            // 
            this.lblCNPJCPF.AutoSize = true;
            this.lblCNPJCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCNPJCPF.Location = new System.Drawing.Point(220, 122);
            this.lblCNPJCPF.Name = "lblCNPJCPF";
            this.lblCNPJCPF.Size = new System.Drawing.Size(48, 18);
            this.lblCNPJCPF.TabIndex = 900010;
            this.lblCNPJCPF.Text = "CNPJ";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(360, 94);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(297, 20);
            this.txtFantasia.TabIndex = 2;
            // 
            // lblFantasia
            // 
            this.lblFantasia.AutoSize = true;
            this.lblFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFantasia.Location = new System.Drawing.Point(220, 95);
            this.lblFantasia.Name = "lblFantasia";
            this.lblFantasia.Size = new System.Drawing.Size(109, 18);
            this.lblFantasia.TabIndex = 900009;
            this.lblFantasia.Text = "Nome Fantasia";
            // 
            // txtRazaoNome
            // 
            this.txtRazaoNome.Location = new System.Drawing.Point(360, 68);
            this.txtRazaoNome.Name = "txtRazaoNome";
            this.txtRazaoNome.Size = new System.Drawing.Size(297, 20);
            this.txtRazaoNome.TabIndex = 1;
            // 
            // lblRazaoNome
            // 
            this.lblRazaoNome.AutoSize = true;
            this.lblRazaoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRazaoNome.Location = new System.Drawing.Point(220, 69);
            this.lblRazaoNome.Name = "lblRazaoNome";
            this.lblRazaoNome.Size = new System.Drawing.Size(97, 18);
            this.lblRazaoNome.TabIndex = 900008;
            this.lblRazaoNome.Text = "Razão Social";
            // 
            // msktxtCelular
            // 
            this.msktxtCelular.Location = new System.Drawing.Point(563, 173);
            this.msktxtCelular.Mask = "(00) 00000-0000";
            this.msktxtCelular.Name = "msktxtCelular";
            this.msktxtCelular.Size = new System.Drawing.Size(94, 20);
            this.msktxtCelular.TabIndex = 6;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCelular.Location = new System.Drawing.Point(505, 174);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(54, 18);
            this.lblCelular.TabIndex = 900019;
            this.lblCelular.Text = "Celular";
            // 
            // msktxtTelefone
            // 
            this.msktxtTelefone.Location = new System.Drawing.Point(360, 173);
            this.msktxtTelefone.Mask = "(00) 0000-0000";
            this.msktxtTelefone.Name = "msktxtTelefone";
            this.msktxtTelefone.Size = new System.Drawing.Size(93, 20);
            this.msktxtTelefone.TabIndex = 5;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTelefone.Location = new System.Drawing.Point(220, 176);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(65, 18);
            this.lblTelefone.TabIndex = 900017;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(360, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEmail.Location = new System.Drawing.Point(220, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 18);
            this.lblEmail.TabIndex = 900018;
            this.lblEmail.Text = "E-mail";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(17, 582);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 59);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMensagem.Location = new System.Drawing.Point(397, 222);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(82, 18);
            this.lblMensagem.TabIndex = 900021;
            this.lblMensagem.Text = "Mensagem";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(280, 249);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(327, 144);
            this.txtMensagem.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.Location = new System.Drawing.Point(492, 466);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(115, 59);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(252, 466);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 59);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9000032;
            this.pictureBox1.TabStop = false;
            // 
            // FormContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(930, 653);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.msktxtCelular);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.msktxtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.msktxtCNPJCPF);
            this.Controls.Add(this.lblCNPJCPF);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(this.lblFantasia);
            this.Controls.Add(this.txtRazaoNome);
            this.Controls.Add(this.lblRazaoNome);
            this.Controls.Add(this.gbTipoCliente);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Contato ";
            this.Load += new System.EventHandler(this.FormContato_Load);
            this.gbTipoCliente.ResumeLayout(false);
            this.gbTipoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTipoCliente;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.MaskedTextBox msktxtCNPJCPF;
        private System.Windows.Forms.Label lblCNPJCPF;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.Label lblFantasia;
        private System.Windows.Forms.TextBox txtRazaoNome;
        private System.Windows.Forms.Label lblRazaoNome;
        private System.Windows.Forms.MaskedTextBox msktxtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox msktxtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}