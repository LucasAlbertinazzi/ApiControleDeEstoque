using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblConsumoComandum
    {
        public int IdComanda { get; set; }
        public string NomeCliente { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public int? Mesa { get; set; }
        public string Obs { get; set; }
        public int? GeradaPor { get; set; }
        public bool Fechada { get; set; }
        public DateTime? FechadaEm { get; set; }
        public int? FechadaPor { get; set; }
    }
}
