using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class TblUsuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public string Cpf { get; set; }
        public int? IdFuncao { get; set; }
        public string IdLocal { get; set; }
        public bool Alterarsenha { get; set; }
        public bool Bloqueado { get; set; }
    }
}
