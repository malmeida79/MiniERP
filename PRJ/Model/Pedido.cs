namespace MiniErp.Model.model
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public Pessoa Pessoa { get; set; }
        public ItemPedido ItemPedido { get; set; }
        public decimal SuTotalPedido { get; set; }
        public decimal MrgDescontoPedido { get; set; }
        public decimal TotalDescontoPedido { get; set; }
        public decimal TotalPedido { get; set; }
    }
}
