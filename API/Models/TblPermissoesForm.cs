using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblPermissoesForm
    {
        public long IdPermissaoForm { get; set; }
        public string Form { get; set; }
        public int IdUsuario { get; set; }
        public DateTime ConcedidaEm { get; set; }
        public int ConcedidaPor { get; set; }
        public int Nivel { get; set; }
    }
}
