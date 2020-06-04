using System;
using System.Windows.Forms;

namespace MiniErp.App.view
{
    public partial class frmAvisoTelaPrincipal : Form
    {
        public frmAvisoTelaPrincipal()
        {
            InitializeComponent();
        }

        private void frmAvisoTelaPrincipal_Load(object sender, EventArgs e)
        {
            btnSair.Visible = false;
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

        private void ckbNaoRealizaBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNaoRealizaBackup.Checked == true)
                btnSair.Visible = true;
            else
                btnSair.Visible = false;
        }
        //
        //
    }
}
