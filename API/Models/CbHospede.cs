using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class CbHospede
    {
        public string IdHospedeCb { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
