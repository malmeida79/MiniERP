namespace MiniErp.Model.model
{
    public class ItemCompra : Compra
    {
        public int IdItemCompra { get; set; }
        public Produto Produto { get; set; }
        public decimal Qtde { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
