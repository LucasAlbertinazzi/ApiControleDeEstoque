using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblPesquisaHospede
    {
        public int Codigo { get; set; }
        public string Documento { get; set; }
        public DateTime Data { get; set; }
        public string ComoNosConheceu { get; set; }
        public int? AtendimentoRecepcao { get; set; }
        public int? AtendimentoMonitoria { get; set; }
        public int? AtendimentoRestaurante { get; set; }
        public int? AtendimentoBar { get; set; }
        public int? ArrumacaoAcomodacao { get; set; }
        public int? ConservacaoDaEmpresa { get; set; }
        public int? Limpeza { get; set; }
        public int? CafeDaManha { get; set; }
        public int? ConexaoDeInternet { get; set; }
        public string GostariaDeVer { get; set; }
        public string ComentariosSugestões { get; set; }
        public string IndiceDeSatisfacao { get; set; }
        public int? AtendimentoReservaAntecipada { get; set; }
        public int? Refeicao { get; set; }
        public string Loginuser { get; set; }
        public string ProcuraNaEmpresa { get; set; }
    }
}
