using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblOcorrServico
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public bool? Ativo { get; set; }
    }
}
