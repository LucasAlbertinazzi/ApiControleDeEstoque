using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblRecebimento
    {
        public long IdRecebimento { get; set; }
        public string Tipo { get; set; }
        public string Documento { get; set; }
        public long? IdHospede { get; set; }
        public string IdCaixa { get; set; }
        public int IdUsuario { get; set; }
        public string Forma { get; set; }
        public int Parcela { get; set; }
        public int QtdParcelas { get; set; }
        public bool Pago { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorPago { get; set; }
        public decimal Juros { get; set; }
        public decimal Desconto { get; set; }
        public string Obs { get; set; }
        public long? IdConsumoFechado { get; set; }

        public virtual TblUsuario IdUsuarioNavigation { get; set; }
    }
}
