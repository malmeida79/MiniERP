using System;

namespace MiniErp.Model.model
{
    public class NotaFiscal
    {
        public int IdNotaFiscal { get; set; }
        public string NumeroNota{ get; set; }
        public string SeriaNota { get; set; }
        public string ChaveAcesso { get; set; }
        public string ProtocoloAutorizacao { get; set; }
        public ItemNotaFiscal ItemNotaFiscal { get; set; }

        //Código de Movimentação(Entrada / Saída / Transferência / Estorno)
        public TipoMovimento TipoMovimento { get; set; }

        //Tipo de emissão da nota(Própria / Terceiros)
        public string TipoEmissao { get; set; }

        //Finalidade da Nota(Complementar / Ajuste / Devolução)
        public string Finalidade { get; set; }

	    //Natureza da Operação(Tabela NaturezaOperacao)
        public NaturezaOperacao NaturezaOperacao { get; set; }

	    //Indicador de Presença(Não se aplica / Presencial / Internet / Teleatendimento / Entrega a domicilio / Outros)
        public string IndicadorPresenca  { get; set; }

	    //Cliente Final
        public bool ClienteFinal { get; set; }

	    //Data de Emissão da Nota
        public DateTime DataEmissao { get; set; }

	    //Destinatário(Tabela Pessoa)
        public Pessoa Pessoa { get; set; }

	    //public decimal es e Impostos
        public decimal BaseCalculoICMS { get; set; }
	    public decimal ICMS { get; set; }
	    public decimal BaseICMS_Subst { get; set; }
	    public decimal ICMS_Subst { get; set; }
	    public decimal TotalProdutos { get; set; }
        public decimal Frete { get; set; }
	    public decimal Seguro { get; set; }
	    public decimal Desconto { get; set; }
	    public decimal Acessorios { get; set; }
	    public decimal Total_IPI { get; set; }
	    public decimal Total_NotaFiscal { get; set; }

	    //Outros Impostos
        public decimal Pis { get; set; }
	    public decimal Cofins { get; set; }
	    public decimal Fcp { get; set; }
	    public decimal Icms_UF_Destino { get; set; }
	    public decimal Icms_UF_Remetente { get; set; }
	    public decimal IbptFederal { get; set; }
	    public decimal IbptEstadual { get; set; }
	    public decimal IbptImportacao { get; set; }

	    //Transportador/Volume
        public Transportadora Transportadora { get; set; }
        public decimal Qtde { get; set; }
	    public string Especie { get; set; }
	    public string Marca { get; set; }
	    public string Numeracao { get; set; }
	    public decimal PesoBruto { get; set; }
	    public decimal PesoLiquido { get; set; }
	    public string NotaReferenciada { get; set; }
    }
}
