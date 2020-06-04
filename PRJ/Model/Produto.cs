namespace MiniErp.Model.model
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Referencia { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Categoria Categoria { get; set; }
        public Marca Marca { get; set; }
        public string DscProduto { get; set; }
        public string Tipo { get; set; }
        public Unidade Unidade { get; set; }
        public decimal NCMSH { get; set; }
        public decimal OCST { get; set; }
        public decimal CFOP { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal MrgPrecoVenda { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal MrgDesconto { get; set; }
        public decimal TotalDesconto { get; set; }
        public string CaminhoImagem { get; set; }
        public string ObsProduto { get; set; }
    }
}
