using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniErp.Model.model
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public NotaFiscal NotaFiscal { get; set; }
        public Funcionario Funcionario { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public ItemCompra ItemCompra { get; set; }
        public decimal Parcela { get; set; }
        public decimal ValorParcela { get; set; }
    }
}
