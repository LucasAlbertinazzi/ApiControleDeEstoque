using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblFinanceiroDivPrinc
    {
        public TblFinanceiroDivPrinc()
        {
            TblFinanceiroDivSecuns = new HashSet<TblFinanceiroDivSecun>();
        }

        public int IdDivPrinc { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblFinanceiroDivSecun> TblFinanceiroDivSecuns { get; set; }
    }
}
