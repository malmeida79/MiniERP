using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniErp.Model.model
{
    public class Caixa
    {
        public int IdCaixa { get; set; }
        public DateTime DataLancamento { get; set; }
        public Funcionario Funcionario { get; set; }
        public int CodigoOperacao { get; set; }      //PK das tabelas de Compra e Venda
        public TipoMovimento TipoMovimento { get; set; }  //Entrada, Saída, Estorno, Transferência, Devolução
        public TipoPagamento TipoPagamento { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public decimal ValorMovimento { get; set; }
        public decimal ValorConferido { get; set; }
        public decimal ValorDiferenca { get; set; } //Conferido ou não
        public bool StatusMovimento { get; set; }
        public string ObsCaixa { get; set; }
    }
}
