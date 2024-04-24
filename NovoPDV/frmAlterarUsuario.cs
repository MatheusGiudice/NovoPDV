using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoPDV
{
    public partial class frmAlterarUsuario : Form
    {
        public frmAlterarUsuario()
        {
            InitializeComponent();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar a janela ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            frmAlterarUsuario.ActiveForm.Hide();
            if (txtLogin.Text == "admin" && txtSenha.Text == "123456")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário e/ou Senha Inválidos !", "Veti PDV");
                txtSenha.Clear();
                txtLogin.Clear();
                txtLogin.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtLogin.Text == "admin" && txtSenha.Text == "123456")
                {
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha Inválidos !", "Veti PDV");
                    txtSenha.Clear();
                    txtLogin.Clear();
                    txtLogin.Focus();
                }
            }
        }
    }
}
