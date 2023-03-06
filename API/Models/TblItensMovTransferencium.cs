using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblItensMovTransferencium
    {
        public long IdItensTransf { get; set; }
        public string Sku { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public int Qtd { get; set; }
        public string Obs { get; set; }
        public string TransferidoPor { get; set; }
        public DateTime TransferidoEm { get; set; }
    }
}
