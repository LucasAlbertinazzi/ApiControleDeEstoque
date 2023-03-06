using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblSuite
    {
        public long IdSuite { get; set; }
        public string Acomodacao { get; set; }
        public string Nome { get; set; }
        public string Abreviatura { get; set; }
        public string Instalacoes { get; set; }
    }
}
