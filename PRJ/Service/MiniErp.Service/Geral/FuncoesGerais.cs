using System;

namespace MiniErp.Service.Geral
{
    public class FuncoesGerais
    {

        /// <summary>
        /// Informa a data somente se existe assiantura ou liberação
        /// </summary>
        /// <param name="campoReferencia">Validador para apresentar ou nao a data</param>
        /// <param name="data">data a ser informada</param>
        /// <returns></returns>
        public static string TrataData(bool campoReferencia, DateTime? data)
        {
            if (data == null)
            {
                return null;
            }

            string retorno = string.Empty;

            if (campoReferencia)
            {
                if (data.ToString().Length >= 10)
                {
                    retorno = data.ToString().Substring(0, 10);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Para o grid troca true/false por sim/nao
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string TrataBool(bool valor)
        {
            string retorno = "Não";
            if (valor)
            {
                retorno = "Sim";
            }
            return retorno;
        }

    }
}