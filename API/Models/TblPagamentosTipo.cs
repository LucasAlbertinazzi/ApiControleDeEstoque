using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblPagamentosTipo
    {
        public long IdPagamentoTipo { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool? LiquidadoNoPag { get; set; }
        public bool TransfForma { get; set; }
    }
}
