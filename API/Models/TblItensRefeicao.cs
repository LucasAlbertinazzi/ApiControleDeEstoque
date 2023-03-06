using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblItensRefeicao
    {
        public int IdRefeicao { get; set; }
        public string Descricao { get; set; }
        public decimal? Preco { get; set; }
    }
}
