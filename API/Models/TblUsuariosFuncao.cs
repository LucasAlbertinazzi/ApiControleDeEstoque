using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblUsuariosFuncao
    {
        public long IdFuncao { get; set; }
        public string Funcao { get; set; }
        public bool Admin { get; set; }
        public string LocaisTrabalho { get; set; }
    }
}
