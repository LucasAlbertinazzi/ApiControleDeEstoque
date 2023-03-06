using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblEntrega
    {
        public int IdEntrega { get; set; }
        public string Tipo { get; set; }
        public string Documento { get; set; }
        public string Obs { get; set; }
        public string Endereco { get; set; }
        public string EndNumero { get; set; }
        public string EndBairro { get; set; }
        public string EndCep { get; set; }
        public string EndCidade { get; set; }
        public string EndPais { get; set; }
        public int? TipoEntrega { get; set; }
        public string EndComplemento { get; set; }
        public string EndUf { get; set; }
    }
}
