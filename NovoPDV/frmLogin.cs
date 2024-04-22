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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "admin" && txtSenha.Text != "123456")
            {
                MessageBox.Show("Usuário e/ou senha incorretos ! Por favor, insira os dados novamente", "Veti PDV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
            else
            {
                frmMenu _Menu = new frmMenu();
                _Menu.ShowDialog();
            }
                
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtUsuario.Text != "admin" && txtSenha.Text != "123456")
                {
                    MessageBox.Show("Usuário e/ou senha incorretos ! Por favor, insira os dados novamente", "Veti PDV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }
                else
                {
                    frmMenu _Menu = new frmMenu();
                    _Menu.ShowDialog();
                }
            }
        }
    }
}
