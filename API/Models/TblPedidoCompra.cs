using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblPedidoCompra
    {
        public long IdPedidoCompra { get; set; }
        public decimal? ValorTotalPedido { get; set; }
        public string CnpjFornecedor { get; set; }
        public string TipoPedido { get; set; }
        public string IdNfEntrada { get; set; }
        public int? CriadoPor { get; set; }
        public DateTime? CriadoEm { get; set; }
        public int? AtualizadoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public string Comprador { get; set; }
        public int? IdDivPrinc { get; set; }
        public int? IdDivSecun { get; set; }
        public int? IdDivTerc { get; set; }
        public int? IdEntrega { get; set; }
        public string TipoEntrega { get; set; }
        public decimal ValorFrete { get; set; }
        public decimal Desconto { get; set; }
        public bool GeracaoManual { get; set; }
        public bool GeradoPorNf { get; set; }
        public bool IncompletoNf { get; set; }
        public DateTime? DataEntrega { get; set; }
        public string Observacao { get; set; }
    }
}
