using System;

namespace MiniErp.Model.model
{
    public class Venda : Pedido
    {
        public int IdVEnda { get; set; }
        public DateTime DataVenda { get; set; }
        public NotaFiscal NotaFiscal { get; set; }
        public TipoMovimento TipoMovimento { get; set; }
        public Pedido Pedido { get; set; }
        public Funcionario Funcionario{ get; set; }
        public decimal TotalBrutoVenda { get; set; }
        public decimal MrgDesconto { get; set; }
        public decimal TotalDescontoVenda { get; set; }
        public decimal TotalVenda { get; set; }
        public decimal Parcela { get; set; }
        public decimal ValorPArcela { get; set; }
    }
}
