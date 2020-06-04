using MiniErp.Domain;

namespace MiniErp.Service.BaseApp
{
    public static class Ambiente
    {
        public enum BotoesBarra { Novo, Editar, Salvar, Excluir, Cancelar, Imprimir, Primeiro, Anterior, Proximo, Ultimo, Fechar }

        public static string GetCNStringDes()
        {
            return Properties.Settings.Default.DBCnstrDes;
        }

        public static string GetCNStringPrd()
        {
            return Properties.Settings.Default.DBCnstrPrd;
        }

        public static string GetModoAmbiente()
        {
            return Properties.Settings.Default.Ambiente;
        }

        public static bool GetHistoricoAtivo()
        {
            return Properties.Settings.Default.HistAtivo;
        }

        public static bool GetErroAtivo()
        {
            return Properties.Settings.Default.ErroAtivo;
        }

        public static bool GetLogAtivo()
        {
            return Properties.Settings.Default.LogAtivo;
        }

        public static string GetBaseAppURI() {
            return "http://localhost:51963/";            
        }


        public static Permissoes GetPermissoes(string formulario)
        {
            return new Permissoes() {
                Excluir = true,
                Gravacao = true,
                Leitura = true
            };
        }
        /// <summary>
        /// Identifica se estamos executando em modo producao
        /// </summary>
        /// <returns>TRUE/FALSE</returns>
        public static bool ISProducao()
        {
            if (Properties.Settings.Default.Ambiente.ToLower() != "desenvolvimento")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}