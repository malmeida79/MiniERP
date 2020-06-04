using System;
using System.Windows.Forms;

namespace MiniErp.App.Forms
{
    public partial class frmAvisoTelaPrincipal : Form
    {
        public frmAvisoTelaPrincipal()
        {
            InitializeComponent();
        }

        private void frmAvisoTelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        // configuração para a progress bar
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbAvisoTelaPrincipal.Increment(2);
            if (pbAvisoTelaPrincipal.Value == pbAvisoTelaPrincipal.Maximum)
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void btnFazerBackup_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //
        //
    }
}
