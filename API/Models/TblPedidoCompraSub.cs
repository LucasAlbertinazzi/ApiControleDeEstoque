using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblPedidoCompraSub
    {
        public int IdPedidoCompraSub { get; set; }
        public int? IdPedidoCompra { get; set; }
        public string Descricao { get; set; }
        public decimal? Qtd { get; set; }
        public decimal? ValorUnit { get; set; }
        public decimal? ValorTotal { get; set; }
        public bool? ComNota { get; set; }
        public DateTime? LancadoEm { get; set; }
        public int? LancadoPor { get; set; }
        public string Sku { get; set; }
        public string Ean { get; set; }
        public int? Ncm { get; set; }
    }
}
