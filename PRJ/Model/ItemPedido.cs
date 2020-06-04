namespace MiniErp.Model.model
{
    public class ItemPedido : Pedido
    { 
        public int IdItemPedido { get; set; }
        public Produto Produto { get; set; }
        public decimal Qtde { get; set; }
        public decimal SubTotal { get; set; }
    }
}
