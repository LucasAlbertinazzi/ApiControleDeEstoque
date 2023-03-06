using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblCaixasHistorico
    {
        public long IdCaixasHistorico { get; set; }
        public long IdFluxo { get; set; }
        public string Tipo { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Acrescimo { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorTotal { get; set; }
        public int LancadoPor { get; set; }
        public DateTime LancadoEm { get; set; }
        public long IdDocumento { get; set; }
    }
}
