using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblReservasComissaoAlq
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public decimal Comissao { get; set; }
    }
}
