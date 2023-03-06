using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblFinanceiroDivSecun
    {
        public int IdDivSecun { get; set; }
        public string Descricao { get; set; }
        public int IdDivPrinc { get; set; }

        public virtual TblFinanceiroDivPrinc IdDivPrincNavigation { get; set; }
    }
}
