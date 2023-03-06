using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblComprasSolicitacaoIten
    {
        public long IdCompraSolicitacaoItem { get; set; }
        public long IdCompraSolicitacao { get; set; }
        public string Sku { get; set; }
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }
        public string Unidade { get; set; }
        public DateTime LancadoEm { get; set; }
        public bool Comprado { get; set; }
    }
}
