using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblTransacoesPasseio
    {
        public long IdPasseio { get; set; }
        public string Parceiro { get; set; }
        public string DescricaoTransacao { get; set; }
    }
}
