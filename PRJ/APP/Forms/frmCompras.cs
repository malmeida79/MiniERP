using MiniErp.Service.BaseApp;
using System;
using System.Windows.Forms;

namespace MiniErp.App.Forms
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            var permissoes = Ambiente.GetPermissoes("compras");

            defaultBarForms.NovoClick += new EventHandler(btnNovo_Click);
            defaultBarForms.SalvarClick += new EventHandler(btnSalvar_Click);
            defaultBarForms.EditarClick += new EventHandler(btnEditar_Click);
            defaultBarForms.CancelarClick += new EventHandler(btnCancelar_Click);
            defaultBarForms.ExcluirClick += new EventHandler(btnExcluir_Click);
            defaultBarForms.ImprimirClick += new EventHandler(btnImprimir_Click);

            defaultBarForms.PrimeiroClick += new EventHandler(btnPrimeiro_Click);
            defaultBarForms.AnteriorClick += new EventHandler(btnAnterior_Click);
            defaultBarForms.ProximoClick += new EventHandler(btnProximo_Click);
            defaultBarForms.UltimoClick += new EventHandler(btnUltimo_Click);

            defaultBarForms.FecharClick += new EventHandler(btnFechar_Click);

            defaultBarForms.DefaultFormBar(permissoes);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgCompras.Rows.Count != 0)
            {
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                Mensagens.Alerta("Não há registro a ser alterado !");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
