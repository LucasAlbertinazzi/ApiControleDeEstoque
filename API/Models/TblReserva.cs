using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblReserva
    {
        public TblReserva()
        {
            TblCaixasCheques = new HashSet<TblCaixasCheque>();
        }

        public long IdReserva { get; set; }
        public string IdReservaCb { get; set; }
        public string NomeHospede { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Fonte { get; set; }
        public string NomeQuarto { get; set; }
        public decimal Total { get; set; }
        public string Adultos { get; set; }
        public string Criancas { get; set; }
        public string IdHospedeCb { get; set; }
        public string StatusHospede { get; set; }
        public string TotalQuarto { get; set; }
        public int ItensAdicionaisBalanco { get; set; }
        public string Status { get; set; }
        public int? Vendedor { get; set; }
        public bool Ota { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string IdHospede { get; set; }
        public int IdPensao { get; set; }
        public string CriadoPor { get; set; }
        public string AtualizadoPor { get; set; }

        public virtual TblUsuario VendedorNavigation { get; set; }
        public virtual ICollection<TblCaixasCheque> TblCaixasCheques { get; set; }
    }
}
