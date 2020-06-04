using System;
using System.Windows.Forms;

namespace MiniErp.App.view
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //
        //
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            timerPrincipal.Start();
        }
        //
        // Chamar formulários
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos frm = new frmPedidos();
            frm.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmCompras frm = new frmCompras();
            frm.Show();
        }

        private void btnPdv_Click(object sender, EventArgs e)
        {
            frmPdv frm = new frmPdv();
            frm.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos frm = new frmProdutos();
            frm.Show();
        }

        private void btnNfe_Click(object sender, EventArgs e)
        {
            frmNfe frm = new frmNfe();
            frm.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            frmFornecedores frm = new frmFornecedores();
            frm.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios frm = new frmFuncionarios();
            frm.Show();
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            frmGraficos frm = new frmGraficos();
            frm.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmAvisoTelaPrincipal frm = new frmAvisoTelaPrincipal();
            frm.Show();
        }
        //
        //
        //
        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            lblDataPrincipal.Text = DateTime.Now.ToLongDateString();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.Show();
        }
    }
}
