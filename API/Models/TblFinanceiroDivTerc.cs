using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblFinanceiroDivTerc
    {
        public int IdDivPrinc { get; set; }
        public int IdDivSecun { get; set; }
        public int IdDivTerc { get; set; }
        public string Descricao { get; set; }
        public int IdCategoria { get; set; }
        public int IdGrupo { get; set; }
    }
}
