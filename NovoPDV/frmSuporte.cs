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
    public partial class frmSuporte : Form
    {
        public frmSuporte()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWhatsApp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://wa.me/551131883334");
            pStart.Start();
        }

        private void btnFormulario_Click(object sender, EventArgs e)
        {
            frmContato _formContato = new frmContato();
            _formContato.ShowDialog();
        }
    }
}
