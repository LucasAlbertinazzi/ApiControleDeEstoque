using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblCaixasCheque
    {
        public long IdCheque { get; set; }
        public long IdReserva { get; set; }
        public decimal Valor { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Numero { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Vencimento { get; set; }
        public bool Predatado { get; set; }
        public int CadastradoPor { get; set; }
        public long IdCaixa { get; set; }

        public virtual TblUsuario CadastradoPorNavigation { get; set; }
        public virtual TblCaixa IdCaixaNavigation { get; set; }
        public virtual TblReserva IdReservaNavigation { get; set; }
    }
}
