using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblLog
    {
        public long IdLog { get; set; }
        public string Categoria { get; set; }
        public DateTime? Datahora { get; set; }
        public int? IdUsuario { get; set; }
        public string Alteracao { get; set; }

        public virtual TblUsuario IdUsuarioNavigation { get; set; }
    }
}
