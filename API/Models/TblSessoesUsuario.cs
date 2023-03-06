using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblSessoesUsuario
    {
        public long IdSessao { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Data { get; set; }

        public virtual TblUsuario IdUsuarioNavigation { get; set; }
    }
}
