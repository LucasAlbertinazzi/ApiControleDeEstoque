using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblConsumo
    {
        public long IdConsumo { get; set; }
        public string Tipo { get; set; }
        public string Documento { get; set; }
        public string Sku { get; set; }
        public int Qtd { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public bool Pago { get; set; }
        public int LancadoPor { get; set; }
        public string IdLocal { get; set; }
        public bool Estornado { get; set; }
        public long? IdTransacao { get; set; }
        public int? EstornadoPor { get; set; }
        public DateTime? EstornadoEm { get; set; }
        public string Obs { get; set; }
        public bool Impresso { get; set; }
        public DateTime? ImpressoEm { get; set; }
        public int? ImpressoPor { get; set; }
        public int? Mesa { get; set; }
        public bool? SolicitadoCozinha { get; set; }
        public int UsuarioSolicitadoCozinha { get; set; }
        public DateTime? DataSolicitadoCozinha { get; set; }
        public bool ImpressoCozinha { get; set; }
        public bool Mobile { get; set; }
        public string EstornadoObs { get; set; }
        public long? IdConsumoFechado { get; set; }
        public string Prepedido { get; set; }
        public string Dispositivo { get; set; }
        public string ObsLocalAlterado { get; set; }
        public string LocalAlteradoUser { get; set; }
    }
}
