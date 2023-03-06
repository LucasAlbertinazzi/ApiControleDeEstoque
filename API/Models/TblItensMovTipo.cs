using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblItensMovTipo
    {
        public int IdItensMovTipo { get; set; }
        public string Descricao { get; set; }
        public bool Manual { get; set; }
    }
}
