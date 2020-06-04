using System;

namespace MiniErp.Domain
{
    public class ClientePessoaFisica: PessoaFisica
    {
        public decimal Saldo { get; set; }
        public DateTime DataUltimaCompra { get; set; }
    }
}
