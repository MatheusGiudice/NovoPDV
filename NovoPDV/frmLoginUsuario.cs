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
    public partial class frmLoginUsuario : Form
    {
        public frmLoginUsuario()
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
                frmLoginUsuario.ActiveForm.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

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
                    this.Close();
                }
            }
        }
    }
}
