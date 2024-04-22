
namespace NovoPDV
{
    partial class frmSuporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuporte));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblHorarioAtendimento = new System.Windows.Forms.Label();
            this.lblSegundaSexta = new System.Windows.Forms.Label();
            this.LblHorasAtendimento = new System.Windows.Forms.Label();
            this.btnFormulario = new System.Windows.Forms.Button();
            this.btnWhatsApp = new System.Windows.Forms.Button();
            this.lblDuvidaCliente = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblOu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(208, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBemVindo.Location = new System.Drawing.Point(289, 87);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(278, 25);
            this.lblBemVindo.TabIndex = 8;
            this.lblBemVindo.Text = "Bem vindo ao suporte da Veti !";
            // 
            // lblHorarioAtendimento
            // 
            this.lblHorarioAtendimento.AutoSize = true;
            this.lblHorarioAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHorarioAtendimento.Location = new System.Drawing.Point(8, 178);
            this.lblHorarioAtendimento.Name = "lblHorarioAtendimento";
            this.lblHorarioAtendimento.Size = new System.Drawing.Size(223, 25);
            this.lblHorarioAtendimento.TabIndex = 9;
            this.lblHorarioAtendimento.Text = "Horário de Atendimento:";
            // 
            // lblSegundaSexta
            // 
            this.lblSegundaSexta.AutoSize = true;
            this.lblSegundaSexta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSegundaSexta.Location = new System.Drawing.Point(44, 215);
            this.lblSegundaSexta.Name = "lblSegundaSexta";
            this.lblSegundaSexta.Size = new System.Drawing.Size(132, 20);
            this.lblSegundaSexta.TabIndex = 10;
            this.lblSegundaSexta.Text = "Segunda a Sexta";
            // 
            // LblHorasAtendimento
            // 
            this.LblHorasAtendimento.AutoSize = true;
            this.LblHorasAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblHorasAtendimento.Location = new System.Drawing.Point(67, 246);
            this.LblHorasAtendimento.Name = "LblHorasAtendimento";
            this.LblHorasAtendimento.Size = new System.Drawing.Size(88, 20);
            this.LblHorasAtendimento.TabIndex = 11;
            this.LblHorasAtendimento.Text = "09h às 18h";
            // 
            // btnFormulario
            // 
            this.btnFormulario.Image = ((System.Drawing.Image)(resources.GetObject("btnFormulario.Image")));
            this.btnFormulario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormulario.Location = new System.Drawing.Point(221, 271);
            this.btnFormulario.Name = "btnFormulario";
            this.btnFormulario.Size = new System.Drawing.Size(172, 60);
            this.btnFormulario.TabIndex = 12;
            this.btnFormulario.Text = "&Formulário de Contato";
            this.btnFormulario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormulario.UseVisualStyleBackColor = true;
            // 
            // btnWhatsApp
            // 
            this.btnWhatsApp.Image = ((System.Drawing.Image)(resources.GetObject("btnWhatsApp.Image")));
            this.btnWhatsApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWhatsApp.Location = new System.Drawing.Point(480, 271);
            this.btnWhatsApp.Name = "btnWhatsApp";
            this.btnWhatsApp.Size = new System.Drawing.Size(131, 60);
            this.btnWhatsApp.TabIndex = 13;
            this.btnWhatsApp.Text = "&WhatsApp";
            this.btnWhatsApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWhatsApp.UseVisualStyleBackColor = true;
            this.btnWhatsApp.Click += new System.EventHandler(this.btnWhatsApp_Click);
            // 
            // lblDuvidaCliente
            // 
            this.lblDuvidaCliente.AutoSize = true;
            this.lblDuvidaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDuvidaCliente.Location = new System.Drawing.Point(289, 178);
            this.lblDuvidaCliente.Name = "lblDuvidaCliente";
            this.lblDuvidaCliente.Size = new System.Drawing.Size(256, 25);
            this.lblDuvidaCliente.TabIndex = 14;
            this.lblDuvidaCliente.Text = "Como deseja nos contatar ?";
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 470);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 51);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTelefone.Location = new System.Drawing.Point(312, 416);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(207, 25);
            this.lblTelefone.TabIndex = 34;
            this.lblTelefone.Text = "Ligue: (11) 3188-3334";
            // 
            // lblOu
            // 
            this.lblOu.AutoSize = true;
            this.lblOu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblOu.Location = new System.Drawing.Point(403, 363);
            this.lblOu.Name = "lblOu";
            this.lblOu.Size = new System.Drawing.Size(39, 25);
            this.lblOu.TabIndex = 33;
            this.lblOu.Text = "Ou";
            // 
            // frmSuporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(721, 533);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblOu);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblDuvidaCliente);
            this.Controls.Add(this.btnWhatsApp);
            this.Controls.Add(this.btnFormulario);
            this.Controls.Add(this.LblHorasAtendimento);
            this.Controls.Add(this.lblSegundaSexta);
            this.Controls.Add(this.lblHorarioAtendimento);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSuporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suporte";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblHorarioAtendimento;
        private System.Windows.Forms.Label lblSegundaSexta;
        private System.Windows.Forms.Label LblHorasAtendimento;
        private System.Windows.Forms.Button btnFormulario;
        private System.Windows.Forms.Button btnWhatsApp;
        private System.Windows.Forms.Label lblDuvidaCliente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblOu;
    }
}