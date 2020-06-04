using System;
using System.Windows.Forms;
using MiniErp.Domain;

using static MiniErp.Service.BaseApp.Ambiente;

namespace MiniErp.App.Controls
{
    public partial class DefaultBarForms : UserControl
    {
        public event EventHandler NovoClick;
        public event EventHandler SalvarClick;
        public event EventHandler EditarClick;
        public event EventHandler CancelarClick;
        public event EventHandler ExcluirClick;
        public event EventHandler ImprimirClick;
        public event EventHandler PrimeiroClick;
        public event EventHandler AnteriorClick;
        public event EventHandler ProximoClick;
        public event EventHandler UltimoClick;
        public event EventHandler FecharClick;

        public DefaultBarForms()
        {
            InitializeComponent();
        }

        #region Metodos internos

        private void OnBtnNovo(object sender, EventArgs e)
        {
            if (NovoClick != null)
            {
                NovoClick(sender, e);
            }
        }

        private void OnBtnSalvar(object sender, EventArgs e)
        {
            if (SalvarClick != null)
            {
                SalvarClick(sender, e);
            }
        }

        private void OnBtnEditar(object sender, EventArgs e)
        {
            if (EditarClick != null)
            {
                EditarClick(sender, e);
            }
        }

        private void OnBtnCancelar(object sender, EventArgs e)
        {
            if (CancelarClick != null)
            {
                CancelarClick(sender, e);
            }
        }

        private void OnBtnExcluir(object sender, EventArgs e)
        {
            if (ExcluirClick != null)
            {
                ExcluirClick(sender, e);
            }
        }

        private void OnBtnImprimir(object sender, EventArgs e)
        {
            if (ImprimirClick != null)
            {
                ImprimirClick(sender, e);
            }
        }

        private void OnBtnPrimeiro(object sender, EventArgs e)
        {
            if (PrimeiroClick != null)
            {
                PrimeiroClick(sender, e);
            }
        }

        private void OnBtnAnterior(object sender, EventArgs e)
        {
            if (AnteriorClick != null)
            {
                AnteriorClick(sender, e);
            }
        }

        private void OnBtnProximo(object sender, EventArgs e)
        {
            if (ProximoClick != null)
            {
                ProximoClick(sender, e);
            }
        }

        private void OnBtnUltimo(object sender, EventArgs e)
        {
            if (UltimoClick != null)
            {
                UltimoClick(sender, e);
            }
        }

        private void OnBtnFechar(object sender, EventArgs e)
        {
            if (FecharClick != null)
            {
                FecharClick(sender, e);
            }
        }

        #endregion

        #region Eventos iternos

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.OnBtnNovo(sender, e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.OnBtnSalvar(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.OnBtnEditar(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.OnBtnCancelar(sender, e);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.OnBtnExcluir(sender, e);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.OnBtnImprimir(sender, e);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            this.OnBtnPrimeiro(sender, e);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.OnBtnAnterior(sender, e);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            this.OnBtnProximo(sender, e);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            this.OnBtnUltimo(sender, e);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.OnBtnFechar(sender, e);
        }

        #endregion

        #region Tratamentos e configuracoes

        protected Button IdBotaoTratado(BotoesBarra botao)
        {
            switch (botao)
            {
                case BotoesBarra.Novo:
                    return btnNovo;
                case BotoesBarra.Salvar:
                    return btnSalvar;
                case BotoesBarra.Editar:
                    return btnEditar;
                case BotoesBarra.Cancelar:
                    return btnCancelar;
                case BotoesBarra.Excluir:
                    return btnExcluir;
                case BotoesBarra.Imprimir:
                    return btnImprimir;
                case BotoesBarra.Primeiro:
                    return btnPrimeiro;
                case BotoesBarra.Anterior:
                    return btnAnterior;
                case BotoesBarra.Proximo:
                    return btnProximo;
                case BotoesBarra.Ultimo:
                    return btnUltimo;
                case BotoesBarra.Fechar:
                    return btnFechar;
                default:
                    throw new Exception("Tipo de botão desconhecido !");

            }
        }

        /// <summary>
        /// Configrador de estado de botoes, para tratamento individual quando necessario.
        /// </summary>
        /// <param name="botao">Botao</param>
        /// <param name="texto">Texto caso se deseje alterar o texto</param>
        /// <param name="visivel">Exibir ou não botao</param>
        /// <param name="habilitado">Habilita ou não botao</param>
        public void ConfigButtons(BotoesBarra botao, string texto = "", bool? visivel = null, bool? habilitado = null)
        {
            Button botaoTratado = IdBotaoTratado(botao);
            if (!string.IsNullOrEmpty(texto))
            {
                botaoTratado.Text = texto;
            }

            if (visivel != null)
            {
                botaoTratado.Visible = (bool)visivel;
            }

            if (habilitado != null)
            {
                botaoTratado.Enabled = (bool)habilitado;
            }

        }

        public void DefaultFormBar(Permissoes permissoesUser, bool desabilitaNavega = false)
        {
            // ativos padrao para cadastro
            ConfigButtons(BotoesBarra.Novo, visivel: true, habilitado: permissoesUser.Gravacao);
            ConfigButtons(BotoesBarra.Salvar, visivel: true, habilitado: permissoesUser.Gravacao);
            ConfigButtons(BotoesBarra.Editar, visivel: true, habilitado: permissoesUser.Gravacao);
            ConfigButtons(BotoesBarra.Excluir, visivel: true, habilitado: permissoesUser.Excluir);
            ConfigButtons(BotoesBarra.Cancelar, visivel: true, habilitado: true);
            ConfigButtons(BotoesBarra.Imprimir, visivel: true, habilitado: true);
            ConfigButtons(BotoesBarra.Fechar, visivel: true, habilitado: true);

            if (!desabilitaNavega)
            {
                this.DefaultNageva(permissoesUser);
            }
        }

        public void DefaultNageva(Permissoes permissoesUser)
        {
            // controle navegacao
            ConfigButtons(BotoesBarra.Primeiro, visivel: true, habilitado: permissoesUser.Leitura);
            ConfigButtons(BotoesBarra.Anterior, visivel: true, habilitado: permissoesUser.Leitura);
            ConfigButtons(BotoesBarra.Proximo, visivel: true, habilitado: permissoesUser.Leitura);
            ConfigButtons(BotoesBarra.Ultimo, visivel: true, habilitado: permissoesUser.Leitura);
        }


        #endregion
    }
}
