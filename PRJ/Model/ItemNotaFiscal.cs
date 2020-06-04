namespace MiniErp.Model.model
{
    public class ItemNotaFiscal : NotaFiscal
    {
        public int IdItemNotaFiscal { get; set; }
        public Produto Produto { get; set; }
        public decimal Qtde { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorFrete { get; set; }
        public decimal ValorAcessorio { get; set; }
        public decimal ValorSeguro { get; set; }
        public decimal ValorTotalItem { get; set; }
        public string LocalEstoque { get; set; }
        public bool ValorTotalItemNaNotaFiscal { get; set; }
        public NaturezaOperacao NaturezaOperacao { get; set; }
    }
}
