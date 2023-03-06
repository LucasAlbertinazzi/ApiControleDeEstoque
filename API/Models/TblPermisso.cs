using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblPermisso
    {
        public long IdPermissao { get; set; }
        public int? IdUsuario { get; set; }
        public string Descricao { get; set; }
        public bool Permitido { get; set; }
    }
}
