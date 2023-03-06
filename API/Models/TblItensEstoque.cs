using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblItensEstoque
    {
        public long IdItemEstoque { get; set; }
        public string Sku { get; set; }
        public string IdLocal { get; set; }
        public int? Qtd { get; set; }
    }
}
