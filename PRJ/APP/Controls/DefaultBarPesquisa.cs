using System.Windows.Forms;

namespace MiniErp.App.Controls
{
    public partial class DefaultBarPesquisa : UserControl
    {
        public DefaultBarPesquisa()
        {
            InitializeComponent();
        }

        #region Setters

        public void SetTotalRegistros(int valor) {
            lblTotalDeRegistro.Text = valor.ToString();
        }

        public void SetCheckAtivo(bool ativo) {
            rbAtivo.Checked = ativo;
        }

        public void SetCheckInativo(bool ativo)
        {
            rbInativo.Checked = ativo;
        }

        public void SetCheckBloqueado(bool ativo)
        {
            rbBloqueado.Checked = ativo;
        }

        public void SetTxtNome(string value)
        {
            txtPesquisarNome.Text = value;
        }

        public void SetTxtCpf(string value)
        {
            txtPesquisarCpf.Text = value;
        }

        #endregion

        #region Getters

        public bool GetCheckAtivo()
        {
            return rbAtivo.Checked;
        }

        public bool GetCheckInativo()
        {
           return rbInativo.Checked;
        }

        public bool GetCheckBloqueado()
        {
            return rbBloqueado.Checked;
        }

        public string GetTxtNome(string value)
        {
            return txtPesquisarNome.Text;
        }

        public string GetTxtCpf(string value)
        {
            return txtPesquisarCpf.Text;
        }

        #endregion
    }
}
