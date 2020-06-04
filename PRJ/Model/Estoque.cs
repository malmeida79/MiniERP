using System;

namespace MiniErp.Model.model
{
    public class Estoque
    {
        public int IdEstoque { get; set; }
        public Produto Produto { get; set; }
        public bool TipoMovimento { get; set; }
        public DateTime DataMovimento { get; set; }
        public decimal Qtde { get; set; }
        public decimal Saldo { get; set; }
    }
}
