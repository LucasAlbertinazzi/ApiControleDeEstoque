using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblPermissoesAcessosFuncao
    {
        public int IdAcessoFuncao { get; set; }
        public long IdFuncao { get; set; }
        public int IdAcesso { get; set; }
        public bool Permitido { get; set; }
        public int LancadoPor { get; set; }
        public DateTime LancadoEm { get; set; }
        public int? AtualizadoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
    }
}
