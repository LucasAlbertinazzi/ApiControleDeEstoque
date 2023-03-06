using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblCaixasVale
    {
        public long IdCaixasVale { get; set; }
        public long IdPedidoCompra { get; set; }
        public long IdFluxo { get; set; }
        public string MetodoVale { get; set; }
        public int LancadoPor { get; set; }
        public DateTime LancadoEm { get; set; }
        public string Obs { get; set; }
        public string Tipo { get; set; }
    }
}
