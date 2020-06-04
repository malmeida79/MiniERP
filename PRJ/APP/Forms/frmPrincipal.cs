using System;
using System.Windows.Forms;

namespace MiniErp.App.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            timerPrincipal.Start();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos frm = new frmPedidos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmCompras frm = new frmCompras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPdv_Click(object sender, EventArgs e)
        {
            frmPdv frm = new frmPdv();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos frm = new frmProdutos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnNfe_Click(object sender, EventArgs e)
        {
            frmNfe frm = new frmNfe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            frmFornecedores frm = new frmFornecedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios frm = new frmFuncionarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            frmGraficos frm = new frmGraficos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Deseja realmente Sair do Sistema?", "Sistema para Gerenciamento Comercial - Atenção!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resposta == DialogResult.Yes)
            {
                frmAvisoTelaPrincipal frm = new frmAvisoTelaPrincipal();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            lblDataPrincipal.Text = DateTime.Now.ToLongDateString();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnClientes_Click(sender, e);
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnCompras_Click(sender, e);
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnFornecedores_Click(sender, e);
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnFuncionarios_Click(sender, e);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnProdutos_Click(sender, e);
        }
    }
}
