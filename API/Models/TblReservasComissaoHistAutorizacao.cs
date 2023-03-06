using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblReservasComissaoHistAutorizacao
    {
        public long IdComissaoHistAuto { get; set; }
        public int IdUsuario { get; set; }
        public string IdReservaCb { get; set; }
        public string Obs { get; set; }
        public decimal? ValorCb { get; set; }
        public decimal? ValorSistema { get; set; }
        public DateTime? AutorizadoEm { get; set; }
    }
}
