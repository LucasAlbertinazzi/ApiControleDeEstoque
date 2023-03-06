using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblReservasPensao
    {
        public int IdPensao { get; set; }
        public string Tipo { get; set; }
        public int RefeicoesDiarias { get; set; }
        public string Descricao { get; set; }
    }
}
