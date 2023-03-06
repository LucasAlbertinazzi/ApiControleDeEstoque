using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblUsuariosHistoricoLogin
    {
        public long IdHistoricoLogin { get; set; }
        public string Username { get; set; }
        public DateTime Data { get; set; }
        public string Ip { get; set; }
        public string NomePc { get; set; }
        public string Sistema { get; set; }
    }
}
