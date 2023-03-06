using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblImpressora
    {
        public int IdImpressora { get; set; }
        public string Descricao { get; set; }
        public string Ip { get; set; }
        public string IdLocal { get; set; }
        public string NomeSpooler { get; set; }
        public string ModeloImpressora { get; set; }
    }
}
